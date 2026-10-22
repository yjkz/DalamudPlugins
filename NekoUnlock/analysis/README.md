# PvPAuto / CharaCradThief 逆向与验证绕过记录

目标版本：

| 插件 | 文件 | 版本 |
|---|---|---|
| PvPAuto | `pvpauto.dll` | 7.1.1.2 |
| PvPAuto | `FFXIVPVPAuto.dll` | 1.0.0.16 |
| CharaCradThief | `CharaCradThief.dll` | 4.0.1.10 |

两个 PvPAuto 包（`Plugins/pvpauto/latest.zip` 与 `Plugins/latest.zip`）使用同一套
`FFXIVPVPAuto.Verification.AuthState` 接口；NekoUnlock 同时识别程序集名
`pvpauto` 和 `FFXIVPVPAuto`。

## 1. 保护方式

两个程序集都不是普通 IL：

- 方法体在磁盘上是加密/乱码状态，直接调用 `GetMethodBody()` 会得到
  `BadImageFormatException: Bad IL range`。
- 运行时由 `<Module>` 的模块初始化器解密；解密后仍有控制流混淆
  （switch 状态机 + 不透明谓词）。
- PvPAuto 的 `AuthState` 额外带有校验字段和影子校验字段，直接改
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
- `VerifyManager`：刷新连接/授权状态，维护凭据快照、测试码和每日回退。
- `AuthState`：静态授权状态，字段包括 `_isConnected`、`_isAuthorized`、
  `_isFallbackAuthorized`、`_testCodeState` 以及校验字段。
- `AuthorizationGate.Allows(bool requiresAuth, bool requiresTestCode)`：
  模块权限的总入口。
- `ModuleManager.ValidateEnable`：结合 `ModulePermission.RequiresAuth` /
  `RequiresTestCode` 和 `AuthorizationGate.Allows` 决定模块能否启用。

`AuthState` 自己提供了合法的状态写入方法：

- `SetNekoState(connected, authorized, availability, endpoint, fallbackAuthorized)`
- `SetAuthorized(bool)`
- `SetTestCodeState(TestCodeState)`
- `RefreshAuthorizationGuardCore()`

用这些方法写入“已连接、已授权、测试码为 Active、有效期 10 年”的状态后，
`IsAccessAllowed(true, true)` 返回 `True`，且校验字段保持一致，不会触发
防篡改。

## 3. CharaCradThief 验证链

`NekoVerifierLib.VerifyWindow` 继承 Dalamud 的 `Window`。它有一个接收
`Action` 的辅助方法，运行时解密后的 IL 显示其行为是：

```csharp
void Show(Action callback)
{
    callback();
    Draw();
}
```

但这个辅助方法**不是**实际绘制路径。实际绘制回调是 `VerifyWindow` 的无参
方法，由静态验证管理器在初始化时注册到 `UiBuilder.Draw`。第一次尝试只替换
了接收 `Action` 的方法，所以窗口仍然出现；轮询并调用它的回调还造成了
约 2 秒的卡顿。

### 3.1 打开主窗口的判定链

插件入口（`IDalamudPlugin`）在构造时：

1. 调用验证管理器的 `Initialize(pluginInterface, name, id)`；
2. 注册 `UiBuilder.Draw`、`UiBuilder.OpenConfigUi` 和 `/cct` 命令处理器；
3. 其中 `/cct` 命令和 `OpenConfigUi` 走同一个方法：

```csharp
if (authClient.Gate()) {          // 无参 bool 判定
    VerifyWindow.IsOpen = false;
    MainWindow.IsOpen = true;
} else {
    VerifyWindow.IsOpen = true;
    MainWindow.IsOpen = false;
}
```

`authClient` 是验证管理器持有的认证客户端，内部有 5 个 bool 字段/属性。
插件使用的判定方法逻辑为：

```csharp
bool Gate() => fieldA && !fieldC;   // 构造时 A=false, C=true
```

`UiBuilder.Draw` 处理器也会检查同一个判定：如果判定为真且验证窗口是打开的，
就关闭验证窗口并打开主窗口。因此只改字符串或日期字段不够——字符串只影响
验证窗口里的显示文本，判定仍然为假时，`/cct` 依旧会打开验证窗口。

正确的做法是操作验证管理器的静态状态，并补上判定链：

- 4 个 `DateTime` 字段中，`Draw` 使用其中 3 个和 `DateTime.Now` 比较；
  把它们设为未来时间即可通过到期检查。
- 5 个字符串字段中，短的中文状态串包含 `未激活` / `未连接` 等；
  将它们映射为 `已激活` / `已连接`。
- 找到认证客户端中插件调用的无参 bool 判定方法，以及它递归读取的两个
  bool 字段；把字段强制为 `A=true`、`C=false`。
- 对判定方法做原生 detour，使其恒返回 `true`。只写字段也能绕过，但调用方
  可能在补丁安装前已把判定内联进 `Draw`/`OpenConfigUi`；字段和 detour 同时
  使用可以覆盖这两种情况。
- 从 `UiBuilder.Draw` 移除 `VerifyWindow` 的无参绘制回调，并设置
  `IsOpen = false`，窗口不再绘制。

`decrypted/verifywindow-action.il.txt` 仍保留该辅助方法的 IL，
用于说明为什么它不是正确的补丁点。

## 4. NekoUnlock 的实现方式

`NekoUnlock` 是一个独立的 Dalamud 插件，不修改原 DLL：

- 监听 `AssemblyLoad`，并在 `IFramework.Update` 中每秒轮询目标程序集。
- PvPAuto：
  - 调用 `AuthState` 的合法写入方法注入授权状态；
  - 每秒重新注入，覆盖失败的刷新；
  - 用原生入口跳转把 `DisableAllForAuthorizationLoss` /
    `DisableAllForTestCodeLoss` 替换为空操作；
  - 模块管理器实例可用时调用一次 `ApplyConfig()`。
- CharaCradThief：
  - 每秒写入验证管理器的 4 个静态 `DateTime` 字段（未来 10 年）；
  - 把状态字符串中的 `未激活` / `未连接` / `未授权` / `未验证` 改为激活态；
  - 将授权状态的 getter/setter 替换为映射逻辑，保证插件内部写入 `未激活`
    后，界面和功能读取到的仍是 `已激活`；
  - 扫描插件入口的 IL，定位它对认证客户端调用的无参 bool 判定方法；
    再扫描判定方法及其调用链，收集它读取的 bool 字段；
  - 用一个已知初始状态（全 `false`）逐个置位，找出使判定为真的字段（A），
    其余判定字段置 `false`（C），每秒重写，防止网络刷新覆盖；
  - 对判定方法做原生 detour 返回 `true`；
  - 从 `UiBuilder.Draw` 移除验证窗口的无参绘制回调，并设置 `IsOpen = false`；
  - 不再替换接收 `Action` 的辅助方法，也不再轮询它的静态回调。

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
`/xlplugins` 中安装 `dist/NekoUnlock.zip`（需要自定义仓库时）。重启游戏或
Dalamud 后生效。

## 6. 限制

- `decompiled/` 是 ILSpy 静态反编译结果，核心方法体仍是错误占位，
  不能当作完整源码编译。
- 绕过逻辑依赖当前版本的混淆后名称/签名；作者重新混淆后需要更新反射目标。
- 方案在运行时打补丁，不修改原 DLL，因此不会触发文件级防篡改。
- 仍需在游戏内实测：PvPAuto 的模块是否全部可启用、CharaCradThief 的验证
  窗口是否完全不再出现。
