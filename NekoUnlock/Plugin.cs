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
    private readonly IDalamudPluginInterface _pluginInterface;
    private readonly object _gate = new();
    private DateTime _nextPvP = DateTime.MinValue;
    private DateTime _nextCct = DateTime.MinValue;
    private readonly List<PvPAutoState> _pvP = new();
    private CctUnlock? _cct;

    public Plugin(IFramework framework, IPluginLog log, IDalamudPluginInterface pluginInterface)
    {
        _framework = framework;
        _log = log;
        _pluginInterface = pluginInterface;
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
                _cct = CctUnlock.TryCreate(assembly, _log, _pluginInterface);
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
/// CharaCradThief's verifier keeps its authorization snapshot in a static class:
/// five strings (connection/authorization status plus three credentials) and four
/// DateTimes. The VerifyWindow draw callback is registered on UiBuilder.Draw.
///
/// Instead of patching the one-argument Show(Action) helper (which is not the
/// draw path), we set the same fields the verifier writes and remove the draw
/// callback from UiBuilder.Draw. This hides the window and makes the verifier's
/// own date/status checks see an active authorization.
/// </summary>
internal sealed class CctUnlock : IDisposable
{
    private const BindingFlags StaticFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
    private const BindingFlags InstanceFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

    private readonly IPluginLog _log;
    private readonly IDalamudPluginInterface _pluginInterface;
    private readonly FieldInfo? _windowField;
    private readonly MethodInfo _drawCallbackMethod;
    private readonly FieldInfo[] _dateFields;
    private readonly FieldInfo[] _stringFields;
    private readonly PropertyInfo? _statusProperty;
    private readonly FieldInfo? _statusField;
    private readonly FieldInfo? _clientField;
    private readonly MethodInfo? _gateMethod;
    private readonly FieldInfo[] _gateFields;
    private DateTime _nextApply = DateTime.MinValue;
    private bool _logged;
    private bool _statusPatched;
    private bool _fieldsResolved;
    private bool _gatePatched;
    private FieldInfo? _positiveField;
    private object? _client;

    private CctUnlock(
        IPluginLog log,
        IDalamudPluginInterface pluginInterface,
        FieldInfo? windowField,
        MethodInfo drawCallbackMethod,
        FieldInfo[] dateFields,
        FieldInfo[] stringFields,
        PropertyInfo? statusProperty,
        FieldInfo? statusField,
        FieldInfo? clientField,
        MethodInfo? gateMethod,
        FieldInfo[] gateFields)
    {
        _log = log;
        _pluginInterface = pluginInterface;
        _windowField = windowField;
        _drawCallbackMethod = drawCallbackMethod;
        _dateFields = dateFields;
        _stringFields = stringFields;
        _statusProperty = statusProperty;
        _statusField = statusField;
        _clientField = clientField;
        _gateMethod = gateMethod;
        _gateFields = gateFields;
    }

    public static CctUnlock? TryCreate(Assembly? assembly, IPluginLog log, IDalamudPluginInterface pluginInterface)
    {
        if (assembly is null)
            return null;

        var windowType = assembly.GetType("NekoVerifierLib.VerifyWindow");
        if (windowType is null)
            return null;

        // The verifier manager is the static class holding >=3 DateTime fields
        // and the VerifyWindow instance.
        var verifierType = assembly.GetTypes().FirstOrDefault(type =>
        {
            var fields = type.GetFields(StaticFlags);
            return fields.Count(field => field.FieldType == typeof(DateTime)) >= 3 &&
                   fields.Any(field => field.FieldType == windowType);
        });
        if (verifierType is null)
            return null;

        var windowField = verifierType
            .GetFields(StaticFlags)
            .FirstOrDefault(field => field.FieldType == windowType);
        var drawCallbackMethod = windowType
            .GetMethods(InstanceFlags)
            .FirstOrDefault(method =>
                method.GetParameters().Length == 0 &&
                method.Name != "Draw" &&
                method.Name != ".ctor" &&
                method.Name != ".cctor");
        if (drawCallbackMethod is null)
            return null;

        var dateFields = verifierType
            .GetFields(StaticFlags)
            .Where(field => field.FieldType == typeof(DateTime))
            .ToArray();
        var stringFields = verifierType
            .GetFields(StaticFlags)
            .Where(field => field.FieldType == typeof(string))
            .ToArray();

        // First string property is the authorization status shown by Draw.
        var statusProperty = verifierType
            .GetProperties(StaticFlags)
            .Where(property => property.PropertyType == typeof(string) &&
                               property.GetMethod is not null &&
                               property.SetMethod is not null)
            .OrderBy(property => property.MetadataToken)
            .FirstOrDefault();

        var statusField = statusProperty?.SetMethod is not null
            ? FindStaticStringField(statusProperty.SetMethod, verifierType) ??
              (statusProperty.GetMethod is not null ? FindStaticStringField(statusProperty.GetMethod, verifierType) : null)
            : null;

        // The plugin entry (IDalamudPlugin) calls the verifier's auth client
        // before deciding between the main window and the verification window.
        // Locate that client, its gate method, and the boolean fields the gate
        // reads. Forcing those fields makes the gate true even when the caller
        // was JIT-compiled before the native detour was installed.
        var pluginType = assembly.GetTypes()
            .FirstOrDefault(type => typeof(IDalamudPlugin).IsAssignableFrom(type));
        var clientField = pluginType is null
            ? null
            : verifierType.GetFields(StaticFlags)
                .FirstOrDefault(field =>
                    !field.FieldType.IsPrimitive &&
                    field.FieldType != typeof(string) &&
                    field.FieldType != typeof(DateTime) &&
                    field.FieldType != windowType &&
                    field.FieldType.Assembly == assembly);
        var gateMethod = pluginType is not null && clientField is not null
            ? FindAuthorizationGate(pluginType, clientField.FieldType)
            : null;
        var gateFields = clientField is not null && gateMethod is not null
            ? CollectGateFields(clientField.FieldType, gateMethod)
            : Array.Empty<FieldInfo>();

        return new CctUnlock(
            log,
            pluginInterface,
            windowField,
            drawCallbackMethod,
            dateFields,
            stringFields,
            statusProperty,
            statusField,
            clientField,
            gateMethod,
            gateFields);
    }

    private static MethodInfo? FindAuthorizationGate(Type pluginType, Type clientType)
    {
        var counts = new Dictionary<MethodInfo, int>();
        const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic |
                                   BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
        var methods = pluginType.GetMethods(flags).Cast<MethodBase>()
            .Concat(pluginType.GetConstructors(flags))
            .Concat(new[] { pluginType.TypeInitializer }.OfType<MethodBase>());

        foreach (var method in methods)
        {
            foreach (var called in EnumerateCalledMethods(method))
            {
                if (called.DeclaringType != clientType ||
                    called.ReturnType != typeof(bool) ||
                    called.GetParameters().Length != 0)
                    continue;

                counts[called] = counts.TryGetValue(called, out var count) ? count + 1 : 1;
            }
        }

        return counts.OrderByDescending(pair => pair.Value)
            .Select(pair => pair.Key)
            .FirstOrDefault();
    }

    private static FieldInfo[] CollectGateFields(Type clientType, MethodInfo gateMethod)
    {
        var fields = new HashSet<FieldInfo>();
        var visited = new HashSet<MethodInfo>();
        var queue = new Queue<MethodInfo>();
        queue.Enqueue(gateMethod);

        while (queue.Count > 0 && visited.Count < 32)
        {
            var method = queue.Dequeue();
            if (!visited.Add(method))
                continue;

            foreach (var called in EnumerateCalledMethods(method))
            {
                if (called.DeclaringType == clientType &&
                    called.ReturnType == typeof(bool) &&
                    called.GetParameters().Length == 0)
                    queue.Enqueue(called);
            }

            try
            {
                RuntimeHelpers.PrepareMethod(method.MethodHandle);
                var il = method.GetMethodBody()?.GetILAsByteArray();
                if (il is null)
                    continue;

                for (var index = 0; index + 4 < il.Length; index++)
                {
                    // ldfld 0x7B, ldsfld 0x7E
                    if (il[index] != 0x7B && il[index] != 0x7E)
                        continue;

                    var token = BitConverter.ToInt32(il, index + 1);
                    try
                    {
                        var field = method.Module.ResolveField(token);
                        if (field is not null &&
                            field.DeclaringType == clientType &&
                            field.FieldType == typeof(bool))
                            fields.Add(field);
                    }
                    catch
                    {
                        // Token can refer to another module.
                    }
                }
            }
            catch
            {
                // Encrypted body or unsupported metadata.
            }
        }

        return fields.ToArray();
    }

    private static IEnumerable<MethodInfo> EnumerateCalledMethods(MethodBase method)
    {
        byte[]? il;
        try
        {
            RuntimeHelpers.PrepareMethod(method.MethodHandle);
            il = method.GetMethodBody()?.GetILAsByteArray();
        }
        catch
        {
            yield break;
        }

        if (il is null)
            yield break;

        for (var index = 0; index + 4 < il.Length; index++)
        {
            // call 0x28, callvirt 0x6F
            if (il[index] != 0x28 && il[index] != 0x6F)
                continue;

            var token = BitConverter.ToInt32(il, index + 1);
            MethodInfo? called = null;
            try
            {
                called = method.Module.ResolveMethod(
                    token,
                    method.DeclaringType?.GetGenericArguments(),
                    method.IsGenericMethod ? method.GetGenericArguments() : null) as MethodInfo;
            }
            catch
            {
                // Token can refer to another module.
            }

            if (called is not null)
                yield return called;
        }
    }

    private static FieldInfo? FindStaticStringField(MethodInfo method, Type declaringType)
    {
        try
        {
            RuntimeHelpers.PrepareMethod(method.MethodHandle);
            var il = method.GetMethodBody()?.GetILAsByteArray();
            if (il is null)
                return null;

            for (var index = 0; index + 4 < il.Length; index++)
            {
                // ldsfld 0x7E, stsfld 0x80
                if (il[index] != 0x7E && il[index] != 0x80)
                    continue;

                var token = BitConverter.ToInt32(il, index + 1);
                try
                {
                    var field = method.Module.ResolveField(token);
                    if (field is not null &&
                        field.DeclaringType == declaringType &&
                        field.FieldType == typeof(string))
                        return field;
                }
                catch
                {
                    // Token can refer to a field in another module.
                }
            }
        }
        catch
        {
            // Encrypted body or unsupported metadata.
        }

        return null;
    }

    public void Apply()
    {
        var now = DateTime.UtcNow;
        if (now < _nextApply)
            return;
        _nextApply = now.AddSeconds(1);

        var expires = DateTime.Now.AddYears(10);
        foreach (var field in _dateFields)
        {
            try { field.SetValue(null, expires); }
            catch { /* readonly or type mismatch on a future build */ }
        }

        if (_clientField is not null && _gateMethod is not null)
        {
            _client ??= _clientField.GetValue(null);
            if (_client is not null)
            {
                if (!_gatePatched)
                {
                    ForceAuthorizationFields(_client);
                    _gatePatched = NativeDetour.Patch(
                        _gateMethod,
                        typeof(CctPatches).GetMethod(nameof(CctPatches.AlwaysTrue))!);
                    if (_gatePatched)
                        _log.Information("[NekoUnlock] CharaCradThief authorization gate patched");
                }
                else
                {
                    // The verifier may reset these fields after its own network
                    // check; keep the gate's inputs valid on every tick.
                    ForceAuthorizationFields(_client);
                }
            }
        }

        if (!_statusPatched &&
            _statusProperty?.GetMethod is not null &&
            _statusProperty.SetMethod is not null &&
            _statusField is not null)
        {
            CctPatches.StatusField = _statusField;
            var getterPatched = NativeDetour.Patch(
                _statusProperty.GetMethod,
                typeof(CctPatches).GetMethod(nameof(CctPatches.GetStatus))!);
            var setterPatched = NativeDetour.Patch(
                _statusProperty.SetMethod,
                typeof(CctPatches).GetMethod(nameof(CctPatches.SetStatus))!);
            if (getterPatched && setterPatched)
            {
                _statusPatched = true;
                _log.Information("[NekoUnlock] CharaCradThief authorization status getter/setter patched");
            }
        }

        foreach (var field in _stringFields)
        {
            try
            {
                if (field.GetValue(null) is not string value)
                    continue;

                if (value.Contains("未激活", StringComparison.Ordinal))
                    field.SetValue(null, "已激活");
                else if (value.Contains("未连接", StringComparison.Ordinal))
                    field.SetValue(null, "已连接");
                else if (value.Contains("未授权", StringComparison.Ordinal))
                    field.SetValue(null, "已授权");
                else if (value.Contains("未验证", StringComparison.Ordinal))
                    field.SetValue(null, "已验证");
            }
            catch
            {
                // Keep credential fields untouched.
            }
        }

        var window = _windowField?.GetValue(null);
        if (window is not null)
        {
            try
            {
                var draw = Delegate.CreateDelegate(typeof(Action), window, _drawCallbackMethod);
                _pluginInterface.UiBuilder.Draw -= (Action)draw;
                window.GetType()
                    .GetProperty("IsOpen", InstanceFlags)
                    ?.SetValue(window, false);
            }
            catch (Exception ex)
            {
                if (!_logged)
                    _log.Warning($"[NekoUnlock] CharaCradThief draw callback removal failed: {ex.GetType().Name}: {ex.Message}");
            }
        }

        if (!_logged)
        {
            _logged = true;
            _log.Information("[NekoUnlock] CharaCradThief authorization fields set and verification window suppressed");
        }
    }

    private void ForceAuthorizationFields(object client)
    {
        if (_gateFields.Length == 0)
            return;

        if (!_fieldsResolved)
        {
            try
            {
                foreach (var field in _gateFields)
                    field.SetValue(client, false);

                var baseline = InvokeGate(client);
                foreach (var field in _gateFields)
                {
                    field.SetValue(client, true);
                    var result = InvokeGate(client);
                    field.SetValue(client, false);
                    if (!baseline && result)
                    {
                        _positiveField = field;
                        break;
                    }
                }
            }
            catch
            {
                // Keep the raw fields untouched if the verifier layout changes.
            }

            _fieldsResolved = true;
        }

        foreach (var field in _gateFields)
        {
            try { field.SetValue(client, field == _positiveField); }
            catch { /* readonly or type mismatch on a future build */ }
        }
    }

    private bool InvokeGate(object client)
    {
        try
        {
            return _gateMethod is not null && _gateMethod.Invoke(client, null) is true;
        }
        catch
        {
            return false;
        }
    }

    public void Dispose()
    {
    }
}

internal static class CctPatches
{
    public static FieldInfo? StatusField;

    public static void NoOpInstance(object self)
    {
    }

    public static bool AlwaysTrue()
    {
        return true;
    }

    public static string GetStatus()
    {
        return MapStatus(StatusField?.GetValue(null) as string);
    }

    public static void SetStatus(string value)
    {
        StatusField?.SetValue(null, MapStatus(value));
    }

    private static string MapStatus(string? value)
    {
        if (string.IsNullOrEmpty(value))
            return value ?? string.Empty;

        return value
            .Replace("未激活", "已激活", StringComparison.Ordinal)
            .Replace("未连接", "已连接", StringComparison.Ordinal)
            .Replace("未授权", "已授权", StringComparison.Ordinal)
            .Replace("未验证", "已验证", StringComparison.Ordinal);
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
