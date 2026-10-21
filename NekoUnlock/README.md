# NekoUnlock

Author-only companion plugin for:

- `PvPAuto` / `pvpauto.dll` 7.1.1.2
- `PvPAuto` / `FFXIVPVPAuto.dll` 1.0.0.16
- `CharaCradThief` / `CharaCradThief.dll` 4.0.1.10

It does **not** modify the original DLLs. It applies the plugins' own local
authorization state at runtime and removes the NekoVerifier round-trip.

## What it does

### PvPAuto

- Finds `FFXIVPVPAuto.Verification.AuthState`.
- Injects a valid local state through the assembly's own setters:
  - `SetNekoState(connected: true, authorized: true, Reachable, "local", fallback: true)`
  - `SetAuthorized(true)`
  - `SetTestCodeState(TestCodeState { Status = Active, ... })`
  - `RefreshAuthorizationGuardCore()`
- Re-applies the state every second so a failed server refresh cannot revert it.
- Patches `ModuleManager.DisableAllForAuthorizationLoss` and
  `DisableAllForTestCodeLoss` to no-ops.
- Calls `ModuleManager.ApplyConfig()` once when the manager is available.

### CharaCradThief

- Finds `NekoVerifierLib.VerifyWindow`.
- Replaces the method that receives the success `Action` with a direct
  `callback()` invocation (the original method invokes the callback and then
  draws the verification window).
- Also polls the verifier's static `Action` field as a fallback if the target
  plugin initialized before this patch was installed.

## Build

```bash
cd E:\github\Dalamud\DalamudPlugins\NekoUnlock
DALAMUD_HOME=F:/DevEnv/dalamud dotnet build NekoUnlock.csproj -c Release
```

## Install (local development)

1. In game: `/xlsettings` → **Experimental** → **Dev Plugin Locations**.
2. Add:
   `E:\github\Dalamud\DalamudPlugins\NekoUnlock\dist\NekoUnlock`
3. Install/enable `PvPAuto` and `CharaCradThief` from the repository's
   `Plugins/pvpauto/latest.zip` and `Plugins/CharaCradThief/latest.zip`.
4. Restart the game (or reload plugins).

The packaged zip is also at `dist/NekoUnlock.zip` if you use a custom
repository.

## Verify in game

- `/xllog` should contain:
  - `[NekoUnlock] loaded`
  - `PvPAuto authorization state applied`
  - `CharaCradThief verification callback patched` (or the callback-polling fallback)
- PvPAuto: modules that were previously blocked should now be enableable.
- CharaCradThief: `/cct` should open without the verification window.

## Troubleshooting

- If PvPAuto modules were already disabled by a failed verification before
  NekoUnlock was installed, enable them once in the PvPAuto UI. NekoUnlock
  prevents the authorization-loss handlers from disabling them again.
- If CharaCradThief still shows the window, check `/xllog` for
  `CharaCradThief verification callback patched`. The callback-polling fallback
  should still authorize the plugin if the patch could not be applied.
- If the target plugins update, their obfuscated member names may change;
  update the reflected type/method names in `Plugin.cs`.

## Notes

- Target versions are pinned by the reflected type/method names. A rebuilt
  plugin with renamed members needs this project updated.
- The original DLLs remain untouched, so file-level anti-tamper is not
  triggered.
- `analysis/` contains the partial ILSpy output and the recovered verifier IL.
  See `analysis/README.md` for the reverse-engineering notes.
