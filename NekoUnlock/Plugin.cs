using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;

namespace NekoUnlock;

public sealed class Plugin : IDalamudPlugin
{
    private readonly IFramework _framework;
    private readonly IPluginLog _log;
    private readonly object _gate = new();
    private DateTime _nextPvP = DateTime.MinValue;
    private DateTime _nextCct = DateTime.MinValue;
    private readonly List<PvPAutoState> _pvP = new();
    private CctUnlock? _cct;

    public Plugin(IFramework framework, IPluginLog log)
    {
        _framework = framework;
        _log = log;
        _framework.Update += OnUpdate;
        AppDomain.CurrentDomain.AssemblyLoad += OnAssemblyLoad;
        _log.Information("[NekoUnlock] loaded");
    }

    public void Dispose()
    {
        _framework.Update -= OnUpdate;
        AppDomain.CurrentDomain.AssemblyLoad -= OnAssemblyLoad;
        _cct?.Dispose();
        NativeDetour.UnpatchAll();
    }

    private void OnAssemblyLoad(object? sender, AssemblyLoadEventArgs args)
    {
        var name = args.LoadedAssembly.GetName().Name;
        if (IsPvPAutoAssembly(name))
            ApplyPvP(args.LoadedAssembly);
        else if (string.Equals(name, "CharaCradThief", StringComparison.OrdinalIgnoreCase))
            ApplyCct(args.LoadedAssembly);
    }

    private void OnUpdate(IFramework framework)
    {
        var now = DateTime.UtcNow;

        if (now >= _nextPvP)
        {
            _nextPvP = now.AddSeconds(1);
            try
            {
                ApplyPvP(FindAssembly("pvpauto"));
                ApplyPvP(FindAssembly("FFXIVPVPAuto"));
            }
            catch (Exception ex)
            {
                _log.Warning($"[NekoUnlock] PvPAuto unlock failed: {ex.GetType().Name}: {ex.Message}");
            }
        }

        if (now >= _nextCct)
        {
            _nextCct = now.AddSeconds(1);
            try
            {
                ApplyCct(FindAssembly("CharaCradThief"));
            }
            catch (Exception ex)
            {
                _log.Warning($"[NekoUnlock] CharaCradThief unlock failed: {ex.GetType().Name}: {ex.Message}");
            }
        }
    }

    private void ApplyPvP(Assembly? assembly)
    {
        lock (_gate)
        {
            if (assembly is not null && !_pvP.Any(state => state.AssemblyName == assembly.GetName().Name))
            {
                var state = PvPAutoState.TryCreate(assembly, _log);
                if (state is not null)
                    _pvP.Add(state);
            }

            foreach (var state in _pvP)
                state.Apply();
        }
    }

    private static bool IsPvPAutoAssembly(string? name)
    {
        return string.Equals(name, "pvpauto", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(name, "FFXIVPVPAuto", StringComparison.OrdinalIgnoreCase);
    }

    private void ApplyCct(Assembly? assembly)
    {
        lock (_gate)
        {
            if (_cct is null && assembly is not null)
                _cct = CctUnlock.TryCreate(assembly, _log);
            _cct?.Apply();
        }
    }

    private static Assembly? FindAssembly(string name)
    {
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            if (string.Equals(assembly.GetName().Name, name, StringComparison.OrdinalIgnoreCase))
                return assembly;
        }

        foreach (var context in AssemblyLoadContext.All)
        {
            foreach (var assembly in context.Assemblies)
            {
                if (string.Equals(assembly.GetName().Name, name, StringComparison.OrdinalIgnoreCase))
                    return assembly;
            }
        }

        return null;
    }
}

/// <summary>
/// PvPAuto keeps its authorization snapshot in the static <c>AuthState</c> class.
/// These setters are the same ones its own verifier uses, so the internal guard
/// hashes stay consistent. Re-applying the state also overrides a failed refresh.
/// </summary>
internal sealed class PvPAutoState
{
    private const BindingFlags StaticFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
    private const BindingFlags InstanceFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

    public string AssemblyName { get; }

