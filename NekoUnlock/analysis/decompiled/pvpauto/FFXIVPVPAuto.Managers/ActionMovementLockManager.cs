using System;
using Dalamud.Hooking;
using Dalamud.Plugin.Services;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Helpers;
using OmenTools.Interop.Game.Models;

namespace FFXIVPVPAuto.Managers;

[ManagerInitOrder(2)]
internal sealed class ActionMovementLockManager : ManagerBase
{
	private delegate nint MoveForbiddenDelegate(nint context);

	private static readonly CompSig MoveForbiddenSig;

	private readonly ActionMovementLeaseSet _leases;

	private Hook<MoveForbiddenDelegate>? _moveForbiddenHook;

	private bool _faulted;

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF4
	}

	internal void EnsureAvailable()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFB 0xF4
	}

	internal IDisposable AcquirePersistent()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x88
	}

	internal IDisposable AcquireTemporary(TimeSpan lifetime)
	{
		/*Error: Invalid metadata token*/;
	}

	internal IDisposable AcquireTemporaryUntil(long expiresAt)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF7 0x79
	}

	private static bool HasAuthorization()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA3 0x10
	}

	private static void EnsureAuthorized()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCB 0x59
	}

	private nint MoveForbiddenDetour(nint context)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x58
	}

	private void OnUpdate(IFramework framework)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA4
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC1
	}

	public ActionMovementLockManager()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEC
	}

	static ActionMovementLockManager()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x54
	}
}
