using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Plugin.Services;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Helpers;
using FFXIVPVPAuto.Managers;

namespace FFXIVPVPAuto.Modules.Combat;

public sealed class PvPSmiteModule : ModuleBase
{
	private sealed class PvPSmiteConfig
	{
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x19
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x80
			}
		}

		public bool DamagePrediction
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x5C
			}
			[CompilerGenerated]
			set
			{
				if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0005: ldarga 87 (out-of-bounds)*/;
				/*Error near IL_0007: Unknown opcode: 0xBC*/;
			}
		}

		public unsafe bool HighPerformanceScan
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x29
			}
			[CompilerGenerated]
			set
			{
				*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
				_ = (double)(int)checked((byte)/*Error near IL_0002: Stack underflow*/);
				/*Error near IL_0003: Not a type handle*/;
			}
		}

		public bool ExcludeInvulnerableTargets
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x0D
			}
		}

		public bool UsePercentThreshold
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8F 0x94
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x95
			}
		}

		public uint HpThreshold
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x2F 0xD9
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xF4
			}
		}

		public float HpPercentThreshold
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x3C
			}
			[CompilerGenerated]
			set
			{
				/*Error: Not a type handle*/;
			}
		}

		public float Range
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x71
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xD7 0x2D
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid local signature token: 0x135B4C67
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB7 0x64
			}
		}

		public PvPSmiteConfig()
		{
			/*Error: Unknown opcode: 0xFF*/;
		}
	}

	private const uint DefaultScanIntervalMs = 100u;

	private const uint ActionSmite = 43248u;

	private PvPSmiteConfig _config;

	private static PvPSmiteModule? _instance;

	private IDisposable? _highPerformanceScanLease;

	private uint? _registeredScanIntervalMs;

	private PvPExecutePrediction _lastPrediction;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x03 0xF3
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBF 0x80
		}
	}

	public override IReadOnlyList<ModuleCommand> Commands
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xEA*/;
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA5
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x88
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCC
	}

	internal static bool TryUseChainedSmite(ulong preferredTargetId, Vector3 origin)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_000a: Stack underflow*/ <= /*Error: ldarg 44 (out-of-bounds)*/% (ushort)6)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0014: Stack underflow*/^ 0x3AB83B1C0FA5D44FL;
		/*Error near IL_0014: Unknown opcode: 0xE6*/;
	}

	private bool TryUseChainedSmiteCore(ulong preferredTargetId, Vector3 origin)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA3 0xFF
	}

	private bool CanUseSmiteOn(PlayerSnapshot target, Vector3 origin)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDC
	}

	protected override void ConfigChanged()
	{
		_ = (double)/*Error near IL_0001: Stack underflow*/ >> (int)/*Error near IL_0001: ldarg 241 (out-of-bounds)*/;
		/*Error: End of method reached without returning.*/;
	}

	internal override bool? GetCommandToggleState(string toggleId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB0
	}

	internal override bool SetCommandToggleState(string toggleId, bool enabled)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x43 0x77
	}

	private void ApplyScanMode()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x00
	}

	private unsafe void UnregisterScan()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		throw /*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
	}

	private void OnUpdate(IFramework _)
	{
		((short[])/*Error near IL_0003: Stack underflow*/)[(uint)/*Error near IL_0001: Stack underflow*/] = 4;
		if (/*Error near IL_0004: Stack underflow*/ < /*Error near IL_0004: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xBF*/;
	}

	private PlayerSnapshot? FindTarget(Vector3 origin)
	{
		/*Error: Empty body found. Decompiled assembly might be a reference assembly.*/;
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x27 0xA6
	}

	private static void DrawCheckbox(string label, bool value, Action<bool> setValue, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4C
	}

	private static void DrawUInt(string label, uint value, Action<uint> setValue, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFC
	}

	private bool MeetsManualThreshold(PlayerSnapshot target)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x88
	}

	public PvPSmiteModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x58
	}
}