    private readonly IPluginLog _log;
    private readonly MethodInfo _setNekoState;
    private readonly MethodInfo _setAuthorized;
    private readonly MethodInfo _setTestCodeState;
    private readonly MethodInfo _refreshGuard;
    private readonly Type _testCodeStateType;
    private readonly object _reachable;
    private readonly object _activeStatus;
    private readonly MethodInfo? _disableAuthLoss;
    private readonly MethodInfo? _disableTestCodeLoss;
    private readonly PropertyInfo? _moduleManagerInstance;
    private readonly MethodInfo? _applyConfig;
    private object? _testCodeState;
    private DateTimeOffset _nextState = DateTimeOffset.MinValue;
    private DateTimeOffset _testCodeStateCreated = DateTimeOffset.MinValue;
    private bool _disablePatched;
    private bool _configApplied;
    private bool _configFailureLogged;
    private bool _logged;

    private PvPAutoState(
        string assemblyName,
        IPluginLog log,
        MethodInfo setNekoState,
        MethodInfo setAuthorized,
        MethodInfo setTestCodeState,
        MethodInfo refreshGuard,
        Type testCodeStateType,
        object reachable,
        object activeStatus,
        MethodInfo? disableAuthLoss,
        MethodInfo? disableTestCodeLoss,
        PropertyInfo? moduleManagerInstance,
        MethodInfo? applyConfig)
    {
        AssemblyName = assemblyName;
        _log = log;
        _setNekoState = setNekoState;
        _setAuthorized = setAuthorized;
        _setTestCodeState = setTestCodeState;
        _refreshGuard = refreshGuard;
        _testCodeStateType = testCodeStateType;
        _reachable = reachable;
        _activeStatus = activeStatus;
        _disableAuthLoss = disableAuthLoss;
        _disableTestCodeLoss = disableTestCodeLoss;
        _moduleManagerInstance = moduleManagerInstance;
        _applyConfig = applyConfig;
    }

    public static PvPAutoState? TryCreate(Assembly? assembly, IPluginLog log)
    {
        if (assembly is null)
            return null;

        var authState = assembly.GetType("FFXIVPVPAuto.Verification.AuthState");
        var nekoAvailability = assembly.GetType("FFXIVPVPAuto.Verification.NekoAvailability");
        var testCodeState = assembly.GetType("FFXIVPVPAuto.Verification.TestCodeState");
        var testCodeStatus = assembly.GetType("FFXIVPVPAuto.Verification.TestCodeStatus");
        if (authState is null || nekoAvailability is null || testCodeState is null || testCodeStatus is null)
            return null;

        var setNekoState = authState.GetMethod("SetNekoState", StaticFlags);
        var setAuthorized = authState.GetMethod("SetAuthorized", StaticFlags);
        var setTestCodeState = authState.GetMethod("SetTestCodeState", StaticFlags);
        var refreshGuard = authState.GetMethod("RefreshAuthorizationGuardCore", StaticFlags);
        if (setNekoState is null || setAuthorized is null || setTestCodeState is null || refreshGuard is null)
            return null;

        if (!Enum.TryParse(nekoAvailability, "Reachable", out var reachable) ||
            !Enum.TryParse(testCodeStatus, "Active", out var active))
            return null;

        var moduleManager = assembly.GetType("FFXIVPVPAuto.Managers.ModuleManager");
        var disableAuthLoss = moduleManager?.GetMethod("DisableAllForAuthorizationLoss", InstanceFlags);
        var disableTestCodeLoss = moduleManager?.GetMethod("DisableAllForTestCodeLoss", InstanceFlags);
        var moduleManagerInstance = moduleManager?.GetProperty("Instance", StaticFlags);
        var applyConfig = moduleManager?.GetMethod("ApplyConfig", InstanceFlags);

        return new PvPAutoState(
            assembly.GetName().Name ?? assembly.FullName ?? "pvpauto",
            log,
            setNekoState,
            setAuthorized,
            setTestCodeState,
            refreshGuard,
            testCodeState,
            reachable!,
            active!,
            disableAuthLoss,
            disableTestCodeLoss,
            moduleManagerInstance,
            applyConfig);
    }

