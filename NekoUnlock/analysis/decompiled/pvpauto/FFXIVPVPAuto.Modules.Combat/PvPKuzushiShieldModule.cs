using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Helpers;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.Combat;

public sealed class PvPKuzushiShieldModule : ModuleBase
{
	private sealed class PvPKuzushiShieldConfig
	{
		public HashSet<uint> DisabledShieldActions
		{
			[CompilerGenerated]
			get
			{
				/*Error near IL_0001: Not a type handle*/;
			}
			[CompilerGenerated]
			set
			{
				if ((int)/*Error near IL_0005: Stack underflow*/ != 0)
				{
					/*Error: Invalid branch target*/;
				}
				if (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error: End of method reached without returning.*/;
			}
		}

		public PvPKuzushiShieldConfig()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			((int[])checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/))[-1] = 2;
			/*Error near IL_0004: Unknown opcode: 0xFF*/;
		}
	}

	private PvPKuzushiShieldConfig _config;

	private readonly KuzushiShieldSequence _sequence;

	private bool _statusPresentBeforeRequest;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE4
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x6F 0xA5
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x35
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE0
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x04
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x48
	}

	private void OnActionEffect(uint sourceEntityId, IBattleChara source, ActionType actionType, uint actionId, uint spellId, ulong targetId, Vector3 location, byte targetCount, IReadOnlyList<ulong> effectTargetIds)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x50
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x8B 0x4A
	}

	private void TryHandleShield()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE1
	}

	private bool IsAuthorized()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x67 0xAC
	}

	private static bool IsActionReadyForSelf(uint actionId, ulong targetId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF5
	}

	private void OnGainStatus(IBattleChara player, ushort id, ushort param, ushort stackCount, TimeSpan remainingTime, ulong sourceId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x60
	}

	private void OnLoseStatus(IBattleChara player, ushort id, ushort param, ushort stackCount, ulong sourceId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD9
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2C
	}

	public PvPKuzushiShieldModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x61
	}
}
