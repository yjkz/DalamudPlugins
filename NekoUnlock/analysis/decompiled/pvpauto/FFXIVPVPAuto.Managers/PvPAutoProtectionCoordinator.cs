using System;
using System.Runtime.CompilerServices;
using Dalamud.Plugin.Services;
using FFXIVPVPAuto.Abstracts;

namespace FFXIVPVPAuto.Managers;

[ManagerInitOrder(2)]
internal sealed class PvPAutoProtectionCoordinator : ManagerBase
{
	private Func<bool>? _guard;

	private Func<bool>? _purify;

	private Func<bool>? _aoePurify;

	private Func<bool>? _elixir;

	internal static PvPAutoProtectionCoordinator? Instance
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid metadata token*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC8
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFD
	}

	protected override void Uninit()
	{
		_ = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0002: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0003: Unknown opcode: 0xF2*/;
	}

	internal void RegisterGuard(Func<bool> handler)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x44
	}

	internal void RegisterPurify(Func<bool> handler)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (double)(/*Error near IL_0001: Stack underflow*/ | /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	internal void RegisterAoePurify(Func<bool> handler)
	{
		/*Error: Unknown opcode: 0x78*/;
	}

	internal void RegisterElixir(Func<bool> handler)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x51
	}

	internal void UnregisterGuard(Func<bool> handler)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x8B 0x2E
	}

	internal void UnregisterPurify(Func<bool> handler)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x35
	}

	internal void UnregisterAoePurify(Func<bool> handler)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAC
	}

	internal void UnregisterElixir(Func<bool> handler)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x60
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCB 0x52
	}

	public PvPAutoProtectionCoordinator()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x57 0x81
	}
}