    public void Apply()
    {
        var now = DateTimeOffset.UtcNow;
        if (now < _nextState)
            return;

        _nextState = now.AddSeconds(1);

        try
        {
            _setNekoState.Invoke(null, new object[] { true, true, _reachable, "local", true });
            _setAuthorized.Invoke(null, new object[] { true });

            if (_testCodeState is null || now - _testCodeStateCreated > TimeSpan.FromHours(1))
            {
                _testCodeState = CreateTestCodeState(now);
                _testCodeStateCreated = now;
            }

            _setTestCodeState.Invoke(null, new[] { _testCodeState });
            _refreshGuard.Invoke(null, null);

            if (!_disablePatched)
            {
                var noOp = typeof(CctPatches).GetMethod(nameof(CctPatches.NoOpInstance))!;
                var patchedAuth = _disableAuthLoss is null || NativeDetour.Patch(_disableAuthLoss, noOp);
                var patchedTest = _disableTestCodeLoss is null || NativeDetour.Patch(_disableTestCodeLoss, noOp);
                if (patchedAuth && patchedTest)
                {
                    _disablePatched = true;
                    if (_disableAuthLoss is not null || _disableTestCodeLoss is not null)
                        _log.Information("[NekoUnlock] PvPAuto authorization-loss handlers patched");
                }
            }

            if (!_configApplied && _moduleManagerInstance is not null && _applyConfig is not null)
            {
                var manager = _moduleManagerInstance.GetValue(null);
                if (manager is not null)
                {
                    try
                    {
                        _applyConfig.Invoke(manager, null);
                        _configApplied = true;
                    }
                    catch (Exception ex)
                    {
                        if (!_configFailureLogged)
                        {
                            _configFailureLogged = true;
                            _log.Warning($"[NekoUnlock] PvPAuto ApplyConfig skipped: {ex.GetType().Name}: {ex.Message}");
                        }
                    }
                }
            }

            if (!_logged)
            {
                _logged = true;
                _log.Information("[NekoUnlock] PvPAuto authorization state applied");
            }
        }
        catch (Exception ex)
        {
            if (!_logged)
            {
                _logged = true;
                _log.Warning($"[NekoUnlock] PvPAuto authorization setter failed: {ex.GetType().Name}: {ex.Message}");
            }
        }
    }

    private object CreateTestCodeState(DateTimeOffset now)
    {
        var state = Activator.CreateInstance(_testCodeStateType)!;
        var expires = now.AddYears(9);
        var tickNow = Environment.TickCount64;
        var tickExpires = tickNow + (long)TimeSpan.FromDays(3285).TotalMilliseconds;

        Set(state, "Status", _activeStatus);
        Set(state, "QualificationExpiresAt", expires);
        Set(state, "PendingExpiresAt", expires);
        Set(state, "LastCheckedAt", now);
        Set(state, "QualificationIssuedAtTickCount", tickNow);
        Set(state, "QualificationExpiresAtTickCount", tickExpires);
        return state;
    }

    private void Set(object instance, string propertyName, object value)
    {
        _testCodeStateType.GetProperty(propertyName)?.SetValue(instance, value);
    }
}

/// <summary>
/// CharaCradThief's <c>VerifyWindow</c> has an entry method that takes the
/// success callback, invokes it, and then draws the window. Replacing that
/// method with a callback invocation skips the drawing and the server round-trip.
/// </summary>
internal sealed class CctUnlock : IDisposable
{
    private readonly IPluginLog _log;
    private readonly MethodInfo _actionMethod;
    private readonly FieldInfo? _callbackField;
    private bool _patched;
    private bool _logged;
    private Action? _lastCallback;

    private CctUnlock(IPluginLog log, MethodInfo actionMethod, FieldInfo? callbackField)
    {
        _log = log;
        _actionMethod = actionMethod;
        _callbackField = callbackField;
    }

