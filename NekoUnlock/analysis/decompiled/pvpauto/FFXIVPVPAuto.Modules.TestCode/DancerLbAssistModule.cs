using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.Game.Object;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Helpers;
using FFXIVPVPAuto.Managers;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.TestCode;

public sealed class DancerLbAssistModule : ModuleBase
{
	private sealed class DancerLbAssistConfig
	{
		public float TargetDistanceMeters
		{
			[CompilerGenerated]
			get
			{
				/*Error: Unknown opcode: 0xE7*/;
			}
			[CompilerGenerated]
			set
			{
				/*Error: Metadata token must be either a methoddef, memberref or methodspec*/;
			}
		}

		internal void Normalize()
		{
			/*Error: Unknown opcode: 0xE8*/;
		}

		public DancerLbAssistConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD8
		}
	}

	private readonly DancerLbSequenceState _state;

	private readonly DancerLbDiagnostics _diagnostics;

	private DancerLbAssistConfig _config;

	private ActionMovementLockManager? _movementLock;

	private ForwardMovementPulseController? _pulseController;

	private IDisposable? _movementLease;

	private bool _registered;

	private bool _runtimeUnavailable;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0003: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1C
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5D
		}
	}

	protected override void Init()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xCD*/;
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x98
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x87 0x5D
	}

	private void Cleanup()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD9
	}

	private bool IsEnvironmentAvailable()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x21
	}

	private bool CanContinue()
	{
		/*Error: Unknown opcode: 0xEF*/;
	}

	private bool IsLocalLb(IBattleChara player, ActionType type, uint actionId, uint spellId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x65
	}

	private static bool CanObserve()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE9
	}

	private void OnPreCharacterCompleteCast(ref bool isPrevented, ref IBattleChara player, ref ActionType type, ref uint actionId, ref uint spellId, ref GameObjectId animationTargetId, ref Vector3 location, ref float rotation, ref short lastUsedActionSequence, ref int animationVariation, ref int ballistaEntityId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x53 0x2E
	}

	private void OnPostCharacterCompleteCast(bool result, IBattleChara player, ActionType type, uint actionId, uint spellId, GameObjectId animationTargetId, Vector3 location, float rotation, short lastUsedActionSequence, int animationVariation, int ballistaEntityId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x64
	}

	private void OnUpdate(IFramework framework)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD3 0x23
	}

	private void CancelPulse()
	{
		/*Error: Invalid metadata token*/;
	}

	private void OnRuntimeError(Exception exception)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x18
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB9
	}

	public unsafe DancerLbAssistModule()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		if (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		*(short*)(nint)/*Error near IL_0004: Stack underflow*/ = (short)(/*Error near IL_0003: Stack underflow*/ * /*Error near IL_0003: Stack underflow*/);
		/*Error near IL_0004: Invalid field token*/;
	}
}
