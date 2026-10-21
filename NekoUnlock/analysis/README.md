# PvPAuto / CharaCradThief 逆向与验证绕过记录

目标版本：

| 插件 | 文件 | 版本 |
|---|---|---|
| PvPAuto | `pvpauto.dll` | 7.1.1.2 |
| PvPAuto | `FFXIVPVPAuto.dll` | 1.0.0.16 |
| CharaCradThief | `CharaCradThief.dll` | 4.0.1.10 |

两个 PvPAuto 包（`Plugins/pvpauto/latest.zip` 与 `Plugins/latest.zip`）使用同一套
`FFXIVPVPAuto.Verification.AuthState` API；NekoUnlock 同时识别程序集名
`pvpauto` 和 `FFXIVPVPAuto`。

## 1. 保护方式

两个程序集都不是普通 IL：

- 方法体在磁盘上是加密/乱码状态，`GetMethodBody()` 直接读取会得到
  `BadImageFormatException: Bad IL range`。
- 运行时由 `<Module>` 的 module initializer 解密；解密后仍有控制流混淆
  （switch 状态机 + 不透明谓词）。
- PvPAuto 的 `AuthState` 额外带有 guard/影子 guard 字段，直接改
  `_isAuthorized` 会被 `IsAuthorizationSnapshotIntactCore` 判定为篡改。
- ILSpy 静态反编译只能得到一部分类型；核心方法体显示为
  `Invalid MethodBodyBlock`。完整源码需要运行时脱壳，不能只靠静态反编译。

运行时可先用 `RuntimeHelpers.PrepareMethod(method.MethodHandle)` 触发解密，
再用 `MonoMod.Utils.DynamicMethodDefinition` 读取解密后的 IL。本目录的
`decrypted/verifywindow-action.il.txt` 就是这样得到的。

## 2. PvPAuto 验证链

关键类型（均在 `FFXIVPVPAuto.Verification`）：

- `AuthVerifyClient`：访问 `https://auth.n3ko.fun/`（以及海外备用端点），
  使用 RSA/HOTP 构造 `/api/v1/query` 请求。
- `VerifyManager`：刷新连接/授权状态，维护凭据快照、test code、fallback。
- `AuthState`：静态授权状态，字段包括 `_isConnected`、`_isAuthorized`、
  `_isFallbackAuthorized`、`_testCodeState`、guard 字段。
- `AuthorizationGate.Allows(bool requiresAuth, bool requiresTestCode)`：
  模块权限的总入口。
- `ModuleManager.ValidateEnable`：结合 `ModulePermission.RequiresAuth` /
  `RequiresTestCode` 和 `AuthorizationGate.Allows` 决定模块能否启用。

`AuthState` 自己提供了合法的状态写入方法：

- `SetNekoState(connected, authorized, availability, endpoint, fallbackAuthorized)`
- `SetAuthorized(bool)`
- `SetTestCodeState(TestCodeState)`
- `RefreshAuthorizationGuardCore()`

用这些方法写入“已连接、已授权、test code Active、有效期 10 年”的状态后，
`IsAccessAllowed(true, true)` 返回 `True`，且 guard 字段保持一致，不会触发
anti-tamper。

## 3. CharaCradThief 验证链

`NekoVerifierLib.VerifyWindow` 继承 Dalamud 的 `Window`。它有一个接收
`Action` 的方法，运行时解密后的 IL 显示其行为是：

```csharp
void Show(Action callback)
{
    callback();
    Draw();
}
```

也就是说，验证窗口拿到的回调会在方法内部直接执行，然后才绘制窗口。
把该方法替换为只调用 `callback()`，即可跳过窗口绘制和服务器验证流程。

## 4. NekoUnlock 的做法

`NekoUnlock` 是一个独立的 Dalamud 插件，不修改原 DLL：

- 监听 `AssemblyLoad`，并在 `IFramework.Update` 中每秒轮询目标程序集。
- PvPAuto：
  - 调用 `AuthState` 的合法 setter 注入授权状态；
  - 每秒重新注入，覆盖失败刷新；
  - 用 native entry detour 把 `DisableAllForAuthorizationLoss` /
    `DisableAllForTestCodeLoss` 替换为空操作；
  - 模块管理器实例可用时调用一次 `ApplyConfig()`。
- CharaCradThief：
  - 用 native entry detour 把 `VerifyWindow` 的 `Action` 方法替换为
    `callback()`；
  - 同时轮询 `VerifyWindow` 内部静态 `Action` 字段，作为补丁未生效时的
    回退路径（例如目标插件先于 NekoUnlock 初始化）。

## 5. 构建与安装

```bash
cd E:\github\Dalamud\DalamudPlugins\NekoUnlock
DALAMUD_HOME=F:/DevEnv/dalamud dotnet build NekoUnlock.csproj -c Release
```

产物：

- `bin/Release/NekoUnlock.dll`
- `bin/Release/NekoUnlock.json`
- `bin/Release/NekoUnlock.deps.json`
- `dist/NekoUnlock.zip`
- `dist/NekoUnlock/`（可直接作为 Dev Plugin Location）

安装：把 `dist/NekoUnlock` 加入 Dalamud 的 Dev Plugin Locations，或在
`/xlplugins` 中安装 `dist/NekoUnlock.zip`（需要自定义仓库时）。重启游戏/Dalamud
后生效。

## 6. 限制

- `analysis/decompiled/` 是 ILSpy 静态反编译结果，核心方法体仍是错误占位，
  不能当作完整源码编译。
- 绕过逻辑依赖当前版本的混淆后名称/签名；作者重新混淆后需要更新反射目标。
- 方案在运行时打补丁，不修改原 DLL，因此不会触发文件级 anti-tamper。
- 仍需在游戏内实测：PvPAuto 的模块是否全部可启用、CharaCradThief 的验证
  窗口是否完全不再出现。
