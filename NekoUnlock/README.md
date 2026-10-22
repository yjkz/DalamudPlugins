# NekoUnlock

作者自用的配套解锁插件，适用于以下版本：

- `PvPAuto` / `pvpauto.dll` 7.1.1.2
- `PvPAuto` / `FFXIVPVPAuto.dll` 1.0.0.16
- `CharaCradThief` / `CharaCradThief.dll` 4.0.1.10

该插件**不会修改原始 DLL 文件**，而是在运行时注入本地授权状态，并移除
NekoVerifier 的服务器验证流程。

## 功能

### PvPAuto

- 找到 `FFXIVPVPAuto.Verification.AuthState`。
- 通过程序集自身的合法写入方法设置本地授权状态：
  - `SetNekoState(connected: true, authorized: true, Reachable, "local", fallback: true)`
  - `SetAuthorized(true)`
  - `SetTestCodeState(TestCodeState { Status = Active, ... })`
  - `RefreshAuthorizationGuardCore()`
- 每秒重新写入一次，避免服务器刷新失败后把状态改回未授权。
- 将 `ModuleManager.DisableAllForAuthorizationLoss` 和
  `DisableAllForTestCodeLoss` 替换为空操作。
- 模块管理器可用时调用一次 `ModuleManager.ApplyConfig()`。

### CharaCradThief

- 找到静态验证管理器（包含验证窗口、5 个状态/凭证字符串和 4 个 `DateTime` 字段）。
- **在插件构造函数之前**拦截认证客户端启动时的同步 HTTP 查询，直接返回
  `Task.FromResult(false)`。否则验证服务器不可达时，客户端构造函数会抛
  `HttpRequestException`，导致整个 CharaCradThief 插件加载失败。
- 找到插件入口使用的“认证客户端”（静态字段），以及它用来决定“打开主窗口还是验证窗口”的
  无参布尔判定方法。
- 对该判定方法做原生 detour，使其始终返回 `true`；同时把判定依赖的两个布尔字段
  强制为“已认证”组合（`认证=true`、`需要验证=false`）。
  - 原生 detour 会先解析 .NET 的 stable-entry precode，改写真正的 JIT 代码入口，
    而不是只改 precode 桩。
  - 即使调用方在 detour 安装前已经被 JIT 并内联了判定逻辑，直接写字段也能保证判定为真。
  - 每秒重写一次，防止插件的网络刷新把状态改回去。
- 每秒把凭证到期 `DateTime` 字段写成未来时间，避免刷新失败后回到
  `0001/1/1`。
- 把状态字符串中的 `未激活` / `未连接` / `未授权` / `未验证` 改为对应的
  激活状态；并把授权状态的 getter/setter 替换为映射逻辑。
- 从 `UiBuilder.Draw` 移除验证窗口的无参绘制回调，并把窗口的 `IsOpen`
  设为 `false`。
- 结果是：`/cct` 或插件列表中的齿轮按钮会**直接打开角色铭牌主窗口**，
  不再弹出验证窗口；如果验证窗口曾经打开，下一帧也会被关闭并切换到主窗口。
- **不再**替换接收 `Action` 的 `Show(Action)` 辅助方法。该方法不是实际绘制
  路径，调用它的回调正是首版出现 2 秒卡顿的原因。

## 构建

```bash
cd E:\github\Dalamud\DalamudPlugins\NekoUnlock
DALAMUD_HOME=F:/DevEnv/dalamud dotnet build NekoUnlock.csproj -c Release
```

## 本地安装

1. 游戏内 `/xlsettings` → **实验性功能（Experimental）** → **开发插件目录（Dev Plugin Locations）**。
2. 添加：
   `E:\github\Dalamud\DalamudPlugins\NekoUnlock\dist\NekoUnlock`
3. 从仓库的 `Plugins/pvpauto/latest.zip`、`Plugins/latest.zip` 和
   `Plugins/CharaCradThief/latest.zip` 安装对应插件。
4. 重启游戏（或重新加载插件）。

如果使用自定义仓库，也可以直接安装打包好的 `dist/NekoUnlock.zip`。
仓库使用的 zip 必须把 `NekoUnlock.dll`、`NekoUnlock.json`、
`NekoUnlock.deps.json` 放在压缩包根目录；不能再套一层 `NekoUnlock/`，
否则 Dalamud 解压后会报 `Could not find file ...\NekoUnlock.json`。

## 游戏内验证

- `/xllog` 中应出现：
  - `[NekoUnlock] loaded`
  - `PvPAuto authorization state applied`
  - `CharaCradThief auth network call suppressed`
  - `CharaCradThief authorization status getter/setter patched`
  - `CharaCradThief authorization gate patched`
  - `CharaCradThief authorization fields set and verification window suppressed`
- PvPAuto：`/pvpauto` 打开主窗口，之前被授权状态阻止的模块应可以启用。
- CharaCradThief：`/cct` 或插件列表中的齿轮按钮应直接打开角色铭牌主窗口，
  不再出现验证窗口。

## 使用方式

- **CharaCradThief**：游戏内输入 `/cct`，或在 Dalamud 插件列表中点击该插件的
  齿轮/设置按钮。授权判定补丁生效后，这会直接打开角色铭牌主窗口。
- **PvPAuto**：游戏内输入 `/pvpauto` 打开主界面，然后在界面里勾选需要的模块；
  NekoUnlock 只负责让授权状态通过，具体功能仍需在插件自己的界面中启用。
- 如果打开时仍然看到验证窗口：
  1. 确认 NekoUnlock 与目标插件都已启用；
  2. 确认版本为 1.0.0.4 或更高；
  3. 完全重启游戏（不是只重载插件）；
  4. 在 `/xllog` 中搜索 `authorization gate patched`，确认补丁已生效。

## 常见问题

- 如果安装前 PvPAuto 的模块已经被验证失败禁用，安装后在界面中手动启用一次；
  NekoUnlock 会阻止授权丢失处理器再次禁用它们。
- 如果 CharaCradThief 仍然显示验证窗口，检查 `/xllog` 中是否有
  `CharaCradThief authorization gate patched`。如果没有，说明没有定位到认证客户端
  或判定方法，通常是目标插件版本与上面列出的版本不一致；请把 `/xllog` 和插件版本
  发回来更新反射目标。
- 如果目标插件更新，混淆后的类型名/方法名可能变化，需要更新 `Plugin.cs`
  中的反射目标。

## 说明

- 目标版本依赖混淆后的类型名和方法名；作者重新构建后需要同步更新本项目。
- 原始 DLL 未被修改，因此不会触发文件级防篡改。
- `analysis/` 目录包含部分 ILSpy 反编译结果和恢复出的验证逻辑；
  详细说明见 `analysis/README.md`。
