using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FFXIVPVPAuto.Managers;

internal static class PvPAutoProtectionMigration
{
	private sealed class LegacyConfig
	{
		public bool EnableGuard
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x3D
			}
			[CompilerGenerated]
			set
			{
				/*Error: Invalid metadata token*/;
			}
		}

		public float GuardDelaySeconds
		{
			[CompilerGenerated]
			get
			{
				/*Error: Unknown opcode: 0xC1*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x5F 0xAD
			}
		}

		public bool EnablePurify
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x5C
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x05
			}
		}

		public unsafe bool FastPurifyBlota
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x13 0xF3
			}
			[CompilerGenerated]
			set
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0004: Expected F8, but got I4
				/*Error: stloc 2 (out-of-bounds)*/;
				*(double*)(nint)/*Error near IL_0004: Stack underflow*/ = (int)(*(byte*)(nint)(~/*Error near IL_0002: Stack underflow*/));
				/*Error near IL_0004: Stack underflow*/;
				_ = 1;
				/*Error near IL_0007: Invalid metadata token*/;
			}
		}

		public bool FastPurifyWindsReply
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x7C
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0xFEF1*/;
			}
		}

		public float PurifyDelaySeconds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9D
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x73 0x2C
			}
		}

		public float SpecialSkillPurifyDelaySeconds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA1
			}
			[CompilerGenerated]
			set
			{
				checked
				{
					_ = (short)/*Error near IL_0001: Stack underflow*/;
					/*Error near IL_0001: Unknown opcode: 0xA6*/;
				}
			}
		}

		public HashSet<uint>? PurifyStatusIds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x7D
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xF5
			}
		}

		public bool EnableElixir
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x47 0xF3
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x90
			}
		}

		public float ElixirHpPercent
		{
			[CompilerGenerated]
			get
			{
				/*Error: Invalid metadata token*/;
			}
			[CompilerGenerated]
			set
			{
				/*Error: stloc 8 (out-of-bounds)*/;
				/*Error near IL_0002: Unknown opcode: 0xBF*/;
			}
		}

		public bool SkipElixirDuringGuard
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xD5
			}
			[CompilerGenerated]
			set
			{
				_ = 1.2294104015508274E-269;
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC7 0x8E
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x18
			}
		}

		public LegacyConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x31
		}
	}

	private sealed class GuardConfig
	{
		public float GuardDelaySeconds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8F 0xA0
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x11
			}
		}

		public bool EnableDragoonLb
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x5D
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xEB 0xFF
			}
		}

		public HashSet<uint> TriggerActionIds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB8
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xBD
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB0
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xF1
			}
		}

		public GuardConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE7 0xA4
		}
	}

	private sealed class PurifyConfig
	{
		public unsafe bool FastPurifyBlota
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xED
			}
			[CompilerGenerated]
			set
			{
				//IL_0005: Expected F8, but got I4
				*(double*)(nint)/*Error near IL_0005: Stack underflow*/ = (int)(*(ushort*)(0 - *(uint*)(nint)/*Error near IL_0001: Stack underflow*/));
				((short[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (short)/*Error near IL_0006: Stack underflow*/;
				/*Error near IL_0006: Unknown opcode: 0xCC*/;
			}
		}

		public unsafe bool FastPurifyWindsReply
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid local signature token: 0xA7A72D53
			}
			[CompilerGenerated]
			set
			{
				*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
				((IntPtr[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (IntPtr)(int)checked((uint)unchecked((int)(*(byte*)(int)(*(uint*)(nint)/*Error near IL_0002: Stack underflow*/))));
				/*Error near IL_0005: Unknown opcode: 0xEC*/;
			}
		}

		public float PurifyDelaySeconds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x3B 0x8B
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xFD
			}
		}

		public float SpecialSkillPurifyDelaySeconds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x3B 0xD8
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x08
			}
		}

		public HashSet<uint> PurifyStatusIds
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB8
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x74
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				_ = ~checked(/*Error near IL_0002: Stack underflow*/ - (nuint)/*Error near IL_0001: Stack underflow*/);
				/*Error near IL_0006: Invalid metadata token*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x14
			}
		}

		public PurifyConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD3 0x9A
		}
	}

	private sealed class ElixirConfig
	{
		public float ElixirHpPercent
		{
			[CompilerGenerated]
			get
			{
				/*Error: Invalid metadata token*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x13 0xEC
			}
		}

		public bool SkipElixirDuringGuard
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9B 0x4D
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xEB 0x2F
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8F 0x52
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xF7 0x02
			}
		}

		public ElixirConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC8
		}
	}

	private const string LegacyModuleId = "PvPAutoProtection";

	private const string MarkerName = "PvPAutoProtection.migrated";

	internal static void TryMigrate()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFF 0xBA
	}

	private static void Write<T>(string directory, string moduleId, T config)
	{
		_ = ((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Unknown opcode: 0xA8*/;
	}
}
