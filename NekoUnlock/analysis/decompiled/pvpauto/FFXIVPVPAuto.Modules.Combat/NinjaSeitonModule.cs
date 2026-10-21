using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Managers;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.Combat;

public sealed class NinjaSeitonModule : ModuleBase
{
	private sealed class NinjaSeitonConfig
	{
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				/*Error near IL_0001: Unknown opcode: 0xFD*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x7F 0xDC
			}
		}

		public bool HighPerformanceScan
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xBF 0xE5
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB4
			}
		}

		public float Range
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x7C
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x1C
			}
		}

		public float HpPercentThreshold
		{
			[CompilerGenerated]
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				checked
				{
					_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
					/*Error near IL_0001: Unknown opcode: 0xCA*/;
				}
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x35
			}
		}

		public bool ExcludeProtectedTargets
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC7 0x99
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA8
			}
		}

		public bool SelectTargetOnRelease
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB7 0x8A
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x0C
			}
		}

		public int ReleaseDelayMs
		{
			[CompilerGenerated]
			get
			{
				if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				checked
				{
					_ = (short)unchecked((nuint)checked((nint)unchecked((uint)checked((int)/*Error near IL_0006: Stack underflow*/))));
					/*Error near IL_0009: Unknown opcode: 0xFF*/;
				}
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8B 0xB5
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				if (/*Error near IL_0002: Stack underflow*/ < /*Error near IL_0002: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0002: Unknown opcode: 0xFE39*/;
			}
			[CompilerGenerated]
			set
			{
				//IL_0001: Invalid comparison between Unknown and I4
				if ((int)/*Error near IL_0006: Stack underflow*/ != ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/])
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0006: Unknown opcode: 0xA8*/;
			}
		}

		public NinjaSeitonConfig()
		{
			/*Error: Invalid metadata token*/;
		}
	}

	private const uint DefaultScanIntervalMs = 100u;

	private const uint NinjaJobId = 30u;

	private const uint ActionSeitonTenchu = 29515u;

	private const uint StatusSeitonReady = 3192u;

	private const int RetryIntervalMs = 150;

	private const int PendingActionTimeoutMs = 1000;

	private static readonly HashSet<uint> SeitonReadyStatuses;

	private NinjaSeitonConfig _config;

	private IDisposable? _highPerformanceScanLease;

	private uint? _registeredScanIntervalMs;

	private DateTime _nextAttemptUtc;

	private DateTime _pendingActionUntilUtc;

	private bool _pendingAction;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x65
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB7 0xC5
		}
	}

	public override IReadOnlyList<ModuleCommand> Commands
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x81
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF7 0x28
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x03 0xF4
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCB 0xD2
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x1C
	}

	internal override bool? GetCommandToggleState(string toggleId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x09
	}

	internal override bool SetCommandToggleState(string toggleId, bool enabled)
	{
		/*Error: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0001: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0002: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	private void ApplyScanMode()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAD
	}

	private void UnregisterScan()
	{
		/*Error: Read out of bounds.*/;
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC4
	}

	private static bool IsReady(PlayerSnapshot localPlayer)
	{
		switch ((int)/*Error near IL_003b: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		}
	}

	private PlayerSnapshot? FindTarget(Vector3 origin)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x05
	}

	private void ScheduleNextAttempt(bool accepted)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x1D
	}

	private void OnPostUseAction(bool result, ActionType actionType, uint actionId, ulong targetId, uint extraParam, UseActionMode queueState, uint comboRouteId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA4
	}

	private void OnPostActionEffect(uint sourceEntityId, IBattleChara source, ActionType actionType, uint actionId, uint spellId, ulong targetId, Vector3 location, byte targetCount, IReadOnlyList<ulong> effectTargetIds)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4D
	}

	private void DrawConfig(ref bool hasChanged)
	{
		switch ((int)/*Error near IL_001b: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		}
	}

	private static void DrawCheckbox(string label, bool value, Action<bool> setValue, ref bool hasChanged)
	{
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0003: ldloc 53 (out-of-bounds)*/;
	}

	public NinjaSeitonModule()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	static NinjaSeitonModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4D
	}
}
