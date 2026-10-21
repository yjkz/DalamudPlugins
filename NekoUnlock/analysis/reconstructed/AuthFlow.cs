// 行为级重建，不是原始源码。
// 发布程序集的方法体在磁盘上是加密的；以下代码是根据元数据、ILSpy 输出
// 和运行时解密后的 IL 还原出的控制流摘要。

namespace FFXIVPVPAuto.Verification.Reconstructed;

internal static class AuthorizationGate
{
    // 来自 ModuleManager.ValidateEnable 中观察到的调用目标。
    public static bool Allows(bool requiresAuth, bool requiresTestCode)
        => AuthState.IsAccessAllowed(requiresAuth, requiresTestCode);
}

internal static class AuthState
{
    // 对观察到的检查逻辑的简化等价写法。
    public static bool IsAccessAllowed(bool requiresAuth, bool requiresTestCode)
        => (!requiresAuth || IsEffectivelyAuthorized)
           && (!requiresTestCode || IsTestFeatureAuthorized);

    public static bool IsEffectivelyAuthorized
        => IsAuthorized || IsFallbackAuthorized;
}

internal sealed class VerifyManager
{
    // AuthVerifyClient 向以下地址发送 RSA/HOTP 包装后的请求：
    //   https://auth.n3ko.fun/api/v1/query
    // 存活检查校验 hello 响应；凭据检查校验机器码/账号/角色凭据。
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

// CharaCradThief：NekoVerifierLib.VerifyWindow
internal sealed class VerifyWindowReconstructed
{
    // 运行时解密后的 IL 显示：
    //   ldarg.1; callvirt Action::Invoke
    //   ldarg.0; callvirt Window::Draw
    // 即先执行回调，再绘制窗口。
    public void Show(Action callback)
    {
        callback();
        Draw();
    }

    private void Draw()
    {
        // 绘制验证码 / Discord 链接等验证界面。
    }
}
