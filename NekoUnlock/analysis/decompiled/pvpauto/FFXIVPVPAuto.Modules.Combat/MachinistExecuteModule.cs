using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Plugin.Services;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Helpers;
using FFXIVPVPAuto.Managers;

namespace FFXIVPVPAuto.Modules.Combat;

public sealed class MachinistExecuteModule : ModuleBase
{
	private sealed class MachinistExecuteConfig
	{
		public bool EnableLimitBreak
		{
			[CompilerGenerated]
			get
			{
				if (/*Error near IL_0002: Stack underflow*/ > /*Error near IL_0002: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0002: Unknown opcode: 0xBE*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x5F 0xEF
			}
		}

		public bool LimitBreakDamagePrediction
		{
			[CompilerGenerated]
			get
			{
				/*Error: Unknown opcode: 0xE7*/;
			}
			[CompilerGenerated]
			set
			{
				return /*Error near IL_0002: Stack underflow*/;
			}
		}

		public uint LimitBreakHpThreshold
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xBF 0x43
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x73 0x8B
			}
		}

		public bool EnableEagleEye
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x30
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xE3 0x98
			}
		}

		public bool EagleEyeDamagePrediction
		{
			[CompilerGenerated]
			get
			{
				/*Error: Unknown opcode: 0xF2*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xCF 0x50
			}
		}

		public uint EagleEyeHpThreshold
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8B 0xCC
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x89
			}
		}

		public bool HighPerformanceScan
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xE3 0x0E
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA9
			}
		}

		public bool ExcludeInvulnerableTargets
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB9
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9C
			}
		}

		public float Range
		{
			[CompilerGenerated]
			get
			{
				if (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				return (float)/*Error near IL_0006: Stack underflow*/;
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0xEA*/;
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (IntPtr)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Not a type handle*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xD1
			}
		}

		public MachinistExecuteConfig()
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Not a type handle*/;
		}
	}

	private const uint DefaultScanIntervalMs = 100u;

	private const uint BardJobId = 23u;

	private const uint MachinistJobId = 31u;

	private const uint DancerJobId = 38u;

	private const uint ActionMarksmanSpite = 29415u;

	private const uint ActionEagleEyeShot = 43251u;

	private MachinistExecuteConfig _config;

	private IDisposable? _highPerformanceScanLease;

	private uint? _registeredScanIntervalMs;

	private PvPExecutePrediction _lastLimitBreakPrediction;

	private PvPExecutePrediction _lastEagleEyePrediction;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3C
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB0
		}
	}

	public override IReadOnlyList<ModuleCommand> Commands
	{
		[CompilerGenerated]
		get
		{
			/*Error: Read out of bounds.*/;
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE1
		}
	}

	protected override void Init()
	{
		/*Error: Unknown opcode: 0xFC*/;
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x1C
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x09
	}

	internal override bool? GetCommandToggleState(string toggleId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA8
	}

	internal override bool SetCommandToggleState(string toggleId, bool enabled)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x80
	}

	private void ApplyScanMode()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEB 0x09
	}

	private void UnregisterScan()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA4
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0x5E911E51
	}

	private static bool IsPhysicalRangedJob(uint jobId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x1C
	}

	private void TryExecute(uint actionId, uint hpThreshold, float range, Vector3 origin, string name, bool excludeInvulnerable, bool damagePrediction)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0C
	}

	private PlayerSnapshot? FindLowestHpTarget(uint actionId, Vector3 origin, float range, uint hpThreshold, bool excludeInvulnerable, bool damagePrediction)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x3B 0xAC
	}

	private void SetPrediction(uint actionId, PvPExecutePrediction prediction)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDD
	}

	private void DrawConfig(ref bool hasChanged)
	{
		/*Error: Unknown opcode: 0xB2*/;
	}

	private static void DrawCheckbox(string label, bool value, Action<bool> setValue, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2D
	}

	private static void DrawPredictionToggle(string label, uint actionId, bool value, Action<bool> setValue, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0x5C34D111
	}

	private static void DrawUInt(string label, uint value, Action<uint> setValue, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x63 0xC5
	}

	public MachinistExecuteModule()
	{
		((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (sbyte)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xC1*/;
	}
}