    public static CctUnlock? TryCreate(Assembly? assembly, IPluginLog log)
    {
        if (assembly is null)
            return null;

        var windowType = assembly.GetType("NekoVerifierLib.VerifyWindow");
        if (windowType is null)
            return null;

        var actionMethod = windowType
            .GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .FirstOrDefault(method =>
            {
                var parameters = method.GetParameters();
                return parameters.Length == 1 && parameters[0].ParameterType == typeof(Action);
            });

        if (actionMethod is null)
            return null;

        FieldInfo? callbackField = null;
        foreach (var nested in windowType.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
        {
            callbackField = nested
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static)
                .FirstOrDefault(field => field.FieldType == typeof(Action));
            if (callbackField is not null)
                break;
        }

        return new CctUnlock(log, actionMethod, callbackField);
    }

    public void Apply()
    {
        if (!_patched)
        {
            _patched = NativeDetour.Patch(_actionMethod, typeof(CctPatches).GetMethod(nameof(CctPatches.InvokeAction))!);
            if (_patched)
                _log.Information("[NekoUnlock] CharaCradThief verification callback patched");
            else if (!_logged)
            {
                _logged = true;
                _log.Warning("[NekoUnlock] CharaCradThief verification patch failed; falling back to callback polling");
            }
        }

        if (_callbackField?.GetValue(null) is Action callback && !ReferenceEquals(callback, _lastCallback))
        {
            _lastCallback = callback;
            try
            {
                callback();
                _log.Information("[NekoUnlock] CharaCradThief verification callback invoked");
            }
            catch (Exception ex)
            {
                _log.Warning($"[NekoUnlock] CharaCradThief callback failed: {ex.GetType().Name}: {ex.Message}");
            }
        }
    }

    public void Dispose()
    {
    }
}

internal static class CctPatches
{
    public static void InvokeAction(object self, Action action)
    {
        action();
    }

    public static void NoOpInstance(object self)
    {
    }
}

internal static class NativeDetour
{
    private const uint PageExecuteReadWrite = 0x40;

    private static readonly HashSet<IntPtr> Patched = new();
    private static readonly Dictionary<IntPtr, byte[]> Originals = new();

    public static bool Patch(MethodInfo target, MethodInfo replacement)
    {
        try
        {
            RuntimeHelpers.PrepareMethod(replacement.MethodHandle);
            var entry = target.MethodHandle.GetFunctionPointer();
            var destination = replacement.MethodHandle.GetFunctionPointer();
            return WriteJump(entry, destination);
        }
        catch
        {
            return false;
        }
    }

    private static bool WriteJump(IntPtr target, IntPtr destination)
    {
        if (target == IntPtr.Zero || destination == IntPtr.Zero)
            return false;

        lock (Patched)
        {
            if (Patched.Contains(target))
                return true;

            var patch = new byte[12];
            patch[0] = 0x48; // mov rax, imm64
            patch[1] = 0xB8;
            BitConverter.GetBytes((long)destination).CopyTo(patch, 2);
            patch[10] = 0xFF; // jmp rax
            patch[11] = 0xE0;

            if (!VirtualProtect(target, (UIntPtr)patch.Length, PageExecuteReadWrite, out var oldProtect))
                return false;

            var original = new byte[patch.Length];
            Marshal.Copy(target, original, 0, original.Length);

            try
            {
                Marshal.Copy(patch, 0, target, patch.Length);
            }
            finally
            {
                VirtualProtect(target, (UIntPtr)patch.Length, oldProtect, out _);
            }

            FlushInstructionCache(GetCurrentProcess(), target, (UIntPtr)patch.Length);
            Originals[target] = original;
            Patched.Add(target);
            return true;
        }
    }

    public static void UnpatchAll()
    {
        lock (Patched)
        {
            foreach (var (target, original) in Originals)
            {
                if (!VirtualProtect(target, (UIntPtr)original.Length, PageExecuteReadWrite, out var oldProtect))
                    continue;

                try
                {
                    Marshal.Copy(original, 0, target, original.Length);
                }
                finally
                {
                    VirtualProtect(target, (UIntPtr)original.Length, oldProtect, out _);
                }

                FlushInstructionCache(GetCurrentProcess(), target, (UIntPtr)original.Length);
            }

            Originals.Clear();
            Patched.Clear();
        }
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

    [DllImport("kernel32.dll")]
    private static extern IntPtr GetCurrentProcess();

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool FlushInstructionCache(IntPtr hProcess, IntPtr lpBaseAddress, UIntPtr dwSize);
}
