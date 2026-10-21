using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Hooking;
using FFXIVClientStructs.FFXIV.Client.Game.Object;
using FFXIVPVPAuto.Abstracts;
using OmenTools.Interop.Game.Models;

namespace FFXIVPVPAuto.Modules.TestCode;

public sealed class LimitlessDashModule : ModuleBase
{
	private unsafe delegate uint GetActionInRangeOrLoSDelegate(uint actionID, GameObject* source, GameObject* target);

	private unsafe delegate bool BeaconLoSCheckDelegate(nint actionManager, nint beacon, Vector3* playerPosition);

	private delegate long ActionRequirementsDelegate(nint actionManager, uint actionID, nint actionRow);

	private sealed class LimitlessDashConfig
	{
		public Dictionary<uint, bool> ActionsEnabled
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xDF 0x8A
			}
			[CompilerGenerated]
			set
			{
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_0002: Stack underflow*/ >= /*Error near IL_0002: Stack underflow*/)
				{
					_ = 8;
					/*Error near IL_0003: Unknown opcode: 0xE5*/;
				}
				if (/*Error near IL_0017: Stack underflow*/ != /*Error near IL_0015: Stack underflow*/% 8.0)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0017: Unknown opcode: 0xFF*/;
			}
		}

		public bool EnableAllDashActions
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x78
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xDD
			}
		}

		public bool EnableGlobalRangeBypass
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC5
			}
			[CompilerGenerated]
			set
			{
				/*Error near IL_0001: Unknown opcode: 0xCC*/;
			}
		}

		public bool IgnoreBeaconWalls
		{
			[CompilerGenerated]
			get
			{
				/*Error: Not a type handle*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9D
			}
		}

		public unsafe bool UnlockDashUsability
		{
			[CompilerGenerated]
			get
			{
				//IL_0003: Unknown result type (might be due to invalid IL or missing references)
				_ = /*Error near IL_0004: Stack underflow*/+ checked((short)(*unchecked((double*)(nint)/*Error near IL_0001: Stack underflow*/)));
				/*Error near IL_0004: Unknown opcode: 0xF4*/;
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0x24*/;
			}
		}

		public LimitlessDashConfig()
		{
			/*Error: Unknown opcode: 0xBD*/;
		}
	}

	private const uint ActionRegressPvP = 29551u;

	private const uint ActionRetrogradePvP = 41507u;

	private const uint ActionRegressPvE = 24403u;

	private const uint ActionBetweenTheLines = 7419u;

	private static readonly CompSig GetActionInRangeOrLoSSig;

	private static readonly CompSig BeaconLoSCheckSig;

	private static readonly CompSig ActionRequirementsSig;

	private Hook<GetActionInRangeOrLoSDelegate>? _getActionInRangeOrLoSHook;

	private Hook<BeaconLoSCheckDelegate>? _beaconLoSCheckHook;

	private Hook<ActionRequirementsDelegate>? _actionRequirementsHook;

	private LimitlessDashConfig _config;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x01
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD4
		}
	}

	protected unsafe override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//IL_0002: Expected I4, but got I8
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (int)checked((ulong)/*Error near IL_0001: Stack underflow*/);
			_ = *(float*)(nint)(8 ^ /*Error near IL_0003: ldarga 78 (out-of-bounds)*/);
			/*Error near IL_0007: Unknown opcode: 0xCA*/;
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x55
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC5
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x23 0xD1
	}

	private unsafe uint GetActionInRangeOrLoSDetour(uint actionID, GameObject* source, GameObject* target)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x00
	}

	private unsafe bool BeaconLoSCheckDetour(nint actionManager, nint beacon, Vector3* playerPosition)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE5
	}

	private long ActionRequirementsDetour(nint actionManager, uint actionID, nint actionRow)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBB 0x6F
	}

	private bool IsManagedDashAction(uint actionID)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6B 0xCA
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0004: Not a type handle*/;
	}

	private void DrawActionCheckbox(uint actionID, string fallbackName, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x31
	}

	private static nint ScanRequired(CompSig signature, string functionName)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x03 0x28
	}

	private void DisposeHooks()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x71
	}

	private static void DisposeHook<T>(ref Hook<T>? hook) where T : Delegate
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEF 0x7E
	}

	public LimitlessDashModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6C
	}

	static LimitlessDashModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFB 0x63
	}
}
