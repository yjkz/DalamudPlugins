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

- 找到静态验证管理器（包含验证窗口、3 个凭证字符串和 4 个 `DateTime` 字段）。
- 每秒把凭证到期 `DateTime` 字段写成未来时间，避免刷新失败后回到
  `0001/1/1`。
- 把状态字符串中的 `未激活` / `未连接` / `未授权` / `未验证` 改为对应的
  激活状态。
- 从 `UiBuilder.Draw` 移除验证窗口的无参绘制回调，并把窗口的 `IsOpen`
  设为 `false`，使“猫猫验证”窗口不再出现。
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

## 游戏内验证

- `/xllog` 中应出现：
  - `[NekoUnlock] loaded`
  - `PvPAuto authorization state applied`
  - `CharaCradThief authorization fields set and verification window suppressed`
- PvPAuto：之前被授权状态阻止的模块应可以启用。
- CharaCradThief：`/cct` 打开时不应再出现验证窗口。

## 常见问题

- 如果安装前 PvPAuto 的模块已经被验证失败禁用，安装后在界面中手动启用一次；
  NekoUnlock 会阻止授权丢失处理器再次禁用它们。
- 如果 CharaCradThief 仍然显示验证窗口，检查 `/xllog` 中是否有
  `CharaCradThief authorization fields set and verification window suppressed`。
  如果窗口仍然出现，说明验证管理器在最后一次轮询之后重新注册了绘制回调；
  保持插件启用并继续观察日志。
- 如果目标插件更新，混淆后的类型名/方法名可能变化，需要更新 `Plugin.cs`
  中的反射目标。

## 说明

- 目标版本依赖混淆后的类型名和方法名；作者重新构建后需要同步更新本项目。
- 原始 DLL 未被修改，因此不会触发文件级防篡改。
- `analysis/` 目录包含部分 ILSpy 反编译结果和恢复出的验证逻辑；
  详细说明见 `analysis/README.md`。
