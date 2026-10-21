using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVPVPAuto.Abstracts;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.TestCode;

public sealed class PvPAoePurifyModule : ModuleBase
{
	private sealed class PvPAoePurifyConfig
	{
		public HashSet<uint> TriggerActionIds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x6C
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xD7 0x0E
			}
		}

		public float TriggerRange
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x7B 0x49
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x0F 0x75
			}
		}

		public float PurifyDelaySeconds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x25
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x77 0xB6
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC7 0x27
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xF9
			}
		}

		public int PendingActionId
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x05
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xE1
			}
		}

		public PvPAoePurifyConfig()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (int)unchecked((ushort)(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
				/*Error near IL_0003: Unknown opcode: 0xE2*/;
			}
		}
	}

	private const uint ActionPurify = 29056u;

	private const uint BuffGuard = 3054u;

	private PvPAoePurifyConfig _config;

	private bool _purifyPending;

	private DateTime _purifyReadyTime;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			/*Error: stloc 2 (out-of-bounds)*/;
			/*Error near IL_0001: ldloc 113 (out-of-bounds)*/;
			_ = (ushort)65456;
			/*Error near IL_0006: Unknown opcode: 0xAA*/;
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4F 0x81
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB3 0x6C
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE9
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x64
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x23 0x65
	}

	private void OnActionEffect(uint sourceEntityId, IBattleChara source, ActionType actionType, uint actionId, uint spellId, ulong targetId, Vector3 location, byte targetCount, IReadOnlyList<ulong> effectTargetIds)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0002: Stack underflow*/+ (double)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xCC*/;
		}
	}

	private bool IsNearbyOpponent(IBattleChara source)
	{
		/*Error: Unknown opcode: 0xF8*/;
	}

	private bool TryUsePurifyOnUpdate()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x40
	}

	private void ResetPurify()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x95
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0006: Expected Obj, but got I
		/*Error: stloc 3 (out-of-bounds)*/;
		if ((int)/*Error near IL_0004: Stack underflow*/ <= (int)(sbyte)/*Error near IL_0002: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	private void DrawSkillToggle(uint actionId, bool removable, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF5
	}

	public PvPAoePurifyModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x77 0xBD
	}
}
