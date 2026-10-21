using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVPVPAuto.Abstracts;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.Combat;

public sealed class PvPAutoPurifyModule : ModuleBase
{
	private sealed class PvPAutoPurifyConfig
	{
		public bool FastPurifyBlota
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x18
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x31
			}
		}

		public bool FastPurifyWindsReply
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC8
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x95
			}
		}

		public float PurifyDelaySeconds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x1B 0xBC
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB9
			}
		}

		public float SpecialSkillPurifyDelaySeconds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA4
			}
			[CompilerGenerated]
			set
			{
				//IL_0002: Expected I8, but got I4
				((long[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = 8L;
				if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0007: Invalid metadata token*/;
			}
		}

		public HashSet<uint> PurifyStatusIds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xFB 0xA2
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xEC
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				_ = (double)(nint)((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
				/*Error near IL_0002: Unknown opcode: 0xA9*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x79
			}
		}

		public int PendingStatusId
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x2F 0xC8
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x08
			}
		}

		public PvPAutoPurifyConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x0F 0x2E
		}
	}

	private const uint ActionPurify = 29056u;

	private const uint BuffGuard = 3054u;

	private PvPAutoPurifyConfig _config;

	private bool _purifyPending;

	private uint _pendingPurifyStatusId;

	private DateTime _purifyReadyTime;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//IL_0006: Invalid comparison between Unknown and I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if ((int)/*Error near IL_000b: Stack underflow*/ <= (int)((short[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/])
			{
				/*Error: Invalid branch target*/;
			}
			if (/*Error near IL_0011: Stack underflow*/ == /*Error near IL_000c: Stack underflow*// /*Error near IL_000c: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (/*Error near IL_0016: Stack underflow*/ > /*Error near IL_0016: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0016: Not a type handle*/;
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4C
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA3 0x13
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB4
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x80
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x3D
	}

	private void OnActionEffect(uint sourceEntityId, IBattleChara source, ActionType actionType, uint actionId, uint spellId, ulong targetId, Vector3 location, byte targetCount, IReadOnlyList<ulong> effectTargetIds)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)(/*Error near IL_0002: Stack underflow*/ + 1);
			/*Error near IL_0003: Unknown opcode: 0xA8*/;
		}
	}

	private bool TryUsePurifyOnUpdate()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF8
	}

	private void SchedulePurify(uint statusId, float delaySeconds)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD3 0x0A
	}

	private void ResetPurify()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x45
	}

	private void DrawConfig(ref bool hasChanged)
	{
		/*Error: starg 183 (out-of-bounds)*/;
		/*Error: End of method reached without returning.*/;
	}

	private void DrawStatusToggle(uint statusId, bool removable, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x23 0xF4
	}

	private static void DrawCheckbox(string label, bool value, Action<bool> setValue, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x61
	}

	public PvPAutoPurifyModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x43 0xFA
	}
}
