using System;
using System.Runtime.CompilerServices;
using FFXIVPVPAuto.Abstracts;

namespace FFXIVPVPAuto.Modules.Combat;

public sealed class PvPAutoElixirModule : ModuleBase
{
	private sealed class PvPAutoElixirConfig
	{
		public float ElixirHpPercent
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x70
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x71
			}
		}

		public bool SkipElixirDuringGuard
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA8
			}
			[CompilerGenerated]
			set
			{
				/*Error: Invalid metadata token*/;
			}
		}

		public unsafe bool SkipElixirDuringWalkingDead
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x2B 0xE0
			}
			[CompilerGenerated]
			set
			{
				*(IntPtr*)(nint)/*Error near IL_0002: Stack underflow*/ = (IntPtr)(int)checked((uint)/*Error near IL_0001: Stack underflow*/);
				((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (sbyte)/*Error near IL_0003: Stack underflow*/;
				/*Error near IL_0003: stloc 174 (out-of-bounds)*/;
				_ = -1;
				_ = 4;
				/*Error near IL_0007: Unknown opcode: 0xA7*/;
			}
		}

		public float WalkingDeadAdvanceSeconds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x75
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x2C
			}
		}

		public unsafe bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				_ = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Unknown opcode: 0xF8*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xE9
			}
		}

		public PvPAutoElixirConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x74
		}
	}

	private const uint ActionStandardElixir = 29711u;

	private const uint BuffGuard = 3054u;

	private PvPAutoElixirConfig _config;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x2D
		}
	}

	public unsafe override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if ((long)(*(sbyte*)(nint)checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/)) != 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = ((sbyte[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/| /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xFD*/;
		}
	}

	protected override void Init()
	{
		/*Error: Unknown opcode: 0xBB*/;
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE3 0x74
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA3 0x29
	}

	private bool TryUseElixirOnUpdate()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4C
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x84
	}

	private static void DrawCheckbox(string label, bool value, Action<bool> setValue, ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB5
	}

	public PvPAutoElixirModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAD
	}
}
