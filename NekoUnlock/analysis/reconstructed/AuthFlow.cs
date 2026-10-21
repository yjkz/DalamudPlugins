// Behavioral reconstruction, not original source.
// The shipped assemblies encrypt method bodies at rest; these snippets summarize
// the control flow recovered from metadata, ILSpy output and runtime-decrypted IL.

namespace FFXIVPVPAuto.Verification.Reconstructed;

internal static class AuthorizationGate
{
    // Observed call target from ModuleManager.ValidateEnable.
    public static bool Allows(bool requiresAuth, bool requiresTestCode)
        => AuthState.IsAccessAllowed(requiresAuth, requiresTestCode);
}

internal static class AuthState
{
    // Simplified equivalent of the observed checks.
    public static bool IsAccessAllowed(bool requiresAuth, bool requiresTestCode)
        => (!requiresAuth || IsEffectivelyAuthorized)
           && (!requiresTestCode || IsTestFeatureAuthorized);

    public static bool IsEffectivelyAuthorized
        => IsAuthorized || IsFallbackAuthorized;
}

internal sealed class VerifyManager
{
    // AuthVerifyClient posts RSA/HOTP-wrapped requests to:
    //   https://auth.n3ko.fun/api/v1/query
    // A live check validates the hello response; a credential check validates
    // the machine/account/character credentials.
    public async Task RefreshAsync()
    {
        var live = await _authClient.CheckLiveResultAsync();
        if (!live.IsReachable)
        {
            _authState.SetNekoState(false, false, live.Availability, live.Endpoint, false);
            return;
        }

        var authorized = true;
        foreach (var credential in _credentials)
        {
            var result = await _authClient.CheckValidityResultAsync(
                credential.Value, credential.IdType, credential.Message);
            authorized &= result.IsValid;
        }

        _authState.SetNekoState(true, authorized, live.Availability, live.Endpoint, false);
        _authState.SetAuthorized(authorized);
    }
}

// CharaCradThief: NekoVerifierLib.VerifyWindow
internal sealed class VerifyWindowReconstructed
{
    // Runtime-decrypted IL shows:
    //   ldarg.1; callvirt Action::Invoke
    //   ldarg.0; callvirt Window::Draw
    // i.e. the callback is invoked before the window is drawn.
    public void Show(Action callback)
    {
        callback();
        Draw();
    }

    private void Draw()
    {
        // ImGui window with the verification code / Discord link.
    }
}
