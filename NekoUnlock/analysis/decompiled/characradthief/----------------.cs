using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net.Http;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CharaCradThief;
using Dalamud.Configuration;
using Dalamud.Hooking;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.Game.UI;
using FFXIVClientStructs.FFXIV.Client.UI.Agent;
using FFXIVClientStructs.FFXIV.Client.UI.Misc;
using FFXIVClientStructs.FFXIV.Common.Math;
using FFXIVClientStructs.FFXIV.Component.GUI;
using FFXIVClientStructs.STD;
using Lumina.Excel;
using Lumina.Excel.Sheets;
using NekoVerifierLib;
using OtpNet;

[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.13.7005")]
[SkipLocalsInit]
internal sealed class _200D_200E_200E_202B_200F_200C_200E_202C_200E_200C_200E_202A_200F_200D_200E_200F : Regex
{
	private sealed class _202D_200E_200D_200D_200E_200C_200F_200C_200E_202E_200E_202B_200E_200F_200E_200F : RegexRunnerFactory
	{
		private sealed class _200B_200E_200E_200D_200F_200E_200F_202A_200E_200B_200E_200E_200E_200D_200F_200E : RegexRunner
		{
			protected override void Scan(ReadOnlySpan<char> P_0)
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x29
			}

			private bool _200E_200F_202B_200B_200E_202B_200F_202C_200E_202B_200F_200D_200E_202B_200E_200F(ReadOnlySpan<char> P_0)
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xE4
			}

			private bool _200F_200E_202A_200D_200F_200B_200E_202A_200F_202E_200E_200F_200E_202B_200F_200F(ReadOnlySpan<char> P_0)
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x37 0x46
			}

			public _200B_200E_200E_200D_200F_200E_200F_202A_200E_200B_200E_200E_200E_200D_200F_200E()
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xD9
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[CompilerGenerated]
			private void _200F_200F_202C_200D_200F_200C_200F_202B_200F_202C_200E_202C_200E_202B_200E_200E(int P_0)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_0003: Stack underflow*/ <= (/*Error near IL_0001: Stack underflow*/ ^ /*Error near IL_0001: Stack underflow*/))
				{
					/*Error: Invalid branch target*/;
				}
				if ((int)/*Error near IL_0008: Stack underflow*/ == 0)
				{
					/*Error: Invalid branch target*/;
				}
				if (/*Error near IL_000d: Stack underflow*/ < /*Error near IL_000b: Stack underflow*/* ((int[])/*Error near IL_000a: Stack underflow*/)[((object[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/]])
				{
					/*Error near IL_000d: Unknown opcode: 0xAE*/;
				}
				_ = ((float[])/*Error near IL_002c: Stack underflow*/)[checked((uint)/*Error near IL_002b: Stack underflow*/)];
				/*Error near IL_002c: Unknown opcode: 0xF4*/;
			}
		}

		protected override RegexRunner CreateInstance()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x49
		}

		public _202D_200E_200D_200D_200E_200C_200F_200C_200E_202E_200E_202B_200E_200F_200E_200F()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x95
		}
	}

	internal static readonly _200D_200E_200E_202B_200F_200C_200E_202C_200E_200C_200E_202A_200F_200D_200E_200F _202C_200E_202A_200D_200E_200E_200E_202B_200F_202B_200E_202B_200F_200D_200E_200F;

	private unsafe _200D_200E_200E_202B_200F_200C_200E_202C_200E_200C_200E_202A_200F_200D_200E_200F()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I8, but got Unknown
		checked
		{
			((long[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = /*Error near IL_0003: Stack underflow*/+ unchecked((sbyte)(nuint)/*Error near IL_0001: Stack underflow*/);
		}
		*(_003F*)(nint)/*Error near IL_0005: Stack underflow*/ = /*Error near IL_0005: Stack underflow*/;
		/*Error near IL_0005: Unknown opcode: 0xF7*/;
	}

	static _200D_200E_200E_202B_200F_200C_200E_202C_200E_200C_200E_202A_200F_200D_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD0
	}
}
[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.13.7005")]
internal static class _200C_200F_200E_202B_200E_200C_200E_200F_200E_202C_200E_200C_200F_200D_200F_200F
{
	internal static readonly TimeSpan _200D_200E_200E_200D_200F_200D_200F_202D_200E_200B_200E_200D_200E_200C_200E_200F;

	internal static readonly bool _200F_200F_202E_202C_200E_200E_200F_200F_200F_202E_200E_202A_200E_202A_200F_200E;

	static _200C_200F_200E_202B_200E_200C_200E_200F_200E_202C_200E_200C_200F_200D_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC4
	}
}
internal class _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _202E_200E_200E_200F_200F_200C_200E_200D_200E_202B_200E_200B_200E_200F
	{
		public byte[] _202E_200E_202C_202B_200E_202A_200F_200B_200E_200E_200E_200B_200E_200D_200E_200E;

		public int _202D_200E_202B_202A_200E_202B_200E_202D_200E_200D_200F_200E_200F_202E_200E_200F;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _202C_200E_200E_200E_200F_200C_200E_200D_200E_202B_200E_200B_200E_200F
	{
		public MemoryStream _200F_200F_200E_202B_200F_202C_200E_200D_200F_202C_200E_200E_200F_200E_200E_200F;
	}

	internal byte[] _202E_200E_200F_200D_200E_202D_200E_200C_200F_200D_200F_200C_200E_200C_200E_200E;

	internal byte[] _200E_200F_200E_202E_200E_200C_200F_200D_200F_200F_200F_202D_200E_202B_200E_200F;

	internal byte[] _202A_200F_202B_200F_200E_202D_200E_200D_200F_200F_200F_200D_200F_200E_200F_200E;

	internal byte[] _200C_200E_202D_200E_200E_200C_200F_202B_200E_202B_200E_202B_200E_202A_200F_200E;

	internal byte[] _200C_200E_202D_200E_200E_200C_200F_202B_200E_202B_200E_202B_200E_200F_200F_200E;

	internal byte[] _200C_200E_202D_202B_200E_200C_200F_202B_200E_202B_200E_202A_200E_200C_200F_200E;

	internal byte[] _200C_200E_202D_202B_200E_202E_200E_202B_200E_202B_200E_202A_200E_200C_200F_200E;

	internal byte[] _200D_200E_202B_200C_200E_200D_200E_202A_200F_200F_200F_200B_200E_202E_200E_200E;

	private static readonly Regex _200D_200E_200C_200C_200F_200D_200F_202B_200F_200E_200E_202E_200E_202E_200E_200E;

	private static readonly byte[] _202D_200E_200C_202B_200E_200E_200E_200F_200F_200E_200E_200E_200F_200F_200F_200E;

	private static readonly byte[] _200C_200E_202C_200C_200F_200D_200E_200E_200F_200C_200E_202D_200E_200D_200E_200E;

	private static readonly Regex _202C_200E_202D_200F_200E_200B_200E_202B_200E_200E_200E_202A_200F_200F_200E_200E;

	private static readonly Regex _200F_200E_200E_200E_200E_202A_200E_202A_200F_200C_200F_202D_200E_202A_200E_200F;

	private static string _202C_200E_200C_202E_200E_202E_200E_200C_200F_200F_200F_200C_200F_202C_200E_200E;

	internal int _202D_200E_200F_200C_200E_200F_200F_200F_200E_200D_200E_200D_200E_200B_200E_200F
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF3 0x2E
		}
	}

	internal bool _200F_200F_202D_200B_200E_202B_200F_200E_200F_202B_200E_202C_200E_200E_200F_200E
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x79
		}
	}

	internal static string _202B_200F_202D_202E_200E_200C_200F_202E_200E_200C_200E_200E_200E_202D_200E_200E
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5B 0xCC
		}
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4D
		}
	}

	private _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5B 0x81
	}

	internal _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E(RSA P_0, bool P_1 = false)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC0
	}

	internal _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E(byte[] P_0, byte[] P_1, byte[] P_2, byte[] P_3, byte[] P_4, byte[] P_5, byte[] P_6, byte[] P_7)
	{
		/*Error: Invalid field token*/;
	}

	internal _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E(byte[] P_0, byte[] P_1, byte[] P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBB 0x2A
	}

	internal RSA _202B_200F_200F_200D_200F_200E_200E_200F_200F_202E_200E_200E_200E_202E_200E_200E()
	{
		/*Error: Invalid metadata token*/;
	}

	internal RSACryptoServiceProvider _200E_200F_200C_200F_200E_202D_200E_200D_200E_202E_200E_200B_200E_202D_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB9
	}

	internal void _202E_200E_200F_200C_200F_202B_200F_202B_200F_200E_200E_200B_200E_200F(RSA P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x99
	}

	internal static BigInteger _202A_200E_202E_202B_200E_200B_200E_200C_200F_200C_200F_200C_200F_202A_200E_200E(byte[] P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAC
	}

	internal static byte[] _200F_200F_202B_200C_200E_202A_200F_200C_200F_200C_200F_200C_200F_202A_200E_200E(BigInteger P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7B 0x1C
	}

	internal static byte[] _200C_200E_200D_202C_200E_200E_200F_200C_200F_200C_200F_200C_200F_202A_200E_200F(byte[] P_0, int P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x63 0x0A
	}

	private static BigInteger _202B_200F_200F_200F_200F_200D_200E_202B_200E_200D_200F_200F_200F_200F_200F_200F(BigInteger P_0, BigInteger P_1, BigInteger P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x64
	}

	internal static _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E _200C_200F_200F_200E_200F_200B_200E_200D_200E_202D_200E_202D_200E_202B_200E_200F(string P_0)
	{
		((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (byte)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xF2*/;
		}
	}

	internal _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E _202A_200F_202E_200F_200E_202A_200F_202C_200E_202A_200F_200E_200E_200D_200F_200E(bool P_0 = false)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC9
	}

	internal _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E _200C_200E_200F_200F_200F_202C_200E_200D_200F_200E_200E_202B_200F_202A_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE7 0xC6
	}

	internal string _202B_200E_202A_202E_200E_200B_200E_202D_200E_200C_200F_202B_200F_200F_200E_200E(bool P_0 = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xCE*/;
		}
	}

	internal string _202E_200E_200E_200D_200E_200F_200E_200D_200F_200D_200F_200E_200E_200C_200E_200F(bool P_0 = false)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x73 0xD0
	}

	internal string _200D_200E_202E_200B_200E_202B_200E_202A_200E_200D_200F_202C_200E_202C_200E_200E(bool P_0, bool P_1, bool P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE8
	}

	private static string _200E_200E_200E_200F_200E_202E_200E_200E_200F_200E_200F_200D_200E_200E_200E_200F(string P_0, int P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDC
	}

	internal byte[] _202C_200E_200F_200C_200E_200D_200F_202C_200E_202C_200E_200C_200F_200C_200F_200E(bool P_0, bool P_1, bool P_2)
	{
		((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xEE*/;
	}

	internal static _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E _200F_200F_202C_202A_200E_202B_200F_202E_200E_200F_200F_200D_200E_202E_200E_200E(string P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA1
	}

	internal string _202C_200E_200F_202B_200F_200D_200E_200D_200F_202B_200E_200C_200F_200B_200E_200F(bool P_0)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0xFC47B572
	}

	internal unsafe static string _200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_202A_200F_200E_200F_200F(string P_0, string P_1)
	{
		_ = *(short*)(int)((uint[])/*Error near IL_0002: Stack underflow*/)[checked((ushort)/*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static _200E_200E_202D_200F_200F_200D_200E_202A_200F_200D_200F_200E_200E_202B_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x34
	}

	[CompilerGenerated]
	internal static int _202E_200E_200F_200F_200E_202D_200E_202D_200E_202B_200E_202E_200E_202A_200E_200F(byte P_0, ref _202E_200E_200E_200F_200F_200C_200E_200D_200E_202B_200E_200B_200E_200F P_1)
	{
		/*Error: Empty body found. Decompiled assembly might be a reference assembly.*/;
	}

	[CompilerGenerated]
	internal static byte[] _200B_200E_202A_202E_200E_200D_200E_202A_200E_200C_200E_200F_200E_200C_200F_200F(ref _202E_200E_200E_200F_200F_200C_200E_200D_200E_202B_200E_200B_200E_200F P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF8
	}

	[CompilerGenerated]
	internal static bool _200E_200F_202A_200E_200F_202B_200F_200E_200F_200E_200F_202A_200F_202A_200F_200E(byte[] P_0, ref _202E_200E_200E_200F_200F_200C_200E_200D_200E_202B_200E_200B_200E_200F P_1)
	{
		//IL_0003: Invalid comparison between Unknown and I
		_ = (uint)/*Error near IL_0001: Stack underflow*/;
		if ((nint)/*Error near IL_0008: Stack underflow*/ > (nint)(nuint)/*Error near IL_0003: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_000d: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000e: Not a type handle*/;
	}

	[CompilerGenerated]
	internal static void _200D_200F_202C_200C_200F_200D_200E_200E_200E_200F_200E_202A_200E_200D_200F_200E(int P_0, ref _202C_200E_200E_200E_200F_200C_200E_200D_200E_202B_200E_200B_200E_200F P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x8F 0xB5
	}

	[CompilerGenerated]
	internal static void _200F_200E_200E_200B_200E_200B_200E_200B_200E_202A_200F_200C_200F_202B_200E_200E(byte[] P_0, ref _202C_200E_200E_200E_200F_200C_200E_200D_200E_202B_200E_200B_200E_200F P_1)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0x5E9E53F8
	}

	[CompilerGenerated]
	internal static byte[] _200C_200F_200C_200D_200F_202A_200F_200E_200F_200E_200F_200C_200F_202A_200E_200E(int P_0, byte[] P_1, ref _202C_200E_200E_200E_200F_200C_200E_200D_200E_202B_200E_200B_200E_200F P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x3B 0xB8
	}

	[CompilerGenerated]
	internal static void _202A_200F_200F_202D_200E_202A_200E_200F_200E_200C_200E_200E_200F_202E_200E_200E(MemoryStream P_0, byte[] P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD0
	}
}
internal class _202A_200E_202A_200C_200E_200D_200E_202B_200E_202B_200E_200F_200E_200E_200F_200F
{
	internal static byte[] _200C_200F_202A_202B_200F_200C_200F_200E_200F_202E_200E_202B_200E_202A_200E_200F(string P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x37 0x29
	}

	internal static string _200F_200E_200D_200B_200E_200E_200E_202B_200E_202A_200E_200E_200F_202B_200F_200F(byte[] P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6B 0x2D
	}

	private static int _202E_200E_202C_202B_200E_202E_200E_200F_200F_200D_200E_202D_200E_200E(char P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x60
	}

	private static char _200F_200F_200C_200D_200F_200E_200E_200B_200E_200E_200E_200D_200E_200F_200F_200F(byte P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloc 166 (out-of-bounds)*/;
			/*Error near IL_0003: Unknown opcode: 0xBB*/;
		}
	}

	public _202A_200E_202A_200C_200E_200D_200E_202B_200E_202B_200E_200F_200E_200E_200F_200F()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}
}
internal class _202D_200E_202B_202A_200E_202C_200E_202D_200E_202D_200E_200D_200E_200D_200F_200E : _202E_200E_200E_202E_200E_200E_200E_200F_200E_202B_200F_200B_200E_200E_200F_200F
{
	private readonly int _202B_200E_200D_202C_200E_202B_200E_202C_200E_202B_200F_202A_200F_200C_200E_200E;

	internal int _200D_200F_200D_200F_200F_202A_200F_200F_200F_202A_200E_202A_200E_202A_200E_200F
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3C
		}
	}

	internal _202D_200E_202B_202A_200E_202C_200E_202D_200E_202D_200E_200D_200E_200D_200F_200E(byte[] P_0, OtpHashMode P_1 = (OtpHashMode)0, int P_2 = 6)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9C
	}

	internal _202D_200E_202B_202A_200E_202C_200E_202D_200E_202D_200E_200D_200E_200D_200F_200E(_200F_200F_202A_200B_200E_200C_200F_202C_200E_200C_200F_202A_200F_202B_200E_200E P_0, OtpHashMode P_1 = (OtpHashMode)0, int P_2 = 6)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x05
	}

	private static void _200E_200F_200F_200E_200E_200B_200E_202A_200E_200B_200E_202B_200F_202C_200E_200E(int P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2C
	}

	internal string _202B_200E_200D_200D_200F_202B_200E_202C_200E_202B_200F_200E_200F_200D_200E_200E(long P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x03 0x4F
	}

	internal bool _200D_200E_202D_202A_200F_202D_200E_200E_200E_202B_200F_200E_200F_202E_200E_200E(string P_0, long P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9F 0x9C
	}

	protected override string Compute(long P_0, OtpHashMode P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x53 0x25
	}
}
internal interface _200F_200F_202A_200B_200E_200C_200F_202C_200E_200C_200F_202A_200F_202B_200E_200E
{
	byte[] ComputeHmac(OtpHashMode P_0, byte[] P_1);
}
public class _202A_200F_200D_200C_200E_200E_200E_200C_200F_202E_200E_202C_200E_202E_200E_200E : _200F_200F_202A_200B_200E_200C_200F_202C_200E_200C_200F_202A_200F_202B_200E_200E
{
	private readonly object _202B_200E_200E_202A_200F_200B_200E_200C_200F_202A_200E_200C_200F_202D_200E_200E;

	private readonly byte[] _200E_200E_200E_202B_200E_200E_200F_200D_200F_200B_200E_202A_200F_202B_200E_200E;

	private readonly int _200D_200E_200C_200F_200F_200D_200E_200D_200F_202B_200E_200E_200F_202E_200E_200F;

	internal _202A_200F_200D_200C_200E_200E_200E_200C_200F_202E_200E_202C_200E_202E_200E_200E(byte[] P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x75
	}

	internal byte[] _200E_200F_202A_202C_200E_202E_200E_202A_200F_200C_200F_200E_200F_202C_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x20
	}

	public byte[] ComputeHmac(OtpHashMode P_0, byte[] P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0007: Stack underflow*/>> (int)checked((uint)/*Error near IL_0006: Stack underflow*/);
		/*Error near IL_0007: Unknown opcode: 0xE2*/;
	}

	private static HMAC _200F_200F_202A_202A_200F_200C_200F_202A_200F_200D_200E_200B_200E_202B_200E_200E(OtpHashMode P_0)
	{
		/*Error: Unknown opcode: 0xEC*/;
	}
}
internal static class _202A_200E_202A_202B_200F_200C_200F_202D_200E_200C_200E_200B_200E_200C_200E_200F
{
	internal static byte[] _200B_200E_200F_202A_200E_200E_200E_200F_200E_202B_200E_200E_200F_200D_200F_200E(int P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x90
	}

	internal static byte[] _200B_200E_200F_202A_200E_200E_200E_200F_200E_202B_200E_200E_200F_200D_200F_200E(OtpHashMode P_0 = (OtpHashMode)0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7F 0x51
	}

	internal static byte[] _202C_200E_202B_200B_200E_202D_200E_202E_200E_200F_200F_202E_200E_202D_200E_200F(_200F_200F_202A_200B_200E_200C_200F_202C_200E_200C_200F_202A_200F_202B_200E_200E P_0, byte[] P_1, OtpHashMode P_2 = (OtpHashMode)0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEC
	}

	internal static byte[] _202C_200E_202B_200B_200E_202D_200E_202E_200E_200F_200F_202E_200E_202D_200E_200F(_200F_200F_202A_200B_200E_200C_200F_202C_200E_200C_200F_202A_200F_202B_200E_200E P_0, int P_1, OtpHashMode P_2 = (OtpHashMode)0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5D
	}

	private static HashAlgorithm _202D_200E_202C_200F_200F_202E_200E_202A_200E_200C_200E_200C_200F_202C_200E_200E(OtpHashMode P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/+ (uint)/*Error near IL_0002: Stack underflow*/;
			_ = 2;
			/*Error near IL_0004: Unknown opcode: 0xEA*/;
		}
	}

	private static int _200D_200F_202A_202B_200F_200B_200E_200D_200F_202B_200E_202E_200E_202B_200F_200E(OtpHashMode P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x93 0xC6
	}
}
internal abstract class _202E_200E_200E_202E_200E_200E_200E_200F_200E_202B_200F_200B_200E_200E_200F_200F
{
	protected readonly _200F_200F_202A_200B_200E_200C_200F_202C_200E_200C_200F_202A_200F_202B_200E_200E _200F_200F_200F_200D_200F_200C_200F_200F_200E_200F_200E_202D_200E_200D_200F_200E;

	protected readonly OtpHashMode _202A_200E_200D_202A_200E_200E_200F_200E_200F_200E_200E_200D_200F_202A_200E_200F;

	internal OtpHashMode _202A_200F_202C_200D_200E_202B_200E_200C_200F_202B_200F_200C_200F_202A_200F_200E
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x70
		}
	}

	internal _202E_200E_200E_202E_200E_200E_200E_200F_200E_202B_200F_200B_200E_200E_200F_200F(byte[] P_0, OtpHashMode P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4B 0x8B
	}

	internal _202E_200E_200E_202E_200E_200E_200E_200F_200E_202B_200F_200B_200E_200E_200F_200F(_200F_200F_202A_200B_200E_200C_200F_202C_200E_200C_200F_202A_200F_202B_200E_200E P_0, OtpHashMode P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x48
	}

	protected abstract string Compute(long P_0, OtpHashMode P_1);

	protected internal long _202B_200E_200D_202D_200E_200C_200E_200F_200E_202B_200F_202B_200E_200F(byte[] P_0, OtpHashMode P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x05
	}

	protected internal static string _200C_200E_200C_200C_200E_200E_200E_202B_200E_202C_200E_200B_200E_200F_200F_200F(long P_0, int P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB9
	}

	protected bool _202C_200E_200F_202A_200F_200B_200E_200F_200F_202D_200E_202B_200E_200C_200F_200E(long P_0, string P_1, out long P_2, _202E_200E_202E_200E_200E_200F_200E_202B_200F_200C_200F_202C_200E_200E P_3)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x18
	}

	private bool _200F_200E_202C_200F_200E_200E_200F_202B_200F_200B_200E_200E_200E_200B_200E_200E(string P_0, string P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB5
	}
}
internal class _202C_200E_202B_200B_200E_200E_200F_202A_200F_200E_200E_200C_200E_202E_200E_200F
{
	internal readonly OtpType _200C_200E_200E_202A_200E_200F_200E_200E_200E_200B_200E_200E_200F_202B_200E_200F;

	internal readonly string _200F_200E_202A_200E_200F_202B_200F_202E_200E_202B_200E_202B_200E_200E_200E_200F;

	internal readonly string _200C_200E_202C_202D_200E_202A_200E_200E_200F_200C_200E_202C_200E_200E_200F_200E;

	internal readonly string _202E_200E_200C_200F_200F_202A_200E_200F_200E_200E_200F_202B_200E_202A_200E_200E;

	internal readonly OtpHashMode _200B_200E_200F_200F_200E_200B_200E_202C_200E_200F_200E_202B_200E_200B_200E_200F;

	internal readonly int _200C_200E_200C_200C_200E_200E_200E_202B_200E_202C_200E_200B_200E_200F_200F_200F;

	internal readonly int _202C_200E_200F_202B_200F_200F_200F_200F_200F_202D_200E_200C_200F_200D_200F_200E;

	internal readonly int _200D_200E_202C_202A_200F_202E_200E_200C_200E_200B_200E_202A_200E_200B_200E_200E;

	internal _202C_200E_202B_200B_200E_200E_200F_202A_200F_200E_200E_200C_200E_202E_200E_200F(OtpType P_0, string P_1, string P_2, string P_3 = null, OtpHashMode P_4 = (OtpHashMode)0, int P_5 = 6, int P_6 = 30, int P_7 = 0)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	internal _202C_200E_202B_200B_200E_200E_200F_202A_200F_200E_200E_200C_200E_202E_200E_200F(OtpType P_0, byte[] P_1, string P_2, string P_3 = null, OtpHashMode P_4 = (OtpHashMode)0, int P_5 = 6, int P_6 = 30, int P_7 = 0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x99
	}

	internal Uri _200D_200F_200C_200D_200E_200C_200F_200C_200F_200D_200E_202E_200E_200C_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB1
	}

	public override string ToString()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x43 0x9F
	}
}
internal class _200B_200E_200F_200F_200F_200B_200E_202A_200F_200C_200F_202B_200F_202B_200F_200F
{
	internal static readonly _200B_200E_200F_200F_200F_200B_200E_202A_200F_200C_200F_202B_200F_202B_200F_200F _202A_200E_200D_202A_200F_200C_200E_202E_200E_200C_200E_200E_200F_200C_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly TimeSpan _200F_200F_200C_200E_200E_202B_200F_202C_200E_202B_200F_202D_200E_202C_200E_200F;

	internal DateTime _202C_200E_200C_200E_200F_200C_200F_202B_200F_200F_200E_202A_200F_202B_200F_200F
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x95
		}
	}

	internal TimeSpan _200F_200F_202A_202A_200E_200C_200E_200D_200E_200F_200E_200C_200F_202C_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Read out of bounds.
		}
	}

	private _200B_200E_200F_200F_200F_200B_200E_202A_200F_200C_200F_202B_200F_202B_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2B 0x50
	}

	internal _200B_200E_200F_200F_200F_200B_200E_202A_200F_200C_200F_202B_200F_202B_200F_200F(DateTime P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC1
	}

	internal _200B_200E_200F_200F_200F_200B_200E_202A_200F_200C_200F_202B_200F_202B_200F_200F(DateTime P_0, DateTime P_1)
	{
		/*Error: Invalid branch target*/;
	}

	internal DateTime _202A_200F_200F_200C_200E_200D_200E_200F_200F_200D_200E_200C_200F_200E_200E_200F(DateTime P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA0
	}

	static _200B_200E_200F_200F_200F_200B_200E_202A_200F_200C_200F_202B_200F_202B_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC9
	}
}
internal class _200C_200F_202A_202E_200E_200F_200F_200D_200F_200D_200E_200F_200F_200F_200F_200E
{
	[CompilerGenerated]
	private static class _200B_200E_200F_200F_200E_202E_200E_202C_200E_200D_200E_200D_200E_200E_200E_200E
	{
		public static Action _200D_200E_200C_200C_200F_200C_200E_202A_200F_200F_200E_200E_200F_200C_200F_200E;

		public static LogoutDelegate _202A_200F_200E_202A_200E_202A_200E_200C_200E_202B_200E_202B_200E_200C_200F_200F;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E
	{
		public static readonly _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E _003C_003E9;

		public static Action _003C_003E9__42_0;

		public static Action _003C_003E9__43_0;

		static _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x17 0x29
		}

		public _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x51
		}

		internal void _200E_200F_202B_202C_200E_200C_200F_202E_200E_200D_200F_200F_200E_200E_200F_200F()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4F 0x1D
		}

		internal void _200C_200F_200F_200E_200E_200E_200E_200D_200F_200F_200E_202D_200E_200B_200E_200E()
		{
			/*Error: Unknown opcode: 0xA7*/;
		}
	}

	internal static IDalamudPluginInterface _200C_200F_200D_202D_200E_202D_200E_202B_200F_200F_200F_200F_200E_202C_200E_200E;

	internal static string _200D_200E_200D_200F_200F_202A_200F_202A_200E_202B_200E_202B_200F_200C_200F_200F;

	internal static ushort _202D_200E_202A_200F_200E_200E_200E_200B_200E_202E_200E_200F_200E_202E_200E_200E;

	internal static _200D_200E_202C_200C_200E_200D_200F_202D_200E_200F_200F_200F_200E_200B_200E_200E _200E_200F_200E_202A_200F_202C_200E_200D_200F_202B_200E_200E_200F_202A_200F_200E;

	internal static VerifyWindow _202D_200E_200F_200B_200E_200D_200E_202A_200E_202C_200E_202A_200E_202A_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string _200F_200F_202E_202C_200E_202C_200E_200D_200F_200D_200F_200C_200F_200E_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string _200F_200F_202A_200E_200E_202D_200E_202A_200E_202A_200E_200E_200F_200D_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string _202A_200F_202A_202A_200F_202A_200F_200B_200E_200D_200F_202D_200E_200B_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string _200D_200F_202A_202D_200E_200D_200E_202A_200E_202E_200E_200C_200E_200F_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string _200D_200F_200E_202E_200E_200F_200F_200E_200E_202D_200E_200D_200F_202C_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static DateTime _202A_200E_200D_200F_200E_202E_200E_202E_200E_200C_200E_202D_200E_202E_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static DateTime _202A_200F_200D_202E_200E_200D_200F_202A_200E_202B_200F_202D_200E_202A_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static DateTime _200C_200E_202D_202D_200E_202B_200E_202B_200E_202E_200E_200C_200F_200E_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static DateTime _200D_200E_200E_202A_200F_202A_200E_200B_200E_202E_200E_202D_200E_200C_200F_200E;

	internal static string _200D_200E_200E_200D_200F_200D_200E_200F_200E_200E_200F_202A_200F_200E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x41
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x29
		}
	}

	internal static string _202C_200E_202A_200E_200E_202A_200F_202C_200E_200B_200E_202C_200E_202B_200F_200F
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xE6*/;
		}
		[CompilerGenerated]
		private set
		{
			_ = 7;
			/*Error near IL_0001: Unknown opcode: 0xBE*/;
		}
	}

	internal unsafe static string _202C_200E_202A_200E_200E_202A_200F_200E_200E_200B_200E_202D_200E_202B_200F_200F
	{
		[CompilerGenerated]
		get
		{
			/*Error: Not a type handle*/;
		}
		[CompilerGenerated]
		private set
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			if (!float.IsFinite(1200318618140572967L))
			{
				throw new ArithmeticException();
			}
			_ = (short)32039;
			/*Error near IL_000c: Unknown opcode: 0xCE*/;
		}
	}

	internal static string _202A_200F_200C_200E_200E_200C_200F_202C_200E_200F_200F_202A_200F_202B_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Invalid comparison between Unknown and I4
			if ((int)/*Error near IL_0003: Stack underflow*/ >= 5)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (int)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0005: Unknown opcode: 0xE8*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x94
		}
	}

	internal static string _200F_200E_200C_200E_200F_200C_200F_200E_200E_202A_200E_200E_200E_200F_200E_200E
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid metadata token*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x87 0x48
		}
	}

	internal static DateTime _200C_200E_200C_200F_200F_202B_200F_202D_200E_202B_200E_200E_200E_202B_200F_200F
	{
		[CompilerGenerated]
		get
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Unknown opcode: 0xCE*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBB 0x66
		}
	}

	internal static DateTime _200C_200E_200C_202A_200F_200F_200E_200E_200F_200F_200E_200F_200E_202B_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFD
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x38
		}
	}

	internal unsafe static DateTime _200C_200E_200C_202A_200F_200F_200E_200D_200E_200C_200F_200E_200E_200C_200E_200F
	{
		[CompilerGenerated]
		get
		{
			_ = ((double[])/*Error near IL_0002: Stack underflow*/)[*(long*)(nint)/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0002: Unknown opcode: 0xE6*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4C
		}
	}

	internal static DateTime _202B_200F_200E_200E_200F_200E_200E_202D_200E_202A_200E_200F_200F_202C_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x93 0xA5
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE8
		}
	}

	internal static void _200C_200F_200D_200F_200F_202C_200E_200F_200E_200C_200F_200E_200E_200F_200E_200F(IDalamudPluginInterface P_0, string P_1, ushort P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEF 0xCE
	}

	private static void _200F_200F_200E_202E_200E_202B_200E_200C_200F_202E_200E_200E_200F_202B_200F_200F()
	{
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0002: Unknown opcode: 0xED*/;
	}

	private unsafe static void _200D_200E_200C_202B_200E_202D_200E_200C_200F_202E_200E_202A_200F_200C_200F_200E(int P_0, int P_1)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF8*/;
	}

	internal static void _200F_200E_202A_200B_200E_202A_200F_202A_200F_200F_200F_200C_200E_200B_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFC
	}

	internal static void _202D_200E_200F_202E_200E_200E_200F_202B_200F_200B_200E_202D_200E_202C_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE5
	}

	private static DateTime _200B_200E_200E_202A_200E_202B_200E_202A_200F_202A_200F_202B_200E_200C_200F_200F(long P_0)
	{
		if (/*Error near IL_0001: Stack underflow*/ == /*Error near IL_0001: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error: End of method reached without returning.*/;
	}

	internal static void _200D_200F_200C_202A_200E_200C_200F_200E_200E_202E_200E_202A_200F_200C_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE5
	}

	public _200C_200F_202A_202E_200E_200F_200F_200D_200F_200D_200E_200F_200F_200F_200F_200E()
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	static _200C_200F_202A_202E_200E_200F_200F_200D_200F_200D_200E_200F_200F_200F_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCB 0xF9
	}
}
internal class _202A_200F_200C_200F_200F_202C_200E_202A_200F_200C_200E_200E_200E_202C_200E_200F
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static IClientState _202D_200E_200E_202B_200F_200C_200F_200D_200F_200F_200F_202D_200E_200E_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static IPlayerState _200D_200E_202C_200D_200F_202C_200E_202A_200F_200D_200F_202C_200E_202E_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static IPluginLog _202A_200E_200D_202B_200E_202A_200E_202A_200E_202A_200E_200D_200F_200F_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static INotificationManager _200B_200E_200C_202A_200F_200C_200F_200C_200F_202D_200E_200D_200E_202A_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static ISigScanner _200C_200E_200D_200B_200E_202D_200E_202B_200E_202A_200E_200F_200F_200E;

	[PluginService]
	internal static IClientState _200F_200E_200C_202C_200E_202B_200F_200E_200E_202A_200E_200D_200E_202A_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC4
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB9
		}
	}

	[PluginService]
	internal static IPlayerState _200E_200E_202A_202B_200E_202C_200E_202A_200F_202A_200E_200D_200E_200E_200F_200F
	{
		[CompilerGenerated]
		get
		{
			/*Error: Empty body found. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		private set
		{
			/*Error: Unknown opcode: 0xF3*/;
		}
	}

	[PluginService]
	internal static IPluginLog _200C_200F_200C_200C_200F_200D_200E_200C_200F_200C_200F_200C_200F_200D_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC4
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x6F 0x54
		}
	}

	[PluginService]
	internal static INotificationManager _200C_200E_200F_200F_200E_200E_200E_202D_200E_200E_200F_202D_200E_200C_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3F 0xC9
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x04
		}
	}

	[PluginService]
	internal static ISigScanner _200E_200E_202A_202D_200E_202E_200E_202E_200E_200E_200E_202D_200E_200D_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x23 0xA2
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA1
		}
	}

	public _202A_200F_200C_200F_200F_202C_200E_202A_200F_200C_200E_200E_200E_202C_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDD
	}
}
internal static class _202B_200F_200F_200C_200F_202C_200E_200D_200E_200D_200F_202B_200E_200C_200F_200F
{
	private delegate IntPtr _200E_200F_200D_200F_200F_200E_200F_200F_200F_202A_200F_200E_200F_200F_200E_200E();

	[Serializable]
	[CompilerGenerated]
	private sealed class _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E
	{
		public static readonly _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E _003C_003E9;

		public static Func<ManagementObject, _003C_003Ef__AnonymousType0<string, long, string>> _003C_003E9__23_0;

		public static Func<_003C_003Ef__AnonymousType0<string, long, string>, bool> _003C_003E9__23_1;

		public static Func<_003C_003Ef__AnonymousType0<string, long, string>, string> _003C_003E9__23_2;

		public static Func<_003C_003Ef__AnonymousType0<string, long, string>, long> _003C_003E9__23_3;

		public static Func<string, string> _003C_003E9__23_4;

		static _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x93 0x92
		}

		public _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xEB 0x2A
		}

		internal _003C_003Ef__AnonymousType0<string, long, string> _202D_200E_202C_200C_200E_200F_200E_200F_200E_200C_200E_200E_200E_200F_200F_200E(ManagementObject P_0)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA8
		}

		internal bool _202C_200E_200E_202E_200E_200F_200E_200C_200E_200E_200E_200F_200F_200E(_003C_003Ef__AnonymousType0<string, long, string> P_0)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFB 0x5F
		}

		internal string _200C_200E_202B_200F_200E_200C_200F_200F_200E_200C_200E_200E_200E_200F_200F_200E(_003C_003Ef__AnonymousType0<string, long, string> P_0)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3F 0xAA
		}

		internal long _200E_200F_202A_200C_200F_202B_200F_200F_200E_200C_200E_200E_200E_200F_200F_200F(_003C_003Ef__AnonymousType0<string, long, string> P_0)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA3 0x11
		}

		internal string _202A_200E_200C_200C_200F_202D_200E_200F_200E_200C_200E_200E_200E_200F_200F_200F(string P_0)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC5
		}
	}

	internal static string _200C_200F_200D_202E_200E_200E_200F_200C_200E_200F_200E_200C_200F_200D_200F_200F;

	private static readonly (string Query, string Property, bool UseFirstOnly)[] _200C_200E_200D_202D_200E_200C_200F_202D_200E_202C_200E_202A_200E_200D_200F_200E;

	private static readonly HashSet<string> _200B_200E_200F_200C_200E_200F_200E_200C_200E_200C_200E_200F_200E_200D_200E_200F;

	private static string _200D_200E_200C_202B_200E_200C_200E_202D_200E_200E_200F_200F_200E_202B_200E_200E;

	internal static UInt128 _200C_200F_202C_200C_200F_200B_200E_200B_200E_202B_200E_202A_200E_200E_200F_200E(string P_0, string P_1 = "")
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE3 0x15
	}

	internal static UInt128 _200D_200E_200C_200F_200F_200C_200F_202D_200E_200D_200E_202A_200F_202A_200E_200E(string P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x89
	}

	internal static string _200E_200E_200C_202B_200F_202D_200E_202A_200F_202C_200E_202E_200E_202D_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x93 0x43
	}

	internal static UInt128 _202B_200E_200F_202D_200E_200C_200F_200B_200E_200B_200E_200D_200F_200F_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x17 0x2B
	}

	internal static string _202C_200E_200E_200C_200E_200B_200E_202B_200E_202B_200E_200E_200E_202E_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x00
	}

	internal static string _202C_200E_202D_200F_200F_200C_200F_200D_200F_202A_200F_200F_200F_202A_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDD
	}

	internal static UInt128 _202E_200E_200C_200D_200E_200E_200F_200C_200F_202C_200E_202E_200E_202B_200F_200F()
	{
		checked
		{
			_ = (ushort)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xBE*/;
		}
	}

	internal static UInt128 _202A_200F_202A_200F_200F_200D_200F_202B_200E_202D_200E_202E_200E_200E_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBD
	}

	internal static string _200E_200F_200E_200E_200E_202D_200E_200D_200F_202A_200F_200F_200F_202A_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x59
	}

	private static string? _200B_200E_200E_200D_200E_202E_200E_200F_200E_202A_200E_202A_200E_202A_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0D
	}

	private static string _200F_200F_202C_202C_200E_202A_200F_202C_200E_202D_200E_202B_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA9
	}

	private static string _200E_200F_200D_200E_200E_202B_200E_200E_200F_202A_200E_200F_200F_202A_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x48
	}

	private static bool _202C_200E_200D_200F_200E_202A_200F_202A_200F_202B_200F_200C_200F_202C_200E_200E(string P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x41
	}

	private static bool _200C_200F_202A_200B_200E_202C_200E_200F_200F_200C_200E_200C_200F_202C_200E_200E(string P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFD
	}

	internal static string _200C_200F_202C_200C_200F_200B_200E_200B_200E_202B_200E_202A_200E_200E_200F_200E(string P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x85
	}

	internal static string _200C_200F_202D_200D_200F_200D_200F_200D_200E_202B_200E_200F_200F_200B_200E_200E(byte[] P_0)
	{
		/*Error: Invalid metadata token for ldtoken instruction.*/;
	}

	internal static string _202D_200E_200E_200D_200F_202C_200E_202B_200F_202B_200E_200B_200E_202C_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDF 0x57
	}

	internal static UInt128 _200C_200F_200C_202D_200E_202D_200E_202D_200E_200E_200F_200C_200F_202A_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x59
	}

	private static string _200E_200E_200F_202D_200E_202C_200E_200F_200F_200F_200F_202A_200F_200D_200F_200F(string P_0, string P_1, bool P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x43 0xFF
	}

	static _202B_200F_200F_200C_200F_202C_200E_200D_200E_200D_200F_202B_200E_200C_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6F 0xF5
	}
}
internal enum _202A_200F_200F_202E_200E_202C_200E_200F_200F_200D_200E_202C_200E_202E_200E_200E : ushort
{

}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct _200B_200E_200F_200E_200F_200E_200F_202A_200E_200D_200F_200F_200E_200B_200E_200F
{
	internal uint _202C_200E_202C_200E_200E_202D_200E_200E_200E_200B_200E_202E_200E_202B_200E_200E;

	internal ushort _200F_200E_200F_200F_200E_202B_200F_200C_200F_202B_200E_202A_200E_200D_200F_200F;

	internal ushort _202D_200E_202A_200F_200E_200E_200E_200B_200E_202A_200E_202B_200E_202E_200E_200E;

	internal UInt128 _202C_200E_202B_200C_200F_202D_200E_202B_200F_200E_200F_200F_200E_200D_200E_200E;

	internal ushort _202A_200F_202A_202E_200E_200B_200E_200D_200E_202E_200E_200F_200F_200E_200E_200F;

	internal ushort _200C_200E_202A_200F_200E_200F_200E_202B_200F_200C_200F_202E_200E_202A_200F_200E;

	internal ushort _202D_200E_200F_200F_200E_200B_200E_202D_200E_202A_200F_202B_200E_202B_200F_200E;

	internal ushort _200C_200E_202B_200D_200E_202B_200F_200C_200E_202A_200F_202B_200E_200B_200E_200F;

	internal uint _200F_200E_200F_202B_200F_200E_200E_202C_200E_200C_200F_202B_200E_202C_200E_200F;

	internal uint _200F_200E_202D_200E_200F_202B_200F_200D_200F_200B_200E_200C_200F_202A_200F_200E;

	internal uint _202A_200E_200D_202A_200F_202A_200F_200C_200F_202C_200E_202B_200F_202E_200E_200E;

	internal uint _200E_200E_200D_200C_200E_202A_200E_202A_200F_200C_200E_202A_200E_200E_200F_200E;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
	internal string _200C_200E_200E_202B_200F_200E_200E_200E_200E_202B_200E_202A_200F_200E_200F_200F;
}
internal struct _202A_200E_200D_202D_200E_200E_200E_200F_200F_200E_200F_200C_200F_200E_200E_200E
{
	internal uint _202C_200E_202C_200E_200E_202D_200E_200E_200E_200B_200E_202E_200E_202B_200E_200E;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct _200B_200E_200E_202B_200E_202A_200E_200F_200E_200D_200F_202C_200E_202B_200E_200E
{
	internal uint _202C_200E_202C_200E_200E_202D_200E_200E_200E_200B_200E_202E_200E_202B_200E_200E;

	internal ushort _200C_200F_202D_202D_200E_200D_200E_200C_200F_202E_200E_202A_200E_200F_200F_200E;

	internal ushort _202D_200E_202A_200F_200E_200E_200E_200B_200E_202A_200E_202B_200E_202E_200E_200E;

	internal uint _200D_200F_202A_202B_200F_202D_200E_200E_200E_202B_200E_200D_200F_200B_200E_200F;

	internal uint _200B_200E_200D_202A_200F_200F_200F_202B_200F_200F_200F_200E_200E_202E_200E_200F;

	internal uint _200E_200F_200E_200C_200F_202B_200F_200B_200E_200F_200E_202B_200E_200E_200E_200E;

	internal UInt128 _202C_200E_202B_200C_200F_202D_200E_202B_200F_200E_200F_200F_200E_200D_200E_200E;

	internal ushort _202A_200F_202A_202E_200E_200B_200E_200D_200E_202E_200E_200F_200F_200E_200E_200F;

	internal ushort _200C_200E_202A_200F_200E_200F_200E_202B_200F_200C_200F_202E_200E_202A_200F_200E;
}
internal static class _202C_200E_200E_202C_200E_200C_200F_200E_200E_200D_200F_200C_200E_200F_200E_200F
{
	internal static T _202D_200E_200C_202C_200E_200F_200E_202A_200F_202B_200F_200C_200E_202A_200F_200F<T>(byte[] P_0) where T : struct
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6C
	}

	internal static T _202D_200E_202A_202B_200E_202A_200E_202B_200E_202C_200E_200D_200E_200C_200E_200F<T>(byte[] P_0) where T : struct
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Invalid branch target*/;
	}

	internal static object _202D_200E_200C_202C_200E_200F_200E_202A_200F_202B_200F_200C_200E_202A_200F_200F(byte[] P_0, Type P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE1
	}

	internal static object _202D_200E_202A_202B_200E_202A_200E_202B_200E_202C_200E_200D_200E_200C_200E_200F(byte[] P_0, Type P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7D
	}

	internal static byte[] _202A_200E_200F_202E_200E_200D_200F_200F_200F_202D_200E_200F_200E_200D_200F_200E<T>(T P_0) where T : struct
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDC
	}

	internal static byte[] _200B_200E_200E_202A_200F_202E_200E_202C_200E_200D_200E_202C_200E_200F_200E_200F<T>(T P_0) where T : struct
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA9
	}

	internal static byte[] _202A_200E_200F_202E_200E_200D_200F_200F_200F_202D_200E_200F_200E_200D_200F_200E(object P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB0
	}

	internal static byte[] _200B_200E_200E_202A_200F_202E_200E_202C_200E_200D_200E_202C_200E_200F_200E_200F(object P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC8
	}
}
internal class _200D_200E_202C_200C_200E_200D_200F_202D_200E_200F_200F_200F_200E_200B_200E_200E
{
	internal HttpClient _200F_200E_200F_200C_200E_202B_200E_202C_200E_202B_200E_200C_200E_200C_200F_200F;

	internal _202D_200E_202B_200E_200E_202A_200E_202A_200E_200C_200E_200D_200E_200F _200C_200F_200F_200E_200F_200C_200E_202A_200F_202A_200F_202B_200F_200E_200E_200F;

	internal _202D_200E_202B_202A_200E_202C_200E_202D_200E_202D_200E_200D_200E_200D_200F_200E _200D_200F_200D_200D_200E_202A_200E_200B_200E_200E_200E_200B_200E_202A_200F_200F;

	internal Random _200C_200E_200E_200E_200F_202E_200E_202E_200E_200C_200E_200D_200E_200D_200E_200E;

	internal bool _200D_200E_200E_202C_200E_200F_200F_202D_200E_202A_200F_200D_200E_202B_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _200B_200E_202A_200B_200E_200E_200E_200D_200E_200C_200E_202B_200E_200B_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _200D_200E_202E_200E_200E_200C_200F_200C_200E_202A_200E_200F_200F_200F_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _200E_200F_202B_202A_200F_200F_200F_200F_200F_202C_200E_202E_200E_200F_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _200F_200E_200E_200F_200F_200D_200F_200E_200F_200D_200F_200D_200E_202B_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _200B_200E_200D_200F_200E_202A_200F_200D_200F_200B_200E_200D_200E_200E_200F_200E;

	internal bool _200B_200E_200C_200E_200E_200E_200E_200D_200E_202A_200F_200C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA4
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC4
		}
	}

	internal bool _200B_200E_200C_200E_200E_200D_200E_200D_200E_202A_200F_200C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x75
		}
		[CompilerGenerated]
		private set
		{
			/*Error: Unknown opcode: 0xC8*/;
		}
	}

	internal bool _200D_200E_200D_200F_200F_202D_200E_200C_200F_200D_200E_200D_200F_202E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB1
		}
		[CompilerGenerated]
		private set
		{
			/*Error: Empty body found. Decompiled assembly might be a reference assembly.*/;
		}
	}

	internal bool _200B_200E_200C_200E_200E_200B_200E_200D_200E_202A_200F_200C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x78
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x54
		}
	}

	internal bool _200C_200E_202E_200E_200E_200B_200E_202A_200F_200E_200F_202B_200E_200B_200E_200E
	{
		[CompilerGenerated]
		get
		{
			/*Error: ldarga 80 (out-of-bounds)*/;
			/*Error near IL_0002: Unknown opcode: 0xE3*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x75
		}
	}

	internal _200D_200E_202C_200C_200E_200D_200F_202D_200E_200F_200F_200F_200E_200B_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7D
	}

	[AsyncStateMachine(typeof(_003CCheckLiveAsync_003Ed__6))]
	[DebuggerStepThrough]
	internal unsafe Task<bool> _200C_200E_200F_202B_200E_202B_200E_202E_200E_200C_200F_200C_200F_200C_200F_200E()
	{
		//IL_0002: Expected F8, but got I4
		//IL_0003: Invalid comparison between Unknown and I8
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = ((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		if ((long)/*Error near IL_0005: Stack underflow*/ > (long)checked((ulong)/*Error near IL_0003: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = ((Array)/*Error near IL_0006: Stack underflow*/).LongLength;
		/*Error near IL_0006: Unknown opcode: 0xE7*/;
	}

	[AsyncStateMachine(typeof(_003CGetLMAsync_003Ed__7))]
	[DebuggerStepThrough]
	internal unsafe Task<_200B_200E_200E_202B_200E_202A_200E_200F_200E_200D_200F_202C_200E_202B_200E_200E> _202E_200E_200F_200E_200F_202E_200E_200F_200F_202B_200E_202A_200F_202D_200E_200F(ushort P_0, UInt128 P_1, ushort P_2, string P_3 = "")
	{
		if (((ushort[])/*Error near IL_0002: Stack underflow*/)[*(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/] != 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Unknown opcode: 0xCA*/;
	}

	internal bool _200F_200E_200E_202A_200F_202A_200F_202B_200E_200F_200F_202D_200E_200E(ushort P_0, UInt128 P_1, ushort P_2, out uint P_3, string P_4 = "")
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x79
	}

	internal bool _202A_200E_202D_200F_200E_200D_200E_202A_200F_200D_200E_200F_200F_200D_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC0
	}

	internal bool _200E_200F_200C_200E_200F_202A_200F_202B_200F_200F_200E_202B_200E_202B_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x05
	}

	internal bool _202C_200E_200C_202D_200E_202A_200E_200D_200F_200C_200F_202B_200F_200D_200E_200F()
	{
		/*Error: Unknown opcode: 0xCA*/;
	}

	internal bool _202B_200F_200D_202D_200E_202B_200F_202A_200E_200F_200F_200D_200E_200C_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x10
	}

	internal bool _200D_200E_202B_200E_200E_202B_200E_200F_200F_200C_200E_200D_200F_200E_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x71
	}

	internal bool _200C_200F_202C_200F_200E_200B_200E_202C_200E_200E_200E_202A_200F_200D_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFC
	}

	internal void _200F_200F_200F_200E_200F_200D_200E_200B_200E_202C_200E_200B_200E_202A_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x8B 0x49
	}
}
public class _202E_200E_200C_202E_200E_202C_200E_202D_200E_200D_200E_202E_200E_202E_200E_200F
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _200E_200F_200F_202D_200E_202C_200E_200D_200F_202B_200F_202A_200F_200D_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _200E_200F_202A_202A_200E_202C_200E_200D_200F_200D_200F_200E_200E_202D_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _202E_200E_202E_202B_200E_200F_200F_200D_200F_202A_200F_202D_200E_202A_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _202B_200F_200F_202B_200F_200B_200E_202E_200E_202A_200E_200E_200F_200E_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _202A_200E_200C_200C_200E_200D_200F_202B_200F_202B_200E_200E_200E_200D_200F_200E;

	public string _200D_200E_200E_200D_200F_200D_200E_200F_200E_200E_200F_200D_200F_200E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD8
		}
		[CompilerGenerated]
		set
		{
			/*Error: Read out of bounds.*/;
		}
	}

	public string _200D_200E_200E_200D_200F_200D_200E_200F_200E_200E_200F_200E_200F_200E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x48
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xCD
		}
	}

	public string _200D_200E_200E_200D_200F_200D_200E_200F_200E_200E_200F_200D_200F_202E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBC
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x80
		}
	}

	public string _200B_200E_200D_200B_200E_200D_200E_200F_200F_202D_200E_200C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD5
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC0
		}
	}

	public string _200F_200F_200E_202B_200F_202E_200E_200D_200F_202C_200E_200E_200F_202B_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD9
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x60
		}
	}

	public _202E_200E_200C_202E_200E_202C_200E_202D_200E_200D_200E_202E_200E_202E_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0C
	}
}
public class _200D_200F_202B_200B_200E_200C_200F_202C_200E_200E_200F_200D_200E_202A_200E_200E
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _202A_200E_202A_200F_200E_202C_200E_202A_200F_200D_200F_202E_200E_200F_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _202A_200F_202A_202B_200F_202D_200E_200F_200E_200F_200F_200E_200F_200D_200E_200E;

	public string _202A_200E_200E_202B_200F_200E_200E_200C_200E_202D_200E_202D_200E_202C_200E_200F
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x33 0x1A
		}
	}

	public string _202A_200E_202A_200F_200E_202B_200E_202B_200F_202B_200F_200E_200F_202A_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFC
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5F 0x78
		}
	}

	public _200D_200F_202B_200B_200E_200C_200F_202C_200E_200E_200F_200D_200E_202A_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x91
	}
}
public class _200B_200E_200E_202D_200E_202A_200F_200E_200E_202A_200F_200C_200E_202B_200E_200E
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _202A_200F_202B_202B_200E_202C_200E_202C_200E_200C_200E_202B_200E_202B_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _202D_200E_202A_202A_200E_200D_200F_200F_200E_202A_200F_200C_200E_200C_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _202B_200E_200D_202C_200E_200E_200E_202A_200F_200C_200F_200D_200F_200F;

	public bool _202B_200E_200F_202B_200E_202E_200E_202E_200E_200F_200F_200E_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x11
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x38
		}
	}

	public int _200C_200E_200F_200F_200E_200D_200F_200C_200F_200E_200F_200F_200E_200F_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x77 0xE6
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x2C
		}
	}

	public string _200C_200E_200E_202B_200F_200E_200E_200E_200E_200C_200F_200E_200F_200E_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1D
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x77 0xE2
		}
	}

	public _200B_200E_200E_202D_200E_202A_200F_200E_200E_202A_200F_200C_200E_202B_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x39
	}
}
public static class _202E_200E_200D_200F_200E_200F_200E_200F_200E_202A_200E_202E_200E_200F_200E_200E
{
	public static HalfVector2 _202A_200E_202B_200E_200F_202C_200E_200E_200F_202B_200E_200E_200E_202A_200E_200F(this BinaryReader P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE4
	}

	public static HalfVector4 _202A_200E_200E_200D_200F_200F_200E_202D_200E_200C_200E_200F_200F_202C_200E_200F(this BinaryReader P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x79
	}
}
public static class _200B_200E_202B_200F_200F_200C_200E_200F_200E_202A_200E_202A_200F_200C_200E_200E
{
	public static void _202A_200E_202C_202E_200E_200C_200F_200B_200E_202C_200E_200E_200F_202E_200E_200E(this BinaryWriter P_0, HalfVector2 P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x93 0x44
	}

	public static void _202A_200E_202C_202E_200E_200C_200F_200B_200E_202C_200E_200E_200F_202E_200E_200E(this BinaryWriter P_0, HalfVector4 P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x69
	}
}
public static class _202D_200E_202D_200D_200F_200D_200F_200F_200E_202A_200E_200F_200E_202C_200E_200E
{
	public static bool _200F_200E_200C_200E_200F_202C_200E_200D_200E_202B_200F_200E_200E_200B_200E_200F(out string P_0, out string? P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC4
	}

	private unsafe static void _200F_200E_202A_200F_200F_200B_200E_200D_200F_202E_200E_200C_200F_200C_200F_200F(StringBuilder P_0, AtkUnitBase* P_1)
	{
	}

	private unsafe static void _202E_200E_200E_200F_200E_202A_200E_200F_200E_200B_200E_200D_200E_200F_200E_200E(StringBuilder P_0, AtkUnitBase* P_1)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	private unsafe static void _200F_200E_202A_200E_200F_202A_200F_200C_200E_200E_200F_200F_200E_202A_200E_200E(StringBuilder P_0, StdVector<AtkValue>* P_1, long P_2)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		*(short*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_000c: Stack underflow*// 7738999155206458405L;
		/*Error near IL_000c: Unknown opcode: 0xAE*/;
	}

	private unsafe static void _202B_200F_200C_200F_200F_202D_200E_200D_200F_202D_200E_200E_200F_200F(StringBuilder P_0, StdVector<AtkValue>* P_1, long P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xC9*/;
	}

	private unsafe static void _200B_200E_200F_202A_200F_200E_200F_200F_200E_202B_200E_200F_200E_202C_200E_200E(StringBuilder P_0, StdVector<AtkValue>* P_1, long P_2, string P_3)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xED
	}

	private unsafe static void _202E_200E_202D_200E_200E_200D_200F_202C_200E_200F_200E_202B_200F_202A_200F_200E(StringBuilder P_0, AtkValue* P_1, int P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0002: Stack underflow*/+ P_0;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}

	private static void _200E_200E_202A_200E_200E_200F_200F_200C_200E_202A_200F_200C_200F_202B_200F_200E(StringBuilder P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x89
	}

	private unsafe static void _202A_200E_200D_202A_200E_200E_200E_202D_200E_200B_200E_202B_200F_200E_200E_200E(StringBuilder P_0, AtkUnitBase* P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x98
	}

	private unsafe static void _200E_200E_200F_200C_200F_200D_200F_200D_200F_200B_200E_200D_200E_200F_200E_200F(StringBuilder P_0, AtkResNode* P_1)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0x896055D5
	}
}
public sealed class _200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E : IEquatable<_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly bool _200D_200E_202B_202A_200F_200E_200F_202B_200F_200D_200E_202D_200E_202A_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly bool _200B_200E_200E_202A_200E_202E_200E_202E_200E_202A_200F_202E_200E_200E_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly bool _200E_200F_202E_200F_200E_202E_200E_200E_200E_202A_200E_200E_200E_202A_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ulong _200D_200E_200E_202C_200E_200B_200E_202D_200E_200D_200F_200F_200E_200F_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202B_200F_200C_202D_200E_200C_200E_200E_200F_202D_200E_202A_200E_200E_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _200F_200E_202B_202E_200E_200F_200E_202B_200E_202D_200E_200F_200E_202E_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200F_200E_202A_202C_200E_200E_200E_200D_200E_200C_200F_202D_200E_202D_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200F_200E_202B_202A_200E_200F_200E_200E_200E_200D_200F_202B_200E_200C_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202A_200E_202E_200C_200F_200F_200E_200C_200F_200B_200E_200D_200E_200E_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200F_200F_200F_202A_200E_200E_200E_200D_200F_200F_200E_200B_200E_200C_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202C_200E_202A_202B_200E_200E_200F_200C_200E_202A_200F_200C_200E_200F_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly uint _202B_200F_200E_200F_200F_202C_200E_200E_200F_200C_200E_200E_200E_202B_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly uint _202D_200E_202B_202A_200F_200C_200E_202E_200E_200E_200F_200F_200E_200C_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly uint _202E_200E_200C_202A_200F_200E_200F_200F_200F_200E_200E_202D_200E_202A_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200F_200F_202A_200B_200E_202A_200F_202B_200E_200F_200F_202A_200F_200F_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _202B_200F_202E_200D_200E_200C_200F_200E_200E_200C_200F_202B_200F_200F_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202D_200E_200C_202C_200E_200C_200E_200C_200F_202B_200F_200D_200F_202A_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _202C_200E_202B_202A_200E_202A_200E_200B_200E_200F_200E_202E_200E_202E_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202A_200F_200D_200F_200F_200D_200E_200F_200F_202E_200E_200E_200E_202D_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _200F_200E_202B_200E_200F_200C_200F_200C_200E_200E_200E_202B_200F_200C_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202B_200E_202B_200C_200F_200E_200E_200C_200F_202C_200E_200E_200E_200C_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200B_200E_200C_200D_200E_200C_200E_200E_200F_200E_200E_202C_200E_202C_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _200B_200E_200D_202C_200E_202A_200F_200D_200F_200B_200E_202A_200E_200D_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200F_200E_202B_202A_200E_200F_200F_200E_200F_202A_200F_202A_200E_202B_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _200C_200E_202E_202A_200E_202D_200E_200E_200F_202D_200E_200D_200E_200F_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202D_200E_200E_202D_200E_200B_200E_200F_200F_200F_200F_202E_200E_200C_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _200E_200E_202D_202C_200E_200F_200F_200B_200E_202B_200E_202A_200E_200D_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202C_200E_200C_202D_200E_202B_200E_202B_200F_200E_200F_200C_200E_200F_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _200C_200F_202B_200E_200E_202A_200E_202A_200F_202C_200E_202B_200E_202B_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200C_200F_202C_200E_200F_202B_200F_200E_200F_202A_200F_200F_200E_200F_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _200C_200E_200F_202E_200E_200E_200F_200F_200F_202B_200E_202B_200E_200D_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202C_200E_200F_202A_200E_200E_200E_202A_200E_202A_200E_202B_200F_200F_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _200B_200E_200C_200C_200E_202E_200E_200B_200E_202A_200E_200D_200E_200D_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202E_200E_202A_200C_200E_200E_200E_202B_200F_200D_200E_200C_200F_200D_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _202E_200E_200E_202A_200E_200D_200F_202B_200E_200C_200F_202B_200F_202A_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202E_200E_202C_200C_200F_200F_200F_202A_200F_202B_200F_200E_200E_200E_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _202B_200E_202C_200F_200F_202E_200E_200C_200E_200D_200F_200F_200E_200B_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200E_200E_202D_200F_200F_202B_200F_202C_200E_202B_200F_202B_200F_200B_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _202C_200E_202E_202A_200F_202A_200F_202A_200E_200D_200F_202B_200F_200D_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200B_200E_200C_202C_200E_200C_200E_200B_200E_200F_200F_202A_200F_200C_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _202B_200F_202A_202D_200E_200C_200E_202B_200F_200F_200E_200F_200E_202A_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202E_200E_200D_202E_200E_200F_200F_202A_200F_200D_200E_202A_200F_202E_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _200D_200E_200E_202B_200E_202B_200F_202B_200F_200E_200E_202B_200E_202A_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202B_200E_202A_200E_200F_200F_200E_200D_200E_202C_200E_200D_200F_202A_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly float _200E_200E_202E_202B_200F_200E_200E_202E_200E_202D_200E_202C_200E_200C_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly short _202A_200E_202A_200F_200F_202E_200E_200C_200E_202B_200F_202C_200E_202E_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _200F_200E_202A_200F_200F_200C_200E_200E_200F_200E_200F_202A_200E_200C_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _200D_200E_202A_200F_200F_200B_200E_200E_200F_200E_200F_202E_200E_200F_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202B_200E_202B_200F_200F_200F_200F_202A_200F_202B_200E_202C_200E_200C_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202E_200E_202B_200E_200F_202E_200E_202B_200E_200D_200E_202A_200E_200E_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly short _202B_200E_202A_200E_200E_202A_200F_200F_200F_200C_200E_200C_200F_202A_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly short _200C_200F_202E_200E_200F_200C_200E_200D_200E_202B_200E_200C_200F_200D_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _200D_200F_200E_202B_200E_200C_200E_200E_200E_202D_200E_200C_200E_202B_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _200D_200F_200F_200F_200F_200C_200E_200F_200E_202B_200E_200C_200F_202B_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _200E_200E_200D_200C_200E_200F_200F_200F_200E_200D_200F_202B_200E_200C_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202A_200E_202D_200D_200F_202D_200E_202D_200E_202E_200E_200D_200E_202A_200F_200E;

	[CompilerGenerated]
	private Type _200C_200F_200D_202A_200F_202E_200E_200F_200E_202B_200F_200E_200E_202B_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x58
		}
	}

	public bool _200B_200E_202A_202C_200E_200E_200E_202B_200F_200E_200F_200E_200E_200C_200F_200E
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid branch target*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9D
		}
	}

	public bool _202D_200E_200F_202C_200E_200D_200F_202B_200F_200F_200E_200D_200F_202A_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB1
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x64
		}
	}

	public bool _202A_200F_202A_202B_200F_202A_200E_200D_200F_202A_200F_200F_200F_202C_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x55
		}
		[CompilerGenerated]
		init
		{
			_ = ((sbyte[])/*Error near IL_0002: Stack underflow*/)[((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]];
			/*Error near IL_0002: Unknown opcode: 0xC9*/;
		}
	}

	public ulong _200F_200F_202C_200C_200E_202E_200E_200E_200E_200E_200F_200D_200F_202B_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9D
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x29
		}
	}

	public ushort _202A_200F_202A_200E_200F_200E_200F_200E_200F_202A_200F_202B_200E_200F_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x03 0x48
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x00
		}
	}

	public byte _200B_200E_202B_202C_200E_202C_200E_202C_200E_202A_200E_202E_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x7F 0x46
		}
		[CompilerGenerated]
		init
		{
			_ = ((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			_ = -396670931523854615L;
			/*Error near IL_000b: Unknown opcode: 0xA6*/;
		}
	}

	public ushort _202E_200E_200F_202C_200E_200D_200F_200C_200F_202E_200E_200C_200F_200D_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x37 0x78
		}
		[CompilerGenerated]
		init
		{
			/*Error: Unknown opcode: 0xF2*/;
		}
	}

	public ushort _200D_200F_202B_202E_200E_200F_200E_202E_200E_200C_200E_202D_200E_200F_200F_200F
	{
		[CompilerGenerated]
		get
		{
			_ = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Unknown opcode: 0xA9*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x10
		}
	}

	public ushort _200C_200F_202E_200E_200F_202A_200E_202A_200E_202A_200E_200B_200E_202B_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x64
		}
		[CompilerGenerated]
		init
		{
			/*Error near IL_0001: Unknown opcode: 0xC5*/;
		}
	}

	public ushort _200F_200E_202C_200E_200E_202B_200E_200C_200E_200D_200F_200F_200F_202E_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBB 0xEE
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE1
		}
	}

	public ushort _202D_200E_200E_200E_200F_202A_200E_200D_200E_200E_200F_202B_200F_202C_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid local signature token: 0x71C16DFA
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD9
		}
	}

	public uint _200D_200E_200C_202B_200F_200F_200E_202E_200E_202E_200E_200E_200E_200D_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x2F 0xDF
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x94
		}
	}

	public uint _202E_200E_202E_200B_200E_200D_200E_200C_200E_200B_200E_200C_200F_202D_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x69
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1B 0x2A
		}
	}

	public uint _202C_200E_200F_200D_200F_200F_200E_202A_200F_202D_200E_200F_200E_200B_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4D
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB9
		}
	}

	public ushort _202C_200E_202C_202B_200F_200E_200F_202A_200E_200C_200E_202B_200F_200F_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD5
		}
		[CompilerGenerated]
		init
		{
			/*Error: Unknown opcode: 0xBD*/;
		}
	}

	public string _202B_200E_200D_202A_200F_200D_200F_202C_200E_202B_200E_200B_200E_200B_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x28
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x70
		}
	}

	public byte _200D_200F_200F_200C_200E_200C_200F_202E_200E_200C_200F_200E_200F_202A_200F_200F
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xF2*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xCF 0x2B
		}
	}

	public string _200C_200E_202D_200E_200F_200D_200E_202B_200F_200C_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x71
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x75
		}
	}

	public byte _200F_200F_202C_200B_200E_200B_200E_202B_200E_200E_200E_202B_200F_202B_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x55
		}
		[CompilerGenerated]
		init
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Expected I4, but got Unknown
			((short[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (short)(int)(/*Error near IL_0003: Stack underflow*/ - ((double[])/*Error near IL_0002: Stack underflow*/)[(long)/*Error near IL_0001: Stack underflow*/]);
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	public string _202E_200E_200C_202B_200F_202C_200E_202C_200E_200F_200E_200F_200F_202D_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xDD
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x0D
		}
	}

	public byte _200C_200E_202D_200D_200F_200E_200E_202C_200E_202D_200E_202A_200E_200C_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC3 0x7C
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid local signature token: 0x6B26F29B
		}
	}

	public ushort _202C_200E_200C_200C_200E_200D_200E_202C_200E_200D_200F_200E_200F_200E_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBF 0x87
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x59
		}
	}

	public string _202E_200E_200E_202B_200E_200F_200F_200B_200E_202C_200E_200B_200E_202E_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x37 0x59
		}
		[CompilerGenerated]
		init
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 93 (out-of-bounds)*/;
			_ = 7;
			/*Error near IL_0004: Invalid field token*/;
		}
	}

	public ushort _202A_200F_200E_200F_200F_200C_200E_200C_200F_202D_200E_202A_200E_200B_200E_200E
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid metadata token*/;
		}
		[CompilerGenerated]
		init
		{
			_ = (uint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEC*/;
		}
	}

	public string _202E_200E_200F_200E_200E_200F_200E_202B_200E_202B_200F_200B_200E_200D_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x64
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x23 0xF1
		}
	}

	public ushort _200D_200F_202A_200C_200E_200F_200E_202D_200E_202D_200E_200C_200F_200E_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x7B 0x14
		}
		[CompilerGenerated]
		init
		{
			_ = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Unknown opcode: 0xAF*/;
		}
	}

	public string _200F_200F_200F_200F_200E_202C_200E_200B_200E_202A_200F_200E_200F_200E_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB7 0xCF
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x0F 0x93
		}
	}

	public ushort _200B_200E_200C_200C_200F_200C_200F_200B_200E_202B_200F_202A_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x6F 0xA8
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB0
		}
	}

	public string _202B_200F_202B_200E_200F_200C_200E_200F_200E_202B_200F_200D_200E_202B_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x29
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x7B 0x66
		}
	}

	public ushort _200E_200F_202D_200C_200E_200D_200E_202E_200E_202A_200E_200F_200E_202B_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x8D
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB7 0x1B
		}
	}

	public string _202E_200E_200F_200F_200F_202A_200E_202B_200E_200C_200E_200C_200E_202B_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD5
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xAB 0x2B
		}
	}

	public ushort _200F_200F_200C_200E_200E_200E_200E_202A_200E_202C_200E_200F_200E_200E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE8
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA4
		}
	}

	public string _200D_200E_200F_202C_200E_202C_200E_200E_200E_202D_200E_202C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			switch ((int)(nint)/*Error near IL_0001: Stack underflow*/)
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
			}
		}
		[CompilerGenerated]
		init
		{
			checked
			{
				if ((nint)(double)/*Error near IL_0001: Stack underflow*/ != 0)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (nint)/*Error near IL_0008: Stack underflow*/;
				/*Error near IL_0008: Unknown opcode: 0xFB*/;
			}
		}
	}

	public ushort _200F_200F_200C_200E_200E_200D_200E_202A_200E_202C_200E_200F_200E_200E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x31
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x39
		}
	}

	public string _200D_200E_200F_202E_200E_202D_200E_200E_200E_202D_200E_202C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x55
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x8D
		}
	}

	public ushort _200F_200F_200C_200E_200E_200C_200E_202A_200E_202C_200E_200F_200E_200E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1D
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x05
		}
	}

	public string _200D_200E_200F_200C_200F_200F_200F_200E_200E_202D_200E_202C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x83 0x0F
		}
		[CompilerGenerated]
		init
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public unsafe ushort _200F_200F_200C_200E_200E_200B_200E_202A_200E_202C_200E_200F_200E_200E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFF 0xBC
		}
		[CompilerGenerated]
		init
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0003: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_003F val;
			checked
			{
				val = /*Error near IL_0006: Stack underflow*/+ *unchecked((int*)(int)/*Error near IL_0004: Stack underflow*/);
				_ = 1.7263231E+17f;
			}
			if ((int)/*Error near IL_000c: ldarg 2 (out-of-bounds)*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			if (*(ushort*)(nint)val == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0015: Unknown opcode: 0xF4*/;
		}
	}

	public string _200C_200E_200F_200E_200F_202A_200F_200E_200E_202D_200E_202C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x37 0x86
		}
		[CompilerGenerated]
		init
		{
			/*Error: stloc 2 (out-of-bounds)*/;
		}
	}

	public ushort _200F_200F_200C_200E_200E_202C_200E_202A_200E_202C_200E_200F_200E_200E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xAC*/;
		}
		[CompilerGenerated]
		init
		{
			if (!float.IsFinite(/*Error near IL_0001: Stack underflow*/))
			{
				throw new ArithmeticException();
			}
			/*Error near IL_0001: Unknown opcode: 0xF6*/;
		}
	}

	public string _200D_200E_200F_202B_200F_200E_200E_200E_200E_202D_200E_202C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x64
		}
		[CompilerGenerated]
		init
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public byte _202C_200E_200E_202A_200E_200D_200F_200F_200F_200E_200E_200F_200F_200C_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3B 0xF6
		}
		[CompilerGenerated]
		init
		{
			if (/*Error near IL_0002: Stack underflow*/ < /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public byte _200D_200F_200D_200B_200E_202C_200E_202D_200E_200E_200E_200F_200F_200E_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB7 0xF6
		}
		[CompilerGenerated]
		init
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Unknown opcode: 0xF1*/;
			}
		}
	}

	public ushort _202B_200F_200E_202A_200E_202A_200F_200F_200F_202C_200E_202D_200E_202A_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xAF 0xD9
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x97 0x01
		}
	}

	public float _200B_200E_200F_200C_200E_202A_200F_200E_200F_202B_200F_202D_200E_200E_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE9
		}
		[CompilerGenerated]
		init
		{
			/*Error: Unknown opcode: 0xAF*/;
		}
	}

	public short _202A_200E_200C_200E_200F_200E_200E_200D_200E_200E_200F_200B_200E_200C_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xCD
		}
		[CompilerGenerated]
		init
		{
			//IL_0003: Invalid comparison between Unknown and I4
			if ((int)/*Error near IL_0005: Stack underflow*/ != checked((short)/*Error near IL_0001: Stack underflow*/ + 7))
			{
				/*Error: Invalid branch target*/;
			}
			_ = ((float[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
			/*Error: End of method reached without returning.*/;
		}
	}

	public byte _200D_200F_200C_202A_200F_200C_200F_200F_200F_200D_200F_200F_200F_200E_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD5
		}
		[CompilerGenerated]
		init
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public byte _200F_200E_200D_200E_200E_200E_200F_200D_200F_202E_200E_202C_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA8
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x85
		}
	}

	public byte _202C_200E_200E_200E_200F_202A_200E_200B_200E_202B_200E_200F_200F_202C_200E_200F
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xF8*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD5
		}
	}

	public byte _202E_200E_200F_200B_200E_202E_200E_202C_200E_202B_200F_202A_200F_200B_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF1
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid local signature token: 0x12082F4D
		}
	}

	public short _200D_200F_202A_202B_200F_202B_200E_200E_200F_200F_200E_202C_200E_200D_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x55
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1B 0xAD
		}
	}

	public short _200C_200F_202A_200D_200E_200F_200E_200B_200E_200E_200E_200C_200F_202C_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5D
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3C
		}
	}

	public byte _202C_200E_200C_200B_200E_200C_200E_200F_200E_200B_200E_200E_200E_202E_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x43 0xCE
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x8C
		}
	}

	public byte _202D_200E_200E_200C_200E_200D_200E_200D_200F_202C_200E_202B_200E_200F_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3F 0x9A
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x07 0x91
		}
	}

	public byte _200D_200E_200F_202A_200F_200C_200E_202B_200E_200D_200F_200E_200E_200F_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x37 0xB7
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5B 0xDF
		}
	}

	public byte _202A_200E_202B_200C_200F_202D_200E_202A_200E_200E_200F_202B_200F_200E
	{
		[CompilerGenerated]
		get
		{
			/*Error: Empty body found. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		init
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xCC*/;
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x64
	}

	[CompilerGenerated]
	private bool _200E_200F_202B_200F_200E_202B_200F_200D_200E_200E_200F_202C_200E_200C_200E_200E(StringBuilder P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC9
	}

	[SpecialName]
	[CompilerGenerated]
	public static bool _200D_200E_200D_202B_200E_200E_200F_200C_200F_202A_200F_202A_200F_200C_200F_200F(_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E? P_0, _200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E? P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x39
	}

	[SpecialName]
	[CompilerGenerated]
	public static bool _202B_200F_200E_202E_200E_202C_200E_200F_200F_200F_200E_202B_200E_202D_200E_200F(_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E? P_0, _200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E? P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x55
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF1
	}

	[CompilerGenerated]
	public override bool Equals(object? P_0)
	{
		switch ((int)/*Error near IL_0039: Stack underflow*/)
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

	[CompilerGenerated]
	public bool Equals(_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E? P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x95
	}

	[CompilerGenerated]
	public _200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E _202B_200E_200E_200F_200E_202B_200F_200C_200E_200F_200E_200F_200F_200C_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x81
	}

	[CompilerGenerated]
	private _200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E(_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x3C
	}

	public _200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x30
	}
}
public static class _200E_200F_200E_200D_200E_202B_200F_202E_200E_202B_200E_200E_200E_200C_200E_200E
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E
	{
		public static readonly _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E _003C_003E9;

		public static Comparison<(float Y, float X, string Text)> _003C_003E9__7_0;

		static _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE3 0xC1
		}

		public _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x45
		}

		internal int _202C_200E_202A_202A_200E_200D_200E_202C_200E_200E_200E_202D_200E_200D_200E_200F((float Y, float X, string Text) P_0, (float Y, float X, string Text) P_1)
		{
			_ = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Unknown opcode: 0xC1*/;
		}
	}

	private static readonly int[] _200E_200F_200E_202B_200F_200E_200F_200D_200F_200F_200F_202D_200E_200F_200E_200E;

	private static readonly int[] _200E_200E_202A_200F_200F_200B_200E_200B_200E_202D_200E_200B_200E_202E_200E_200F;

	private static readonly int[] _200E_200F_202B_200F_200F_202B_200F_200E_200E_202A_200F_202B_200F_200D_200F_200F;

	public static bool _200C_200F_200F_200C_200F_200D_200F_202C_200E_200C_200F_200B_200E_200C_200F_200E(out _200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E? P_0, out string? P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x33 0xEF
	}

	public static bool _202B_200F_200F_200F_200E_200F_200E_200D_200E_200C_200F_202E_200E_200E_200F_200E(out string P_0, out string? P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x58
	}

	private unsafe static bool _202E_200E_202A_200E_200F_202C_200E_200D_200F_200F_200F_200E_200F_202B_200E_200E(AtkUnitBase* P_0, out string P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x34
	}

	private unsafe static string _202D_200E_202B_200E_200E_202A_200E_202E_200E_202A_200F_202A_200F_200E_200E_200F(AtkUnitBase* P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x04
	}

	private unsafe static bool _202B_200E_202A_202A_200E_202E_200E_200D_200F_200F_200F_200E_200E_200D_200E_200F(AtkUnitBase* P_0, int P_1, out uint P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9B 0x5C
	}

	private unsafe static bool _200D_200E_202C_202D_200E_200B_200E_200F_200F_200C_200E_200B_200E_202E_200E_200E(StdVector<AtkValue>* P_0, long P_1, out uint P_2)
	{
		//IL_0002: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0007: Stack underflow*/ != checked((int)(ushort)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_0009: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0009: Unknown opcode: 0xED*/;
	}

	private static string _200D_200E_200E_202A_200F_200E_200F_202B_200E_202D_200E_202C_200E_200F(uint P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x10
	}

	private static string _202B_200E_202A_202B_200F_202D_200E_200D_200E_202D_200E_202D_200E_200F_200E_200F(uint P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBB 0x99
	}

	private static string _200E_200F_200F_202C_200E_200B_200E_202B_200F_200F_200E_200D_200F_200B_200E_200F(uint P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4B 0x8F
	}

	private static string _200F_200F_200D_202B_200E_202D_200E_200B_200E_200F_200F_202B_200F_200C_200E_200E(uint P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9D
	}

	static _200E_200F_200E_200D_200E_202B_200F_202E_200E_202B_200E_200E_200E_200C_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9F 0x54
	}
}
public static class _202A_200F_200C_200E_200F_202D_200E_202A_200F_202A_200F_200E_200E_200B_200E_200E
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate byte _202B_200E_200D_200D_200E_200B_200E_200C_200E_202B_200E_200B_200E_200D_200F_200F(IntPtr P_0, IntPtr P_1, int P_2);

	private readonly struct _200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F : IEquatable<_200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _200F_200E_200D_200D_200F_202D_200E_202E_200E_200E_200F_202E_200E_202D_200E_200E;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly uint _200E_200F_200D_200D_200F_202D_200E_202B_200F_202E_200E_200B_200E_202B_200E_200F;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _202B_200E_200E_202A_200E_200D_200E_202A_200F_202B_200E_200E_200F_202A_200F_200E;

		public int _200D_200F_202A_200E_200E_202A_200F_200F_200E_202E_200E_202C_200E_202C_200E_200E
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x70
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8F 0xF5
			}
		}

		public uint _200D_200E_202A_200F_200E_202A_200E_200C_200E_202B_200F_202B_200F_202B_200F_200F
		{
			[CompilerGenerated]
			get
			{
				/*Error: Unknown opcode: 0xC0*/;
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x5B 0xD3
			}
		}

		public string _200D_200F_200E_200F_200F_200C_200E_200E_200F_202E_200E_200D_200F_200E
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x0F 0x8A
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x39
			}
		}

		public _200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F(int P_0, uint P_1, string P_2)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x70
		}

		[CompilerGenerated]
		public override string ToString()
		{
			nint num = (nint)/*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0001: ldloc 89 (out-of-bounds)*/ != /*Error near IL_0003: ldloc 77 (out-of-bounds)*/)
			{
				/*Error: Invalid branch target*/;
			}
			checked
			{
				_ = (long)unchecked((nuint)num);
				/*Error: End of method reached without returning.*/;
			}
		}

		[CompilerGenerated]
		private bool _200E_200F_202B_200F_200E_202B_200F_200D_200E_200E_200F_202C_200E_200C_200E_200E(StringBuilder P_0)
		{
			/*Error: Unknown opcode: 0xE9*/;
		}

		[SpecialName]
		[CompilerGenerated]
		public static bool _200D_200E_200D_202B_200E_200E_200F_200C_200F_202A_200F_202A_200F_200C_200F_200F(_200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F P_0, _200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F P_1)
		{
			//IL_0002: Expected I8, but got I4
			((long[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = -1L;
			/*Error near IL_0002: Read out of bounds.*/;
		}

		[SpecialName]
		[CompilerGenerated]
		public static bool _202B_200F_200E_202E_200E_202C_200E_200F_200F_200F_200E_202B_200E_202D_200E_200F(_200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F P_0, _200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F P_1)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD0
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB1
		}

		[CompilerGenerated]
		public override bool Equals(object P_0)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x15
		}

		[CompilerGenerated]
		public bool Equals(_200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F P_0)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x7F 0xAB
		}

		[CompilerGenerated]
		public void _200F_200E_202C_200C_200F_202A_200E_200F_200E_202A_200E_202B_200F_200E_200F_200E(out int P_0, out uint P_1, out string P_2)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBF 0x62
		}
	}

	private static readonly string[] _200B_200E_200C_202D_200E_200C_200E_202B_200F_200F_200F_202C_200E_200B_200E_200E;

	private static readonly _200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F _202D_200E_202B_202B_200E_200C_200F_202C_200E_200D_200F_200E_200E_200E_200F_200F;

	private static _202B_200E_200D_200D_200E_200B_200E_200C_200E_202B_200E_200B_200E_200D_200F_200F? _200C_200E_202C_200F_200F_200C_200F_200C_200F_200C_200E_202A_200E_200E;

	private static readonly object _202D_200E_200D_200E_200E_202B_200F_202A_200F_200C_200E_200F_200E_202D_200E_200F;

	private static _202B_200E_200D_200D_200E_200B_200E_200C_200E_202B_200E_200B_200E_200D_200F_200F _200F_200F_202D_202C_200E_200B_200E_202B_200F_200B_200E_202B_200E_202A_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD0
	}

	public static bool _200E_200E_202C_202D_200E_200F_200F_202A_200E_202A_200E_200F_200E_200D_200F_200E(out string P_0, out string? P_1)
	{
		/*Error: Read out of bounds.*/;
	}

	public static bool _202D_200E_200C_202A_200F_202E_200E_200E_200F_202C_200E_202A_200E_202E_200E_200E(_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E P_0, out string? P_1, bool P_2 = false)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x18
	}

	public static bool _200D_200F_200F_202B_200E_200F_200E_202C_200E_202D_200E_202A_200F_202D_200E_200E(out string? P_0, bool P_1 = false)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF1
	}

	private unsafe static void _202A_200E_202B_200F_200E_200C_200E_202C_200E_202A_200E_200D_200F_200C_200E_200E(uint* P_0, List<_200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F> P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD4
	}

	private static _200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F _200F_200F_200D_202B_200E_202D_200E_200B_200E_200F_200F_202B_200F_200C_200E_200E(int P_0, uint P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA1
	}

	private static string _200D_200F_202B_200B_200E_200E_200F_200F_200F_200F_200F_202E_200E_200E_200F_200E(List<_200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F> P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDB 0xCA
	}

	private static string _202A_200E_202E_200B_200E_202B_200F_202A_200F_202B_200E_202A_200F_200F_200E_200E(int P_0, uint P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF1
	}

	private static string _202D_200E_200F_200E_200E_202D_200E_202B_200E_202A_200E_202C_200E_200D_200F_200E(int P_0, uint P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x84
	}

	private static bool _202A_200E_200C_202D_200E_200E_200E_202C_200E_202D_200E_200D_200F_200E_200F_200E(List<_200D_200E_202B_200F_200E_200F_200E_200D_200E_200D_200F_200D_200F_202E_200E_200F> P_0, int P_1, uint P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2D
	}

	private static bool _202B_200E_202B_200C_200F_202E_200E_200D_200F_202B_200F_200B_200E_200C_200F_200F(uint P_0)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken()
		//    at System.Reflection.Metadata.Ecma335.MetadataTokens.EntityHandle(Int32 token)
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeMetadataToken() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 227
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 1273
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2391
	}

	private static bool _200F_200E_200D_202A_200F_200C_200F_200F_200E_200F_200F_202B_200E_200B_200E_200F(uint P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0C
	}

	private static bool _200E_200E_202A_200F_200E_200B_200E_200D_200F_200E_200F_202B_200E_202A_200E_200E(uint P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0F 0x68
	}

	private static bool _200E_200F_202D_200B_200E_202D_200E_200F_200E_202C_200E_202D_200E_202B_200F_200E(RowRef<BannerCondition> P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x89
	}

	private unsafe static bool _200C_200F_202E_200B_200E_200C_200F_200F_200E_200D_200F_202B_200E_200E_200E_200E(_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E P_0, bool* P_1, out string? P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6B 0xD0
	}

	private unsafe static BannerHelper* _200F_200F_202E_200B_200E_202E_200E_202E_200E_200C_200E_200B_200E_202A_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5C
	}

	private unsafe static void _200E_200E_202A_202B_200F_200F_200F_200D_200E_202E_200E_200F_200E_202A_200F_200E(CharaCardData* P_0, _200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E P_1, bool* P_2)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	private unsafe static void _202B_200F_200D_200F_200E_202B_200F_202B_200F_202A_200F_202A_200E_200C_200F_200E(_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E P_0, bool* P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC4
	}

	private unsafe static void _202E_200E_200C_200E_200E_202D_200E_200F_200F_200E_200E_200C_200F_200C_200E_200F(CharaCardData* P_0, CharaCardData P_1)
	{
		_ = ((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}

	private unsafe static void _200D_200F_202B_200F_200F_202B_200E_200C_200F_202A_200F_200E_200F_202D_200E_200E(CharaCard* P_0, CharaCardData P_1, bool* P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x91
	}

	private unsafe static bool _202B_200E_202A_200E_200F_202D_200E_200E_200E_200E_200F_202B_200E_200E_200F_200F(bool* P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4C
	}

	private static string _200B_200E_200C_202A_200F_200E_200F_202C_200E_202A_200F_202C_200E_200E_200E_200E(_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x65
	}

	private unsafe static string _202A_200F_202C_202C_200E_202A_200F_200E_200E_202D_200E_202B_200F_202B_200F_200E(uint* P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x37 0x53
	}

	private unsafe static string _200E_200F_202A_202B_200F_200B_200E_202B_200E_202A_200E_200D_200E_202B_200E_200F(bool* P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE5
	}

	private static string _202E_200E_200C_202A_200F_202A_200F_202B_200E_202A_200E_202A_200F_202C_200E_200F(CharaCardData P_0)
	{
		((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
		if (/*Error near IL_0003: Stack underflow*/ < /*Error near IL_0003: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0003: Invalid branch target*/;
	}

	private unsafe static string _200C_200E_200F_202A_200E_200D_200E_200F_200F_202A_200E_200B_200E_202C_200E_200F(void* P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x38
	}

	static _202A_200F_200C_200E_200F_202D_200E_202A_200F_202A_200F_200E_200E_200B_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF3 0x1F
	}
}
public sealed class _202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E : IEquatable<_202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202D_200E_200E_202A_200F_200D_200F_202B_200E_200C_200E_200E_200F_200B_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly bool _200E_200F_202E_200F_200E_202E_200E_200E_200E_202A_200E_200E_200E_202A_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200F_200F_202A_200B_200E_202A_200F_202B_200E_200F_200F_202A_200F_200F_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202D_200E_200C_202C_200E_200C_200E_200C_200F_202B_200F_200D_200F_202A_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202A_200F_200D_200F_200F_200D_200E_200F_200F_202E_200E_200E_200E_202D_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly byte _202B_200E_202B_200C_200F_200E_200E_200C_200F_202C_200E_200E_200E_200C_200F_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200B_200E_200C_200D_200E_200C_200E_200E_200F_200E_200E_202C_200E_202C_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200F_200E_202B_202A_200E_200F_200F_200E_200F_202A_200F_202A_200E_202B_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202D_200E_200E_202D_200E_200B_200E_200F_200F_200F_200F_202E_200E_200C_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _202C_200E_200C_202D_200E_202B_200E_202B_200F_200E_200F_200C_200E_200F_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ushort _200C_200F_202C_200E_200F_202B_200F_200E_200F_202A_200F_200F_200E_200F_200F_200E;

	[CompilerGenerated]
	private unsafe Type _200C_200F_200D_202A_200F_202E_200E_200F_200E_202B_200F_200E_200E_202B_200F_200F
	{
		[CompilerGenerated]
		get
		{
			/*Error: stloc 3 (out-of-bounds)*/;
			if (/*Error near IL_0003: Stack underflow*/ < /*Error near IL_0003: Stack underflow*/)
			{
				*(_003F*)(nint)/*Error near IL_0004: Stack underflow*/ = /*Error near IL_0004: Stack underflow*/;
				((short[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (short)/*Error near IL_0005: Stack underflow*/;
				/*Error near IL_0005: Invalid metadata token*/;
			}
			/*Error near IL_0015: Invalid metadata token*/;
		}
	}

	public ushort _200C_200E_202C_202B_200E_200F_200E_202A_200E_200F_200F_202B_200E_202C_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//IL_0007: Expected F4, but got I4
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			((float[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = checked((sbyte)/*Error near IL_0006: Stack underflow*/);
			/*Error near IL_0007: Unknown opcode: 0xEB*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x40
		}
	}

	public bool _202A_200F_202A_202B_200F_202A_200E_200D_200F_202A_200F_200F_200F_202C_200E_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9F 0x05
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFD
		}
	}

	public ushort _202C_200E_202C_202B_200F_200E_200F_202A_200E_200C_200E_202B_200F_200F_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4C
		}
		[CompilerGenerated]
		init
		{
			/*Error: Unknown opcode: 0xEE*/;
		}
	}

	public byte _200D_200F_200F_200C_200E_200C_200F_202E_200E_200C_200F_200E_200F_202A_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3C
		}
		[CompilerGenerated]
		init
		{
			_ = (short)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public byte _200F_200F_202C_200B_200E_200B_200E_202B_200E_200E_200E_202B_200F_202B_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB9
		}
		[CompilerGenerated]
		init
		{
			throw /*Error near IL_0001: Stack underflow*/;
		}
	}

	public byte _200C_200E_202D_200D_200F_200E_200E_202C_200E_202D_200E_202A_200E_200C_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x08
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA9
		}
	}

	public ushort _202C_200E_200C_200C_200E_200D_200E_202C_200E_200D_200F_200E_200F_200E_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB1
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC1
		}
	}

	public ushort _202A_200F_200E_200F_200F_200C_200E_200C_200F_202D_200E_202A_200E_200B_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x0F 0xDF
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x58
		}
	}

	public ushort _200D_200F_202A_200C_200E_200F_200E_202D_200E_202D_200E_200C_200F_200E_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x6C
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x75
		}
	}

	public ushort _200B_200E_200C_200C_200F_200C_200F_200B_200E_202B_200F_202A_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x2D
		}
		[CompilerGenerated]
		init
		{
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Unknown opcode: 0xF0*/;
		}
	}

	public unsafe ushort _200E_200F_202D_200C_200E_200D_200E_202E_200E_202A_200E_200F_200E_202B_200E_200E
	{
		[CompilerGenerated]
		get
		{
			((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
			_ = *(double*)(nint)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: ldarga 68 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0x78*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB9
		}
	}

	public static _202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E _202B_200F_200C_202A_200E_200D_200F_202E_200E_202E_200E_202E_200E_200B_200E_200F(_200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E P_0)
	{
		/*Error: Unknown opcode: 0xF1*/;
	}

	public _200D_200E_202C_202B_200E_202E_200E_202A_200F_202B_200E_202D_200E_202B_200F_200E _200F_200F_202A_200E_200F_200C_200E_202A_200E_200C_200F_200E_200E_202C_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x89
	}

	public void _200F_200F_200C_202C_200E_200E_200F_202A_200F_200F_200F_202A_200E_200C_200E_200F()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Unknown opcode: 0xC7*/;
	}

	public string _202B_200F_200C_200E_200F_202D_200E_200B_200E_202C_200E_200B_200E_202A_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x58
	}

	public static _202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E? _200C_200F_202D_200C_200F_202D_200E_202B_200E_202B_200F_202A_200E_202B_200E_200E(string? P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF3 0x7B
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x41
	}

	[CompilerGenerated]
	private bool _200E_200F_202B_200F_200E_202B_200F_200D_200E_200E_200F_202C_200E_200C_200E_200E(StringBuilder P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public static bool _200D_200E_200D_202B_200E_200E_200F_200C_200F_202A_200F_202A_200F_200C_200F_200F(_202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E? P_0, _202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E? P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4B 0x83
	}

	[SpecialName]
	[CompilerGenerated]
	public static bool _202B_200F_200E_202E_200E_202C_200E_200F_200F_200F_200E_202B_200E_202D_200E_200F(_202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E? P_0, _202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E? P_1)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken()
		//    at System.Reflection.Metadata.Ecma335.MetadataTokens.EntityHandle(Int32 token)
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeMetadataToken() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 227
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 1273
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2391
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE3 0xFD
	}

	[CompilerGenerated]
	public unsafe override bool Equals(object? P_0)
	{
		_ = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid field token*/;
	}

	[CompilerGenerated]
	public bool Equals(_202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E? P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x01
	}

	[CompilerGenerated]
	public _202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E _202B_200E_200E_200F_200E_202B_200F_200C_200E_200F_200E_200F_200F_200C_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBC
	}

	[CompilerGenerated]
	private _202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E(_202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC1
	}

	public _202A_200F_202E_200F_200E_202A_200F_200C_200E_202A_200E_202C_200E_202B_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x09
	}
}
public class _200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F : IEquatable<_200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string _200C_200E_202E_200C_200E_202C_200E_202D_200E_200B_200E_202E_200E_202C_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string? _200C_200E_202A_200E_200E_200C_200E_200E_200E_200E_200E_200D_200F_202B_200F_200E;

	[CompilerGenerated]
	protected virtual Type _200C_200F_200D_202A_200F_202E_200E_200F_200E_202B_200F_200E_200E_202B_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x51
		}
	}

	public unsafe string _202A_200E_200C_200E_200F_202B_200E_200D_200E_200F_200E_200B_200E_200E_200F_200E
	{
		[CompilerGenerated]
		get
		{
			/*Error near IL_0001: Unknown opcode: 0xCC*/;
		}
		[CompilerGenerated]
		init
		{
			_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xBE*/;
		}
	}

	public string? _200E_200F_200D_200E_200F_200D_200E_202D_200E_202A_200F_200F_200F_200E_200E_200F
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xCB*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x35
		}
	}

	public static bool _202B_200F_202C_200B_200E_200E_200E_202C_200E_200D_200F_200E_200F_200E
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xAD
		}
	}

	public _200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F(string P_0, string? P_1 = null)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x99
	}

	public string? _202D_200E_202E_200D_200E_202B_200F_200B_200E_200E_200E_200C_200E_202B_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x01
	}

	public bool _202B_200F_202A_200C_200F_202B_200F_200D_200F_202A_200F_200E_200F_200D_200E_200E(out string? P_0)
	{
		/*Error: Unknown opcode: 0xCB*/;
	}

	public IntPtr _200F_200E_202A_200F_200E_200C_200F_200B_200E_202C_200E_200F_200F_200D_200E_200F()
	{
		if (/*Error near IL_0001: Stack underflow*/ < /*Error near IL_0001: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0001: Unknown opcode: 0x78*/;
	}

	public unsafe T* _200F_200E_202A_200F_200E_200C_200F_200B_200E_202C_200E_200F_200F_200D_200E_200F<T>() where T : unmanaged
	{
		_ = 1;
		/*Error near IL_0001: Unknown opcode: 0xFB*/;
	}

	public IntPtr _202B_200E_200D_200F_200F_202C_200E_202C_200E_202E_200E_200E_200E_200F_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x41
	}

	public unsafe T* _202B_200E_200D_200F_200F_202C_200E_202C_200E_202E_200E_200E_200E_200F_200F_200F<T>() where T : unmanaged
	{
		//IL_0009: Expected I8, but got F8
		/*Error: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		if (/*Error near IL_0007: Stack underflow*/ > /*Error near IL_0007: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		*(long*)(nint)/*Error near IL_0009: Stack underflow*/ = (long)(double)/*Error near IL_0008: Stack underflow*/;
		/*Error: End of method reached without returning.*/;
	}

	public T _202B_200F_200C_200B_200E_200C_200E_202B_200E_202A_200E_202E_200E_200E_200F_200F<T>() where T : Delegate
	{
		checked
		{
			_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0003: Unknown opcode: 0xF7*/;
		}
	}

	public Hook<T> _202D_200E_200F_200B_200E_200F_200E_202E_200E_200C_200E_200E_200F_200E_200E_200F<T>(T P_0) where T : Delegate
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF0
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6F 0xA2
	}

	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x28
	}

	[SpecialName]
	[CompilerGenerated]
	public static bool _200D_200E_200D_202B_200E_200E_200F_200C_200F_202A_200F_202A_200F_200C_200F_200F(_200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F? P_0, _200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F? P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF8
	}

	[SpecialName]
	[CompilerGenerated]
	public static bool _202B_200F_200E_202E_200E_202C_200E_200F_200F_200F_200E_202B_200E_202D_200E_200F(_200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F? P_0, _200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F? P_1)
	{
		/*Error: Unknown opcode: 0xAD*/;
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB0
	}

	[CompilerGenerated]
	public override bool Equals(object? P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x45
	}

	[CompilerGenerated]
	public virtual bool Equals(_200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F? P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD1
	}

	[CompilerGenerated]
	protected _200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F(_200E_200E_200D_200C_200F_200D_200F_200D_200E_202E_200E_202C_200E_202B_200E_200F P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC5
	}

	[CompilerGenerated]
	public void _200F_200E_202C_200C_200F_202A_200E_200F_200E_202A_200E_202B_200F_200E_200F_200E(out string P_0, out string? P_1)
	{
		_ = 3;
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}
}
[Serializable]
public class _202B_200E_200E_200E_200E_200B_200E_200C_200E_202B_200E_200D_200E_202A_200E_200F : IPluginConfiguration
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int Version__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool IsConfigWindowMovable__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool SomePropertyToBeSavedAndWithADefault__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool EnablePortraitLimitationRemoval__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool EnableRecipeSearchLimitationRemoval__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool EnableCharaCardDesignDump__BackingField;

	public int _200C_200E_202C_202B_200E_200F_200E_202A_200E_200F_200F_202B_200E_202C_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB3 0x46
		}
		[CompilerGenerated]
		set
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (/*Error near IL_000a: Stack underflow*/ > /*Error near IL_000a: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_000a: Unknown opcode: 0xBE*/;
		}
	}

	public bool _200D_200F_202B_202D_200E_200F_200F_200C_200E_200D_200E_200C_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xCC
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x63 0x56
		}
	}

	public bool _202B_200F_202E_200C_200E_202B_200F_200C_200E_200E_200F_200D_200F_202B_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF1
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC9
		}
	}

	public bool _202B_200F_202C_202A_200F_202B_200E_200D_200E_200E_200E_200F_200E_200B_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x70
		}
		[CompilerGenerated]
		set
		{
			if (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	public bool _200B_200E_200C_200D_200E_202A_200E_202A_200E_202D_200E_202C_200E_202A_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid local signature token: 0x46E8C9A7
		}
		[CompilerGenerated]
		set
		{
			/*Error: Unknown opcode: 0xE8*/;
		}
	}

	public bool _202E_200E_200F_202A_200E_202B_200E_200E_200E_202B_200E_202A_200F_202B_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x91
		}
		[CompilerGenerated]
		set
		{
			_ = (double)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xF3*/;
		}
	}

	public void _200C_200E_202E_200D_200E_202D_200E_202A_200F_200E_200F_202B_200E_202E_200E_200E()
	{
		/*Error: Unknown opcode: 0xF8*/;
	}

	public _202B_200E_200E_200E_200E_200B_200E_200C_200E_202B_200E_200D_200E_202A_200E_200F()
	{
		((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
		if (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Unknown opcode: 0xF0*/;
	}
}
[Flags]
public enum _202A_200F_202A_202B_200E_202B_200E_200B_200E_202E_200E_200B_200E_202A_200E_200E
{

}
public sealed class _202B_200E_200E_202A_200F_202C_200E_200C_200F_202B_200F_202B_200E_200C_200E_200F : IDalamudPlugin, IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E
	{
		public static readonly _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E _003C_003E9;

		public static Func<Task?> _003C_003E9__28_0;

		static _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E()
		{
			// ILSpy could not decompile this. Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// System.ArgumentException: Invalid token. (Parameter 'token')
			//    at System.Reflection.Throw.InvalidToken()
			//    at System.Reflection.Metadata.Ecma335.MetadataTokens.EntityHandle(Int32 token)
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeMetadataToken() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 227
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeMethodReference() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 245
			//    at ICSharpCode.Decompiler.IL.ILReader.DecodeJmp() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 2219
			//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 981
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 539
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 506
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 726
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2391
		}

		public _202B_200F_200C_200F_200F_202A_200E_200F_200F_202C_200E_202A_200F_202B_200F_200E()
		{
			/*Error: Unknown opcode: 0xE7*/;
		}

		[AsyncStateMachine(typeof(_003C_003COnLogin_003Eb__28_0_003Ed))]
		[DebuggerStepThrough]
		internal Task? _200F_200F_200C_200F_200F_200C_200F_200D_200E_200E_200E_202D_200E_200C_200F_200F()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x68
		}
	}

	public static ushort _202D_200E_202A_200F_200E_200E_200E_200B_200E_202E_200E_200F_200E_202E_200E_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ITextureProvider _200F_200E_200F_200E_200F_200D_200F_202D_200E_200F_200E_200C_200E_202B_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static IDalamudPluginInterface _202A_200F_202A_200F_200E_200E_200F_200F_200F_200C_200F_200D_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static ICommandManager _202D_200E_200E_200E_200E_200F_200E_202E_200E_202C_200E_200D_200F_202E_200E_200F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static IUnlockState _202A_200E_202E_202D_200E_200C_200F_200F_200F_200F_200F_202D_200E_200E_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _202B_200E_200E_200E_200E_200B_200E_200C_200E_202B_200E_200D_200E_202A_200E_200F _202D_200E_202A_202A_200E_200D_200E_200E_200F_200B_200E_200E_200E_202A_200F_200E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly MainWindow _200E_200F_200F_200B_200E_202D_200E_200B_200E_200F_200E_202C_200E_202E_200E_200E;

	public string _200D_200F_200E_200F_200F_200C_200E_200E_200F_202E_200E_200D_200F_200E
	{
		get
		{
			/*Error: Unknown opcode: 0xE9*/;
		}
	}

	public ITextureProvider _200F_200F_202B_200F_200F_200F_200F_200E_200F_200E_200F_202E_200E_200C_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x54
		}
	}

	[PluginService]
	internal static IDalamudPluginInterface _200C_200F_200D_202D_200E_202D_200E_202B_200F_200F_200F_200F_200E_202C_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x49
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB0
		}
	}

	[PluginService]
	internal static ICommandManager _202A_200F_202E_202A_200F_202C_200E_200F_200E_200D_200E_202B_200E_200F_200E_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x85
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE3 0xAD
		}
	}

	[PluginService]
	internal static IUnlockState _202A_200E_202C_202E_200E_202A_200E_202B_200E_200D_200E_200F_200F_200D_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBC
		}
		[CompilerGenerated]
		private set
		{
			/*Error: Unknown opcode: 0xBC*/;
		}
	}

	public _202B_200E_200E_200E_200E_200B_200E_200C_200E_202B_200E_200D_200E_202A_200E_200F _200B_200E_200F_202A_200E_202A_200F_200F_200E_202C_200E_200F_200F_200F_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//IL_0006: Expected I4, but got F4
			((short[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = 0;
			/*Error near IL_0006: Unknown opcode: 0xAE*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xCF 0x92
		}
	}

	private MainWindow _200E_200E_200F_200E_200F_200C_200F_200C_200E_202C_200E_202A_200E_200F_200F_200E
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC5
		}
		[CompilerGenerated]
		init
		{
			checked
			{
				_ = (int)/*Error near IL_0001: Stack underflow*/;
				_ = (ulong)((float[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0002: ldloc 1 (out-of-bounds)*/];
				/*Error near IL_0005: Unknown opcode: 0xAB*/;
			}
		}
	}

	public _202B_200E_200E_202A_200F_202C_200E_200C_200F_202B_200F_202B_200E_200C_200E_200F(ITextureProvider P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD1
	}

	private void _200E_200F_200D_200F_200E_200F_200E_202B_200E_202E_200E_200F_200E_200F_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD9
	}

	public void Dispose()
	{
		_ = 3;
		/*Error near IL_0001: Unknown opcode: 0xE2*/;
	}

	private void _202D_200E_202A_202B_200F_202B_200F_200C_200F_200D_200F_202D_200E_200C_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAD
	}

	private unsafe void _202A_200E_200C_202B_200E_200D_200F_202A_200F_200E_200E_202D_200E_200D_200F_200E(string P_0, string P_1)
	{
		//IL_0002: Expected Obj, but got F4
		_ = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public void _200F_200E_202D_202D_200E_200F_200F_200D_200E_200E_200E_202E_200E_200E_200E_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x99
	}

	static _202B_200E_200E_202A_200F_202C_200E_200C_200F_202B_200F_202B_200E_200C_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x59
	}
}
public static class _202C_200E_200C_202A_200E_202E_200E_202A_200F_202E_200E_202E_200E_200C_200F_200E
{
	public static bool _200D_200F_200F_202B_200E_200F_200E_202C_200E_202D_200E_202A_200F_202D_200E_200E(_202A_200F_202A_202B_200E_202B_200E_200B_200E_202E_200E_200B_200E_202A_200E_200E P_0 = (_202A_200F_202A_202B_200E_202B_200E_200B_200E_202E_200E_200B_200E_202A_200E_200E)262143)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBC
	}

	public static bool _202B_200F_202A_200F_200F_202C_200E_202A_200E_202C_200E_200C_200E_200F(_200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E P_0, _202A_200F_202A_202B_200E_202B_200E_200B_200E_202E_200E_200B_200E_202A_200E_200E P_1 = (_202A_200F_202A_202B_200E_202B_200E_200B_200E_202E_200E_200B_200E_202A_200E_200E)262143)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC7 0xE1
	}
}
public sealed class _200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E : IEquatable<_200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E>
{
	[CompilerGenerated]
	private sealed class _202C_200E_202E_200E_200E_200C_200F_202A_200F_200F_200E_200E_200F_200E_200F_200E
	{
		public unsafe AgentCharaCard* _200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_200D_200F_200F_200F_200F;

		public _202C_200E_202E_200E_200E_200C_200F_202A_200F_200F_200E_200E_200F_200E_200F_200E()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF5
		}

		internal bool _202A_200F_202C_200E_200E_200E_200F_202D_200E_200D_200E_200F_200F_200C_200F_200E(ClassJob P_0)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x13 0x87
		}
	}

	public ushort _200C_200E_202C_202B_200E_200F_200E_202A_200E_200F_200F_202B_200E_202C_200E_200E;

	public HalfVector4 _202D_200E_202C_202E_200E_200C_200F_200C_200E_200B_200E_202D_200E_200F_200F_200E;

	public HalfVector4 _202D_200E_202B_202A_200E_200D_200F_200F_200E_202A_200E_200D_200F_200F;

	public short _202A_200E_200C_200E_200F_200E_200E_200D_200E_200E_200F_200B_200E_200C_200E_200F;

	public byte _200D_200F_200D_200B_200E_202C_200E_202D_200E_200E_200E_200F_200F_200E_200F_200E;

	public ushort _202B_200F_200E_202A_200E_202A_200F_200F_200F_202C_200E_202D_200E_202A_200E_200E;

	public float _200B_200E_200F_200C_200E_202A_200F_200E_200F_202B_200F_202D_200E_200E_200F_200E;

	public byte _202C_200E_200E_202A_200E_200D_200F_200F_200F_200E_200E_200F_200F_200C_200F_200E;

	public HalfVector2 _200D_200F_200F_202B_200F_202E_200E_200F_200F_200F_200E_202A_200E_200F_200E_200E;

	public HalfVector2 _202D_200E_200C_200F_200F_202A_200E_202B_200E_200B_200E_200C_200E_202B_200F_200E;

	public byte _200D_200F_200C_202A_200F_200C_200F_200F_200F_200D_200F_200F_200F_200E_200F_200F;

	public byte _200F_200E_200D_200E_200E_200E_200F_200D_200F_202E_200E_202C_200E_200E;

	public byte _202C_200E_200E_200E_200F_202A_200E_200B_200E_202B_200E_200F_200F_202C_200E_200F;

	public byte _202E_200E_200F_200B_200E_202E_200E_202C_200E_202B_200F_202A_200F_200B_200E_200F;

	public short _200D_200F_202A_202B_200F_202B_200E_200E_200F_200F_200E_202C_200E_200D_200E_200E;

	public short _200C_200F_202A_200D_200E_200F_200E_200B_200E_200E_200E_200C_200F_202C_200E_200E;

	public byte _202C_200E_200C_200B_200E_200C_200E_200F_200E_200B_200E_200E_200E_202E_200E_200E;

	public byte _202D_200E_200E_200C_200E_200D_200E_200D_200F_202C_200E_202B_200E_200F_200E_200F;

	public byte _200D_200E_200F_202A_200F_200C_200E_202B_200E_200D_200F_200E_200E_200F_200E_200E;

	public byte _202A_200E_202B_200C_200F_202D_200E_202A_200E_200E_200F_202B_200F_200E;

	public ushort _200C_200F_202E_200E_200F_202A_200E_202A_200E_202A_200E_200B_200E_202B_200F_200E;

	public ushort _200F_200E_202C_200E_200E_202B_200E_200C_200E_200D_200F_200F_200F_202E_200E_200E;

	public ushort _202D_200E_200E_200E_200F_202A_200E_200D_200E_200E_200F_202B_200F_202C_200E_200F;

	public ClassJob? _200F_200F_202C_202A_200E_200F_200F_202B_200E_200E_200E_202D_200E_202B_200E_200E;

	[CompilerGenerated]
	private Type _200C_200F_200D_202A_200F_202E_200E_200F_200E_202B_200F_200E_200E_202B_200F_200F
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x21
		}
	}

	public void _200C_200E_200E_200F_200F_200C_200E_202E_200E_200C_200E_200D_200E_202A_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x81
	}

	public unsafe bool _200B_200E_200D_202B_200E_202D_200E_200D_200E_202A_200F_200C_200F_200E_200F_200E(ExportedPortraitData* P_0)
	{
		_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xE8*/;
	}

	public unsafe bool _200F_200E_202B_200F_200F_202A_200F_202A_200E_200E_200E_200E_200F_200E_200E_200F(ExportedPortraitData* P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9C
	}

	[AsyncStateMachine(typeof(_003CToClipboard_003Ed__30))]
	[DebuggerStepThrough]
	public void _200F_200F_200C_202C_200E_200E_200F_202A_200F_200F_200F_202A_200E_200C_200E_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x30
	}

	public string _202B_200F_200C_200E_200F_202D_200E_200B_200E_202C_200E_200B_200E_202A_200F_200F()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x19
	}

	public static _200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E? _200C_200F_202D_200C_200F_202D_200E_202B_200E_202B_200F_202A_200E_202B_200E_200E(string? P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE9
	}

	[CompilerGenerated]
	public override string ToString()
	{
		_ = ((object[])/*Error near IL_0002: Stack underflow*/)[((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]];
		/*Error near IL_0002: Unknown opcode: 0xE4*/;
	}

	[CompilerGenerated]
	private bool _200E_200F_202B_200F_200E_202B_200F_200D_200E_200E_200F_202C_200E_200C_200E_200E(StringBuilder P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEB 0xDC
	}

	[SpecialName]
	[CompilerGenerated]
	public static bool _200D_200E_200D_202B_200E_200E_200F_200C_200F_202A_200F_202A_200F_200C_200F_200F(_200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E? P_0, _200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E? P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCD
	}

	[SpecialName]
	[CompilerGenerated]
	public static bool _202B_200F_200E_202E_200E_202C_200E_200F_200F_200F_200E_202B_200E_202D_200E_200F(_200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E? P_0, _200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E? P_1)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x33 0xB5
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x65
	}

	[CompilerGenerated]
	public override bool Equals(object? P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x1C
	}

	[CompilerGenerated]
	public bool Equals(_200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E? P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC7 0x46
	}

	[CompilerGenerated]
	public _200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E _202B_200E_200E_200F_200E_202B_200F_200C_200E_200F_200E_200F_200F_200C_200F_200E()
	{
		if (/*Error near IL_0002: Stack underflow*/ > /*Error near IL_0002: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Not a type handle*/;
	}

	[CompilerGenerated]
	private _200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E(_200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x87 0x99
	}

	public _200D_200F_202B_200B_200E_202D_200E_202C_200E_200D_200F_200F_200F_200F_200F_200E()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x73 0xAC
	}
}
[CompilerGenerated]
internal sealed class _200C_200F_202C_202A_200E_202A_200E_202E_200E_200E_200F_202C_200E_202C_200E_200E
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 15)]
	internal struct _200C_200F_202B_200D_200F_200E_200F_200C_200F_202A_200F_200B_200E_200D_200F_200F
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 24)]
	internal struct _200E_200F_200E_200D_200F_200B_200E_200E_200E_202E_200E_202C_200E_200B_200E_200F
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 32)]
	internal struct _200E_200E_200C_200E_200E_202A_200F_200E_200F_200F_200E_200F_200F_202A_200E_200E
	{
	}

	internal static readonly _200E_200E_200C_200E_200E_202A_200F_200E_200F_200F_200E_200F_200F_202A_200E_200E _12719CAFBFBFBD6E3F50D6CE2471443FC73A7B74791375824521DF112E7FB3FF/* Not supported: data(81 2B E0 56 8F 6F 1F 4E B8 E6 D9 6F D0 8A E7 69 C8 52 4D 90 03 07 23 62 F3 B6 2F 08 BA F7 9B 16) */;

	internal static readonly _200C_200F_202B_200D_200F_200E_200F_200C_200F_202A_200F_200B_200E_200D_200F_200F _95524C911AFEB934ED10A8D7FA3546CD5EBA4BFD0D0E8A1ABB244985A66F2D3F/* Not supported: data(86 54 D0 52 89 29 1D C3 F2 87 5C E1 4D 20 32) */;

	internal static readonly _200E_200E_200C_200E_200E_202A_200F_200E_200F_200F_200E_200F_200F_202A_200E_200E _9B2DB538CF69A1972C2A8ED3FC878BD9DB384B08EECA884A54A654E1C31B0A00/* Not supported: data(D8 BC B3 CE C6 4A 28 B9 B3 F0 9A 09 2B 38 68 B2 D2 65 3A EA EB A9 79 E1 05 21 34 03 2E C5 41 FD) */;

	internal static readonly _200E_200F_200E_200D_200F_200B_200E_200E_200E_202E_200E_202C_200E_200B_200E_200F CEF76AA97553FA0580CBDF91C7D51CE5FA0BF7DFD5DAEC144A2CC9038AB2EDF1/* Not supported: data(1E 8D A7 23 54 41 7D F5 43 F1 89 9B 0B 32 F6 A9 DC 8E 2A E6 D5 63 77 56) */;

	internal static readonly _200E_200E_200C_200E_200E_202A_200F_200E_200F_200F_200E_200F_200F_202A_200E_200E DB1EF895DEFB4B190D7B6E7052EE788DBEACC13DA25027CE1BACF963626E6B0A/* Not supported: data(47 C2 B6 74 A2 5A 8C 7E 2C F7 0D 62 1B 85 82 4C 06 2B F5 9C 7F 72 C2 45 26 A0 94 7D 3F E4 D3 74) */;

	internal static uint _200F_200F_200E_202C_200E_202A_200F_200C_200F_202C_200E_200D_200F_200B_200E_200E(string P_0)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x81
	}
}
internal static class _202B_200F_200C_200C_200F_200D_200F_202B_200E_202C_200E_202A_200F_200D_200F_200E
{
	[CompilerGenerated]
	private static class _200B_200E_200F_200F_200E_202E_200E_202C_200E_200D_200E_200D_200E_200E_200E_200E
	{
		public static ResolveEventHandler _200B_200E_200F_200F_200E_200C_200E_200D_200E_200C_200E_200B_200E_200D_200F_200E;
	}

	internal unsafe static float _202C_200E_202A_200E_200F_202D_200E_200C_200E_200C_200F_200B_200E_202D_200E_200F(int P_0, int P_1)
	{
		bool[] array = (bool[])(object)new int[1] { 2 };
		int num = P_0 ^ P_1;
		while (true)
		{
			uint num2;
			switch ((num2 = 1738837281u) % (uint)((int[])(object)array)[0])
			{
			case 0u:
				continue;
			}
			return *(float*)(&num);
		}
	}

	internal unsafe static double _202A_200F_202B_202E_200E_200D_200E_200C_200E_200C_200F_200B_200E_202D_200E_200F(int P_0, int P_1, int P_2, int P_3)
	{
		bool[] array = (bool[])(object)new int[10] { 11, 960096609, -839684450, 71029927, 169016049, 381509565, 1100680913, -303320758, -415134550, 1884608005 };
		byte[] array3 = default;
		byte[] array2 = default;
		long num3 = default;
		long num4 = default;
		while (true)
		{
			int num = 1214757776;
			while (true)
			{
				uint num2 = (uint)num;
				switch ((uint)num % (uint)((int[])(object)array)[0])
				{
				case 9u:
					break;
				case 2u:
					BitConverter.GetBytes(P_0).CopyTo(array3, 0);
					num = ((((int[])(object)array)[1] + ((int[])(object)array)[0] > ((int[])(object)array)[7]) ? (((int)num2 * -39513103) ^ ((int[])(object)array)[7]) : (((int)num2 * -1992219087) ^ ((int[])(object)array)[6]));
					continue;
				case 8u:
					array3 = new byte[Convert.ToInt32(4.0 + Math.Floor(4.0))];
					num = ((((int[])(object)array)[4] + ((int[])(object)array)[3] == ((int[])(object)array)[1]) ? ((int)(num2 * 1582606522) ^ ((int[])(object)array)[2]) : (((int)num2 * -632194571) ^ ((int[])(object)array)[6]));
					continue;
				case 5u:
					BitConverter.GetBytes(P_2).CopyTo(array2, 0);
					num = ((((int[])(object)array)[0] + ((int[])(object)array)[1] >= ((int[])(object)array)[0]) ? (((int)num2 * -194601490) ^ ((int[])(object)array)[2]) : ((int)(num2 * 222397162) ^ ((int[])(object)array)[2]));
					continue;
				case 4u:
					num3 = BitConverter.ToInt64(array3, 0) ^ num4;
					num = ((((int[])(object)array)[2] + ((int[])(object)array)[5] == ((int[])(object)array)[5]) ? (((int)num2 * -43638552) ^ ((int[])(object)array)[1]) : ((int)(num2 * 1120728710) ^ ((int[])(object)array)[9]));
					continue;
				case 3u:
					num4 = BitConverter.ToInt64(array2, 0);
					num = ((((int[])(object)array)[2] + ((int[])(object)array)[1] < ((int[])(object)array)[3]) ? (((int)num2 * -1638590139) ^ ((int[])(object)array)[1]) : ((int)(num2 * 762150248) ^ ((int[])(object)array)[4]));
					continue;
				case 6u:
					BitConverter.GetBytes(P_3).CopyTo(array2, Convert.ToInt32(2.585786437626905 + Math.Sqrt(2.0)));
					num = ((((int[])(object)array)[2] + ((int[])(object)array)[1] > ((int[])(object)array)[3]) ? ((int)(num2 * 214117564) ^ ((int[])(object)array)[3]) : ((int)(num2 * 2083740177) ^ ((int[])(object)array)[3]));
					continue;
				case 7u:
					BitConverter.GetBytes(P_1).CopyTo(array3, Convert.ToInt32(3.5838531634528574 - Math.Cos(2.0)));
					num = (((((int[])(object)array)[6] ^ ((int[])(object)array)[8]) != ((int[])(object)array)[6]) ? ((int)(num2 * 251019470) ^ ((int[])(object)array)[8]) : (((int)num2 * -991563836) ^ ((int[])(object)array)[6]));
					continue;
				case 0u:
					num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[3]) > ((int[])(object)array)[4]) ? ((int)(num2 * 633454043) ^ ((int[])(object)array)[1]) : (((int)num2 * -425958316) ^ ((int[])(object)array)[5]));
					continue;
				case 1u:
					array2 = new byte[Convert.ToInt32(4.0 + Math.Round(4.0))];
					num = ((((int[])(object)array)[0] + ((int[])(object)array)[0] <= ((int[])(object)array)[0]) ? ((int)(num2 * 914192967) ^ ((int[])(object)array)[1]) : (((int)num2 * -536770711) ^ ((int[])(object)array)[1]));
					continue;
				default:
					return *(double*)(&num3);
				}
				break;
			}
		}
	}

	private static uint _200F_200F_202B_202A_200E_200C_200E_200E_200E_202B_200E_200C_200E_200B_200E_200F(uint P_0, int P_1)
	{
		bool[] array = (bool[])(object)new int[0];
		uint num = P_0 << (P_1 & Convert.ToInt32(46.5 - Math.Abs(15.5)));
		uint num2 = P_0 >> ((Convert.ToInt32(32.287903316665066 + Math.Sin(16.0)) - P_1) & Convert.ToInt32(30.793532518062204 + Math.Sin(15.5)));
		return num | num2;
	}

	private static uint _200E_200F_200D_200F_200E_202C_200E_202B_200E_202E_200E_200D_200F_202B_200F_200E(uint P_0, int P_1)
	{
		bool[] array = (bool[])(object)new int[0];
		uint num = P_0 >> (P_1 & Convert.ToInt32(46.5 - Math.Abs(15.5)));
		uint num2 = P_0 << ((Convert.ToInt32(33.204119982655925 - Math.Log10(16.0)) - P_1) & Convert.ToInt32(47.0 - Math.Round(15.5)));
		return num | num2;
	}

	private static byte[] _202B_200E_202A_202D_200E_202A_200E_202A_200E_200C_200E_200B_200E_202B_200E_200E(byte[] P_0, uint P_1, uint P_2, byte[] P_3)
	{
		bool[] array = (bool[])(object)new int[40]
		{
			46, -1166402130, 1360786497, 731333621, -382891951, 1006774972, -1240691190, 757738467, 939722236, -393294295,
			1782490823, 329328177, -1257418552, -1695285731, 1301936753, 931592562, -2001449127, -327578738, 511497686, 876361352,
			241342176, 453059178, -1133718936, 1901707611, -992471929, -1780697392, -770051097, 1056387648, 836196067, 464340475,
			479527507, -1352543413, 179960081, 2074006360, 1583314870, -736772174, 1228603945, -995787322, 1369244987, -1688785852
		};
		int num4 = default;
		uint num14 = default;
		uint num13 = default;
		uint[] array3 = default;
		uint num5 = default;
		uint num8 = default;
		uint num9 = default;
		uint num10 = default;
		uint num11 = default;
		uint num3 = default;
		uint num7 = default;
		byte[] array2 = default;
		uint[] array4 = default;
		uint num6 = default;
		while (true)
		{
			int num = 1557563399;
			while (true)
			{
				uint num2 = (uint)num;
				switch ((uint)num % (uint)((int[])(object)array)[0])
				{
				case 5u:
					break;
				case 16u:
				{
					ulong num19 = BitConverter.ToUInt64(P_0, num4);
					num14 = (uint)num19;
					num13 = (uint)(num19 >> Convert.ToInt32(48.0 - Math.Round(16.0)));
					num = (((((int[])(object)array)[15] ^ ((int[])(object)array)[3]) <= ((int[])(object)array)[17]) ? ((int)(num2 * 1201794895) ^ ((int[])(object)array)[15]) : ((int[])(object)array)[29]);
					continue;
				}
				case 37u:
					array3[1] = 0u;
					num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[7]) > ((int[])(object)array)[0]) ? ((int)(num2 * 2033032644) ^ ((int[])(object)array)[8]) : ((int)(num2 * 1551551438) ^ ((int[])(object)array)[4]));
					continue;
				case 8u:
					num5 = 1u;
					num = ((((int[])(object)array)[10] + ((int[])(object)array)[8] != ((int[])(object)array)[11]) ? ((int)(num2 * 1342283564) ^ ((int[])(object)array)[13]) : ((int)(num2 * 309384283) ^ ((int[])(object)array)[13]));
					continue;
				case 45u:
					num = ((((int[])(object)array)[14] + ((int[])(object)array)[8] >= ((int[])(object)array)[14]) ? (((int)num2 * -1143480897) ^ ((int[])(object)array)[1]) : ((int)(num2 * 1094563782) ^ ((int[])(object)array)[14]));
					continue;
				case 0u:
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[4]) <= ((int[])(object)array)[4]) ? (((int)num2 * -1393764667) ^ ((int[])(object)array)[1]) : (((int)num2 * -121168265) ^ ((int[])(object)array)[4]));
					continue;
				case 15u:
					num8 = (num9 = (num5 = (num10 = (num11 = 0u))));
					num = ((((int[])(object)array)[12] + ((int[])(object)array)[9] < ((int[])(object)array)[6]) ? ((int)(num2 * 1272041935) ^ ((int[])(object)array)[17]) : ((int)(num2 * 422217849) ^ ((int[])(object)array)[0]));
					continue;
				case 33u:
					array3 = new uint[Convert.ToInt32(1.0 + Math.Truncate(1.0))];
					num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[0]) != ((int[])(object)array)[4]) ? ((int)(num2 * 347340363) ^ ((int[])(object)array)[5]) : (((int)num2 * -554833928) ^ ((int[])(object)array)[1]));
					continue;
				case 30u:
				{
					int num15;
					if (num11 >= (uint)Convert.ToInt32(102.92820323027551 - Math.Sqrt(48.0)))
					{
						num = 1124888714;
						num15 = num;
					}
					else
					{
						num = 1004919790;
						num15 = num;
					}
					continue;
				}
				case 42u:
					num3 = (uint)Convert.ToInt32(1.0 + Math.Floor(1.0));
					num = ((((int[])(object)array)[12] + ((int[])(object)array)[15] == ((int[])(object)array)[18]) ? ((int)(num2 * 1543739928) ^ ((int[])(object)array)[6]) : ((int)(num2 * 1524672005) ^ ((int[])(object)array)[31]));
					continue;
				case 24u:
					num7 = (array3[num10] = _200F_200F_202B_202A_200E_200C_200E_200E_200E_202B_200E_200C_200E_200B_200E_200F(array3[num10] + num8 + num9, (int)(num8 + num9)));
					num = ((((int[])(object)array)[1] + ((int[])(object)array)[9] > ((int[])(object)array)[0]) ? ((int)(num2 * 440554604) ^ ((int[])(object)array)[1]) : ((int)(num2 * 1720280672) ^ ((int[])(object)array)[21]));
					continue;
				case 20u:
					Array.Copy(BitConverter.GetBytes(((ulong)num13 << Convert.ToInt32(29.22741127776022 + Math.Log(16.0))) | num14), 0, array2, num4, Convert.ToInt32(12.0 - Math.Abs(4.0)));
					num = (((((int[])(object)array)[17] ^ ((int[])(object)array)[20]) != ((int[])(object)array)[9]) ? ((int)(num2 * 1512296860) ^ ((int[])(object)array)[38]) : (((int)num2 * -195178690) ^ ((int[])(object)array)[16]));
					continue;
				case 32u:
				{
					int num12;
					if (num3 != 0)
					{
						num = 2000130534;
						num12 = num;
					}
					else
					{
						num = 946917878;
						num12 = num;
					}
					continue;
				}
				case 41u:
					array4 = new uint[Convert.ToInt32(32.957659480323386 + Math.Cos(16.0))];
					num = ((((int[])(object)array)[0] + ((int[])(object)array)[1] < ((int[])(object)array)[0]) ? ((int)(num2 * 384080130) ^ ((int[])(object)array)[1]) : (((int)num2 * -164909842) ^ ((int[])(object)array)[1]));
					continue;
				case 21u:
					num14 -= array4[0];
					num = (((((int[])(object)array)[25] ^ ((int[])(object)array)[26]) == ((int[])(object)array)[9]) ? (((int)num2 * -575982507) ^ ((int[])(object)array)[18]) : ((int)(num2 * 877560034) ^ ((int[])(object)array)[37]));
					continue;
				case 10u:
					num5++;
					num = ((((int[])(object)array)[6] + ((int[])(object)array)[13] != ((int[])(object)array)[15]) ? ((int)(num2 * 365307283) ^ ((int[])(object)array)[16]) : (((int)num2 * -1711868568) ^ ((int[])(object)array)[2]));
					continue;
				case 4u:
					num = (((((int[])(object)array)[7] ^ ((int[])(object)array)[6]) > ((int[])(object)array)[9]) ? ((int)(num2 * 1281317575) ^ ((int[])(object)array)[21]) : ((int)(num2 * 1736273503) ^ ((int[])(object)array)[28]));
					continue;
				case 11u:
					num6 = (uint)Convert.ToInt32(4.416146836547142 + Math.Cos(2.0));
					num = (((((int[])(object)array)[2] ^ ((int[])(object)array)[0]) == ((int[])(object)array)[0]) ? (((int)num2 * -1289670068) ^ ((int[])(object)array)[1]) : ((int)(num2 * 910408167) ^ ((int[])(object)array)[3]));
					continue;
				case 14u:
					num11++;
					num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[16]) > ((int[])(object)array)[21]) ? (((int)num2 * -153127322) ^ ((int[])(object)array)[17]) : (((int)num2 * -521797862) ^ ((int[])(object)array)[23]));
					continue;
				case 28u:
					num = ((((int[])(object)array)[1] + ((int[])(object)array)[1] >= ((int[])(object)array)[1]) ? ((int)(num2 * 405935953) ^ ((int[])(object)array)[2]) : (((int)num2 * -644715449) ^ ((int[])(object)array)[2]));
					continue;
				case 36u:
					num14 = _200E_200F_200D_200F_200E_202C_200E_202B_200E_202E_200E_200D_200F_202B_200F_200E(num14 - array4[Convert.ToInt32(1.0 + Math.Abs(1.0)) * (int)num3], (int)num13) ^ num13;
					num = ((((int[])(object)array)[16] + ((int[])(object)array)[0] <= ((int[])(object)array)[16]) ? ((int)(num2 * 1068301692) ^ ((int[])(object)array)[1]) : (((int)num2 * -490139226) ^ ((int[])(object)array)[34]));
					continue;
				case 38u:
					num9 = num7;
					num = ((((int[])(object)array)[11] + ((int[])(object)array)[14] <= ((int[])(object)array)[1]) ? (((int)num2 * -2084431585) ^ ((int[])(object)array)[7]) : (((int)num2 * -1790121015) ^ ((int[])(object)array)[22]));
					continue;
				case 27u:
				{
					int num18;
					if (num4 >= P_0.Length)
					{
						num = 1469874311;
						num18 = num;
					}
					else
					{
						num = 1936060022;
						num18 = num;
					}
					continue;
				}
				case 9u:
					array4[0] = P_1;
					num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[4]) <= ((int[])(object)array)[12]) ? ((int)(num2 * 1521330040) ^ ((int[])(object)array)[6]) : (((int)num2 * -852415570) ^ ((int[])(object)array)[12]));
					continue;
				case 2u:
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[9]) <= ((int[])(object)array)[0]) ? ((int)(num2 * 739171648) ^ ((int[])(object)array)[2]) : ((int)(num2 * 140540146) ^ ((int[])(object)array)[9]));
					continue;
				case 12u:
					num13 -= array4[1];
					num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[20]) <= ((int[])(object)array)[35]) ? (((int)num2 * -393025962) ^ ((int[])(object)array)[23]) : ((int)(num2 * 327563588) ^ ((int[])(object)array)[36]));
					continue;
				case 26u:
					num13 = _200E_200F_200D_200F_200E_202C_200E_202B_200E_202E_200E_200D_200F_202B_200F_200E(num13 - array4[Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0)) * (int)num3 + 1], (int)num14) ^ num14;
					num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[24]) < ((int[])(object)array)[12]) ? (((int)num2 * -241043390) ^ ((int[])(object)array)[33]) : ((int[])(object)array)[33]);
					continue;
				case 3u:
					num = ((((int[])(object)array)[10] + ((int[])(object)array)[13] == ((int[])(object)array)[6]) ? ((int)(num2 * 1690082176) ^ ((int[])(object)array)[10]) : ((int)(num2 * 77088226) ^ ((int[])(object)array)[18]));
					continue;
				case 18u:
					num7 = (array4[num5] = _200F_200F_202B_202A_200E_200C_200E_200E_200E_202B_200E_200C_200E_200B_200E_200F(array4[num5] + num8 + num9, Convert.ToInt32(3.9974949866040546 - Math.Sin(1.5))));
					num = (((((int[])(object)array)[6] ^ ((int[])(object)array)[4]) == ((int[])(object)array)[15]) ? (((int)num2 * -50253298) ^ ((int[])(object)array)[19]) : ((int[])(object)array)[19]);
					continue;
				case 25u:
					num4 += Convert.ToInt32(6.0 + Math.Sqrt(4.0));
					num = ((((int[])(object)array)[9] + ((int[])(object)array)[12] < ((int[])(object)array)[9]) ? (((int)num2 * -1052453603) ^ ((int[])(object)array)[39]) : (((int)num2 * -1067046983) ^ ((int[])(object)array)[17]));
					continue;
				case 6u:
					num3--;
					num = ((((int[])(object)array)[16] + ((int[])(object)array)[9] != ((int[])(object)array)[14]) ? (((int)num2 * -1557844713) ^ ((int[])(object)array)[35]) : (((int)num2 * -980475630) ^ ((int[])(object)array)[13]));
					continue;
				case 31u:
					num5 = (uint)Convert.ToInt32(7.544068044350276 - Math.Log10(3.5));
					num = (((((int[])(object)array)[5] ^ ((int[])(object)array)[3]) <= ((int[])(object)array)[7]) ? (((int)num2 * -1581534546) ^ ((int[])(object)array)[7]) : ((int)(num2 * 512829171) ^ ((int[])(object)array)[4]));
					continue;
				case 22u:
					array2 = new byte[P_0.Length];
					num = (((((int[])(object)array)[2] ^ ((int[])(object)array)[23]) != ((int[])(object)array)[18]) ? ((int)(num2 * 115433365) ^ ((int[])(object)array)[26]) : ((int)(num2 * 186968590) ^ ((int[])(object)array)[13]));
					continue;
				case 34u:
					num8 = num7;
					num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[13]) < ((int[])(object)array)[6]) ? ((int)(num2 * 93240267) ^ ((int[])(object)array)[20]) : ((int)(num2 * 681790698) ^ ((int[])(object)array)[16]));
					continue;
				case 40u:
					num10 = (num10 + 1) % (uint)Convert.ToInt32(3.0 - Math.Abs(1.0));
					num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[11]) <= ((int[])(object)array)[2]) ? (((int)num2 * -838511744) ^ ((int[])(object)array)[25]) : (((int)num2 * -1906000365) ^ ((int[])(object)array)[12]));
					continue;
				case 1u:
					num4 = 0;
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[11]) > ((int[])(object)array)[8]) ? ((int)(num2 * 714787639) ^ ((int[])(object)array)[14]) : (((int)num2 * -114274360) ^ ((int[])(object)array)[27]));
					continue;
				case 19u:
				{
					int num17;
					if (num5 != uint.MaxValue)
					{
						num = 543208202;
						num17 = num;
					}
					else
					{
						num = 1565433139;
						num17 = num;
					}
					continue;
				}
				case 29u:
				{
					int num16;
					if (num5 < (uint)Convert.ToInt32(16.0 + Math.Ceiling(16.0)))
					{
						num = 745875599;
						num16 = num;
					}
					else
					{
						num = 774422067;
						num16 = num;
					}
					continue;
				}
				case 13u:
					num = ((((int[])(object)array)[4] + ((int[])(object)array)[2] == ((int[])(object)array)[0]) ? ((int)(num2 * 512515504) ^ ((int[])(object)array)[1]) : (((int)num2 * -1748518681) ^ ((int[])(object)array)[6]));
					continue;
				case 39u:
					num5 = (num5 + 1) % (uint)Convert.ToInt32(48.0 - Math.Round(16.0));
					num = (((((int[])(object)array)[19] ^ ((int[])(object)array)[1]) == ((int[])(object)array)[2]) ? (((int)num2 * -915015567) ^ ((int[])(object)array)[0]) : ((int)(num2 * 1950763665) ^ ((int[])(object)array)[24]));
					continue;
				case 35u:
					num = ((((int[])(object)array)[20] + ((int[])(object)array)[8] >= ((int[])(object)array)[18]) ? (((int)num2 * -1556262929) ^ ((int[])(object)array)[32]) : ((int)(num2 * 1189703314) ^ ((int[])(object)array)[21]));
					continue;
				case 23u:
					num5--;
					num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[11]) == ((int[])(object)array)[11]) ? (((int)num2 * -1730740810) ^ ((int[])(object)array)[2]) : ((int)(num2 * 1703966712) ^ ((int[])(object)array)[11]));
					continue;
				case 43u:
					array4[num5] = array4[num5 - 1] + P_2;
					num = (((((int[])(object)array)[6] ^ ((int[])(object)array)[14]) > ((int[])(object)array)[6]) ? ((int[])(object)array)[15] : ((int)(num2 * 1782568891) ^ ((int[])(object)array)[12]));
					continue;
				case 44u:
					array3[num5 / num6] = (array3[num5 / num6] << Convert.ToInt32(10.0 - Math.Sqrt(4.0))) + P_3[num5];
					num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[0]) <= ((int[])(object)array)[10]) ? ((int[])(object)array)[10] : (((int)num2 * -1905920802) ^ ((int[])(object)array)[2]));
					continue;
				case 7u:
					num = ((((int[])(object)array)[19] + ((int[])(object)array)[6] > ((int[])(object)array)[27]) ? (((int)num2 * -1617683902) ^ ((int[])(object)array)[0]) : (((int)num2 * -411686083) ^ ((int[])(object)array)[30]));
					continue;
				default:
					return array2;
				}
				break;
			}
		}
	}

	internal static string _202A_200F_200F_202B_200E_202C_200E_200B_200E_200F_200F_200C_200E_200D_200F_200F(string P_0, int P_1, byte[] P_2, uint[] P_3)
	{
		bool[] array = (bool[])(object)new int[7] { 9, 1222303047, -1324269990, -797857217, 486017487, -1236139440, -1005688287 };
		char[] array2 = P_0.ToCharArray();
		int num3 = default;
		byte[] array4 = default;
		byte[] array3 = default;
		while (true)
		{
			int num = 1694575975;
			while (true)
			{
				uint num2 = (uint)num;
				switch ((uint)num % (uint)((int[])(object)array)[0])
				{
				case 2u:
					break;
				case 0u:
					num3++;
					num = ((((int[])(object)array)[3] + ((int[])(object)array)[3] <= ((int[])(object)array)[3]) ? ((int)(num2 * 1315680929) ^ ((int[])(object)array)[5]) : (((int)num2 * -1341078235) ^ ((int[])(object)array)[4]));
					continue;
				case 3u:
					array4[num3] = (byte)array2[num3];
					num = ((((int[])(object)array)[0] + ((int[])(object)array)[2] != ((int[])(object)array)[0]) ? ((int[])(object)array)[4] : (((int)num2 * -1312723727) ^ ((int[])(object)array)[4]));
					continue;
				case 1u:
				{
					byte[] sourceArray = _202B_200E_202A_202D_200E_202A_200E_202A_200E_200C_200E_200B_200E_202B_200E_200E(array4, P_3[0], P_3[1], P_2);
					array3 = new byte[P_1];
					Array.Copy(sourceArray, array3, P_1);
					num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[5]) == ((int[])(object)array)[0]) ? (((int)num2 * -1800799008) ^ ((int[])(object)array)[6]) : (((int)num2 * -1386243565) ^ ((int[])(object)array)[6]));
					continue;
				}
				case 8u:
					num3 = 0;
					num = ((((int[])(object)array)[2] + ((int[])(object)array)[0] >= ((int[])(object)array)[0]) ? (((int)num2 * -1061253835) ^ ((int[])(object)array)[0]) : (((int)num2 * -1493943750) ^ ((int[])(object)array)[2]));
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= array2.Length)
					{
						num = 1084821454;
						num4 = num;
					}
					else
					{
						num = 1070144391;
						num4 = num;
					}
					continue;
				}
				case 4u:
					array4 = new byte[array2.Length];
					num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[1]) < ((int[])(object)array)[0]) ? (((int)num2 * -782880968) ^ ((int[])(object)array)[1]) : ((int)(num2 * 1014302526) ^ ((int[])(object)array)[1]));
					continue;
				case 7u:
					num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[3]) > ((int[])(object)array)[1]) ? (((int)num2 * -1272363967) ^ ((int[])(object)array)[1]) : (((int)num2 * -1664137608) ^ ((int[])(object)array)[3]));
					continue;
				default:
					return Encoding.Unicode.GetString(array3);
				}
				break;
			}
		}
	}

	internal static void _202E_200E_200C_200E_200F_200C_200E_202A_200F_202B_200F_200B_200E_202E_200E_200E()
	{
		bool[] array = (bool[])(object)new int[1] { 2 };
		AppDomain.CurrentDomain.AssemblyResolve += _200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_200D_200F_202B_200F_200F;
		while (true)
		{
			uint num;
			switch ((num = 1924856201u) % (uint)((int[])(object)array)[0])
			{
			case 0u:
				break;
			default:
				return;
			case 1u:
				return;
			}
		}
	}

	private static Assembly _200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_200D_200F_202B_200F_200F(object P_0, ResolveEventArgs P_1)
	{
		bool[] array = (bool[])(object)new int[7] { 6, -1144022401, -1422894229, -1693695699, 340867546, 3, 1580237404 };
		Assembly result = default;
		try
		{
			byte[] array2 = _200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_200D_200F_200F_200F_200F(P_1.Name.Split((char)Convert.ToInt32(66.0 - Math.Ceiling(22.0)))[0]);
			while (true)
			{
				IL_0071:
				int num = 1884829045;
				while (true)
				{
					uint num2 = (uint)num;
					switch ((uint)num % (uint)((int[])(object)array)[0])
					{
					case 0u:
						break;
					default:
						goto end_IL_0076;
					case 1u:
					{
						int num3;
						int num4;
						if (array2 != null)
						{
							num3 = 310475878;
							num4 = num3;
						}
						else
						{
							num3 = 320936756;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * ((int[])(object)array)[1]);
						continue;
					}
					case 5u:
						result = null;
						num = (((((int[])(object)array)[2] ^ ((int[])(object)array)[0]) > ((int[])(object)array)[0]) ? ((int)(num2 * 1607201194) ^ ((int[])(object)array)[0]) : (((int)num2 * -1571418443) ^ ((int[])(object)array)[2]));
						continue;
					case 2u:
						goto end_IL_0076;
					case 3u:
						result = AppDomain.CurrentDomain.Load(array2);
						num = (((((int[])(object)array)[2] ^ ((int[])(object)array)[0]) == ((int[])(object)array)[1]) ? (((int)num2 * -416857408) ^ ((int[])(object)array)[0]) : ((int[])(object)array)[4]);
						continue;
					case 4u:
						goto end_IL_0076;
					}
					goto IL_0071;
					continue;
					end_IL_0076:
					break;
				}
				break;
			}
		}
		catch
		{
			while (true)
			{
				IL_014a:
				int num5 = 1321001938;
				while (true)
				{
					uint num2 = (uint)num5;
					switch ((uint)num5 % (uint)((int[])(object)array)[5])
					{
					case 0u:
						break;
					default:
						goto end_IL_014f;
					case 1u:
						result = null;
						num5 = ((((int[])(object)array)[5] + ((int[])(object)array)[1] < ((int[])(object)array)[4]) ? ((int)(num2 * 416047712) ^ ((int[])(object)array)[6]) : (((int)num2 * -1752627301) ^ ((int[])(object)array)[3]));
						continue;
					case 2u:
						goto end_IL_014f;
					}
					goto IL_014a;
					continue;
					end_IL_014f:
					break;
				}
				break;
			}
		}
		return result;
	}

	private static string _202E_200E_202D_200F_200F_202B_200E_202E_200E_200F_200E_200D_200E_202A_200E_200E(string P_0)
	{
		//IL_0879: Expected I4, but got I8
		//IL_0885: Expected I4, but got I8
		//IL_0d6b: Expected I4, but got I8
		//IL_0d77: Expected I4, but got I8
		bool[] array = (bool[])(object)new int[22]
		{
			28, 2103483098, 2009428859, 362462244, -1062176831, 621705299, -1718912394, -920224183, -1720782577, -958761965,
			-1953209707, -937909585, 269694423, 1187553098, 418188160, 250443553, -845027883, -378144692, 1943615179, 1996110979,
			1104077157, -541715819
		};
		if (string.IsNullOrEmpty(P_0))
		{
			goto IL_00ce;
		}
		goto IL_0b12;
		IL_00ce:
		int num = 83922782;
		goto IL_00d3;
		IL_00d3:
		uint num2 = default;
		int num7 = default;
		int num4 = default;
		int num5 = default;
		int num10 = default;
		while (true)
		{
			num2 = (uint)num;
			switch ((uint)num % (uint)((int[])(object)array)[0])
			{
			case 17u:
				break;
			case 19u:
				goto IL_0155;
			case 2u:
			{
				int num8;
				int num9;
				if (num7 + 1 < P_0.Length)
				{
					num8 = -277116399;
					num9 = num8;
				}
				else
				{
					num8 = -1400909881;
					num9 = num8;
				}
				num = num8 ^ ((int)num2 * ((int[])(object)array)[14]);
				continue;
			}
			case 3u:
				goto IL_01b2;
			case 12u:
				goto IL_025c;
			case 7u:
				goto IL_0298;
			case 27u:
				goto IL_02b5;
			case 22u:
				goto IL_032a;
			case 5u:
				goto IL_037d;
			case 14u:
				goto IL_039c;
			case 13u:
				goto IL_0421;
			case 26u:
				goto IL_0459;
			case 11u:
				goto IL_04cc;
			case 24u:
				goto IL_0502;
			case 23u:
				goto IL_0538;
			case 21u:
				goto IL_0588;
			case 18u:
				goto IL_05bf;
			case 1u:
				goto IL_05f4;
			case 6u:
			{
				int num6 = Convert.ToInt32(13.380515006246586 + Math.Tan(5.0));
				byte[] array4 = new byte[Convert.ToInt32(6.842178717650422 + Math.Tan(4.0))];
				array4[0] = (byte)Convert.ToInt32(186.2667994305757 + Math.Cos(93.5));
				array4[1] = (byte)Convert.ToInt32(121.0 + Math.Floor(120.5));
				array4[Convert.ToInt32(1.0 + Math.Floor(1.0))] = (byte)Convert.ToInt32(240.0 + Math.Tanh(120.5));
				array4[Convert.ToInt32(3.070737201667703 - Math.Cos(1.5))] = (byte)Convert.ToInt32(93.0 - Math.Floor(31.0));
				array4[Convert.ToInt32(4.416146836547142 + Math.Cos(2.0))] = (byte)Convert.ToInt32(98.30059254374363 - Math.Cos(49.0));
				array4[Convert.ToInt32(5.747022297238661 + Math.Tan(2.5))] = (byte)Convert.ToInt32(82.3767507096021 + Math.Log10(42.0));
				array4[Convert.ToInt32(7.732050807568877 - Math.Sqrt(3.0))] = (byte)Convert.ToInt32(89.0 - Math.Tanh(44.0));
				array4[Convert.ToInt32(11.0 - Math.Round(3.5))] = (byte)Convert.ToInt32(176.1399382837638 + Math.Cos(88.5));
				uint[] array5 = new uint[Convert.ToInt32(2.5403023058681398 - Math.Cos(1.0))];
				array5[0] = 4164532716u;
				array5[1] = 907187459u;
				return string.Format(_202A_200F_200F_202B_200E_202C_200E_200B_200E_200F_200F_200C_200E_200D_200F_200F("\u0013.\u001cX\u009bÞ#^*!\u001cL\u0096$¶°", num6, (byte[])(object)array4, (uint[])(object)array5), Convert.ToInt32(127.11903717481248 - Math.Log(61.5)));
			}
			case 16u:
				goto IL_08e8;
			case 15u:
				goto IL_0941;
			case 20u:
				goto IL_0978;
			case 25u:
				goto IL_09fa;
			case 8u:
				goto IL_0aa6;
			case 0u:
				goto IL_0ac3;
			case 9u:
				goto IL_0afa;
			case 4u:
				goto IL_0b12;
			default:
			{
				int num3 = Convert.ToInt32(5.0 + Math.Truncate(5.0));
				byte[] array2 = new byte[Convert.ToInt32(4.0 + Math.Ceiling(4.0))];
				array2[0] = (byte)Convert.ToInt32(149.78222150000354 + Math.Sin(74.5));
				array2[1] = (byte)Convert.ToInt32(68.6124860801609 - Math.Sqrt(31.5));
				array2[Convert.ToInt32(2.8414709848078967 - Math.Sin(1.0))] = (byte)Convert.ToInt32(29.0 + Math.Round(29.5));
				array2[Convert.ToInt32(1.0 + Math.Ceiling(1.5))] = (byte)Convert.ToInt32(316.0 - Math.Truncate(105.5));
				array2[Convert.ToInt32(5.414213562373095 - Math.Sqrt(2.0))] = (byte)Convert.ToInt32(84.0 + Math.Abs(84.0));
				array2[Convert.ToInt32(3.41886116991581 + Math.Sqrt(2.5))] = (byte)Convert.ToInt32(135.0 - Math.Truncate(45.0));
				array2[Convert.ToInt32(6.989992496600445 + Math.Cos(3.0))] = (byte)Convert.ToInt32(23.000000000075502 + Math.Tanh(12.0));
				array2[Convert.ToInt32(10.0 - Math.Truncate(3.5))] = (byte)Convert.ToInt32(127.0 + Math.Abs(127.0));
				uint[] array3 = new uint[Convert.ToInt32(2.0 - Math.Log(1.0))];
				array3[0] = 3995576877u;
				array3[1] = 3142795940u;
				return string.Format(_202A_200F_200F_202B_200E_202C_200E_200B_200E_200F_200F_200C_200E_200D_200F_200F("7Ò\u0002§Ó\u0006&\b\u0093ël\u001a\u0016\f¥\u008d", num3, (byte[])(object)array2, (uint[])(object)array3), (uint)(num4 + num5 * Convert.ToInt32(2349125912.0 - Math.Ceiling(783041970.5))));
			}
			}
			break;
			IL_0afa:
			int num11;
			if (num10 > 0)
			{
				num = 1849973165;
				num11 = num;
			}
			else
			{
				num = 2068611002;
				num11 = num;
			}
			continue;
			IL_037d:
			int num12;
			if (num7 + 1 < P_0.Length)
			{
				num = 436788495;
				num12 = num;
			}
			else
			{
				num = 234313892;
				num12 = num;
			}
			continue;
			IL_05bf:
			num = (((((int[])(object)array)[2] ^ ((int[])(object)array)[4]) > ((int[])(object)array)[4]) ? ((int)(num2 * 256281337) ^ ((int[])(object)array)[7]) : (((int)num2 * -1525983386) ^ ((int[])(object)array)[7]));
			continue;
			IL_0ac3:
			num = ((((int[])(object)array)[3] + ((int[])(object)array)[9] != ((int[])(object)array)[8]) ? (((int)num2 * -1212087877) ^ ((int[])(object)array)[9]) : ((int)(num2 * 1129899703) ^ ((int[])(object)array)[6]));
			continue;
			IL_0459:
			num4 = ((num4 << Convert.ToInt32(5.801143615546934 + Math.Cos(2.5))) + num4 + (num4 >> Convert.ToInt32(25.64892165271299 + Math.Tan(13.5)))) ^ 0;
			num = (((((int[])(object)array)[6] ^ ((int[])(object)array)[5]) >= ((int[])(object)array)[1]) ? ((int)(num2 * 762909224) ^ ((int[])(object)array)[2]) : ((int[])(object)array)[12]);
			continue;
			IL_0155:
			int num13;
			if (num10 > Convert.ToInt32(3.0 - Math.Abs(1.0)))
			{
				num = 1016016192;
				num13 = num;
			}
			else
			{
				num = 2068611002;
				num13 = num;
			}
			continue;
			IL_0aa6:
			int num14;
			if (num7 < P_0.Length)
			{
				num = 1850064012;
				num14 = num;
			}
			else
			{
				num = 372653566;
				num14 = num;
			}
			continue;
			IL_0588:
			num = ((((int[])(object)array)[8] + ((int[])(object)array)[1] != ((int[])(object)array)[7]) ? ((int)(num2 * 2051372952) ^ ((int[])(object)array)[11]) : ((int)(num2 * 383667706) ^ ((int[])(object)array)[11]));
			continue;
			IL_025c:
			num10 = P_0.Length;
			num = (((((int[])(object)array)[6] ^ ((int[])(object)array)[2]) >= ((int[])(object)array)[0]) ? (((int)num2 * -1773822556) ^ ((int[])(object)array)[1]) : ((int)(num2 * 691290052) ^ ((int[])(object)array)[6]));
			continue;
			IL_09fa:
			num5 = ((num5 << Convert.ToInt32(2.5 + Math.Abs(2.5))) + num5 + (num5 >> Convert.ToInt32(26.405079336690108 + Math.Cos(13.5)))) ^ (int)(P_0[num7] | ((uint)P_0[num7 + 1] << Convert.ToInt32(15.096910013008056 + Math.Log10(8.0))));
			num = ((((int[])(object)array)[4] + ((int[])(object)array)[0] >= ((int[])(object)array)[14]) ? ((int)(num2 * 593471267) ^ ((int[])(object)array)[1]) : ((int)(num2 * 770084160) ^ ((int[])(object)array)[15]));
			continue;
			IL_0421:
			num = (((((int[])(object)array)[5] ^ ((int[])(object)array)[9]) < ((int[])(object)array)[2]) ? ((int)(num2 * 431787286) ^ ((int[])(object)array)[16]) : (((int)num2 * -709767266) ^ ((int[])(object)array)[12]));
			continue;
			IL_0538:
			num7 += Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0));
			num = (((((int[])(object)array)[13] ^ ((int[])(object)array)[5]) != ((int[])(object)array)[14]) ? ((int[])(object)array)[20] : (((int)num2 * -1532156830) ^ ((int[])(object)array)[5]));
			continue;
			IL_0978:
			num4 = ((num4 << Convert.ToInt32(3.41886116991581 + Math.Sqrt(2.5))) + num4 + (num4 >> Convert.ToInt32(13.0 + Math.Ceiling(13.5)))) ^ P_0[num7];
			num = ((((int[])(object)array)[7] + ((int[])(object)array)[5] == ((int[])(object)array)[6]) ? (((int)num2 * -1536354925) ^ ((int[])(object)array)[3]) : ((int)(num2 * 2076961824) ^ ((int[])(object)array)[10]));
			continue;
			IL_032a:
			num4 = Convert.ToInt32(528981895.5 - Math.Abs(176327298.5));
			num = ((((int[])(object)array)[1] + ((int[])(object)array)[1] > ((int[])(object)array)[3]) ? (((int)num2 * -934027700) ^ ((int[])(object)array)[1]) : ((int)(num2 * 1753140019) ^ ((int[])(object)array)[4]));
			continue;
			IL_0298:
			int num15;
			if (num7 < P_0.Length)
			{
				num = 357387814;
				num15 = num;
			}
			else
			{
				num = 149346651;
				num15 = num;
			}
			continue;
			IL_0941:
			num5 = num4;
			num = ((((int[])(object)array)[4] + ((int[])(object)array)[5] == ((int[])(object)array)[1]) ? ((int)(num2 * 1311927251) ^ ((int[])(object)array)[5]) : (((int)num2 * -1822741903) ^ ((int[])(object)array)[5]));
			continue;
			IL_0502:
			num = ((((int[])(object)array)[4] + ((int[])(object)array)[8] != ((int[])(object)array)[1]) ? (((int)num2 * -477794097) ^ ((int[])(object)array)[18]) : ((int)(num2 * 205167791) ^ ((int[])(object)array)[4]));
			continue;
			IL_039c:
			num5 = ((num5 << Convert.ToInt32(7.0 - Math.Truncate(2.5))) + num5 + (num5 >> Convert.ToInt32(14.0 + Math.Floor(13.5)))) ^ P_0[num7];
			num = (((((int[])(object)array)[13] ^ ((int[])(object)array)[13]) <= ((int[])(object)array)[7]) ? (((int)num2 * -2143962218) ^ ((int[])(object)array)[10]) : ((int)(num2 * 1491355806) ^ ((int[])(object)array)[17]));
			continue;
			IL_08e8:
			num7 += Convert.ToInt32(1.0 + Math.Abs(1.0));
			num = (((((int[])(object)array)[12] ^ ((int[])(object)array)[10]) < ((int[])(object)array)[0]) ? ((int)(num2 * 681546750) ^ ((int[])(object)array)[13]) : ((int)(num2 * 357837240) ^ ((int[])(object)array)[5]));
			continue;
			IL_01b2:
			num4 = ((num4 << Convert.ToInt32(4.01338570184857 + Math.Tanh(2.5))) + num4 + (num4 >> Convert.ToInt32(40.0 - Math.Truncate(13.5)))) ^ (int)(P_0[num7] | ((uint)P_0[num7 + 1] << Convert.ToInt32(15.854499966191387 - Math.Cos(8.0))));
			num = (((((int[])(object)array)[7] ^ ((int[])(object)array)[0]) == ((int[])(object)array)[2]) ? (((int)num2 * -1963634744) ^ ((int[])(object)array)[3]) : ((int)(num2 * 670707661) ^ ((int[])(object)array)[8]));
			continue;
			IL_04cc:
			num = ((((int[])(object)array)[1] + ((int[])(object)array)[1] == ((int[])(object)array)[3]) ? (((int)num2 * -552304313) ^ ((int[])(object)array)[1]) : (((int)num2 * -683032666) ^ ((int[])(object)array)[3]));
			continue;
			IL_05f4:
			num10 -= Convert.ToInt32(4.301029995663981 - Math.Log10(2.0));
			num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[20]) != ((int[])(object)array)[17]) ? (((int)num2 * -1153730696) ^ ((int[])(object)array)[21]) : (((int)num2 * -1902118586) ^ ((int[])(object)array)[15]));
			continue;
			IL_02b5:
			num5 = ((num5 << Convert.ToInt32(7.0 - Math.Floor(2.5))) + num5 + (num5 >> Convert.ToInt32(40.0 - Math.Floor(13.5)))) ^ 0;
			num = (((((int[])(object)array)[11] ^ ((int[])(object)array)[15]) != ((int[])(object)array)[5]) ? ((int[])(object)array)[19] : (((int)num2 * -147852153) ^ ((int[])(object)array)[7]));
		}
		goto IL_00ce;
		IL_0b12:
		num7 = 0;
		num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[1]) > ((int[])(object)array)[1]) ? (((int)num2 * -443510831) ^ ((int[])(object)array)[0]) : ((int[])(object)array)[2]);
		goto IL_00d3;
	}

	private static byte[] _200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_200D_200F_200F_200F_200F(string P_0)
	{
		bool[] array = (bool[])(object)new int[25]
		{
			5, 35906654, -1347544466, 751421124, 11, -1332259748, -253895847, 91022109, -836132245, -1913066418,
			61417249, 1796310581, -313754050, -1774592083, 6, 1636067284, 2055388793, 1206181840, 731668798, 4,
			1369800020, -1253885355, 3, -938503098, 2
		};
		Stream manifestResourceStream = typeof(_202B_200F_200C_200C_200F_200D_200F_202B_200E_202C_200E_202A_200F_200D_200F_200E).Module.Assembly.GetManifestResourceStream(_202E_200E_202D_200F_200F_202B_200E_202E_200E_200F_200E_200D_200E_202A_200E_200E(P_0));
		byte[] array3 = default;
		RijndaelManaged rijndaelManaged = default;
		byte[] array6 = default;
		MemoryStream memoryStream = default;
		int num5 = default;
		byte[] array5 = default;
		byte[] result = default;
		while (true)
		{
			int num = 1316703027;
			while (true)
			{
				uint num2 = (uint)num;
				switch ((uint)num % (uint)((int[])(object)array)[0])
				{
				case 4u:
					break;
				case 2u:
					if (manifestResourceStream != null)
					{
						num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[1]) > ((int[])(object)array)[0]) ? (((int)num2 * -846932635) ^ ((int[])(object)array)[1]) : (((int)num2 * -411245794) ^ ((int[])(object)array)[0]));
						continue;
					}
					return null;
				case 1u:
					manifestResourceStream.Read(array3, 0, array3.Length);
					num = ((((int[])(object)array)[0] + ((int[])(object)array)[3] >= ((int[])(object)array)[0]) ? (((int)num2 * -1709973629) ^ ((int[])(object)array)[3]) : ((int)(num2 * 2142580511) ^ ((int[])(object)array)[2]));
					continue;
				case 3u:
					array3 = new byte[manifestResourceStream.Length];
					num = ((((int[])(object)array)[0] + ((int[])(object)array)[2] != ((int[])(object)array)[0]) ? (((int)num2 * -397027810) ^ ((int[])(object)array)[2]) : (((int)num2 * -264321938) ^ ((int[])(object)array)[1]));
					continue;
				default:
					manifestResourceStream.Seek(0L, SeekOrigin.Begin);
					try
					{
						byte[] array2 = array3;
						while (true)
						{
							IL_01d9:
							int num3 = 1508373215;
							while (true)
							{
								num2 = (uint)num3;
								switch ((uint)num3 % (uint)((int[])(object)array)[4])
								{
								case 6u:
									break;
								case 3u:
									rijndaelManaged.Padding = (PaddingMode)Convert.ToInt32(3.0 - Math.Floor(1.0));
									num3 = (((((int[])(object)array)[3] ^ ((int[])(object)array)[10]) == ((int[])(object)array)[0]) ? (((int)num2 * -415616290) ^ ((int[])(object)array)[10]) : (((int)num2 * -1344816702) ^ ((int[])(object)array)[11]));
									continue;
								case 4u:
									rijndaelManaged = new RijndaelManaged();
									num3 = ((((int[])(object)array)[3] + ((int[])(object)array)[7] > ((int[])(object)array)[3]) ? (((int)num2 * -1666245413) ^ ((int[])(object)array)[9]) : ((int)(num2 * 1767071284) ^ ((int[])(object)array)[1]));
									continue;
								case 9u:
									rijndaelManaged.KeySize = Convert.ToInt32(128.0 + Math.Abs(128.0));
									num3 = (((((int[])(object)array)[6] ^ ((int[])(object)array)[7]) >= ((int[])(object)array)[10]) ? (((int)num2 * -1512647173) ^ ((int[])(object)array)[0]) : (((int)num2 * -196726955) ^ ((int[])(object)array)[12]));
									continue;
								case 8u:
									num3 = (((((int[])(object)array)[3] ^ ((int[])(object)array)[4]) < ((int[])(object)array)[5]) ? (((int)num2 * -1167211743) ^ ((int[])(object)array)[0]) : (((int)num2 * -1403180306) ^ ((int[])(object)array)[5]));
									continue;
								case 2u:
									Array.Copy(Encoding.UTF8.GetBytes(P_0.PadRight(array6.Length)), array6, array6.Length);
									num3 = (((((int[])(object)array)[5] ^ ((int[])(object)array)[4]) < ((int[])(object)array)[6]) ? ((int)(num2 * 457831501) ^ ((int[])(object)array)[7]) : ((int)(num2 * 747686747) ^ ((int[])(object)array)[5]));
									continue;
								case 1u:
									memoryStream = new MemoryStream(array2);
									num3 = ((((int[])(object)array)[7] + ((int[])(object)array)[4] <= ((int[])(object)array)[5]) ? (((int)num2 * -1433290769) ^ ((int[])(object)array)[1]) : (((int)num2 * -1603204991) ^ ((int[])(object)array)[8]));
									continue;
								case 0u:
									rijndaelManaged.Mode = (CipherMode)Convert.ToInt32(3.0 - Math.Sqrt(1.0));
									num3 = ((((int[])(object)array)[7] + ((int[])(object)array)[3] > ((int[])(object)array)[10]) ? (((int)num2 * -1465882331) ^ ((int[])(object)array)[10]) : (((int)num2 * -2055047803) ^ ((int[])(object)array)[9]));
									continue;
								case 5u:
									array6 = new byte[Convert.ToInt32(32.287903316665066 + Math.Sin(16.0))];
									num3 = (((((int[])(object)array)[3] ^ ((int[])(object)array)[3]) <= ((int[])(object)array)[6]) ? (((int)num2 * -1426341482) ^ ((int[])(object)array)[2]) : ((int)(num2 * 110314683) ^ ((int[])(object)array)[6]));
									continue;
								case 10u:
									rijndaelManaged.Key = array6;
									num3 = ((((int[])(object)array)[9] + ((int[])(object)array)[8] >= ((int[])(object)array)[5]) ? (((int)num2 * -1874761568) ^ ((int[])(object)array)[13]) : ((int)(num2 * 1857499217) ^ ((int[])(object)array)[9]));
									continue;
								default:
								{
									CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
									try
									{
										byte[] array4 = new byte[array2.Length + Convert.ToInt32(28.0 + Math.Sqrt(16.0))];
										while (true)
										{
											IL_0505:
											int num4 = 86446911;
											while (true)
											{
												num2 = (uint)num4;
												switch ((uint)num4 % (uint)((int[])(object)array)[14])
												{
												case 4u:
													break;
												default:
													goto end_IL_050a;
												case 3u:
													num5 = cryptoStream.Read(array4, 0, array2.Length + Convert.ToInt32(32.3006322420239 - Math.Tan(16.0)));
													num4 = (((((int[])(object)array)[0] ^ ((int[])(object)array)[13]) > ((int[])(object)array)[9]) ? ((int)(num2 * 1940210795) ^ ((int[])(object)array)[15]) : ((int)(num2 * 1604761549) ^ ((int[])(object)array)[9]));
													continue;
												case 5u:
													Array.Copy(array4, 0, array5, 0, num5);
													num4 = ((((int[])(object)array)[5] + ((int[])(object)array)[16] == ((int[])(object)array)[5]) ? ((int)(num2 * 791663111) ^ ((int[])(object)array)[12]) : ((int)(num2 * 836553608) ^ ((int[])(object)array)[17]));
													continue;
												case 0u:
													result = array5;
													num4 = (((((int[])(object)array)[3] ^ ((int[])(object)array)[16]) >= ((int[])(object)array)[12]) ? (((int)num2 * -1678157354) ^ ((int[])(object)array)[18]) : ((int)(num2 * 359628834) ^ ((int[])(object)array)[4]));
													continue;
												case 1u:
													array5 = new byte[num5];
													num4 = (((((int[])(object)array)[16] ^ ((int[])(object)array)[14]) != ((int[])(object)array)[6]) ? (((int)num2 * -402148316) ^ ((int[])(object)array)[16]) : ((int)(num2 * 2130825254) ^ ((int[])(object)array)[13]));
													continue;
												case 2u:
													goto end_IL_050a;
												}
												goto IL_0505;
												continue;
												end_IL_050a:
												break;
											}
											break;
										}
									}
									finally
									{
										cryptoStream.Close();
										while (true)
										{
											IL_0668:
											int num6 = 705881835;
											while (true)
											{
												num2 = (uint)num6;
												switch ((uint)num6 % (uint)((int[])(object)array)[19])
												{
												case 2u:
													break;
												default:
													goto end_IL_066d;
												case 3u:
													memoryStream.Close();
													num6 = ((((int[])(object)array)[18] + ((int[])(object)array)[2] == ((int[])(object)array)[2]) ? ((int)(num2 * 608069724) ^ ((int[])(object)array)[6]) : (((int)num2 * -375187308) ^ ((int[])(object)array)[20]));
													continue;
												case 0u:
													rijndaelManaged.Clear();
													num6 = (((((int[])(object)array)[20] ^ ((int[])(object)array)[16]) == ((int[])(object)array)[11]) ? ((int)(num2 * 23700827) ^ ((int[])(object)array)[8]) : (((int)num2 * -1683879526) ^ ((int[])(object)array)[21]));
													continue;
												case 1u:
													goto end_IL_066d;
												}
												goto IL_0668;
												continue;
												end_IL_066d:
												break;
											}
											break;
										}
									}
									goto end_IL_01de;
								}
								}
								goto IL_01d9;
								continue;
								end_IL_01de:
								break;
							}
							break;
						}
					}
					catch
					{
						while (true)
						{
							IL_0707:
							int num7 = 1838035717;
							while (true)
							{
								num2 = (uint)num7;
								switch ((uint)num7 % (uint)((int[])(object)array)[22])
								{
								case 2u:
									break;
								default:
									goto end_IL_070c;
								case 1u:
									result = null;
									num7 = ((((int[])(object)array)[11] + ((int[])(object)array)[1] < ((int[])(object)array)[20]) ? (((int)num2 * -1731093162) ^ ((int[])(object)array)[23]) : ((int)(num2 * 652156177) ^ ((int[])(object)array)[23]));
									continue;
								case 0u:
									goto end_IL_070c;
								}
								goto IL_0707;
								continue;
								end_IL_070c:
								break;
							}
							break;
						}
					}
					return result;
				}
				break;
			}
		}
	}
}
internal static class _200D_200E_200D_202D_200E_202A_200F_202A_200F_200E_200E_200E_200F_202A_200F_200E
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate bool _200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_202A_200F_200C_200F_200F(IntPtr P_0, uint P_1, uint P_2, out uint P_3);

	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle", SetLastError = true)]
	private static extern IntPtr _200F_200F_200D_202B_200F_202E_200E_200D_200E_202E_200E_200E_200E_200F_200F_200E(string P_0);

	[DllImport("kernel32.dll", EntryPoint = "GetProcAddress", SetLastError = true)]
	private static extern IntPtr _202B_200F_202E_200B_200E_202E_200E_202C_200E_202A_200F_200C_200E_200E(IntPtr P_0, string P_1);

	private static _200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_202A_200F_200C_200F_200F _200E_200E_202A_202B_200E_200C_200E_200B_200E_200E_200E_200C_200E_202B_200F_200F()
	{
		//IL_0232: Expected I4, but got I8
		//IL_023e: Expected I4, but got I8
		//IL_0473: Expected I4, but got I8
		//IL_047f: Expected I4, but got I8
		bool[] array = (bool[])(object)new int[0];
		int num = Convert.ToInt32(23.463427081999566 - Math.Sin(12.0));
		byte[] array2 = new byte[Convert.ToInt32(4.0 + Math.Floor(4.0))];
		array2[0] = (byte)Convert.ToInt32(144.0 - Math.Truncate(48.0));
		array2[1] = (byte)Convert.ToInt32(202.0 - Math.Log10(100.0));
		array2[Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0))] = (byte)Convert.ToInt32(231.0 + Math.Sqrt(121.0));
		array2[Convert.ToInt32(3.9974949866040546 - Math.Sin(1.5))] = (byte)Convert.ToInt32(88.01770192510541 - Math.Sin(44.0));
		array2[Convert.ToInt32(2.0 + Math.Truncate(2.0))] = (byte)Convert.ToInt32(63.48845456116898 + Math.Log(33.5));
		array2[Convert.ToInt32(4.198856384453066 - Math.Cos(2.5))] = (byte)Convert.ToInt32(221.51778269427896 + Math.Sin(110.5));
		array2[Convert.ToInt32(4.267949192431123 + Math.Sqrt(3.0))] = (byte)Convert.ToInt32(83.0 - Math.Ceiling(27.5));
		array2[Convert.ToInt32(6.001822102388801 + Math.Tanh(3.5))] = (byte)Convert.ToInt32(161.75337899554654 + Math.Sqrt(85.5));
		uint[] array3 = new uint[Convert.ToInt32(1.0 + Math.Ceiling(1.0))];
		array3[0] = 733420589u;
		array3[1] = 4098177414u;
		IntPtr intPtr = _200F_200F_200D_202B_200F_202E_200E_200D_200E_202E_200E_200E_200E_200F_200F_200E(_202B_200F_200C_200C_200F_200D_200F_202B_200E_202C_200E_202A_200F_200D_200F_200E._202A_200F_200F_202B_200E_202C_200E_200B_200E_200F_200F_200C_200E_200D_200F_200F("\u0085¿\u001aòMÊDoù0Ûa$Ñã\u0095\u008eC\u0016q¹>Ht", num, (byte[])(object)array2, (uint[])(object)array3));
		int num2 = Convert.ToInt32(42.0 - Math.Truncate(14.0));
		byte[] array4 = new byte[Convert.ToInt32(9.157821282349577 - Math.Tan(4.0))];
		array4[0] = (byte)Convert.ToInt32(101.23891364890036 - Math.Tan(50.5));
		array4[1] = (byte)Convert.ToInt32(39.278753600952825 - Math.Log10(19.0));
		array4[Convert.ToInt32(2.0 + Math.Log(1.0))] = (byte)Convert.ToInt32(69.52618527958555 + Math.Tan(35.0));
		array4[Convert.ToInt32(2.0948517463551335 + Math.Tanh(1.5))] = (byte)Convert.ToInt32(244.9083330424043 + Math.Log10(123.5));
		array4[Convert.ToInt32(2.0 + Math.Truncate(2.0))] = (byte)Convert.ToInt32(166.24954011797334 - Math.Cos(83.0));
		array4[Convert.ToInt32(3.0 + Math.Round(2.5))] = (byte)Convert.ToInt32(78.39794000867204 + Math.Log10(40.0));
		array4[Convert.ToInt32(4.267949192431123 + Math.Sqrt(3.0))] = (byte)Convert.ToInt32(74.0 + Math.Tanh(37.5));
		array4[Convert.ToInt32(4.0 + Math.Truncate(3.5))] = (byte)Convert.ToInt32(121.5 + Math.Abs(121.5));
		uint[] array5 = new uint[Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0))];
		array5[0] = 909973531u;
		array5[1] = 1976192254u;
		IntPtr intPtr2 = _202B_200F_202E_200B_200E_202E_200E_202C_200E_202A_200F_200C_200E_200E(intPtr, _202B_200F_200C_200C_200F_200D_200F_202B_200E_202C_200E_202A_200F_200D_200F_200E._202A_200F_200F_202B_200E_202C_200E_200B_200E_200F_200F_200C_200E_200D_200F_200F("ß\u0002\u001e4Ó\u008f\u0096?\u009f\u0091\u0098LO.\u0088·3±\u0095µ©`1\u0005ä\"þ\u0012>\v\u008bC", num2, (byte[])(object)array4, (uint[])(object)array5));
		if (intPtr2 == IntPtr.Zero)
		{
			throw new NullReferenceException();
		}
		return (_200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_202A_200F_200C_200F_200F)Marshal.GetDelegateForFunctionPointer(intPtr2, typeof(_200F_200F_200E_200E_200F_200C_200F_200D_200F_202C_200E_202A_200F_200C_200F_200F));
	}

	internal unsafe static void _202C_200E_202E_202B_200E_202E_200E_200B_200E_200D_200F_202D_200E_202D_200E_200E()
	{
		bool[] array = (bool[])(object)new int[221]
		{
			227, -345684127, -211538151, 5981022, -1091911263, 1890531585, 1477946962, 1173872796, -426638529, -1423850757,
			857842786, -2004583417, 1712639825, 1290657114, 967499256, 1073461147, 722847415, -1186362692, 458239114, 1500912534,
			1685137994, 524018708, 1163045637, 788751982, -594185730, -857349202, 700939785, 1589210062, 1503232113, 459348959,
			1629358012, 1381782119, 1630825533, -1380456845, 931842060, -2100652106, -1818252128, -804883228, 1345811612, -269483271,
			2144148537, 2040450807, -1105463835, -859845932, 646675252, -1246242195, -870893360, -155799275, -1912478409, 1576427311,
			-90542306, -2133233438, 976810772, 2004458698, -1903266167, -1758219073, 1219328747, -1492813574, 1549525750, 346812490,
			1338873749, -1761568552, -975671247, -330502773, 1367828490, 701549490, 2011449464, -1441102083, -1947459461, -1959752037,
			-1193593834, -1189126045, 626012431, 1606444645, 1349662280, 1764380660, 81640131, -495394405, -938901161, -232754535,
			827811086, 537953371, 1774155068, 1006111194, -1223752115, -427558553, 896888938, -2022386294, -1740035761, 224794778,
			-273828362, -482298949, -660278887, -1946452637, 1844051053, -1600702775, 1568885350, 1680905102, 387200343, 1039353486,
			640200365, 457005766, -1489091980, -757048941, -620010842, 1602782284, -1307110206, 538796036, -1768004890, -2032819145,
			-1198525924, 693886803, -151321390, 1630744509, 139445880, 1937398664, 1643723133, -467161500, -736184687, -2086944149,
			-70559317, -1195723807, 1063383977, 1349694977, 1160453791, -657440564, 1595728239, 541252598, 1421699051, -1575410342,
			1093475962, -1879096055, -1843426844, 777385621, 1642839616, 309655992, -959326973, -1306055960, 996918274, 235842415,
			-1762739174, -1752198144, 1802837926, -1473688022, -1428254624, 1864319244, 106179768, -1895891184, 772416768, 1314412203,
			931514507, 1937020125, -1673103552, -881936724, -1426613977, 1653311931, 1317463025, -193635060, -1246309859, 411747834,
			-2067731238, 1840276030, -888003913, -791345677, -2094591155, -1139599519, -1642848546, 1833969141, -386567493, 650864028,
			470551964, 786657000, 1185625297, 1658997539, -1518891991, -133222010, 1450620673, 371436335, -1104413290, 1264973573,
			-2110522563, -518279438, -2094006951, -881330932, 2029344240, 1137846497, -953653084, -504087630, -1007889833, -188145794,
			553414141, 1404460118, 709763401, 2040504989, 939361198, 665575814, 2073219313, 755015397, 1850057395, 1252429956,
			-121123586, -980483099, 1047563717, 1149808521, 114851108, -2134862020, -313605777, -1484250462, -1748411411, -1964015446,
			1076166056, 1164590431, -402946297, -1000219885, 1752454925, -53452539, 1175634332, 202981378, -1210643855, 1858607159,
			-1911607413
		};
		Module module = typeof(_003CModule_003E).Module;
		string fullyQualifiedName = module.FullyQualifiedName;
		bool flag = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == Convert.ToInt32(90.0 - Math.Round(30.0));
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		uint[] array2 = default;
		uint[] array3 = default;
		uint num8 = default;
		uint num3 = default;
		uint num5 = default;
		uint num13 = default;
		uint num4 = default;
		uint num14 = default;
		uint num7 = default;
		int num17 = default;
		uint num10 = default;
		uint num9 = default;
		int num28 = default;
		ushort num29 = default;
		uint* ptr5 = default;
		uint* ptr3 = default;
		uint num15 = default;
		uint num6 = default;
		uint num20 = default;
		uint num18 = default;
		uint num11 = default;
		uint num21 = default;
		uint* ptr2 = default;
		while (true)
		{
			int num = 1286913529;
			while (true)
			{
				uint num2 = (uint)num;
				uint num31;
				switch ((uint)num % (uint)((int[])(object)array)[0])
				{
				case 172u:
					break;
				default:
					return;
				case 85u:
					array2[Convert.ToInt32(12.784880011912184 + Math.Sin(6.5))] = ~(array2[Convert.ToInt32(19.5 - Math.Abs(6.5))] ^ (uint)Convert.ToInt32(1121521771.1248162 + Math.Tan(560760888.0)));
					num = (((((int[])(object)array)[165] ^ ((int[])(object)array)[48]) != ((int[])(object)array)[124]) ? (((int)num2 * -1011573124) ^ ((int[])(object)array)[204]) : ((int)(num2 * 1279625737) ^ ((int[])(object)array)[64]));
					continue;
				case 161u:
					array2[1] = array2[1] ^ array3[1];
					num = (((((int[])(object)array)[132] ^ ((int[])(object)array)[136]) < ((int[])(object)array)[93]) ? ((int)(num2 * 1463380353) ^ ((int[])(object)array)[5]) : ((int)(num2 * 540494177) ^ ((int[])(object)array)[157]));
					continue;
				case 80u:
					num8 += (uint)((int)array2[Convert.ToInt32(12.0 - Math.Floor(4.0))] * -14);
					num = (((((int[])(object)array)[51] ^ ((int[])(object)array)[45]) != ((int[])(object)array)[107]) ? ((int)(num2 * 683263065) ^ ((int[])(object)array)[147]) : (((int)num2 * -554526578) ^ ((int[])(object)array)[54]));
					continue;
				case 179u:
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[1]) == ((int[])(object)array)[1]) ? ((int)(num2 * 1314807673) ^ ((int[])(object)array)[1]) : ((int)(num2 * 1477348341) ^ ((int[])(object)array)[2]));
					continue;
				case 118u:
					array2[0] = num3;
					num = ((((int[])(object)array)[51] + ((int[])(object)array)[115] < ((int[])(object)array)[112]) ? ((int)(num2 * 1374052129) ^ ((int[])(object)array)[188]) : (((int)num2 * -19777446) ^ ((int[])(object)array)[13]));
					continue;
				case 223u:
					num5 += array2[Convert.ToInt32(6.0 + Math.Ceiling(6.0))];
					num = (((((int[])(object)array)[49] ^ ((int[])(object)array)[35]) == ((int[])(object)array)[129]) ? (((int)num2 * -939805178) ^ ((int[])(object)array)[71]) : ((int)(num2 * 898164705) ^ ((int[])(object)array)[168]));
					continue;
				case 145u:
					array2[Convert.ToInt32(14.845098040014257 - Math.Log10(7.0))] = array2[Convert.ToInt32(7.0 + Math.Truncate(7.0))] ^ array3[Convert.ToInt32(13.154901959985743 + Math.Log10(7.0))];
					num = ((((int[])(object)array)[11] + ((int[])(object)array)[54] < ((int[])(object)array)[55]) ? ((int)(num2 * 1353209410) ^ ((int[])(object)array)[4]) : (((int)num2 * -696445806) ^ ((int[])(object)array)[101]));
					continue;
				case 54u:
					array2[Convert.ToInt32(9.295251907761575 + Math.Log(5.5))] = array2[Convert.ToInt32(5.0 + Math.Round(5.5))] & (uint)Convert.ToInt32(1934793032.8073428 - Math.Sin(967396516.5));
					num = ((((int[])(object)array)[37] + ((int[])(object)array)[23] < ((int[])(object)array)[10]) ? (((int)num2 * -105966610) ^ ((int[])(object)array)[129]) : (((int)num2 * -1071176449) ^ ((int[])(object)array)[24]));
					continue;
				case 108u:
					num3 = array2[Convert.ToInt32(4.362667945448815 + Math.Tan(4.5))] * (uint)Convert.ToInt32(162.11940368961575 + Math.Tan(83.0));
					num = (((((int[])(object)array)[75] ^ ((int[])(object)array)[31]) != ((int[])(object)array)[20]) ? (((int)num2 * -1944086559) ^ ((int[])(object)array)[132]) : ((int)(num2 * 1478357935) ^ ((int[])(object)array)[124]));
					continue;
				case 176u:
					return;
				case 152u:
					array2[Convert.ToInt32(6.0 - Math.Floor(2.0))] = array2[Convert.ToInt32(3.090702573174318 + Math.Sin(2.0))] | num8;
					num = ((((int[])(object)array)[87] + ((int[])(object)array)[84] == ((int[])(object)array)[46]) ? ((int)(num2 * 1675217534) ^ ((int[])(object)array)[72]) : (((int)num2 * -476505109) ^ ((int[])(object)array)[105]));
					continue;
				case 219u:
					num = (((((int[])(object)array)[17] ^ ((int[])(object)array)[5]) >= ((int[])(object)array)[0]) ? ((int)(num2 * 2093355150) ^ ((int[])(object)array)[3]) : (((int)num2 * -1256378287) ^ ((int[])(object)array)[29]));
					continue;
				case 8u:
				{
					int num26;
					if (num13 < num4)
					{
						num = 351918465;
						num26 = num;
					}
					else
					{
						num = 202145635;
						num26 = num;
					}
					continue;
				}
				case 170u:
					num14 = 0u;
					num = ((((int[])(object)array)[97] + ((int[])(object)array)[34] <= ((int[])(object)array)[47]) ? ((int)(num2 * 1447810402) ^ ((int[])(object)array)[215]) : ((int)(num2 * 149540878) ^ ((int[])(object)array)[175]));
					continue;
				case 187u:
					array2[Convert.ToInt32(5.0 + Math.Round(5.0))] = num5 * 3501171073u;
					num = (((((int[])(object)array)[166] ^ ((int[])(object)array)[155]) > ((int[])(object)array)[146]) ? (((int)num2 * -44608552) ^ ((int[])(object)array)[128]) : (((int)num2 * -2122484461) ^ ((int[])(object)array)[200]));
					continue;
				case 128u:
					array2[Convert.ToInt32(4.267949192431123 + Math.Sqrt(3.0))] = array2[Convert.ToInt32(9.0 - Math.Truncate(3.0))] & (uint)Convert.ToInt32(1934793032.8073428 - Math.Sin(967396516.5));
					num = ((((int[])(object)array)[59] + ((int[])(object)array)[28] <= ((int[])(object)array)[9]) ? ((int)(num2 * 697470009) ^ ((int[])(object)array)[32]) : ((int)(num2 * 1146922308) ^ ((int[])(object)array)[124]));
					continue;
				case 200u:
					array2 = new uint[Convert.ToInt32(8.0 + Math.Truncate(8.0))];
					num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[22]) >= ((int[])(object)array)[16]) ? ((int)(num2 * 1469186437) ^ ((int[])(object)array)[17]) : ((int)(num2 * 1265570624) ^ ((int[])(object)array)[25]));
					continue;
				case 45u:
					array2[Convert.ToInt32(10.958924274663138 + Math.Sin(5.0))] = array2[Convert.ToInt32(15.0 - Math.Round(5.0))] | (uint)((int)num3 * -1328368855);
					num = ((((int[])(object)array)[101] + ((int[])(object)array)[12] == ((int[])(object)array)[81]) ? ((int)(num2 * 1538206092) ^ ((int[])(object)array)[90]) : ((int)(num2 * 1229225725) ^ ((int[])(object)array)[159]));
					continue;
				case 215u:
					array2[Convert.ToInt32(6.0 + Math.Truncate(6.0))] = num8;
					num = ((((int[])(object)array)[23] + ((int[])(object)array)[63] <= ((int[])(object)array)[0]) ? ((int)(num2 * 1193762725) ^ ((int[])(object)array)[72]) : (((int)num2 * -2056889817) ^ ((int[])(object)array)[120]));
					continue;
				case 160u:
					array2[Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0))] = array2[Convert.ToInt32(2.0 + Math.Log10(1.0))] & (uint)Convert.ToInt32(70026201.0 - Math.Truncate(23342067.0));
					num = ((((int[])(object)array)[74] + ((int[])(object)array)[156] > ((int[])(object)array)[201]) ? (((int)num2 * -1640251245) ^ ((int[])(object)array)[0]) : ((int)(num2 * 176990888) ^ ((int[])(object)array)[207]));
					continue;
				case 221u:
					array2[Convert.ToInt32(7.243197504692072 - Math.Sin(4.0))] = array2[Convert.ToInt32(4.0 + Math.Floor(4.0))] ^ array3[Convert.ToInt32(8.653643620863612 + Math.Cos(4.0))];
					num = (((((int[])(object)array)[32] ^ ((int[])(object)array)[2]) >= ((int[])(object)array)[7]) ? ((int)(num2 * 1580316320) ^ ((int[])(object)array)[59]) : (((int)num2 * -1017671762) ^ ((int[])(object)array)[67]));
					continue;
				case 58u:
					array2[Convert.ToInt32(14.000000611804454 + Math.Tanh(7.5))] = array2[Convert.ToInt32(8.0 + Math.Truncate(7.5))] & (uint)Convert.ToInt32(46688965.3628512 - Math.Sqrt(23342067.0));
					num = ((((int[])(object)array)[96] + ((int[])(object)array)[123] >= ((int[])(object)array)[0]) ? (((int)num2 * -1557066513) ^ ((int[])(object)array)[52]) : ((int)(num2 * 945962683) ^ ((int[])(object)array)[202]));
					continue;
				case 211u:
					array2[Convert.ToInt32(4.401527855896044 + Math.Sin(2.5))] = array2[Convert.ToInt32(7.0 - Math.Round(2.5))] & (uint)Convert.ToInt32(1039726625.0 + Math.Tanh(519863313.0));
					num = (((((int[])(object)array)[112] ^ ((int[])(object)array)[130]) < ((int[])(object)array)[120]) ? ((int)(num2 * 411172153) ^ ((int[])(object)array)[151]) : ((int)(num2 * 1627766477) ^ ((int[])(object)array)[22]));
					continue;
				case 196u:
					num7 += array2[Convert.ToInt32(2.0 - Math.Log10(1.0))] << Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0));
					num = ((((int[])(object)array)[138] + ((int[])(object)array)[53] <= ((int[])(object)array)[60]) ? ((int)(num2 * 864240300) ^ ((int[])(object)array)[173]) : ((int)(num2 * 336739594) ^ ((int[])(object)array)[14]));
					continue;
				case 27u:
					array2[Convert.ToInt32(15.0 - Math.Ceiling(5.0))] = array2[Convert.ToInt32(10.283662185463227 - Math.Cos(5.0))] & (uint)Convert.ToInt32(1039726617.2841108 + Math.Log10(519863313.0));
					num = ((((int[])(object)array)[54] + ((int[])(object)array)[145] <= ((int[])(object)array)[105]) ? (((int)num2 * -1971547534) ^ ((int[])(object)array)[158]) : ((int)(num2 * 1402207912) ^ ((int[])(object)array)[17]));
					continue;
				case 182u:
					array2[Convert.ToInt32(10.291330225708741 + Math.Cos(5.5))] = array2[Convert.ToInt32(11.999966597156304 - Math.Tanh(5.5))] ^ array3[Convert.ToInt32(16.0 - Math.Truncate(5.5))];
					num = ((((int[])(object)array)[44] + ((int[])(object)array)[20] < ((int[])(object)array)[22]) ? (((int)num2 * -149194904) ^ ((int[])(object)array)[44]) : (((int)num2 * -1486706501) ^ ((int[])(object)array)[27]));
					continue;
				case 114u:
					array2[num17] = num10;
					num = (((((int[])(object)array)[16] ^ ((int[])(object)array)[17]) >= ((int[])(object)array)[23]) ? (((int)num2 * -872613612) ^ ((int[])(object)array)[20]) : ((int[])(object)array)[30]);
					continue;
				case 116u:
					num5 = array2[Convert.ToInt32(7.0 - Math.Floor(2.5))] * (uint)Convert.ToInt32(84.0 - Math.Floor(28.0));
					num = (((((int[])(object)array)[29] ^ ((int[])(object)array)[9]) != ((int[])(object)array)[8]) ? ((int)(num2 * 214433387) ^ ((int[])(object)array)[41]) : (((int)num2 * -1352444393) ^ ((int[])(object)array)[11]));
					continue;
				case 226u:
					num3 += (uint)((int)array2[Convert.ToInt32(10.0 - Math.Sqrt(4.0))] * Convert.ToInt32(47.36172783601759 - Math.Log10(23.0)));
					num = ((((int[])(object)array)[108] + ((int[])(object)array)[29] < ((int[])(object)array)[115]) ? (((int)num2 * -2002679425) ^ ((int[])(object)array)[144]) : (((int)num2 * -2138117668) ^ ((int[])(object)array)[129]));
					continue;
				case 76u:
					num8 += array2[Convert.ToInt32(4.401527855896044 + Math.Sin(2.5))];
					num = (((((int[])(object)array)[37] ^ ((int[])(object)array)[10]) >= ((int[])(object)array)[0]) ? (((int)num2 * -102252593) ^ ((int[])(object)array)[58]) : ((int)(num2 * 1486845889) ^ ((int[])(object)array)[114]));
					continue;
				case 184u:
					array2[Convert.ToInt32(4.0 + Math.Truncate(4.0))] = ~(array2[Convert.ToInt32(12.0 - Math.Ceiling(4.0))] ^ array2[1]);
					num = ((((int[])(object)array)[89] + ((int[])(object)array)[25] != ((int[])(object)array)[29]) ? ((int)(num2 * 530355444) ^ ((int[])(object)array)[112]) : ((int)(num2 * 1395974709) ^ ((int[])(object)array)[39]));
					continue;
				case 39u:
					num8 = array2[Convert.ToInt32(3.0 + Math.Round(2.5))] * 4294967163u;
					num = (((((int[])(object)array)[30] ^ ((int[])(object)array)[6]) < ((int[])(object)array)[24]) ? ((int)(num2 * 706886165) ^ ((int[])(object)array)[28]) : (((int)num2 * -20911592) ^ ((int[])(object)array)[46]));
					continue;
				case 12u:
					num8 += (uint)((int)array2[1] * -75);
					num = ((((int[])(object)array)[16] + ((int[])(object)array)[33] <= ((int[])(object)array)[28]) ? ((int)(num2 * 942150800) ^ ((int[])(object)array)[50]) : (((int)num2 * -1292476105) ^ ((int[])(object)array)[35]));
					continue;
				case 23u:
					num7 += array2[1] << Convert.ToInt32(3.6989700043360187 + Math.Log10(2.0));
					num = ((((int[])(object)array)[37] + ((int[])(object)array)[17] != ((int[])(object)array)[48]) ? (((int)num2 * -1325604075) ^ ((int[])(object)array)[59]) : ((int)(num2 * 1784398091) ^ ((int[])(object)array)[41]));
					continue;
				case 94u:
					num5 *= 2859698471u;
					num = (((((int[])(object)array)[36] ^ ((int[])(object)array)[31]) != ((int[])(object)array)[103]) ? ((int)(num2 * 986615741) ^ ((int[])(object)array)[203]) : (((int)num2 * -1612537181) ^ ((int[])(object)array)[47]));
					continue;
				case 171u:
					array2[Convert.ToInt32(17.70601386677269 - Math.Tan(7.5))] = array2[Convert.ToInt32(7.0 + Math.Round(7.5))] | num7;
					num = ((((int[])(object)array)[52] + ((int[])(object)array)[37] == ((int[])(object)array)[74]) ? (((int)num2 * -363342546) ^ ((int[])(object)array)[66]) : (((int)num2 * -710319501) ^ ((int[])(object)array)[83]));
					continue;
				case 216u:
					array2[Convert.ToInt32(6.0 + Math.Truncate(5.5))] = array2[Convert.ToInt32(10.291330225708741 + Math.Cos(5.5))] + array2[Convert.ToInt32(7.0 + Math.Ceiling(7.5))];
					num = ((((int[])(object)array)[1] + ((int[])(object)array)[22] != ((int[])(object)array)[45]) ? (((int)num2 * -1794519314) ^ ((int[])(object)array)[63]) : ((int)(num2 * 457827855) ^ ((int[])(object)array)[53]));
					continue;
				case 213u:
					num9 = 3402596709u;
					num = ((((int[])(object)array)[1] + ((int[])(object)array)[2] == ((int[])(object)array)[3]) ? ((int)(num2 * 866388444) ^ ((int[])(object)array)[0]) : ((int)(num2 * 1548733410) ^ ((int[])(object)array)[5]));
					continue;
				case 10u:
					array2[0] = array2[0] << Convert.ToInt32(1.2384058440442351 + Math.Tanh(1.0));
					num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[25]) < ((int[])(object)array)[39]) ? ((int)(num2 * 82200319) ^ ((int[])(object)array)[11]) : (((int)num2 * -795352121) ^ ((int[])(object)array)[42]));
					continue;
				case 112u:
					array2[Convert.ToInt32(10.0 - Math.Sqrt(4.0))] = array2[Convert.ToInt32(7.243197504692072 - Math.Sin(4.0))] + array2[Convert.ToInt32(7.998177897611199 - Math.Tanh(3.5))];
					num = (((((int[])(object)array)[35] ^ ((int[])(object)array)[5]) < ((int[])(object)array)[6]) ? ((int)(num2 * 971128225) ^ ((int[])(object)array)[62]) : ((int)(num2 * 1433158623) ^ ((int[])(object)array)[37]));
					continue;
				case 131u:
					num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[4]) <= ((int[])(object)array)[3]) ? ((int)(num2 * 1860297574) ^ ((int[])(object)array)[9]) : (((int)num2 * -622387393) ^ ((int[])(object)array)[4]));
					continue;
				case 165u:
					array2[Convert.ToInt32(9.0 - Math.Truncate(3.0))] = num3;
					num = (((((int[])(object)array)[6] ^ ((int[])(object)array)[22]) > ((int[])(object)array)[47]) ? (((int)num2 * -1664239010) ^ ((int[])(object)array)[65]) : (((int)num2 * -250528358) ^ ((int[])(object)array)[61]));
					continue;
				case 126u:
					num8 += (uint)((int)array2[Convert.ToInt32(3.0 + Math.Ceiling(3.0))] * Convert.ToInt32(245.90657831483776 + Math.Log10(124.0)));
					num = ((((int[])(object)array)[6] + ((int[])(object)array)[29] <= ((int[])(object)array)[30]) ? (((int)num2 * -449005191) ^ ((int[])(object)array)[27]) : ((int)(num2 * 1206190872) ^ ((int[])(object)array)[48]));
					continue;
				case 42u:
					array2[Convert.ToInt32(4.6020599913279625 + Math.Log10(2.5))] = num7;
					num = (((((int[])(object)array)[44] ^ ((int[])(object)array)[81]) < ((int[])(object)array)[35]) ? ((int)(num2 * 642297086) ^ ((int[])(object)array)[3]) : ((int)(num2 * 1242549305) ^ ((int[])(object)array)[118]));
					continue;
				case 2u:
					array2[Convert.ToInt32(3.090702573174318 + Math.Sin(2.0))] = array2[Convert.ToInt32(4.9640275800758165 - Math.Tanh(2.0))] ^ array3[Convert.ToInt32(2.0 + Math.Abs(2.0))];
					num = (((((int[])(object)array)[49] ^ ((int[])(object)array)[169]) > ((int[])(object)array)[12]) ? ((int)(num2 * 711225274) ^ ((int[])(object)array)[171]) : ((int)(num2 * 103312868) ^ ((int[])(object)array)[137]));
					continue;
				case 19u:
					array2[Convert.ToInt32(8.999329299739067 - Math.Tanh(4.0))] = num5;
					num = (((((int[])(object)array)[76] ^ ((int[])(object)array)[33]) != ((int[])(object)array)[117]) ? ((int)(num2 * 505480316) ^ ((int[])(object)array)[125]) : ((int)(num2 * 1231824820) ^ ((int[])(object)array)[98]));
					continue;
				case 194u:
					array2[Convert.ToInt32(5.858879991940133 + Math.Sin(3.0))] = num5;
					num = ((((int[])(object)array)[77] + ((int[])(object)array)[61] != ((int[])(object)array)[156]) ? (((int)num2 * -1507760989) ^ ((int[])(object)array)[187]) : (((int)num2 * -895774208) ^ ((int[])(object)array)[153]));
					continue;
				case 56u:
					array3 = new uint[Convert.ToInt32(9.200288544779621 - Math.Tan(8.0))];
					num = ((((int[])(object)array)[13] + ((int[])(object)array)[2] == ((int[])(object)array)[10]) ? (((int)num2 * -1679217299) ^ ((int[])(object)array)[26]) : ((int)(num2 * 2046733827) ^ ((int[])(object)array)[27]));
					continue;
				case 104u:
					num3 += array2[Convert.ToInt32(9.0 - Math.Round(3.0))] << 1;
					num = ((((int[])(object)array)[116] + ((int[])(object)array)[68] == ((int[])(object)array)[44]) ? (((int)num2 * -1119335855) ^ ((int[])(object)array)[69]) : ((int)(num2 * 1892798682) ^ ((int[])(object)array)[184]));
					continue;
				case 68u:
					array2[Convert.ToInt32(2.0025050133959454 + Math.Sin(1.5))] = num3;
					num = (((((int[])(object)array)[82] ^ ((int[])(object)array)[121]) == ((int[])(object)array)[19]) ? (((int)num2 * -388886025) ^ ((int[])(object)array)[43]) : (((int)num2 * -203470588) ^ ((int[])(object)array)[123]));
					continue;
				case 67u:
					num5 += array2[1] << Convert.ToInt32(5.916290731874155 - Math.Log(2.5));
					num = (((((int[])(object)array)[15] ^ ((int[])(object)array)[7]) <= ((int[])(object)array)[18]) ? ((int)(num2 * 1972857971) ^ ((int[])(object)array)[25]) : ((int)(num2 * 1328106314) ^ ((int[])(object)array)[56]));
					continue;
				case 29u:
					array2[Convert.ToInt32(2.0 + Math.Ceiling(2.5))] = array2[Convert.ToInt32(4.198856384453066 - Math.Cos(2.5))] ^ array3[Convert.ToInt32(4.252977702761339 - Math.Tan(2.5))];
					num = ((((int[])(object)array)[56] + ((int[])(object)array)[53] >= ((int[])(object)array)[13]) ? ((int)(num2 * 1364799033) ^ ((int[])(object)array)[52]) : (((int)num2 * -213004016) ^ ((int[])(object)array)[93]));
					continue;
				case 123u:
					num7 += (uint)((int)array2[Convert.ToInt32(7.0 - Math.Round(2.5))] * -26);
					num = (((((int[])(object)array)[60] ^ ((int[])(object)array)[16]) == ((int[])(object)array)[41]) ? (((int)num2 * -919271204) ^ ((int[])(object)array)[3]) : ((int)(num2 * 601719382) ^ ((int[])(object)array)[108]));
					continue;
				case 83u:
					array2[Convert.ToInt32(19.0 - Math.Truncate(6.5))] = array2[Convert.ToInt32(7.0 + Math.Round(6.5))] + array2[0];
					num = ((((int[])(object)array)[30] + ((int[])(object)array)[78] < ((int[])(object)array)[0]) ? (((int)num2 * -440194063) ^ ((int[])(object)array)[89]) : ((int)(num2 * 468942861) ^ ((int[])(object)array)[94]));
					continue;
				case 71u:
				{
					int num30;
					if (num28 < num29)
					{
						num = 568797420;
						num30 = num;
					}
					else
					{
						num = 1957390318;
						num30 = num;
					}
					continue;
				}
				case 191u:
					num7 = array2[Convert.ToInt32(5.0 + Math.Round(4.5))] << Convert.ToInt32(24.25834261322606 + Math.Sqrt(14.0));
					num = (((((int[])(object)array)[39] ^ ((int[])(object)array)[76]) != ((int[])(object)array)[90]) ? ((int)(num2 * 1664595096) ^ ((int[])(object)array)[91]) : (((int)num2 * -670014811) ^ ((int[])(object)array)[7]));
					continue;
				case 46u:
					num5 = array2[0] & (uint)Convert.ToInt32(1405035220.798773 - Math.Sqrt(702504358.0));
					num = ((((int[])(object)array)[127] + ((int[])(object)array)[84] >= ((int[])(object)array)[85]) ? ((int)(num2 * 1413586574) ^ ((int[])(object)array)[34]) : (((int)num2 * -254053549) ^ ((int[])(object)array)[190]));
					continue;
				case 153u:
					ptr5 = (uint*)(ptr + (uint)(flag ? (*(int*)((byte*)ptr2 + (nint)Convert.ToInt32(1.0 + Math.Ceiling(1.5)) * (nint)Convert.ToInt32(2.0 + Math.Round(2.0)))) : (*(int*)((byte*)ptr2 + Convert.ToInt32(2.0 + Math.Floor(2.0))))));
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[9]) != ((int[])(object)array)[8]) ? ((int[])(object)array)[16] : ((int)(num2 * 1971554321) ^ ((int[])(object)array)[13]));
					continue;
				case 120u:
					num8 += (uint)((int)array2[Convert.ToInt32(9.550510257216821 + Math.Sqrt(6.0))] * Convert.ToInt32(27.062996062994095 + Math.Sqrt(15.5)));
					num = ((((int[])(object)array)[19] + ((int[])(object)array)[1] < ((int[])(object)array)[31]) ? ((int)(num2 * 1614041839) ^ ((int[])(object)array)[54]) : ((int)(num2 * 1277961879) ^ ((int[])(object)array)[22]));
					continue;
				case 20u:
					array2[Convert.ToInt32(7.0 + Math.Truncate(7.0))] = array2[Convert.ToInt32(21.0 - Math.Round(7.0))] | num3;
					num = (((((int[])(object)array)[162] ^ ((int[])(object)array)[104]) == ((int[])(object)array)[102]) ? ((int)(num2 * 2002797419) ^ ((int[])(object)array)[141]) : (((int)num2 * -1231557026) ^ ((int[])(object)array)[164]));
					continue;
				case 86u:
					array2[Convert.ToInt32(6.0 + Math.Abs(6.0))] = array2[Convert.ToInt32(12.999987711650796 - Math.Tanh(6.0))] + 3504597758u;
					num = ((((int[])(object)array)[19] + ((int[])(object)array)[2] < ((int[])(object)array)[45]) ? ((int)(num2 * 1481092339) ^ ((int[])(object)array)[16]) : ((int)(num2 * 138138553) ^ ((int[])(object)array)[71]));
					continue;
				case 147u:
					array2[0] = array2[0] ^ (uint)Convert.ToInt32(953651932.99461 + Math.Cos(476825966.0));
					num = ((((int[])(object)array)[15] + ((int[])(object)array)[16] != ((int[])(object)array)[24]) ? (((int)num2 * -850533820) ^ ((int[])(object)array)[49]) : (((int)num2 * -561539406) ^ ((int[])(object)array)[46]));
					continue;
				case 143u:
					num8 = array2[Convert.ToInt32(10.283662185463227 - Math.Cos(5.0))] & 0xACDC8BB2u;
					num = ((((int[])(object)array)[31] + ((int[])(object)array)[1] > ((int[])(object)array)[69]) ? ((int)(num2 * 489938687) ^ ((int[])(object)array)[69]) : ((int)(num2 * 1772063148) ^ ((int[])(object)array)[9]));
					continue;
				case 110u:
					array2[0] = array2[0] | num7;
					num = (((((int[])(object)array)[38] ^ ((int[])(object)array)[36]) != ((int[])(object)array)[13]) ? (((int)num2 * -95161210) ^ ((int[])(object)array)[47]) : (((int)num2 * -1769457641) ^ ((int[])(object)array)[30]));
					continue;
				case 7u:
					num7 += (uint)((int)array2[Convert.ToInt32(10.0 - Math.Floor(3.5))] * -23);
					num = ((((int[])(object)array)[106] + ((int[])(object)array)[72] == ((int[])(object)array)[49]) ? (((int)num2 * -23174572) ^ ((int[])(object)array)[58]) : (((int)num2 * -1765647592) ^ ((int[])(object)array)[139]));
					continue;
				case 149u:
					num8 += array2[Convert.ToInt32(8.0 - Math.Ceiling(2.5))] << Convert.ToInt32(2.585786437626905 + Math.Sqrt(2.0));
					num = (((((int[])(object)array)[32] ^ ((int[])(object)array)[66]) > ((int[])(object)array)[86]) ? ((int)(num2 * 1369235820) ^ ((int[])(object)array)[46]) : (((int)num2 * -1704555436) ^ ((int[])(object)array)[113]));
					continue;
				case 57u:
					num8 += (uint)((int)array2[Convert.ToInt32(3.0 + Math.Abs(3.0))] * -21);
					num = ((((int[])(object)array)[172] + ((int[])(object)array)[45] == ((int[])(object)array)[66]) ? ((int)(num2 * 746949301) ^ ((int[])(object)array)[153]) : ((int)(num2 * 879395644) ^ ((int[])(object)array)[176]));
					continue;
				case 36u:
					array2[Convert.ToInt32(15.999999388195546 - Math.Tanh(7.5))] = array2[Convert.ToInt32(23.0 - Math.Round(7.5))] + array2[Convert.ToInt32(2.0 + Math.Truncate(1.5))];
					num = (((((int[])(object)array)[9] ^ ((int[])(object)array)[31]) > ((int[])(object)array)[21]) ? (((int)num2 * -1083505915) ^ ((int[])(object)array)[19]) : (((int)num2 * -497048309) ^ ((int[])(object)array)[52]));
					continue;
				case 192u:
					num4 = *(uint*)((byte*)ptr2 + (nint)Convert.ToInt32(1.0 + Math.Floor(1.0)) * (nint)Convert.ToInt32(3.6989700043360187 + Math.Log10(2.0))) >> Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0));
					num = ((((int[])(object)array)[4] + ((int[])(object)array)[7] != ((int[])(object)array)[15]) ? ((int)(num2 * 22407545) ^ ((int[])(object)array)[17]) : (((int)num2 * -1834882693) ^ ((int[])(object)array)[15]));
					continue;
				case 43u:
					array2[Convert.ToInt32(1.0 + Math.Truncate(1.0))] = array2[Convert.ToInt32(1.0 + Math.Truncate(1.0))] * (uint)Convert.ToInt32(183322515.9836088 - Math.Sin(91661257.5));
					num = (((((int[])(object)array)[40] ^ ((int[])(object)array)[29]) <= ((int[])(object)array)[71]) ? ((int)(num2 * 922421234) ^ ((int[])(object)array)[62]) : ((int)(num2 * 2020684294) ^ ((int[])(object)array)[92]));
					continue;
				case 101u:
					array2[Convert.ToInt32(15.8750612633917 - Math.Log10(7.5))] = array2[Convert.ToInt32(17.73861278752583 - Math.Sqrt(7.5))] << Convert.ToInt32(20.54402111088937 + Math.Sin(10.0));
					num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[14]) != ((int[])(object)array)[46]) ? (((int)num2 * -98773079) ^ ((int[])(object)array)[80]) : ((int)(num2 * 530096498) ^ ((int[])(object)array)[49]));
					continue;
				case 64u:
					num3 = array2[Convert.ToInt32(7.0 + Math.Ceiling(7.0))] >> Convert.ToInt32(14.0 + Math.Floor(13.5));
					num = ((((int[])(object)array)[112] + ((int[])(object)array)[151] == ((int[])(object)array)[150]) ? ((int)(num2 * 246875985) ^ ((int[])(object)array)[65]) : (((int)num2 * -1193187861) ^ ((int[])(object)array)[160]));
					continue;
				case 40u:
					array2[Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0))] = array2[Convert.ToInt32(1.0 + Math.Round(1.0))] & (uint)Convert.ToInt32(697416231.0 + Math.Round(697416230.5));
					num = ((((int[])(object)array)[4] + ((int[])(object)array)[6] <= ((int[])(object)array)[9]) ? ((int)(num2 * 166528242) ^ ((int[])(object)array)[14]) : ((int)(num2 * 806771125) ^ ((int[])(object)array)[78]));
					continue;
				case 0u:
					array2[Convert.ToInt32(1.5 + Math.Abs(1.5))] = array2[Convert.ToInt32(3.9974949866040546 - Math.Sin(1.5))] + array2[Convert.ToInt32(23.0 - Math.Ceiling(7.5))];
					num = (((((int[])(object)array)[102] ^ ((int[])(object)array)[141]) != ((int[])(object)array)[92]) ? ((int)(num2 * 1038649238) ^ ((int[])(object)array)[179]) : (((int)num2 * -1305363940) ^ ((int[])(object)array)[128]));
					continue;
				case 195u:
					num7 = array2[Convert.ToInt32(9.21079579943078 + Math.Cos(4.5))] * (uint)Convert.ToInt32(82.67630067190707 - Math.Log(39.5));
					num = (((((int[])(object)array)[126] ^ ((int[])(object)array)[1]) != ((int[])(object)array)[108]) ? ((int)(num2 * 451348231) ^ ((int[])(object)array)[135]) : (((int)num2 * -170198518) ^ ((int[])(object)array)[87]));
					continue;
				case 59u:
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[15]) == ((int[])(object)array)[2]) ? (((int)num2 * -1772888977) ^ ((int[])(object)array)[2]) : (((int)num2 * -1365689695) ^ ((int[])(object)array)[15]));
					continue;
				case 206u:
					array2[Convert.ToInt32(22.0 - Math.Floor(7.5))] = array2[Convert.ToInt32(22.0 - Math.Floor(7.5))] | (array2[Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0))] & 0xFD37A819u);
					num = (((((int[])(object)array)[22] ^ ((int[])(object)array)[112]) < ((int[])(object)array)[85]) ? ((int)(num2 * 506641167) ^ ((int[])(object)array)[205]) : ((int)(num2 * 1529670184) ^ ((int[])(object)array)[71]));
					continue;
				case 135u:
				{
					byte* num32 = ptr + (uint)(*(int*)(ptr + Convert.ToInt32(30.0 + Math.Ceiling(30.0))));
					num29 = *(ushort*)(num32 + Convert.ToInt32(9.0 - Math.Round(3.0)));
					ushort num33 = *(ushort*)(num32 + Convert.ToInt32(20.999999995877694 - Math.Tanh(10.0)));
					ptr3 = null;
					num15 = 0u;
					ptr2 = (uint*)(num32 + Convert.ToInt32(23.156146041267508 + Math.Cos(12.0)) + (int)num33);
					num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[0]) == ((int[])(object)array)[0]) ? (((int)num2 * -268237252) ^ ((int[])(object)array)[0]) : ((int)(num2 * 977149461) ^ ((int[])(object)array)[1]));
					continue;
				}
				case 88u:
					num31 = *ptr2;
					goto IL_3053;
				case 193u:
					num6++;
					num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[205]) < ((int[])(object)array)[193]) ? (((int)num2 * -810774655) ^ ((int[])(object)array)[219]) : (((int)num2 * -1694008036) ^ ((int[])(object)array)[215]));
					continue;
				case 92u:
					ptr2 = (uint*)((byte*)ptr2 + (nint)Convert.ToInt32(10.0 - Math.Sqrt(4.0)) * (nint)Convert.ToInt32(4.909297426825682 - Math.Sin(2.0)));
					num = (((((int[])(object)array)[10] ^ ((int[])(object)array)[1]) != ((int[])(object)array)[12]) ? ((int[])(object)array)[22] : ((int)(num2 * 731316762) ^ ((int[])(object)array)[7]));
					continue;
				case 22u:
					num10 = (num20 >> Convert.ToInt32(10.259637310505756 + Math.Log10(5.5))) | (num20 << Convert.ToInt32(23.35137525716348 - Math.Log(10.5)));
					num = ((((int[])(object)array)[23] + ((int[])(object)array)[5] <= ((int[])(object)array)[20]) ? ((int)(num2 * 590914684) ^ ((int[])(object)array)[35]) : ((int)(num2 * 1071056730) ^ ((int[])(object)array)[7]));
					continue;
				case 49u:
					num8 += array2[Convert.ToInt32(6.0 - Math.Ceiling(2.0))] << Convert.ToInt32(4.252977702761339 - Math.Tan(2.5));
					num = ((((int[])(object)array)[74] + ((int[])(object)array)[89] == ((int[])(object)array)[98]) ? (((int)num2 * -432982956) ^ ((int[])(object)array)[15]) : ((int)(num2 * 458428889) ^ ((int[])(object)array)[143]));
					continue;
				case 127u:
					num7 = array2[Convert.ToInt32(11.039829713349635 + Math.Cos(6.0))] * 4294967263u;
					num = (((((int[])(object)array)[47] ^ ((int[])(object)array)[111]) < ((int[])(object)array)[23]) ? (((int)num2 * -1893628417) ^ ((int[])(object)array)[161]) : ((int)(num2 * 1978031904) ^ ((int[])(object)array)[112]));
					continue;
				case 111u:
					num8 += (uint)((int)array2[Convert.ToInt32(2.0 - Math.Log10(1.0))] * Convert.ToInt32(122.0 - Math.Ceiling(40.5)));
					num = (((((int[])(object)array)[62] ^ ((int[])(object)array)[133]) < ((int[])(object)array)[160]) ? (((int)num2 * -1882882580) ^ ((int[])(object)array)[43]) : (((int)num2 * -339070386) ^ ((int[])(object)array)[170]));
					continue;
				case 34u:
					num = ((((int[])(object)array)[214] + ((int[])(object)array)[199] < ((int[])(object)array)[43]) ? ((int)(num2 * 667389785) ^ ((int[])(object)array)[216]) : ((int)(num2 * 1592028356) ^ ((int[])(object)array)[146]));
					continue;
				case 103u:
					array2[Convert.ToInt32(16.5 - Math.Abs(5.5))] = ~(array2[Convert.ToInt32(13.345207879911715 - Math.Sqrt(5.5))] ^ 0xF872A16Bu);
					num = ((((int[])(object)array)[42] + ((int[])(object)array)[37] >= ((int[])(object)array)[53]) ? ((int)(num2 * 2096100439) ^ ((int[])(object)array)[45]) : ((int)(num2 * 540013988) ^ ((int[])(object)array)[102]));
					continue;
				case 4u:
					num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[1]) >= ((int[])(object)array)[0]) ? ((int)(num2 * 263171487) ^ ((int[])(object)array)[1]) : ((int)(num2 * 1744662514) ^ ((int[])(object)array)[6]));
					continue;
				case 210u:
					array2[Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0))] = array2[Convert.ToInt32(1.2384058440442351 + Math.Tanh(1.0))] | (uint)((int)num8 * Convert.ToInt32(1080589800.267369 + Math.Log10(540294904.5)));
					num = ((((int[])(object)array)[12] + ((int[])(object)array)[31] > ((int[])(object)array)[58]) ? ((int)(num2 * 152083126) ^ ((int[])(object)array)[27]) : (((int)num2 * -1954897023) ^ ((int[])(object)array)[89]));
					continue;
				case 208u:
					num3 = array2[Convert.ToInt32(18.0 - Math.Ceiling(6.0))] << Convert.ToInt32(7.09861228866811 - Math.Log(3.0));
					num = (((((int[])(object)array)[165] ^ ((int[])(object)array)[89]) > ((int[])(object)array)[86]) ? (((int)num2 * -1556135065) ^ ((int[])(object)array)[129]) : ((int)(num2 * 1444785151) ^ ((int[])(object)array)[175]));
					continue;
				case 119u:
					array2[1] = array2[1] | num7;
					num = ((((int[])(object)array)[113] + ((int[])(object)array)[9] < ((int[])(object)array)[60]) ? ((int)(num2 * 1081008221) ^ ((int[])(object)array)[134]) : ((int)(num2 * 537854977) ^ ((int[])(object)array)[126]));
					continue;
				case 17u:
					num = ((((int[])(object)array)[3] + ((int[])(object)array)[2] > ((int[])(object)array)[12]) ? (((int)num2 * -1070345822) ^ ((int[])(object)array)[6]) : ((int)(num2 * 1610900073) ^ ((int[])(object)array)[19]));
					continue;
				case 142u:
					num5 = array2[Convert.ToInt32(11.720584501801074 - Math.Sin(6.0))] << Convert.ToInt32(4.0 - Math.Truncate(1.5));
					num = ((((int[])(object)array)[120] + ((int[])(object)array)[86] > ((int[])(object)array)[111]) ? ((int)(num2 * 2069239133) ^ ((int[])(object)array)[166]) : (((int)num2 * -1363183504) ^ ((int[])(object)array)[68]));
					continue;
				case 148u:
					num5 += (uint)((int)array2[Convert.ToInt32(5.522878745280337 + Math.Log10(3.0))] * -106);
					num = (((((int[])(object)array)[19] ^ ((int[])(object)array)[24]) > ((int[])(object)array)[4]) ? ((int)(num2 * 842929057) ^ ((int[])(object)array)[35]) : ((int)(num2 * 1737714223) ^ ((int[])(object)array)[45]));
					continue;
				case 91u:
					array2[Convert.ToInt32(7.0 - Math.Truncate(2.5))] = num7;
					num = ((((int[])(object)array)[41] + ((int[])(object)array)[14] >= ((int[])(object)array)[50]) ? ((int)(num2 * 387405624) ^ ((int[])(object)array)[35]) : ((int)(num2 * 1285469370) ^ ((int[])(object)array)[61]));
					continue;
				case 139u:
					num17 = 0;
					num = (((((int[])(object)array)[16] ^ ((int[])(object)array)[16]) <= ((int[])(object)array)[5]) ? (((int)num2 * -2010740956) ^ ((int[])(object)array)[28]) : ((int)(num2 * 713500386) ^ ((int[])(object)array)[28]));
					continue;
				case 183u:
					array2[Convert.ToInt32(21.0 - Math.Floor(7.0))] = array2[Convert.ToInt32(11.6094379124341 - Math.Log(5.0))];
					num = ((((int[])(object)array)[144] + ((int[])(object)array)[62] != ((int[])(object)array)[18]) ? (((int)num2 * -1987823680) ^ ((int[])(object)array)[199]) : (((int)num2 * -1236443623) ^ ((int[])(object)array)[93]));
					continue;
				case 129u:
					num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[5]) >= ((int[])(object)array)[2]) ? (((int)num2 * -1482630563) ^ ((int[])(object)array)[17]) : (((int)num2 * -2127513912) ^ ((int[])(object)array)[26]));
					continue;
				case 168u:
					num7 += array2[Convert.ToInt32(2.0 - Math.Log10(1.0))] << Convert.ToInt32(6.0 - Math.Abs(2.0));
					num = ((((int[])(object)array)[140] + ((int[])(object)array)[150] == ((int[])(object)array)[147]) ? (((int)num2 * -898417934) ^ ((int[])(object)array)[1]) : (((int)num2 * -1838275644) ^ ((int[])(object)array)[181]));
					continue;
				case 78u:
					num5 = array2[Convert.ToInt32(15.945910149055313 - Math.Log(7.0))] * 4140998273u;
					num = (((((int[])(object)array)[89] ^ ((int[])(object)array)[28]) != ((int[])(object)array)[188]) ? (((int)num2 * -1050803278) ^ ((int[])(object)array)[198]) : ((int)(num2 * 1197615370) ^ ((int[])(object)array)[138]));
					continue;
				case 198u:
					array2[1] = array2[1] << Convert.ToInt32(4.083709268125845 + Math.Log(2.5));
					num = (((((int[])(object)array)[118] ^ ((int[])(object)array)[77]) != ((int[])(object)array)[108]) ? (((int)num2 * -1092039273) ^ ((int[])(object)array)[133]) : (((int)num2 * -1328426181) ^ ((int[])(object)array)[47]));
					continue;
				case 102u:
					array2[Convert.ToInt32(19.0 - Math.Truncate(6.5))] = array2[Convert.ToInt32(7.0 + Math.Floor(6.5))] ^ (uint)Convert.ToInt32(2703587790.0 - Math.Ceiling(901195930.0));
					num = ((((int[])(object)array)[54] + ((int[])(object)array)[21] == ((int[])(object)array)[69]) ? (((int)num2 * -2066023189) ^ ((int[])(object)array)[1]) : (((int)num2 * -283213837) ^ ((int[])(object)array)[72]));
					continue;
				case 189u:
					if (flag)
					{
						num31 = *(uint*)((byte*)ptr2 + (nint)Convert.ToInt32(2.0 + Math.Log10(1.0)) * (nint)Convert.ToInt32(4.301029995663981 - Math.Log10(2.0)));
						goto IL_3053;
					}
					num = ((((int[])(object)array)[4] + ((int[])(object)array)[8] >= ((int[])(object)array)[5]) ? ((int)(num2 * 410875208) ^ ((int[])(object)array)[1]) : (((int)num2 * -1352429523) ^ ((int[])(object)array)[13]));
					continue;
				case 166u:
					num5 = array2[Convert.ToInt32(6.878679656440358 + Math.Sqrt(4.5))] * 4294966941u;
					num = ((((int[])(object)array)[127] + ((int[])(object)array)[111] < ((int[])(object)array)[71]) ? ((int)(num2 * 1352089442) ^ ((int[])(object)array)[11]) : (((int)num2 * -1428197744) ^ ((int[])(object)array)[128]));
					continue;
				case 124u:
					array2[Convert.ToInt32(6.613705638880109 + Math.Log(4.0))] = num3;
					num = ((((int[])(object)array)[96] + ((int[])(object)array)[129] >= ((int[])(object)array)[33]) ? (((int)num2 * -145694786) ^ ((int[])(object)array)[149]) : ((int)(num2 * 1555958585) ^ ((int[])(object)array)[103]));
					continue;
				case 97u:
					num7 = array2[1] >> Convert.ToInt32(27.803784426551623 - Math.Sin(13.5));
					num = (((((int[])(object)array)[13] ^ ((int[])(object)array)[27]) == ((int[])(object)array)[6]) ? ((int)(num2 * 1881649368) ^ ((int[])(object)array)[122]) : (((int)num2 * -2138254917) ^ ((int[])(object)array)[131]));
					continue;
				case 48u:
					num3 += (uint)((int)array2[Convert.ToInt32(4.01338570184857 + Math.Tanh(2.5))] * Convert.ToInt32(30.99999999999981 - Math.Tanh(15.0)));
					num = (((((int[])(object)array)[24] ^ ((int[])(object)array)[73]) >= ((int[])(object)array)[93]) ? (((int)num2 * -333094015) ^ ((int[])(object)array)[94]) : ((int)(num2 * 68944700) ^ ((int[])(object)array)[111]));
					continue;
				case 72u:
					array2[Convert.ToInt32(11.121320343559642 - Math.Sqrt(4.5))] = array2[Convert.ToInt32(7.495922603223725 + Math.Log(4.5))] | num7;
					num = (((((int[])(object)array)[70] ^ ((int[])(object)array)[41]) >= ((int[])(object)array)[61]) ? ((int)(num2 * 44530480) ^ ((int[])(object)array)[97]) : (((int)num2 * -1855674935) ^ ((int[])(object)array)[68]));
					continue;
				case 38u:
					num28 = 0;
					num = ((((int[])(object)array)[8] + ((int[])(object)array)[5] >= ((int[])(object)array)[7]) ? ((int)(num2 * 1611195904) ^ ((int[])(object)array)[8]) : ((int)(num2 * 101831552) ^ ((int[])(object)array)[8]));
					continue;
				case 61u:
					array2[Convert.ToInt32(7.09861228866811 - Math.Log(3.0))] = array2[Convert.ToInt32(7.732050807568877 - Math.Sqrt(3.0))] + 4104306935u;
					num = (((((int[])(object)array)[143] ^ ((int[])(object)array)[90]) != ((int[])(object)array)[32]) ? (((int)num2 * -1172488994) ^ ((int[])(object)array)[191]) : (((int)num2 * -437409285) ^ ((int[])(object)array)[156]));
					continue;
				case 138u:
				{
					uint num36 = num20;
					uint* ptr8 = ptr5;
					ptr5 = (uint*)((byte*)ptr8 + Convert.ToInt32(4.693147180559945 - Math.Log(2.0)));
					uint num37 = (num36 ^ *ptr8) + num18 + num9 * num10;
					num20 = num18;
					num18 = num9;
					num18 = num10;
					num10 = num37;
					num = (((((int[])(object)array)[17] ^ ((int[])(object)array)[2]) <= ((int[])(object)array)[12]) ? ((int[])(object)array)[20] : ((int)(num2 * 1481746124) ^ ((int[])(object)array)[8]));
					continue;
				}
				case 185u:
					num3 = array2[Convert.ToInt32(18.0 - Math.Abs(6.0))] * (uint)Convert.ToInt32(88.0 - Math.Tanh(43.5));
					num = (((((int[])(object)array)[63] ^ ((int[])(object)array)[84]) <= ((int[])(object)array)[79]) ? ((int)(num2 * 798883234) ^ ((int[])(object)array)[72]) : (((int)num2 * -2052398263) ^ ((int[])(object)array)[87]));
					continue;
				case 25u:
				{
					int num34;
					int num35;
					if (num11 == 3277223862u)
					{
						num34 = -1170761307;
						num35 = num34;
					}
					else
					{
						num34 = -745991118;
						num35 = num34;
					}
					num = num34 ^ ((int)num2 * ((int[])(object)array)[11]);
					continue;
				}
				case 225u:
					num5 += (uint)((int)array2[Convert.ToInt32(6.0 - Math.Ceiling(2.0))] * Convert.ToInt32(227.0 - Math.Tanh(113.0)));
					num = (((((int[])(object)array)[73] ^ ((int[])(object)array)[115]) <= ((int[])(object)array)[127]) ? ((int)(num2 * 1544614688) ^ ((int[])(object)array)[16]) : (((int)num2 * -1092235659) ^ ((int[])(object)array)[142]));
					continue;
				case 156u:
					array2[0] = array2[0] ^ array3[0];
					num = ((((int[])(object)array)[15] + ((int[])(object)array)[1] >= ((int[])(object)array)[10]) ? ((int)(num2 * 1101884004) ^ ((int[])(object)array)[78]) : (((int)num2 * -549541600) ^ ((int[])(object)array)[189]));
					continue;
				case 37u:
					num7 += (uint)((int)array2[Convert.ToInt32(3.9974949866040546 - Math.Sin(1.5))] * Convert.ToInt32(28.471278270002045 - Math.Tan(20.5)));
					num = ((((int[])(object)array)[66] + ((int[])(object)array)[58] <= ((int[])(object)array)[57]) ? (((int)num2 * -1761214759) ^ ((int[])(object)array)[77]) : (((int)num2 * -761697383) ^ ((int[])(object)array)[104]));
					continue;
				case 175u:
					num7 += (uint)((int)array2[Convert.ToInt32(4.0 + Math.Ceiling(4.0))] * Convert.ToInt32(33.0 - Math.Ceiling(11.0)));
					num = (((((int[])(object)array)[28] ^ ((int[])(object)array)[30]) > ((int[])(object)array)[93]) ? ((int)(num2 * 724762230) ^ ((int[])(object)array)[140]) : ((int)(num2 * 2085451855) ^ ((int[])(object)array)[136]));
					continue;
				case 134u:
					array2[Convert.ToInt32(11.121320343559642 - Math.Sqrt(4.5))] = array2[Convert.ToInt32(5.0 + Math.Round(4.5))] >> Convert.ToInt32(3.3068528194400546 + Math.Log(2.0));
					num = (((((int[])(object)array)[76] ^ ((int[])(object)array)[31]) == ((int[])(object)array)[1]) ? ((int)(num2 * 1419680924) ^ ((int[])(object)array)[49]) : (((int)num2 * -1990565419) ^ ((int[])(object)array)[96]));
					continue;
				case 60u:
					num21 = (uint)Convert.ToInt32(32.0 + Math.Abs(32.0));
					num = ((((int[])(object)array)[135] + ((int[])(object)array)[74] == ((int[])(object)array)[12]) ? (((int)num2 * -121304914) ^ ((int[])(object)array)[188]) : ((int)(num2 * 1509619082) ^ ((int[])(object)array)[210]));
					continue;
				case 90u:
					num5 *= 3629250209u;
					num = (((((int[])(object)array)[53] ^ ((int[])(object)array)[141]) != ((int[])(object)array)[188]) ? ((int)(num2 * 1563247339) ^ ((int[])(object)array)[195]) : (((int)num2 * -1965266645) ^ ((int[])(object)array)[107]));
					continue;
				case 32u:
					array2[Convert.ToInt32(17.0 - Math.Round(5.5))] = array2[Convert.ToInt32(10.000033402843696 + Math.Tanh(5.5))] | (uint)((int)num7 * -2059672527);
					num = (((((int[])(object)array)[101] ^ ((int[])(object)array)[30]) <= ((int[])(object)array)[92]) ? (((int)num2 * -1510630390) ^ ((int[])(object)array)[34]) : ((int)(num2 * 340446035) ^ ((int[])(object)array)[130]));
					continue;
				case 1u:
					num3 = array2[Convert.ToInt32(5.801143615546934 + Math.Cos(2.5))] & 0xC20707DDu;
					num = (((((int[])(object)array)[25] ^ ((int[])(object)array)[95]) >= ((int[])(object)array)[21]) ? ((int)(num2 * 1795410393) ^ ((int[])(object)array)[150]) : ((int)(num2 * 220856636) ^ ((int[])(object)array)[106]));
					continue;
				case 115u:
				{
					uint* ptr6 = ptr2;
					ptr2 = (uint*)((byte*)ptr6 + Convert.ToInt32(6.0 - Math.Round(2.0)));
					uint num27 = *ptr6;
					uint* ptr7 = ptr2;
					ptr2 = (uint*)((byte*)ptr7 + Convert.ToInt32(6.0 - Math.Truncate(2.0)));
					num11 = num27 * *ptr7;
					num = ((((int[])(object)array)[9] + ((int[])(object)array)[7] != ((int[])(object)array)[7]) ? ((int[])(object)array)[10] : ((int)(num2 * 473306184) ^ ((int[])(object)array)[4]));
					continue;
				}
				case 30u:
					num5 += (uint)((int)array2[0] * Convert.ToInt32(10.294459674429609 - Math.Sin(5.5)));
					num = ((((int[])(object)array)[123] + ((int[])(object)array)[131] == ((int[])(object)array)[134]) ? ((int)(num2 * 428394864) ^ ((int[])(object)array)[107]) : (((int)num2 * -1222977876) ^ ((int[])(object)array)[172]));
					continue;
				case 146u:
					array2[Convert.ToInt32(10.5 - Math.Abs(3.5))] = array2[Convert.ToInt32(5.12917130661303 + Math.Sqrt(3.5))] + (uint)Convert.ToInt32(382855185.0 + Math.Round(382855185.0));
					num = ((((int[])(object)array)[118] + ((int[])(object)array)[19] <= ((int[])(object)array)[124]) ? (((int)num2 * -1164352979) ^ ((int[])(object)array)[183]) : (((int)num2 * -1010564107) ^ ((int[])(object)array)[21]));
					continue;
				case 122u:
					num8 = array2[Convert.ToInt32(11.121320343559642 - Math.Sqrt(4.5))] * 4294967245u;
					num = (((((int[])(object)array)[50] ^ ((int[])(object)array)[94]) > ((int[])(object)array)[24]) ? (((int)num2 * -310981572) ^ ((int[])(object)array)[121]) : (((int)num2 * -1681305927) ^ ((int[])(object)array)[137]));
					continue;
				case 117u:
					num7 = array2[Convert.ToInt32(18.0 - Math.Abs(6.0))] * 4294967228u;
					num = ((((int[])(object)array)[44] + ((int[])(object)array)[11] != ((int[])(object)array)[32]) ? (((int)num2 * -2024290470) ^ ((int[])(object)array)[103]) : ((int)(num2 * 723180279) ^ ((int[])(object)array)[49]));
					continue;
				case 130u:
					array2[Convert.ToInt32(3.0 - Math.Round(1.0))] = array2[Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0))] | (uint)((int)num5 * -1570679145);
					num = ((((int[])(object)array)[182] + ((int[])(object)array)[48] == ((int[])(object)array)[134]) ? (((int)num2 * -1626652623) ^ ((int[])(object)array)[114]) : (((int)num2 * -823378703) ^ ((int[])(object)array)[208]));
					continue;
				case 140u:
					num7 += (uint)((int)array2[Convert.ToInt32(5.010007503399555 - Math.Cos(3.0))] * -52);
					num = ((((int[])(object)array)[53] + ((int[])(object)array)[45] >= ((int[])(object)array)[21]) ? ((int)(num2 * 1172394145) ^ ((int[])(object)array)[58]) : ((int)(num2 * 1224540935) ^ ((int[])(object)array)[32]));
					continue;
				case 33u:
					num8 += (uint)((int)array2[Convert.ToInt32(2.8239087409443187 + Math.Log10(1.5))] * -26);
					num = (((((int[])(object)array)[15] ^ ((int[])(object)array)[76]) > ((int[])(object)array)[57]) ? ((int)(num2 * 1106311898) ^ ((int[])(object)array)[110]) : (((int)num2 * -1201042126) ^ ((int[])(object)array)[12]));
					continue;
				case 181u:
					array2[Convert.ToInt32(9.0 - Math.Round(3.0))] = array2[Convert.ToInt32(6.141120008059867 - Math.Sin(3.0))] ^ array3[Convert.ToInt32(6.9950547536867305 - Math.Tanh(3.0))];
					num = (((((int[])(object)array)[108] ^ ((int[])(object)array)[27]) >= ((int[])(object)array)[53]) ? ((int)(num2 * 901541332) ^ ((int[])(object)array)[11]) : (((int)num2 * -635968740) ^ ((int[])(object)array)[109]));
					continue;
				case 203u:
					num7 *= 2472342737u;
					num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[75]) >= ((int[])(object)array)[89]) ? ((int)(num2 * 629449915) ^ ((int[])(object)array)[126]) : ((int)(num2 * 1597826972) ^ ((int[])(object)array)[93]));
					continue;
				case 155u:
					array2[Convert.ToInt32(8.3905620875659 + Math.Log(5.0))] = array2[Convert.ToInt32(15.0 - Math.Truncate(5.0))] & (uint)Convert.ToInt32(1394832469.843492 - Math.Log10(697416230.5));
					num = (((((int[])(object)array)[52] ^ ((int[])(object)array)[50]) >= ((int[])(object)array)[7]) ? ((int)(num2 * 573330691) ^ ((int[])(object)array)[43]) : ((int)(num2 * 514285961) ^ ((int[])(object)array)[73]));
					continue;
				case 167u:
					array2[Convert.ToInt32(4.362667945448815 + Math.Tan(4.5))] = array2[Convert.ToInt32(8.346787486224656 + Math.Log10(4.5))] ^ array3[Convert.ToInt32(9.653212513775344 - Math.Log10(4.5))];
					num = (((((int[])(object)array)[28] ^ ((int[])(object)array)[76]) != ((int[])(object)array)[20]) ? (((int)num2 * -1333342340) ^ ((int[])(object)array)[86]) : ((int)(num2 * 746462479) ^ ((int[])(object)array)[42]));
					continue;
				case 93u:
				{
					int num22;
					int num23;
					if (num21 == (uint)Convert.ToInt32(96.0 - Math.Truncate(32.0)))
					{
						num22 = 963596209;
						num23 = num22;
					}
					else
					{
						num22 = 1930256478;
						num23 = num22;
					}
					num = num22 ^ ((int)num2 * ((int[])(object)array)[212]);
					continue;
				}
				case 28u:
					array2[0] = array2[0] | (array2[Convert.ToInt32(1.8149601367384811 - Math.Tan(2.0))] & (uint)Convert.ToInt32(702504358.0 + Math.Abs(702504358.0)));
					num = ((((int[])(object)array)[95] + ((int[])(object)array)[124] <= ((int[])(object)array)[63]) ? (((int)num2 * -1480443544) ^ ((int[])(object)array)[193]) : ((int)(num2 * 461015773) ^ ((int[])(object)array)[11]));
					continue;
				case 75u:
					num8 += (uint)((int)array2[Convert.ToInt32(4.0 + Math.Ceiling(4.0))] * -18);
					num = (((((int[])(object)array)[11] ^ ((int[])(object)array)[106]) != ((int[])(object)array)[26]) ? (((int)num2 * -2131966174) ^ ((int[])(object)array)[115]) : (((int)num2 * -1363435252) ^ ((int[])(object)array)[56]));
					continue;
				case 11u:
					num8 += (uint)((int)array2[Convert.ToInt32(7.9364566872907965 + Math.Cos(3.5))] * Convert.ToInt32(14.000000611804454 + Math.Tanh(7.5)));
					num = (((((int[])(object)array)[127] ^ ((int[])(object)array)[44]) > ((int[])(object)array)[12]) ? (((int)num2 * -1341149568) ^ ((int[])(object)array)[132]) : (((int)num2 * -332992050) ^ ((int[])(object)array)[146]));
					continue;
				case 204u:
					num8 += (uint)((int)array2[0] * -166);
					num = (((((int[])(object)array)[67] ^ ((int[])(object)array)[21]) >= ((int[])(object)array)[70]) ? ((int)(num2 * 1096876585) ^ ((int[])(object)array)[56]) : ((int)(num2 * 1012515591) ^ ((int[])(object)array)[167]));
					continue;
				case 154u:
					num7 = array2[0] >> Convert.ToInt32(28.82390874094432 + Math.Log10(15.0));
					num = ((((int[])(object)array)[33] + ((int[])(object)array)[4] < ((int[])(object)array)[14]) ? ((int)(num2 * 1225617420) ^ ((int[])(object)array)[27]) : ((int)(num2 * 783300506) ^ ((int[])(object)array)[38]));
					continue;
				case 164u:
					array2[Convert.ToInt32(10.999909204262595 - Math.Tanh(5.0))] = array2[Convert.ToInt32(9.301029995663981 + Math.Log10(5.0))] ^ array3[Convert.ToInt32(5.0 + Math.Floor(5.0))];
					num = (((((int[])(object)array)[37] ^ ((int[])(object)array)[38]) <= ((int[])(object)array)[12]) ? (((int)num2 * -285037083) ^ ((int[])(object)array)[40]) : (((int)num2 * -410767943) ^ ((int[])(object)array)[19]));
					continue;
				case 201u:
					array2[Convert.ToInt32(2.0 + Math.Log10(1.0))] = num7;
					num = ((((int[])(object)array)[108] + ((int[])(object)array)[151] >= ((int[])(object)array)[17]) ? ((int)(num2 * 1690599261) ^ ((int[])(object)array)[196]) : ((int)(num2 * 589615156) ^ ((int[])(object)array)[7]));
					continue;
				case 50u:
					num7 = array2[Convert.ToInt32(3.0 + Math.Floor(2.5))] * (uint)Convert.ToInt32(32.807886552931954 - Math.Sqrt(14.5));
					num = (((((int[])(object)array)[52] ^ ((int[])(object)array)[4]) >= ((int[])(object)array)[23]) ? (((int)num2 * -2125709257) ^ ((int[])(object)array)[45]) : (((int)num2 * -1573876453) ^ ((int[])(object)array)[53]));
					continue;
				case 214u:
					num3 += (uint)((int)array2[Convert.ToInt32(-11.101419947171719 + Math.Tan(1.5))] * -50);
					num = ((((int[])(object)array)[48] + ((int[])(object)array)[68] <= ((int[])(object)array)[46]) ? ((int)(num2 * 2020003313) ^ ((int[])(object)array)[28]) : ((int)(num2 * 285753180) ^ ((int[])(object)array)[107]));
					continue;
				case 16u:
					num8 = array2[Convert.ToInt32(18.0 - Math.Truncate(6.0))] * (uint)Convert.ToInt32(41.16334436146394 + Math.Sin(21.0));
					num = ((((int[])(object)array)[33] + ((int[])(object)array)[92] <= ((int[])(object)array)[79]) ? (((int)num2 * -12890040) ^ ((int[])(object)array)[106]) : (((int)num2 * -604092243) ^ ((int[])(object)array)[95]));
					continue;
				case 31u:
				{
					int num12;
					if (num11 == 0)
					{
						num = 202145635;
						num12 = num;
					}
					else
					{
						num = 1419375084;
						num12 = num;
					}
					continue;
				}
				case 6u:
					num5 += (uint)((int)array2[Convert.ToInt32(6.625414359841406 + Math.Tan(3.5))] * Convert.ToInt32(53.0 + Math.Floor(52.5)));
					num = (((((int[])(object)array)[37] ^ ((int[])(object)array)[60]) < ((int[])(object)array)[134]) ? ((int)(num2 * 1278525723) ^ ((int[])(object)array)[145]) : (((int)num2 * -1265365763) ^ ((int[])(object)array)[44]));
					continue;
				case 106u:
					num7 += (uint)((int)array2[Convert.ToInt32(3.5838531634528574 - Math.Cos(2.0))] * -51);
					num = (((((int[])(object)array)[70] ^ ((int[])(object)array)[70]) < ((int[])(object)array)[0]) ? ((int)(num2 * 1360874422) ^ ((int[])(object)array)[136]) : (((int)num2 * -1941899545) ^ ((int[])(object)array)[19]));
					continue;
				case 52u:
					num8 = array2[Convert.ToInt32(4.909297426825682 - Math.Sin(2.0))] << Convert.ToInt32(22.302585092994047 - Math.Log(10.0));
					num = ((((int[])(object)array)[6] + ((int[])(object)array)[51] > ((int[])(object)array)[11]) ? ((int)(num2 * 1650451627) ^ ((int[])(object)array)[95]) : ((int)(num2 * 1232879572) ^ ((int[])(object)array)[40]));
					continue;
				case 137u:
					*ptr3 ^= array2[num6 & (uint)Convert.ToInt32(15.346635317835025 - Math.Cos(7.5))];
					num = (((((int[])(object)array)[148] ^ ((int[])(object)array)[105]) >= ((int[])(object)array)[208]) ? ((int[])(object)array)[217] : ((int)(num2 * 1552597773) ^ ((int[])(object)array)[29]));
					continue;
				case 141u:
					ptr3 = (uint*)(ptr + (uint)(flag ? (*(int*)((byte*)ptr2 + (nint)Convert.ToInt32(2.0025050133959454 + Math.Sin(1.5)) * (nint)Convert.ToInt32(3.035972419924183 + Math.Tanh(2.0)))) : (*(int*)((byte*)ptr2 + Convert.ToInt32(4.301029995663981 - Math.Log10(2.0))))));
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[6]) > ((int[])(object)array)[4]) ? (((int)num2 * -1213510220) ^ ((int[])(object)array)[11]) : ((int[])(object)array)[12]);
					continue;
				case 180u:
					num6 = 0u;
					num = ((((int[])(object)array)[23] + ((int[])(object)array)[109] >= ((int[])(object)array)[23]) ? (((int)num2 * -1227512840) ^ ((int[])(object)array)[145]) : ((int[])(object)array)[214]);
					continue;
				case 218u:
					num5 += (uint)((int)array2[Convert.ToInt32(1.0 + Math.Round(1.0))] * -6);
					num = ((((int[])(object)array)[148] + ((int[])(object)array)[99] <= ((int[])(object)array)[75]) ? (((int)num2 * -695211706) ^ ((int[])(object)array)[136]) : (((int)num2 * -1947362160) ^ ((int[])(object)array)[180]));
					continue;
				case 3u:
					num5 += (uint)((int)array2[Convert.ToInt32(7.243197504692072 - Math.Sin(4.0))] * Convert.ToInt32(75.56540286659131 + Math.Tan(36.5)));
					num = (((((int[])(object)array)[34] ^ ((int[])(object)array)[62]) <= ((int[])(object)array)[15]) ? (((int)num2 * -2054638823) ^ ((int[])(object)array)[122]) : (((int)num2 * -158462079) ^ ((int[])(object)array)[4]));
					continue;
				case 24u:
					num3 += (uint)((int)array2[0] * Convert.ToInt32(80.08276253029823 - Math.Sqrt(37.0)));
					num = (((((int[])(object)array)[56] ^ ((int[])(object)array)[163]) != ((int[])(object)array)[151]) ? (((int)num2 * -1658498595) ^ ((int[])(object)array)[177]) : ((int)(num2 * 1516325235) ^ ((int[])(object)array)[91]));
					continue;
				case 159u:
					array2[Convert.ToInt32(2.0 + Math.Ceiling(2.0))] = array2[Convert.ToInt32(2.585786437626905 + Math.Sqrt(2.0))] >> Convert.ToInt32(6.0 + Math.Floor(6.0));
					num = (((((int[])(object)array)[66] ^ ((int[])(object)array)[95]) >= ((int[])(object)array)[70]) ? (((int)num2 * -1939997696) ^ ((int[])(object)array)[98]) : (((int)num2 * -1339052931) ^ ((int[])(object)array)[10]));
					continue;
				case 109u:
					array2[Convert.ToInt32(12.293986133227309 + Math.Tan(7.5))] = array2[Convert.ToInt32(14.653364682164975 + Math.Cos(7.5))] ^ array3[Convert.ToInt32(12.261387212474169 + Math.Sqrt(7.5))];
					num = ((((int[])(object)array)[112] + ((int[])(object)array)[87] <= ((int[])(object)array)[40]) ? ((int)(num2 * 1883798567) ^ ((int[])(object)array)[116]) : ((int)(num2 * 545804019) ^ ((int[])(object)array)[103]));
					continue;
				case 41u:
					num10 = (uint)Convert.ToInt32(1381284799.0 - Math.Tanh(690642399.0));
					num = (((((int[])(object)array)[5] ^ ((int[])(object)array)[1]) > ((int[])(object)array)[1]) ? ((int)(num2 * 1100367305) ^ ((int[])(object)array)[1]) : ((int)(num2 * 1846192477) ^ ((int[])(object)array)[7]));
					continue;
				case 177u:
					num8 = array2[Convert.ToInt32(14.449489742783179 - Math.Sqrt(6.0))] * 4294967155u;
					num = ((((int[])(object)array)[19] + ((int[])(object)array)[49] < ((int[])(object)array)[64]) ? ((int)(num2 * 709340819) ^ ((int[])(object)array)[163]) : ((int)(num2 * 528124155) ^ ((int[])(object)array)[121]));
					continue;
				case 125u:
					array2[Convert.ToInt32(2.0 - Math.Log(1.0))] = array2[Convert.ToInt32(1.1585290151921035 + Math.Sin(1.0))] ^ array3[Convert.ToInt32(1.2384058440442351 + Math.Tanh(1.0))];
					num = (((((int[])(object)array)[47] ^ ((int[])(object)array)[20]) >= ((int[])(object)array)[35]) ? ((int)(num2 * 1710743171) ^ ((int[])(object)array)[51]) : (((int)num2 * -1679305844) ^ ((int[])(object)array)[12]));
					continue;
				case 186u:
					_200E_200E_202A_202B_200E_200C_200E_200B_200E_200E_200E_200C_200E_202B_200F_200F()((IntPtr)ptr3, num15 << Convert.ToInt32(3.0 - Math.Abs(1.0)), num21, out num21);
					num = (((((int[])(object)array)[40] ^ ((int[])(object)array)[138]) > ((int[])(object)array)[108]) ? (((int)num2 * -788265702) ^ ((int[])(object)array)[211]) : ((int)(num2 * 55019692) ^ ((int[])(object)array)[5]));
					continue;
				case 73u:
					num5 += array2[Convert.ToInt32(3.0 + Math.Ceiling(3.0))] << 1;
					num = (((((int[])(object)array)[51] ^ ((int[])(object)array)[43]) >= ((int[])(object)array)[154]) ? ((int)(num2 * 302463809) ^ ((int[])(object)array)[186]) : (((int)num2 * -769089526) ^ ((int[])(object)array)[0]));
					continue;
				case 69u:
					num18 = (num9 >> Convert.ToInt32(1.5 + Math.Abs(1.5))) | (num9 << Convert.ToInt32(31.674148649426527 - Math.Log(14.5)));
					num = (((((int[])(object)array)[33] ^ ((int[])(object)array)[16]) != ((int[])(object)array)[13]) ? (((int)num2 * -2138246734) ^ ((int[])(object)array)[33]) : (((int)num2 * -963430790) ^ ((int[])(object)array)[3]));
					continue;
				case 84u:
					num14++;
					num = ((((int[])(object)array)[59] + ((int[])(object)array)[95] <= ((int[])(object)array)[51]) ? (((int)num2 * -1291198695) ^ ((int[])(object)array)[123]) : (((int)num2 * -1205313666) ^ ((int[])(object)array)[220]));
					continue;
				case 113u:
					array2[Convert.ToInt32(4.0 + Math.Floor(3.5))] = array2[Convert.ToInt32(5.747237031504632 + Math.Log(3.5))] * 3054432229u;
					num = (((((int[])(object)array)[81] ^ ((int[])(object)array)[55]) < ((int[])(object)array)[4]) ? ((int)(num2 * 384820439) ^ ((int[])(object)array)[82]) : ((int)(num2 * 1126046179) ^ ((int[])(object)array)[37]));
					continue;
				case 89u:
					num13++;
					num = ((((int[])(object)array)[21] + ((int[])(object)array)[2] <= ((int[])(object)array)[12]) ? ((int)(num2 * 791022141) ^ ((int[])(object)array)[21]) : ((int)(num2 * 462294067) ^ ((int[])(object)array)[9]));
					continue;
				case 79u:
					num7 += (uint)((int)array2[Convert.ToInt32(11.000012288349204 + Math.Tanh(6.0))] * -7);
					num = ((((int[])(object)array)[45] + ((int[])(object)array)[21] == ((int[])(object)array)[35]) ? ((int)(num2 * 1408761813) ^ ((int[])(object)array)[24]) : (((int)num2 * -85723580) ^ ((int[])(object)array)[60]));
					continue;
				case 224u:
					num5 += (uint)((int)array2[Convert.ToInt32(3.9974949866040546 - Math.Sin(1.5))] * Convert.ToInt32(61.0 + Math.Floor(61.0)));
					num = ((((int[])(object)array)[5] + ((int[])(object)array)[8] <= ((int[])(object)array)[81]) ? ((int)(num2 * 264650160) ^ ((int[])(object)array)[57]) : ((int)(num2 * 913673622) ^ ((int[])(object)array)[88]));
					continue;
				case 14u:
					num28++;
					num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[20]) <= ((int[])(object)array)[12]) ? (((int)num2 * -1687202429) ^ ((int[])(object)array)[23]) : ((int)(num2 * 1203395041) ^ ((int[])(object)array)[22]));
					continue;
				case 74u:
					array2[1] = num8;
					num = (((((int[])(object)array)[38] ^ ((int[])(object)array)[33]) < ((int[])(object)array)[4]) ? ((int)(num2 * 656612723) ^ ((int[])(object)array)[18]) : (((int)num2 * -1746478825) ^ ((int[])(object)array)[66]));
					continue;
				case 82u:
					array2[0] = array2[0] & 0xAC4144B3u;
					num = ((((int[])(object)array)[140] + ((int[])(object)array)[171] >= ((int[])(object)array)[50]) ? ((int)(num2 * 53134836) ^ ((int[])(object)array)[174]) : ((int)(num2 * 1012496725) ^ ((int[])(object)array)[192]));
					continue;
				case 133u:
					num7 = array2[Convert.ToInt32(6.9950547536867305 - Math.Tanh(3.0))] & 0x8CAD66B6u;
					num = (((((int[])(object)array)[113] ^ ((int[])(object)array)[60]) < ((int[])(object)array)[83]) ? (((int)num2 * -640663657) ^ ((int[])(object)array)[121]) : (((int)num2 * -401508826) ^ ((int[])(object)array)[72]));
					continue;
				case 35u:
					array2[Convert.ToInt32(4.301029995663981 - Math.Log10(2.0))] = num5;
					num = (((((int[])(object)array)[53] ^ ((int[])(object)array)[105]) < ((int[])(object)array)[26]) ? (((int)num2 * -364479425) ^ ((int[])(object)array)[154]) : (((int)num2 * -1167502870) ^ ((int[])(object)array)[95]));
					continue;
				case 53u:
					num5 += (uint)((int)array2[Convert.ToInt32(7.243197504692072 - Math.Sin(4.0))] * -99);
					num = (((((int[])(object)array)[129] ^ ((int[])(object)array)[51]) != ((int[])(object)array)[122]) ? (((int)num2 * -685613944) ^ ((int[])(object)array)[148]) : (((int)num2 * -409322482) ^ ((int[])(object)array)[45]));
					continue;
				case 18u:
					num3 += (uint)((int)array2[1] * Convert.ToInt32(187.0 - Math.Round(62.5)));
					num = (((((int[])(object)array)[42] ^ ((int[])(object)array)[18]) < ((int[])(object)array)[27]) ? (((int)num2 * -1418995450) ^ ((int[])(object)array)[55]) : (((int)num2 * -767260215) ^ ((int[])(object)array)[55]));
					continue;
				case 174u:
					array2[Convert.ToInt32(6.619484993753414 - Math.Tan(5.0))] = array2[Convert.ToInt32(15.0 - Math.Truncate(5.0))] | (array2[Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0))] & 0xACDC8BB2u);
					num = (((((int[])(object)array)[70] ^ ((int[])(object)array)[27]) <= ((int[])(object)array)[6]) ? ((int)(num2 * 1920064682) ^ ((int[])(object)array)[75]) : (((int)num2 * -747397834) ^ ((int[])(object)array)[58]));
					continue;
				case 26u:
					array2[Convert.ToInt32(2.929262798332297 + Math.Cos(1.5))] = ~(array2[Convert.ToInt32(4.0 - Math.Truncate(1.5))] ^ array2[Convert.ToInt32(3.0 + Math.Round(2.5))]);
					num = (((((int[])(object)array)[69] ^ ((int[])(object)array)[15]) >= ((int[])(object)array)[10]) ? ((int)(num2 * 1883791843) ^ ((int[])(object)array)[31]) : (((int)num2 * -1612013744) ^ ((int[])(object)array)[76]));
					continue;
				case 66u:
					num20 = (num18 >> Convert.ToInt32(7.0 - Math.Floor(2.5))) | (num18 << Convert.ToInt32(30.674234614174768 - Math.Sqrt(13.5)));
					num = (((((int[])(object)array)[25] ^ ((int[])(object)array)[21]) > ((int[])(object)array)[8]) ? (((int)num2 * -900722748) ^ ((int[])(object)array)[6]) : (((int)num2 * -2012060143) ^ ((int[])(object)array)[32]));
					continue;
				case 99u:
					array2[Convert.ToInt32(9.041075725336862 - Math.Sin(5.0))] = array2[Convert.ToInt32(9.041075725336862 - Math.Sin(5.0))] + array2[Convert.ToInt32(21.0 - Math.Abs(7.0))];
					num = ((((int[])(object)array)[45] + ((int[])(object)array)[38] < ((int[])(object)array)[10]) ? (((int)num2 * -687251685) ^ ((int[])(object)array)[100]) : (((int)num2 * -548124931) ^ ((int[])(object)array)[88]));
					continue;
				case 163u:
					array2[Convert.ToInt32(6.9950547536867305 - Math.Tanh(3.0))] = array2[Convert.ToInt32(9.0 - Math.Round(3.0))] | (array2[Convert.ToInt32(5.0 + Math.Round(5.5))] & 0x8CAD66B6u);
					num = ((((int[])(object)array)[48] + ((int[])(object)array)[47] != ((int[])(object)array)[24]) ? (((int)num2 * -557051265) ^ ((int[])(object)array)[127]) : ((int)(num2 * 1463223539) ^ ((int[])(object)array)[108]));
					continue;
				case 144u:
					array2[Convert.ToInt32(9.653212513775344 - Math.Log10(4.5))] = array2[Convert.ToInt32(8.022469882334903 - Math.Sin(4.5))] + array2[Convert.ToInt32(7.0 + Math.Truncate(7.0))];
					num = (((((int[])(object)array)[50] ^ ((int[])(object)array)[61]) == ((int[])(object)array)[67]) ? (((int)num2 * -712704435) ^ ((int[])(object)array)[14]) : (((int)num2 * -1092294399) ^ ((int[])(object)array)[68]));
					continue;
				case 47u:
					num = (((((int[])(object)array)[202] ^ ((int[])(object)array)[116]) == ((int[])(object)array)[17]) ? (((int)num2 * -1955506921) ^ ((int[])(object)array)[150]) : ((int)(num2 * 887861387) ^ ((int[])(object)array)[209]));
					continue;
				case 95u:
					num5 += (uint)((int)array2[Convert.ToInt32(18.0 - Math.Round(6.0))] * -13);
					num = ((((int[])(object)array)[59] + ((int[])(object)array)[47] == ((int[])(object)array)[59]) ? (((int)num2 * -177025090) ^ ((int[])(object)array)[63]) : (((int)num2 * -1346535279) ^ ((int[])(object)array)[64]));
					continue;
				case 207u:
					num7 += (uint)((int)array2[Convert.ToInt32(3.0 + Math.Floor(3.0))] * -6);
					num = (((((int[])(object)array)[73] ^ ((int[])(object)array)[24]) != ((int[])(object)array)[112]) ? (((int)num2 * -37000190) ^ ((int[])(object)array)[182]) : (((int)num2 * -1263343589) ^ ((int[])(object)array)[24]));
					continue;
				case 178u:
					array2[Convert.ToInt32(3.3068528194400546 + Math.Log(2.0))] = array2[Convert.ToInt32(6.0 - Math.Floor(2.0))] & 0xAC4144B3u;
					num = (((((int[])(object)array)[20] ^ ((int[])(object)array)[141]) >= ((int[])(object)array)[131]) ? (((int)num2 * -910189929) ^ ((int[])(object)array)[194]) : (((int)num2 * -1563924702) ^ ((int[])(object)array)[178]));
					continue;
				case 217u:
					num3 += (uint)((int)array2[Convert.ToInt32(3.0 - Math.Floor(1.0))] * -37);
					num = ((((int[])(object)array)[11] + ((int[])(object)array)[44] >= ((int[])(object)array)[84]) ? ((int)(num2 * 1721588855) ^ ((int[])(object)array)[11]) : (((int)num2 * -1023877470) ^ ((int[])(object)array)[178]));
					continue;
				case 121u:
					array2[Convert.ToInt32(7.000670700260933 + Math.Tanh(4.0))] = ~(array2[Convert.ToInt32(6.613705638880109 + Math.Log(4.0))] ^ (uint)Convert.ToInt32(2376573075.0 - Math.Ceiling(792191025.0)));
					num = ((((int[])(object)array)[55] + ((int[])(object)array)[45] < ((int[])(object)array)[120]) ? (((int)num2 * -636902665) ^ ((int[])(object)array)[105]) : (((int)num2 * -2068460580) ^ ((int[])(object)array)[165]));
					continue;
				case 65u:
					num3 = array2[Convert.ToInt32(3.41886116991581 + Math.Sqrt(2.5))] * (uint)Convert.ToInt32(227.39187109718003 - Math.Sin(113.5));
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[37]) <= ((int[])(object)array)[20]) ? (((int)num2 * -1917376071) ^ ((int[])(object)array)[37]) : ((int)(num2 * 1076603288) ^ ((int[])(object)array)[18]));
					continue;
				case 197u:
					array2[Convert.ToInt32(16.64575131106459 - Math.Sqrt(7.0))] = array2[Convert.ToInt32(12.054089850944687 + Math.Log(7.0))] << Convert.ToInt32(5.747022297238661 + Math.Tan(2.5));
					num = (((((int[])(object)array)[50] ^ ((int[])(object)array)[102]) > ((int[])(object)array)[61]) ? ((int)(num2 * 1604653643) ^ ((int[])(object)array)[162]) : (((int)num2 * -1615738961) ^ ((int[])(object)array)[139]));
					continue;
				case 87u:
					num18 = 4079296522u;
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[0]) < ((int[])(object)array)[0]) ? (((int)num2 * -417927468) ^ ((int[])(object)array)[4]) : ((int)(num2 * 1548640865) ^ ((int[])(object)array)[0]));
					continue;
				case 209u:
					num3 += (uint)((int)array2[Convert.ToInt32(7.374585640158594 - Math.Tan(3.5))] * -49);
					num = ((((int[])(object)array)[129] + ((int[])(object)array)[81] == ((int[])(object)array)[14]) ? (((int)num2 * -332460227) ^ ((int[])(object)array)[70]) : ((int)(num2 * 1224473760) ^ ((int[])(object)array)[141]));
					continue;
				case 188u:
					num3 += (uint)((int)array2[Convert.ToInt32(14.449489742783179 - Math.Sqrt(6.0))] * -53);
					num = (((((int[])(object)array)[29] ^ ((int[])(object)array)[41]) == ((int[])(object)array)[4]) ? ((int)(num2 * 2006501102) ^ ((int[])(object)array)[10]) : (((int)num2 * -613104594) ^ ((int[])(object)array)[57]));
					continue;
				case 205u:
					array2[Convert.ToInt32(13.791759469228055 - Math.Log(6.0))] = num8;
					num = ((((int[])(object)array)[36] + ((int[])(object)array)[37] <= ((int[])(object)array)[173]) ? ((int)(num2 * 1891521648) ^ ((int[])(object)array)[117]) : ((int)(num2 * 267437260) ^ ((int[])(object)array)[206]));
					continue;
				case 77u:
					num5 += (uint)((int)array2[Convert.ToInt32(3.0 + Math.Round(2.5))] * -73);
					num = (((((int[])(object)array)[81] ^ ((int[])(object)array)[84]) == ((int[])(object)array)[10]) ? ((int)(num2 * 1408622046) ^ ((int[])(object)array)[20]) : (((int)num2 * -1879124021) ^ ((int[])(object)array)[99]));
					continue;
				case 105u:
					array2[Convert.ToInt32(11.0 - Math.Ceiling(3.5))] = array2[Convert.ToInt32(6.625414359841406 + Math.Tan(3.5))] ^ array3[Convert.ToInt32(3.0 + Math.Round(3.5))];
					num = ((((int[])(object)array)[10] + ((int[])(object)array)[119] <= ((int[])(object)array)[24]) ? (((int)num2 * -2006351211) ^ ((int[])(object)array)[174]) : (((int)num2 * -1408445569) ^ ((int[])(object)array)[5]));
					continue;
				case 107u:
					num17++;
					num = (((((int[])(object)array)[10] ^ ((int[])(object)array)[13]) <= ((int[])(object)array)[18]) ? (((int)num2 * -2005176690) ^ ((int[])(object)array)[12]) : (((int)num2 * -1976909845) ^ ((int[])(object)array)[36]));
					continue;
				case 150u:
					num7 = array2[Convert.ToInt32(14.653364682164975 + Math.Cos(7.5))] >> Convert.ToInt32(11.70899380861525 - Math.Tan(6.0));
					num = ((((int[])(object)array)[20] + ((int[])(object)array)[7] != ((int[])(object)array)[12]) ? ((int)(num2 * 1869734132) ^ ((int[])(object)array)[74]) : (((int)num2 * -1244742340) ^ ((int[])(object)array)[29]));
					continue;
				case 63u:
					num3 += (uint)((int)array2[Convert.ToInt32(7.09861228866811 - Math.Log(3.0))] * -413);
					num = (((((int[])(object)array)[27] ^ ((int[])(object)array)[32]) <= ((int[])(object)array)[27]) ? ((int)(num2 * 565759684) ^ ((int[])(object)array)[43]) : ((int)(num2 * 427242523) ^ ((int[])(object)array)[38]));
					continue;
				case 21u:
				{
					uint[] array4 = array2;
					int num24 = (int)num6 & Convert.ToInt32(12.261387212474169 + Math.Sqrt(7.5));
					uint num25 = array2[num6 & (uint)Convert.ToInt32(14.000000611804454 + Math.Tanh(7.5))];
					uint* ptr4 = ptr3;
					ptr3 = (uint*)((byte*)ptr4 + Convert.ToInt32(4.909297426825682 - Math.Sin(2.0)));
					array4[num24] = (num25 ^ *ptr4) + 2472163924u;
					num = (((((int[])(object)array)[214] ^ ((int[])(object)array)[136]) >= ((int[])(object)array)[23]) ? ((int)(num2 * 1420823381) ^ ((int[])(object)array)[146]) : ((int)(num2 * 1562483831) ^ ((int[])(object)array)[218]));
					continue;
				}
				case 212u:
					array2[Convert.ToInt32(17.10141994717172 - Math.Tan(1.5))] = array2[Convert.ToInt32(-11.101419947171719 + Math.Tan(1.5))] ^ array3[Convert.ToInt32(5.0 - Math.Ceiling(1.5))];
					num = ((((int[])(object)array)[31] + ((int[])(object)array)[31] >= ((int[])(object)array)[25]) ? (((int)num2 * -173662055) ^ ((int[])(object)array)[33]) : (((int)num2 * -1122332765) ^ ((int[])(object)array)[39]));
					continue;
				case 81u:
					num20 = (uint)Convert.ToInt32(102365457.0 - Math.Truncate(34121819.0));
					num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[2]) >= ((int[])(object)array)[0]) ? (((int)num2 * -1260714016) ^ ((int[])(object)array)[0]) : (((int)num2 * -836846051) ^ ((int[])(object)array)[3]));
					continue;
				case 13u:
					array2[Convert.ToInt32(5.916290731874155 - Math.Log(2.5))] = array2[Convert.ToInt32(7.5 - Math.Abs(2.5))] | (array2[Convert.ToInt32(6.619484993753414 - Math.Tan(5.0))] & 0xC20707DDu);
					num = (((((int[])(object)array)[61] ^ ((int[])(object)array)[138]) > ((int[])(object)array)[129]) ? (((int)num2 * -715062274) ^ ((int[])(object)array)[155]) : (((int)num2 * -2089701414) ^ ((int[])(object)array)[82]));
					continue;
				case 151u:
					num3 += array2[Convert.ToInt32(7.09861228866811 - Math.Log(3.0))] << Convert.ToInt32(3.070737201667703 - Math.Cos(1.5));
					num = (((((int[])(object)array)[183] ^ ((int[])(object)array)[75]) < ((int[])(object)array)[149]) ? (((int)num2 * -910731517) ^ ((int[])(object)array)[185]) : (((int)num2 * -1780322417) ^ ((int[])(object)array)[142]));
					continue;
				case 98u:
					array2[Convert.ToInt32(3.5 + Math.Abs(3.5))] = num8;
					num = (((((int[])(object)array)[71] ^ ((int[])(object)array)[38]) == ((int[])(object)array)[109]) ? ((int)(num2 * 793566035) ^ ((int[])(object)array)[142]) : (((int)num2 * -681273622) ^ ((int[])(object)array)[152]));
					continue;
				case 132u:
				{
					int num19;
					if (num17 >= Convert.ToInt32(15.854499966191387 - Math.Cos(8.0)))
					{
						num = 687967830;
						num19 = num;
					}
					else
					{
						num = 1487630086;
						num19 = num;
					}
					continue;
				}
				case 157u:
					num5 = array2[Convert.ToInt32(9.550510257216821 + Math.Sqrt(6.0))] * 4294967083u;
					num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[13]) > ((int[])(object)array)[26]) ? (((int)num2 * -2073579411) ^ ((int[])(object)array)[84]) : (((int)num2 * -1528480063) ^ ((int[])(object)array)[61]));
					continue;
				case 202u:
					array2[Convert.ToInt32(11.039829713349635 + Math.Cos(6.0))] = array2[Convert.ToInt32(11.000012288349204 + Math.Tanh(6.0))] ^ array3[Convert.ToInt32(6.0 + Math.Floor(6.0))];
					num = (((((int[])(object)array)[69] ^ ((int[])(object)array)[16]) < ((int[])(object)array)[13]) ? (((int)num2 * -1125123875) ^ ((int[])(object)array)[79]) : ((int)(num2 * 823316334) ^ ((int[])(object)array)[49]));
					continue;
				case 62u:
					array2[Convert.ToInt32(4.301029995663981 - Math.Log10(2.0))] = array2[Convert.ToInt32(4.909297426825682 - Math.Sin(2.0))] + 4111237607u;
					num = ((((int[])(object)array)[33] + ((int[])(object)array)[66] <= ((int[])(object)array)[45]) ? (((int)num2 * -1157996372) ^ ((int[])(object)array)[46]) : (((int)num2 * -1353997111) ^ ((int[])(object)array)[77]));
					continue;
				case 136u:
					array3[num17] = num18;
					num = (((((int[])(object)array)[28] ^ ((int[])(object)array)[3]) > ((int[])(object)array)[10]) ? (((int)num2 * -1387379272) ^ ((int[])(object)array)[31]) : ((int)(num2 * 1105718113) ^ ((int[])(object)array)[24]));
					continue;
				case 220u:
					num3 += (uint)((int)array2[Convert.ToInt32(12.0 - Math.Floor(4.0))] * -30);
					num = (((((int[])(object)array)[96] ^ ((int[])(object)array)[23]) == ((int[])(object)array)[102]) ? ((int)(num2 * 50236102) ^ ((int[])(object)array)[20]) : (((int)num2 * -1607542155) ^ ((int[])(object)array)[119]));
					continue;
				case 96u:
				{
					int num16;
					if (num14 >= num15)
					{
						num = 762111241;
						num16 = num;
					}
					else
					{
						num = 730083893;
						num16 = num;
					}
					continue;
				}
				case 5u:
					array2[Convert.ToInt32(4.909297426825682 - Math.Sin(2.0))] = array2[Convert.ToInt32(1.8149601367384811 - Math.Tan(2.0))] | (uint)((int)num5 * -7377567);
					num = ((((int[])(object)array)[35] + ((int[])(object)array)[187] <= ((int[])(object)array)[145]) ? ((int)(num2 * 1465502555) ^ ((int[])(object)array)[197]) : (((int)num2 * -549106742) ^ ((int[])(object)array)[71]));
					continue;
				case 100u:
					array2[Convert.ToInt32(9.0 - Math.Round(3.0))] = ~(array2[Convert.ToInt32(5.858879991940133 + Math.Sin(3.0))] ^ array2[Convert.ToInt32(1.0 + Math.Truncate(1.0))]);
					num = (((((int[])(object)array)[12] ^ ((int[])(object)array)[39]) >= ((int[])(object)array)[21]) ? (((int)num2 * -929105815) ^ ((int[])(object)array)[50]) : ((int)(num2 * 1096855213) ^ ((int[])(object)array)[90]));
					continue;
				case 222u:
					array2[Convert.ToInt32(6.0 + Math.Truncate(6.0))] = num5;
					num = ((((int[])(object)array)[38] + ((int[])(object)array)[39] < ((int[])(object)array)[49]) ? (((int)num2 * -1340265511) ^ ((int[])(object)array)[70]) : (((int)num2 * -1638353321) ^ ((int[])(object)array)[9]));
					continue;
				case 199u:
					num8 *= 2472727313u;
					num = ((((int[])(object)array)[13] + ((int[])(object)array)[31] >= ((int[])(object)array)[1]) ? (((int)num2 * -945343656) ^ ((int[])(object)array)[49]) : (((int)num2 * -906056995) ^ ((int[])(object)array)[81]));
					continue;
				case 162u:
					array2[Convert.ToInt32(6.878679656440358 + Math.Sqrt(4.5))] = num7;
					num = (((((int[])(object)array)[150] ^ ((int[])(object)array)[104]) != ((int[])(object)array)[79]) ? ((int)(num2 * 1230375198) ^ ((int[])(object)array)[156]) : (((int)num2 * -587535459) ^ ((int[])(object)array)[138]));
					continue;
				case 169u:
					num13 = 0u;
					num = ((((int[])(object)array)[3] + ((int[])(object)array)[7] == ((int[])(object)array)[13]) ? ((int)(num2 * 895280313) ^ ((int[])(object)array)[12]) : (((int)num2 * -865190642) ^ ((int[])(object)array)[18]));
					continue;
				case 15u:
					num9 = (num10 >> Convert.ToInt32(10.0 - Math.Floor(3.5))) | (num10 << Convert.ToInt32(13.0 + Math.Floor(12.5)));
					num = ((((int[])(object)array)[13] + ((int[])(object)array)[14] >= ((int[])(object)array)[10]) ? (((int)num2 * -449022042) ^ ((int[])(object)array)[23]) : (((int)num2 * -868594962) ^ ((int[])(object)array)[34]));
					continue;
				case 158u:
					num5 = array2[Convert.ToInt32(15.999999388195546 - Math.Tanh(7.5))] & 0xFD37A819u;
					num = (((((int[])(object)array)[72] ^ ((int[])(object)array)[55]) < ((int[])(object)array)[103]) ? (((int)num2 * -1781280758) ^ ((int[])(object)array)[201]) : (((int)num2 * -447856581) ^ ((int[])(object)array)[24]));
					continue;
				case 51u:
					num7 += (uint)((int)array2[Convert.ToInt32(6.0 + Math.Sqrt(4.0))] * Convert.ToInt32(27.594920663309892 - Math.Cos(13.5)));
					num = (((((int[])(object)array)[52] ^ ((int[])(object)array)[105]) <= ((int[])(object)array)[3]) ? (((int)num2 * -127537480) ^ ((int[])(object)array)[21]) : ((int)(num2 * 1873428316) ^ ((int[])(object)array)[117]));
					continue;
				case 44u:
					num3 += (uint)((int)array2[Convert.ToInt32(2.0 + Math.Truncate(2.0))] * -105);
					num = (((((int[])(object)array)[28] ^ ((int[])(object)array)[39]) > ((int[])(object)array)[117]) ? (((int)num2 * -1399812209) ^ ((int[])(object)array)[138]) : (((int)num2 * -1368547920) ^ ((int[])(object)array)[138]));
					continue;
				case 173u:
					array2[Convert.ToInt32(11.128197823098409 + Math.Log(6.5))] = array2[Convert.ToInt32(11.128197823098409 + Math.Log(6.5))] ^ array3[Convert.ToInt32(10.450490243203607 + Math.Sqrt(6.5))];
					num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[47]) <= ((int[])(object)array)[31]) ? ((int)(num2 * 1217575371) ^ ((int[])(object)array)[85]) : ((int)(num2 * 700409781) ^ ((int[])(object)array)[25]));
					continue;
				case 70u:
					num7 += (uint)((int)array2[0] * -38);
					num = (((((int[])(object)array)[159] ^ ((int[])(object)array)[12]) < ((int[])(object)array)[53]) ? (((int)num2 * -699716275) ^ ((int[])(object)array)[49]) : ((int)(num2 * 46177633) ^ ((int[])(object)array)[169]));
					continue;
				case 190u:
					num = ((((int[])(object)array)[7] + ((int[])(object)array)[1] != ((int[])(object)array)[0]) ? (((int)num2 * -1558496752) ^ ((int[])(object)array)[24]) : (((int)num2 * -997873339) ^ ((int[])(object)array)[1]));
					continue;
				case 9u:
					num3 *= (uint)Convert.ToInt32(735628428.5 + Math.Abs(735628428.5));
					num = (((((int[])(object)array)[7] ^ ((int[])(object)array)[78]) == ((int[])(object)array)[16]) ? ((int)(num2 * 1302747264) ^ ((int[])(object)array)[2]) : (((int)num2 * -913303001) ^ ((int[])(object)array)[153]));
					continue;
				case 55u:
					return;
					IL_3053:
					num15 = num31 >> Convert.ToInt32(2.0 + Math.Log10(1.0));
					num = ((((int[])(object)array)[3] + ((int[])(object)array)[3] == ((int[])(object)array)[5]) ? ((int)(num2 * 1316262154) ^ ((int[])(object)array)[13]) : ((int[])(object)array)[14]);
					continue;
				}
				break;
			}
		}
	}
}
internal static class _200C_200F_200F_200C_200E_202C_200E_200F_200E_200C_200E_200E_200F_202C_200E_200E
{
	internal static void _202C_200E_202E_202B_200E_202E_200E_200B_200E_200D_200F_202D_200E_202D_200E_200E(RuntimeTypeHandle P_0, int P_1, bool P_2)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF0
	}
}
internal static class _202B_200E_200F_200F_200E_202A_200E_200D_200E_202A_200F_202D_200E_200D_200E_200E
{
	private class _202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E
	{
		internal Type _202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E;

		internal int _202D_200E_200C_202A_200E_202E_200E_202A_200E_202C_200E_200E_200F_200D_200E_200E;

		internal int _200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F;

		internal int _200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E;

		internal int _200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E;

		internal int _202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E;

		internal int _202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E;

		public _202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E()
		{
			bool[] array = (bool[])(object)new int[1] { 2 };
			base._002Ector();
			while (true)
			{
				uint num;
				switch ((num = 1665983315u) % (uint)((int[])(object)array)[0])
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					return;
				}
			}
		}
	}

	private class _200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E
	{
		internal List<Type> _202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E;

		internal int _202D_200E_200C_202A_200E_202E_200E_202A_200E_202C_200E_200E_200F_200D_200E_200E;

		internal int _200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F;

		internal List<int> _200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E;

		internal int _200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E;

		internal int _202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E;

		internal int _202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E;

		public _200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E()
		{
			bool[] array = (bool[])(object)new int[1] { 2 };
			_202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E = new List<Type>();
			_200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E = new List<int>();
			base._002Ector();
			while (true)
			{
				uint num;
				switch ((num = 1300063995u) % (uint)((int[])(object)array)[0])
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					return;
				}
			}
		}
	}

	private static object _202A_200F_202B_202D_200E_200D_200E_202E_200E_200C_200E_202E_200E_202D_200E_200F;

	private static Dictionary<MethodBase, DynamicMethod> _200B_200E_200C_200C_200F_200C_200E_202E_200E_200B_200E_200D_200F_200E_200E_200F;

	private static OpCode[] _202C_200E_200D_200C_200E_200F_200F_200F_200F_202B_200F_202A_200E_202A_200F_200F;

	private static OpCode[] _200F_200E_200D_202A_200F_200D_200F_200C_200F_200D_200E_200D_200F_200C_200F_200E;

	private static byte[] _202A_200F_202B_202B_200F_202A_200F_200B_200E_200E_200E_200C_200F_200D_200F_200F()
	{
		return new byte[11852]
		{
			2, 0, 0, 0, 1, 0, 0, 0, 10, 0,
			0, 0, 12, 0, 0, 0, 0, 0, 0, 0,
			5, 0, 0, 0, 8, 0, 0, 0, 15, 0,
			0, 0, 11, 0, 0, 0, 9, 0, 0, 0,
			13, 0, 0, 0, 6, 0, 0, 0, 14, 0,
			0, 0, 3, 0, 0, 0, 4, 0, 0, 0,
			7, 0, 0, 0, 208, 1, 0, 0, 0, 0,
			0, 0, 51, 0, 0, 0, 32, 0, 12, 0,
			0, 0, 2, 0, 0, 0, 141, 0, 8, 0,
			0, 0, 105, 1, 0, 1, 37, 0, 2, 0,
			0, 0, 32, 0, 12, 0, 0, 0, 0, 0,
			0, 0, 32, 0, 12, 0, 0, 0, 3, 0,
			0, 0, 158, 0, 2, 0, 0, 0, 37, 0,
			2, 0, 0, 0, 32, 0, 12, 0, 0, 0,
			1, 0, 0, 0, 32, 0, 12, 0, 0, 0,
			45, 25, 9, 220, 158, 0, 2, 0, 0, 0,
			14, 254, 14, 0, 0, 0, 1, 0, 0, 0,
			0, 40, 0, 1, 0, 0, 0, 30, 3, 0,
			6, 32, 0, 12, 0, 0, 0, 44, 118, 130,
			64, 37, 0, 2, 0, 0, 0, 14, 254, 14,
			0, 0, 0, 0, 0, 0, 0, 0, 12, 254,
			14, 0, 0, 0, 1, 0, 0, 0, 0, 32,
			0, 12, 0, 0, 0, 0, 0, 0, 0, 148,
			0, 2, 0, 0, 0, 94, 0, 2, 0, 0,
			0, 69, 0, 9, 0, 0, 0, 3, 0, 0,
			0, 12, 0, 0, 0, 50, 0, 0, 0, 21,
			0, 0, 0, 56, 0, 13, 0, 0, 0, 50,
			0, 0, 0, 40, 0, 1, 0, 0, 0, 23,
			3, 0, 6, 12, 254, 14, 0, 0, 0, 1,
			0, 0, 0, 0, 32, 0, 12, 0, 0, 0,
			0, 0, 0, 0, 148, 0, 2, 0, 0, 0,
			12, 254, 14, 0, 0, 0, 1, 0, 0, 0,
			0, 32, 0, 12, 0, 0, 0, 1, 0, 0,
			0, 148, 0, 2, 0, 0, 0, 97, 0, 2,
			0, 0, 0, 12, 254, 14, 0, 0, 0, 1,
			0, 0, 0, 0, 32, 0, 12, 0, 0, 0,
			0, 0, 0, 0, 148, 0, 2, 0, 0, 0,
			1, 254, 2, 0, 0, 0, 58, 0, 13, 0,
			0, 0, 42, 0, 0, 0, 12, 254, 14, 0,
			0, 0, 0, 0, 0, 0, 0, 32, 0, 12,
			0, 0, 0, 227, 114, 3, 71, 90, 0, 2,
			0, 0, 0, 12, 254, 14, 0, 0, 0, 1,
			0, 0, 0, 0, 32, 0, 12, 0, 0, 0,
			1, 0, 0, 0, 148, 0, 2, 0, 0, 0,
			97, 0, 2, 0, 0, 0, 56, 0, 13, 0,
			0, 0, 13, 0, 0, 0, 12, 254, 14, 0,
			0, 0, 0, 0, 0, 0, 0, 32, 0, 12,
			0, 0, 0, 196, 251, 46, 8, 90, 0, 2,
			0, 0, 0, 12, 254, 14, 0, 0, 0, 1,
			0, 0, 0, 0, 32, 0, 12, 0, 0, 0,
			1, 0, 0, 0, 148, 0, 2, 0, 0, 0,
			97, 0, 2, 0, 0, 0, 56, 0, 13, 0,
			0, 0, 13, 0, 0, 0, 42, 0, 2, 0,
			0, 0, 12, 0, 0, 0, 13, 0, 0, 0,
			8, 0, 0, 0, 11, 0, 0, 0, 3, 0,
			0, 0, 6, 0, 0, 0, 7, 0, 0, 0,
			9, 0, 0, 0, 0, 0, 0, 0, 4, 0,
			0, 0, 5, 0, 0, 0, 10, 0, 0, 0,
			2, 0, 0, 0, 14, 0, 0, 0, 1, 0,
			0, 0, 15, 0, 0, 0, 244, 43, 0, 0,
			1, 0, 0, 0, 82, 1, 0, 1, 255, 255,
			255, 255, 236, 4, 0, 0, 225, 4, 0, 0,
			1, 225, 4, 0, 0, 155, 0, 0, 0, 237,
			4, 0, 0, 32, 0, 11, 0, 0, 0, 38,
			0, 0, 0, 141, 0, 7, 0, 0, 0, 105,
			1, 0, 1, 37, 0, 12, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 40, 0, 0, 0, 158,
			0, 12, 0, 0, 0, 37, 0, 12, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 1, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 66, 57, 153,
			26, 158, 0, 12, 0, 0, 0, 37, 0, 12,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 2,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 209,
			210, 48, 22, 158, 0, 12, 0, 0, 0, 37,
			0, 12, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 3, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 103, 42, 219, 148, 158, 0, 12, 0, 0,
			0, 37, 0, 12, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 4, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 157, 239, 221, 142, 158, 0, 12,
			0, 0, 0, 37, 0, 12, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 5, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 134, 97, 195, 117, 158,
			0, 12, 0, 0, 0, 37, 0, 12, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 6, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 87, 131, 45,
			101, 158, 0, 12, 0, 0, 0, 37, 0, 12,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 7,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 109,
			71, 157, 41, 158, 0, 12, 0, 0, 0, 37,
			0, 12, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 8, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 210, 85, 236, 244, 158, 0, 12, 0, 0,
			0, 37, 0, 12, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 9, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 224, 3, 15, 208, 158, 0, 12,
			0, 0, 0, 37, 0, 12, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 10, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 27, 185, 244, 3, 158,
			0, 12, 0, 0, 0, 37, 0, 12, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 11, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 94, 67, 85,
			72, 158, 0, 12, 0, 0, 0, 37, 0, 12,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 12,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 30,
			229, 36, 24, 158, 0, 12, 0, 0, 0, 37,
			0, 12, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 13, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 70, 202, 200, 74, 158, 0, 12, 0, 0,
			0, 37, 0, 12, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 14, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 247, 146, 249, 88, 158, 0, 12,
			0, 0, 0, 37, 0, 12, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 15, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 61, 188, 150, 67, 158,
			0, 12, 0, 0, 0, 37, 0, 12, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 16, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 48, 85, 210,
			56, 158, 0, 12, 0, 0, 0, 37, 0, 12,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 17,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 247,
			222, 85, 125, 158, 0, 12, 0, 0, 0, 37,
			0, 12, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 18, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 41, 104, 57, 41, 158, 0, 12, 0, 0,
			0, 37, 0, 12, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 19, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 37, 135, 221, 195, 158, 0, 12,
			0, 0, 0, 37, 0, 12, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 20, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 58, 143, 89, 27, 158,
			0, 12, 0, 0, 0, 37, 0, 12, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 21, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 34, 11, 100,
			58, 158, 0, 12, 0, 0, 0, 37, 0, 12,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 22,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 91,
			255, 150, 218, 158, 0, 12, 0, 0, 0, 37,
			0, 12, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 23, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 91, 30, 90, 9, 158, 0, 12, 0, 0,
			0, 37, 0, 12, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 24, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 255, 166, 158, 79, 158, 0, 12,
			0, 0, 0, 37, 0, 12, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 25, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 42, 53, 160, 124, 158,
			0, 12, 0, 0, 0, 37, 0, 12, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 26, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 75, 95, 241,
			96, 158, 0, 12, 0, 0, 0, 37, 0, 12,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 27,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 7,
			129, 50, 51, 158, 0, 12, 0, 0, 0, 37,
			0, 12, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 28, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 67, 195, 85, 141, 158, 0, 12, 0, 0,
			0, 37, 0, 12, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 29, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 83, 115, 108, 60, 158, 0, 12,
			0, 0, 0, 37, 0, 12, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 30, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 98, 186, 72, 45, 158,
			0, 12, 0, 0, 0, 37, 0, 12, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 31, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 97, 206, 46,
			7, 158, 0, 12, 0, 0, 0, 37, 0, 12,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 32,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 234,
			202, 248, 71, 158, 0, 12, 0, 0, 0, 37,
			0, 12, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 33, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 47, 209, 181, 88, 158, 0, 12, 0, 0,
			0, 37, 0, 12, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 34, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 54, 50, 180, 54, 158, 0, 12,
			0, 0, 0, 37, 0, 12, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 35, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 210, 186, 17, 50, 158,
			0, 12, 0, 0, 0, 37, 0, 12, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 36, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 244, 182, 121,
			10, 158, 0, 12, 0, 0, 0, 37, 0, 12,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 37,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 2,
			0, 0, 0, 158, 0, 12, 0, 0, 0, 14,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			9, 254, 2, 0, 0, 0, 0, 0, 0, 0,
			1, 40, 0, 13, 0, 0, 0, 129, 3, 0,
			10, 14, 254, 2, 0, 0, 0, 0, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 121, 190,
			161, 95, 37, 0, 12, 0, 0, 0, 14, 254,
			2, 0, 0, 0, 10, 0, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 0, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 94, 0, 12, 0,
			0, 0, 69, 0, 4, 0, 0, 0, 40, 0,
			0, 0, 44, 4, 0, 0, 88, 2, 0, 0,
			241, 2, 0, 0, 144, 1, 0, 0, 3, 2,
			0, 0, 117, 1, 0, 0, 175, 1, 0, 0,
			195, 0, 0, 0, 19, 3, 0, 0, 167, 4,
			0, 0, 46, 2, 0, 0, 212, 3, 0, 0,
			182, 2, 0, 0, 32, 4, 0, 0, 223, 0,
			0, 0, 54, 1, 0, 0, 203, 1, 0, 0,
			116, 2, 0, 0, 231, 1, 0, 0, 249, 0,
			0, 0, 224, 4, 0, 0, 135, 4, 0, 0,
			81, 1, 0, 0, 145, 3, 0, 0, 158, 0,
			0, 0, 1, 4, 0, 0, 173, 3, 0, 0,
			105, 4, 0, 0, 88, 3, 0, 0, 26, 1,
			0, 0, 53, 3, 0, 0, 56, 2, 0, 0,
			155, 2, 0, 0, 30, 2, 0, 0, 167, 0,
			0, 0, 213, 2, 0, 0, 195, 4, 0, 0,
			240, 3, 0, 0, 114, 3, 0, 0, 71, 4,
			0, 0, 56, 0, 5, 0, 0, 0, 224, 4,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 11,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 3, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 88, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 25,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 1,
			254, 12, 0, 0, 0, 57, 0, 5, 0, 0,
			0, 187, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 10, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 194, 121, 2, 11, 90, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 7,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 97,
			0, 12, 0, 0, 0, 56, 0, 5, 0, 0,
			0, 159, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 10, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 1, 118, 35, 11, 90, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 26,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 97,
			0, 12, 0, 0, 0, 56, 0, 5, 0, 0,
			0, 159, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 3, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 17,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 88,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 19, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 1, 254, 12, 0, 0, 0, 57, 0,
			5, 0, 0, 0, 215, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 10, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 176, 238, 220, 3, 90,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 17, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 10, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 78, 27, 164, 35, 90,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 28, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 0, 0, 0, 0, 14, 254,
			2, 0, 0, 0, 8, 0, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 6, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 11, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 88, 0, 12, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 0, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 4, 254, 12, 0,
			0, 0, 57, 0, 5, 0, 0, 0, 241, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 13,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 56,
			0, 5, 0, 0, 0, 159, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 10, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 162, 187, 85, 138,
			90, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 1, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 97, 0, 12, 0, 0, 0, 56,
			0, 5, 0, 0, 0, 159, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 5, 0, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 8, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 1, 0, 0,
			0, 88, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 3, 0, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 8, 0, 0, 0, 0, 154,
			0, 12, 0, 0, 0, 111, 0, 13, 0, 0,
			0, 168, 3, 0, 10, 162, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 10, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 14, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 6, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 2, 254,
			12, 0, 0, 0, 57, 0, 5, 0, 0, 0,
			22, 1, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 29, 24, 146, 23, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 3, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			11, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 15, 0, 0, 0, 148, 0, 12, 0, 0,
			0, 56, 0, 5, 0, 0, 0, 159, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 0, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 3, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 2, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 1, 254,
			12, 0, 0, 0, 58, 0, 5, 0, 0, 0,
			46, 1, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 64, 37, 64, 180, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 11, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 65, 152, 120, 38, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 5, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			7, 0, 0, 0, 0, 126, 0, 6, 0, 0,
			0, 176, 3, 0, 10, 111, 0, 13, 0, 0,
			0, 174, 3, 0, 10, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 3, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 4,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 97,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 10, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 4, 254, 12, 0, 0, 0, 57, 0,
			5, 0, 0, 0, 77, 1, 0, 0, 12, 254,
			2, 0, 0, 0, 10, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 110, 111, 152, 44, 90,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 10, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 27, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 56, 0, 5, 0, 0,
			0, 159, 0, 0, 0, 126, 0, 6, 0, 0,
			0, 169, 3, 0, 10, 12, 254, 2, 0, 0,
			0, 2, 0, 0, 0, 0, 111, 0, 13, 0,
			0, 0, 170, 3, 0, 10, 12, 254, 2, 0,
			0, 0, 5, 0, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 0, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 1, 0, 0, 0, 115, 0,
			13, 0, 0, 0, 171, 3, 0, 10, 14, 254,
			2, 0, 0, 0, 6, 0, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 4, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 10, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 88, 0, 12, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 4, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 2, 254, 12, 0,
			0, 0, 58, 0, 5, 0, 0, 0, 109, 1,
			0, 0, 12, 254, 2, 0, 0, 0, 10, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 138,
			233, 157, 204, 90, 0, 12, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 7, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 97, 0, 12, 0,
			0, 0, 56, 0, 5, 0, 0, 0, 159, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 10, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 201,
			100, 207, 54, 90, 0, 12, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 17, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 97, 0, 12, 0,
			0, 0, 56, 0, 5, 0, 0, 0, 159, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 7, 0,
			0, 0, 0, 126, 0, 6, 0, 0, 0, 175,
			3, 0, 10, 111, 0, 13, 0, 0, 0, 174,
			3, 0, 10, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			12, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 7, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 97, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			15, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			4, 254, 12, 0, 0, 0, 58, 0, 5, 0,
			0, 0, 140, 1, 0, 0, 12, 254, 2, 0,
			0, 0, 10, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 194, 155, 102, 207, 90, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			1, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			97, 0, 12, 0, 0, 0, 56, 0, 5, 0,
			0, 0, 159, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 25, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 56, 0, 5, 0, 0, 0, 159,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 4,
			0, 0, 0, 0, 141, 0, 7, 0, 0, 0,
			55, 1, 0, 1, 14, 254, 2, 0, 0, 0,
			5, 0, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 3, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 3,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 88,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 0, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 2, 254, 12, 0, 0, 0, 58, 0,
			5, 0, 0, 0, 167, 1, 0, 0, 12, 254,
			2, 0, 0, 0, 10, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 218, 169, 219, 234, 90,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 1, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 10, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 189, 50, 76, 233, 90,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 8, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 0, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 0, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 88, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 6, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 1, 254, 12, 0, 0,
			0, 58, 0, 5, 0, 0, 0, 195, 1, 0,
			0, 12, 254, 2, 0, 0, 0, 10, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 199, 182,
			222, 48, 90, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 14, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 56, 0, 5, 0, 0, 0, 159, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 10, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 234, 121,
			155, 57, 90, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 11, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 56, 0, 5, 0, 0, 0, 159, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 16, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 8, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 88, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 3, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 1, 254,
			12, 0, 0, 0, 58, 0, 5, 0, 0, 0,
			223, 1, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 183, 36, 152, 222, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 20, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 215, 119, 88, 228, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 20, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			11, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 12, 0, 0, 0, 148, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 20, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			11, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 11, 0, 0, 0, 148, 0, 12, 0, 0,
			0, 2, 254, 12, 0, 0, 0, 58, 0, 5,
			0, 0, 0, 251, 1, 0, 0, 12, 254, 2,
			0, 0, 0, 10, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 122, 176, 253, 235, 90, 0,
			12, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			11, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 22, 0, 0, 0, 148, 0, 12, 0, 0,
			0, 97, 0, 12, 0, 0, 0, 56, 0, 5,
			0, 0, 0, 159, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 10, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 255, 37, 153, 217, 90, 0,
			12, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			11, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 20, 0, 0, 0, 148, 0, 12, 0, 0,
			0, 97, 0, 12, 0, 0, 0, 56, 0, 5,
			0, 0, 0, 159, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 7, 0, 0, 0, 0, 126, 0,
			6, 0, 0, 0, 173, 3, 0, 10, 111, 0,
			13, 0, 0, 0, 174, 3, 0, 10, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 22, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 5, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 6, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 2, 254, 12, 0, 0,
			0, 58, 0, 5, 0, 0, 0, 22, 2, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 23, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 10, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 46, 186, 222, 55, 90,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 3, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 2, 0, 0, 0, 0, 111,
			0, 13, 0, 0, 0, 160, 3, 0, 10, 58,
			0, 5, 0, 0, 0, 36, 2, 0, 0, 32,
			0, 11, 0, 0, 0, 103, 226, 152, 75, 37,
			0, 12, 0, 0, 0, 56, 0, 5, 0, 0,
			0, 38, 2, 0, 0, 32, 0, 11, 0, 0,
			0, 177, 248, 183, 17, 37, 0, 12, 0, 0,
			0, 38, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 10, 0, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 3, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 90, 0, 12, 0, 0,
			0, 97, 0, 12, 0, 0, 0, 56, 0, 5,
			0, 0, 0, 159, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 9, 0, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 4, 0, 0, 0, 0, 60,
			0, 5, 0, 0, 0, 52, 2, 0, 0, 32,
			0, 11, 0, 0, 0, 84, 111, 42, 81, 37,
			0, 12, 0, 0, 0, 56, 0, 5, 0, 0,
			0, 54, 2, 0, 0, 32, 0, 11, 0, 0,
			0, 116, 234, 100, 57, 37, 0, 12, 0, 0,
			0, 38, 0, 12, 0, 0, 0, 56, 0, 5,
			0, 0, 0, 159, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 7, 0, 0, 0, 0, 9, 254,
			2, 0, 0, 0, 2, 0, 0, 0, 1, 58,
			0, 5, 0, 0, 0, 61, 2, 0, 0, 126,
			0, 6, 0, 0, 0, 181, 3, 0, 10, 56,
			0, 5, 0, 0, 0, 62, 2, 0, 0, 126,
			0, 6, 0, 0, 0, 182, 3, 0, 10, 12,
			254, 2, 0, 0, 0, 2, 0, 0, 0, 0,
			111, 0, 13, 0, 0, 0, 183, 3, 0, 10,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 11, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 18, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 88, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 5, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 2, 254, 12,
			0, 0, 0, 58, 0, 5, 0, 0, 0, 80,
			2, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			34, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			56, 0, 5, 0, 0, 0, 159, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 10, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 0, 25, 245,
			254, 90, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 30, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 97, 0, 12, 0, 0, 0,
			56, 0, 5, 0, 0, 0, 159, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 9, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 1, 0, 0,
			0, 88, 0, 12, 0, 0, 0, 14, 254, 2,
			0, 0, 0, 9, 0, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 2, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 16, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 88, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 1, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 4, 254, 12, 0, 0,
			0, 57, 0, 5, 0, 0, 0, 112, 2, 0,
			0, 12, 254, 2, 0, 0, 0, 10, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 81, 10,
			9, 174, 90, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 1, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 56, 0, 5, 0, 0, 0, 159, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 32, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 12, 0, 0, 0, 35, 0, 1, 0, 0,
			0, 55, 186, 223, 27, 21, 158, 144, 64, 35,
			0, 1, 0, 0, 0, 0, 0, 0, 0, 0,
			160, 128, 64, 40, 0, 13, 0, 0, 0, 67,
			0, 0, 10, 89, 0, 12, 0, 0, 0, 40,
			0, 13, 0, 0, 0, 53, 0, 0, 10, 111,
			0, 13, 0, 0, 0, 157, 3, 0, 10, 32,
			0, 11, 0, 0, 0, 0, 0, 0, 0, 154,
			0, 12, 0, 0, 0, 14, 254, 2, 0, 0,
			0, 1, 0, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 0, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			1, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			88, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 1, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 4, 254, 12, 0, 0, 0, 58,
			0, 5, 0, 0, 0, 147, 2, 0, 0, 12,
			254, 2, 0, 0, 0, 10, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 32, 108, 246, 66,
			90, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 1, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 97, 0, 12, 0, 0, 0, 56,
			0, 5, 0, 0, 0, 159, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 10, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 113, 117, 218, 153,
			90, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 1, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 97, 0, 12, 0, 0, 0, 56,
			0, 5, 0, 0, 0, 159, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 2, 0, 0, 0, 0,
			111, 0, 13, 0, 0, 0, 164, 3, 0, 10,
			14, 254, 2, 0, 0, 0, 3, 0, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 6, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 6, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 88, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 6, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 4, 254,
			12, 0, 0, 0, 58, 0, 5, 0, 0, 0,
			178, 2, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 141, 152, 35, 213, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 3, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			11, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 6, 0, 0, 0, 148, 0, 12, 0, 0,
			0, 56, 0, 5, 0, 0, 0, 159, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 7, 0, 0,
			0, 0, 126, 0, 6, 0, 0, 0, 180, 3,
			0, 10, 111, 0, 13, 0, 0, 0, 174, 3,
			0, 10, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 17,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 8, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 88, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 22,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 2,
			254, 12, 0, 0, 0, 58, 0, 5, 0, 0,
			0, 205, 2, 0, 0, 12, 254, 2, 0, 0,
			0, 10, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 58, 45, 193, 194, 90, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 12,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 97,
			0, 12, 0, 0, 0, 56, 0, 5, 0, 0,
			0, 159, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 10, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 80, 181, 180, 67, 90, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 33,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 97,
			0, 12, 0, 0, 0, 56, 0, 5, 0, 0,
			0, 159, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 12, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 19,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 88,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 2, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 2, 254, 12, 0, 0, 0, 57, 0,
			5, 0, 0, 0, 233, 2, 0, 0, 12, 254,
			2, 0, 0, 0, 10, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 227, 118, 141, 36, 90,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 2, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 10, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 58, 24, 215, 251, 90,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 24, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 56, 0,
			5, 0, 0, 0, 159, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 5, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 0, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 2, 0, 0, 0, 0,
			111, 0, 13, 0, 0, 0, 165, 3, 0, 10,
			111, 0, 13, 0, 0, 0, 167, 3, 0, 10,
			162, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 7, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			4, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			88, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 10, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 1, 254, 12, 0, 0, 0, 58,
			0, 5, 0, 0, 0, 11, 3, 0, 0, 12,
			254, 2, 0, 0, 0, 10, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 55, 47, 45, 219,
			90, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 10, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 97, 0, 12, 0, 0, 0, 56,
			0, 5, 0, 0, 0, 159, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 10, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 94, 73, 212, 18,
			90, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 2, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 97, 0, 12, 0, 0, 0, 56,
			0, 5, 0, 0, 0, 159, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 1, 0, 0, 0, 0,
			20, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 6, 0, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 0, 0, 0, 0, 0, 111, 0,
			13, 0, 0, 0, 185, 3, 0, 10, 111, 0,
			13, 0, 0, 0, 163, 3, 0, 10, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 17, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 8, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 88, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 2, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 1, 254, 12, 0, 0,
			0, 57, 0, 5, 0, 0, 0, 45, 3, 0,
			0, 12, 254, 2, 0, 0, 0, 10, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 42, 80,
			167, 2, 90, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 19, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 56, 0, 5, 0, 0, 0, 159, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 10, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 109, 223,
			91, 147, 90, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 36, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 56, 0, 5, 0, 0, 0, 159, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 1, 0, 0,
			0, 0, 20, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 1, 0, 0, 0, 0, 111,
			0, 13, 0, 0, 0, 161, 3, 0, 10, 12,
			254, 2, 0, 0, 0, 2, 0, 0, 0, 0,
			40, 0, 13, 0, 0, 0, 162, 3, 0, 10,
			111, 0, 13, 0, 0, 0, 163, 3, 0, 10,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 1, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 1, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 97, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 3, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 4, 254, 12,
			0, 0, 0, 57, 0, 5, 0, 0, 0, 80,
			3, 0, 0, 12, 254, 2, 0, 0, 0, 10,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			1, 168, 73, 199, 90, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 4, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 97, 0, 12,
			0, 0, 0, 56, 0, 5, 0, 0, 0, 159,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 10,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			22, 120, 205, 245, 90, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 4, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 97, 0, 12,
			0, 0, 0, 56, 0, 5, 0, 0, 0, 159,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 9,
			0, 0, 0, 0, 69, 0, 4, 0, 0, 0,
			4, 0, 0, 0, 3, 2, 0, 0, 117, 1,
			0, 0, 54, 1, 0, 0, 44, 4, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 4, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 5, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 88, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 16, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 1, 254, 12,
			0, 0, 0, 58, 0, 5, 0, 0, 0, 106,
			3, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			21, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			56, 0, 5, 0, 0, 0, 159, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 10, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 86, 24, 191,
			192, 90, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 21, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 97, 0, 12, 0, 0, 0,
			56, 0, 5, 0, 0, 0, 159, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 7, 0, 0, 0,
			0, 126, 0, 6, 0, 0, 0, 184, 3, 0,
			10, 111, 0, 13, 0, 0, 0, 174, 3, 0,
			10, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 12, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 7, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 21, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 2, 254,
			12, 0, 0, 0, 57, 0, 5, 0, 0, 0,
			137, 3, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 75, 226, 32, 235, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 7, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 99, 213, 202, 149, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 35, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			7, 0, 0, 0, 0, 126, 0, 6, 0, 0,
			0, 178, 3, 0, 10, 12, 254, 2, 0, 0,
			0, 9, 0, 0, 0, 0, 111, 0, 13, 0,
			0, 0, 179, 3, 0, 10, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 1, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			13, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			88, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 12, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 1, 254, 12, 0, 0, 0, 57,
			0, 5, 0, 0, 0, 169, 3, 0, 0, 12,
			254, 2, 0, 0, 0, 10, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 253, 205, 150, 131,
			90, 0, 12, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 14, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 97, 0, 12, 0, 0, 0, 56,
			0, 5, 0, 0, 0, 159, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 31, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 56, 0, 5, 0,
			0, 0, 159, 0, 0, 0, 208, 0, 10, 0,
			0, 0, 93, 0, 0, 2, 1, 40, 0, 13,
			0, 0, 0, 129, 3, 0, 10, 111, 0, 13,
			0, 0, 0, 130, 3, 0, 10, 9, 254, 2,
			0, 0, 0, 1, 0, 0, 0, 1, 12, 254,
			2, 0, 0, 0, 0, 0, 0, 0, 0, 111,
			0, 13, 0, 0, 0, 158, 3, 0, 10, 32,
			0, 11, 0, 0, 0, 0, 0, 0, 0, 141,
			0, 7, 0, 0, 0, 55, 1, 0, 1, 111,
			0, 13, 0, 0, 0, 159, 3, 0, 10, 116,
			0, 7, 0, 0, 0, 75, 1, 0, 1, 14,
			254, 2, 0, 0, 0, 2, 0, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 2, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 0, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 97, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 1, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 4, 254, 12,
			0, 0, 0, 58, 0, 5, 0, 0, 0, 204,
			3, 0, 0, 12, 254, 2, 0, 0, 0, 10,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			133, 42, 200, 53, 90, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 1, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 97, 0, 12,
			0, 0, 0, 56, 0, 5, 0, 0, 0, 159,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 10,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			24, 149, 35, 207, 90, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 2, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 97, 0, 12,
			0, 0, 0, 56, 0, 5, 0, 0, 0, 159,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			26, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 8, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 97, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			2, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			2, 254, 12, 0, 0, 0, 57, 0, 5, 0,
			0, 0, 232, 3, 0, 0, 12, 254, 2, 0,
			0, 0, 10, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 72, 8, 93, 127, 90, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			9, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			97, 0, 12, 0, 0, 0, 56, 0, 5, 0,
			0, 0, 159, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 10, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 145, 22, 176, 146, 90, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			30, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			97, 0, 12, 0, 0, 0, 56, 0, 5, 0,
			0, 0, 159, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 2, 0, 0, 0, 0, 111, 0, 13,
			0, 0, 0, 165, 3, 0, 10, 111, 0, 13,
			0, 0, 0, 166, 3, 0, 10, 58, 0, 5,
			0, 0, 0, 247, 3, 0, 0, 32, 0, 11,
			0, 0, 0, 92, 175, 88, 53, 37, 0, 12,
			0, 0, 0, 56, 0, 5, 0, 0, 0, 249,
			3, 0, 0, 32, 0, 11, 0, 0, 0, 226,
			42, 156, 100, 37, 0, 12, 0, 0, 0, 38,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 10, 0, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 9, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 90, 0, 12, 0, 0, 0, 97,
			0, 12, 0, 0, 0, 56, 0, 5, 0, 0,
			0, 159, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 6, 0, 0, 0, 0, 111, 0, 13, 0,
			0, 0, 172, 3, 0, 10, 14, 254, 2, 0,
			0, 0, 7, 0, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 3, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			11, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 1, 0, 0, 0, 148, 0, 12, 0, 0,
			0, 88, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 6, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 1, 254, 12, 0, 0, 0,
			57, 0, 5, 0, 0, 0, 24, 4, 0, 0,
			12, 254, 2, 0, 0, 0, 10, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 87, 46, 63,
			142, 90, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 0, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 97, 0, 12, 0, 0, 0,
			56, 0, 5, 0, 0, 0, 159, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 10, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 146, 168, 202,
			56, 90, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 18, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 97, 0, 12, 0, 0, 0,
			56, 0, 5, 0, 0, 0, 159, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 8, 0, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 3, 0, 0,
			0, 0, 142, 0, 12, 0, 0, 0, 105, 0,
			12, 0, 0, 0, 60, 0, 5, 0, 0, 0,
			40, 4, 0, 0, 32, 0, 11, 0, 0, 0,
			59, 40, 251, 29, 37, 0, 12, 0, 0, 0,
			56, 0, 5, 0, 0, 0, 42, 4, 0, 0,
			32, 0, 11, 0, 0, 0, 182, 239, 174, 22,
			37, 0, 12, 0, 0, 0, 38, 0, 12, 0,
			0, 0, 56, 0, 5, 0, 0, 0, 159, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 7, 0,
			0, 0, 0, 126, 0, 6, 0, 0, 0, 177,
			3, 0, 10, 111, 0, 13, 0, 0, 0, 174,
			3, 0, 10, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			17, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 11, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 88, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			4, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			2, 254, 12, 0, 0, 0, 57, 0, 5, 0,
			0, 0, 63, 4, 0, 0, 12, 254, 2, 0,
			0, 0, 11, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 29, 0, 0, 0, 148, 0, 12,
			0, 0, 0, 56, 0, 5, 0, 0, 0, 159,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 10,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			5, 83, 198, 54, 90, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 20, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 97, 0, 12,
			0, 0, 0, 56, 0, 5, 0, 0, 0, 159,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 3,
			0, 0, 0, 0, 142, 0, 12, 0, 0, 0,
			105, 0, 12, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 1, 0, 0, 0, 88, 0, 12, 0,
			0, 0, 14, 254, 2, 0, 0, 0, 4, 0,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			5, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 11, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 6, 0, 0,
			0, 148, 0, 12, 0, 0, 0, 88, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			1, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			4, 254, 12, 0, 0, 0, 58, 0, 5, 0,
			0, 0, 97, 4, 0, 0, 12, 254, 2, 0,
			0, 0, 10, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 224, 28, 140, 143, 90, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			0, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			97, 0, 12, 0, 0, 0, 56, 0, 5, 0,
			0, 0, 159, 0, 0, 0, 12, 254, 2, 0,
			0, 0, 10, 0, 0, 0, 0, 32, 0, 11,
			0, 0, 0, 202, 83, 243, 38, 90, 0, 12,
			0, 0, 0, 12, 254, 2, 0, 0, 0, 11,
			0, 0, 0, 0, 32, 0, 11, 0, 0, 0,
			7, 0, 0, 0, 148, 0, 12, 0, 0, 0,
			97, 0, 12, 0, 0, 0, 56, 0, 5, 0,
			0, 0, 159, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 0, 0, 0, 0, 14, 254, 2, 0,
			0, 0, 9, 0, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 1, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			11, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 9, 0, 0, 0, 148, 0, 12, 0, 0,
			0, 88, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 1, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 1, 254, 12, 0, 0, 0,
			57, 0, 5, 0, 0, 0, 127, 4, 0, 0,
			12, 254, 2, 0, 0, 0, 10, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 192, 225, 176,
			155, 90, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 3, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 97, 0, 12, 0, 0, 0,
			56, 0, 5, 0, 0, 0, 159, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 10, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 143, 184, 172,
			166, 90, 0, 12, 0, 0, 0, 12, 254, 2,
			0, 0, 0, 11, 0, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 19, 0, 0, 0, 148, 0,
			12, 0, 0, 0, 97, 0, 12, 0, 0, 0,
			56, 0, 5, 0, 0, 0, 159, 0, 0, 0,
			12, 254, 2, 0, 0, 0, 8, 0, 0, 0,
			0, 32, 0, 11, 0, 0, 0, 1, 0, 0,
			0, 88, 0, 12, 0, 0, 0, 14, 254, 2,
			0, 0, 0, 8, 0, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 2, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 7, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 97, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 3, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 2, 254, 12, 0, 0,
			0, 57, 0, 5, 0, 0, 0, 159, 4, 0,
			0, 12, 254, 2, 0, 0, 0, 10, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 49, 192,
			217, 86, 90, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 16, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 56, 0, 5, 0, 0, 0, 159, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 10, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 20, 51,
			18, 35, 90, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 2, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 97, 0, 12, 0, 0,
			0, 56, 0, 5, 0, 0, 0, 159, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 4, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 12, 254,
			2, 0, 0, 0, 11, 0, 0, 0, 0, 32,
			0, 11, 0, 0, 0, 4, 0, 0, 0, 148,
			0, 12, 0, 0, 0, 88, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 2, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 1, 254,
			12, 0, 0, 0, 58, 0, 5, 0, 0, 0,
			187, 4, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 18, 219, 30, 164, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 5, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 255, 145, 47, 142, 90, 0, 12, 0, 0,
			0, 12, 254, 2, 0, 0, 0, 11, 0, 0,
			0, 0, 32, 0, 11, 0, 0, 0, 3, 0,
			0, 0, 148, 0, 12, 0, 0, 0, 97, 0,
			12, 0, 0, 0, 56, 0, 5, 0, 0, 0,
			159, 0, 0, 0, 12, 254, 2, 0, 0, 0,
			5, 0, 0, 0, 0, 32, 0, 11, 0, 0,
			0, 0, 0, 0, 0, 208, 0, 10, 0, 0,
			0, 82, 1, 0, 1, 1, 40, 0, 13, 0,
			0, 0, 129, 3, 0, 10, 162, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 0,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 9, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 97, 0, 12, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 11, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 10,
			0, 0, 0, 148, 0, 12, 0, 0, 0, 4,
			254, 12, 0, 0, 0, 57, 0, 5, 0, 0,
			0, 216, 4, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 12, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 56, 0, 5, 0, 0, 0, 159, 0,
			0, 0, 12, 254, 2, 0, 0, 0, 10, 0,
			0, 0, 0, 32, 0, 11, 0, 0, 0, 121,
			42, 35, 209, 90, 0, 12, 0, 0, 0, 12,
			254, 2, 0, 0, 0, 11, 0, 0, 0, 0,
			32, 0, 11, 0, 0, 0, 5, 0, 0, 0,
			148, 0, 12, 0, 0, 0, 97, 0, 12, 0,
			0, 0, 56, 0, 5, 0, 0, 0, 159, 0,
			0, 0, 221, 0, 5, 0, 0, 0, 236, 4,
			0, 0, 38, 0, 12, 0, 0, 0, 32, 0,
			11, 0, 0, 0, 105, 169, 87, 81, 37, 0,
			12, 0, 0, 0, 14, 254, 2, 0, 0, 0,
			10, 0, 0, 0, 0, 12, 254, 2, 0, 0,
			0, 11, 0, 0, 0, 0, 32, 0, 11, 0,
			0, 0, 37, 0, 0, 0, 148, 0, 12, 0,
			0, 0, 94, 0, 12, 0, 0, 0, 69, 0,
			4, 0, 0, 0, 2, 0, 0, 0, 226, 4,
			0, 0, 235, 4, 0, 0, 56, 0, 5, 0,
			0, 0, 235, 4, 0, 0, 221, 0, 5, 0,
			0, 0, 236, 4, 0, 0, 42, 0, 12, 0,
			0, 0
		};
	}

	private static void _200C_200F_200D_200F_200F_202C_200E_200F_200E_200C_200F_200E_200E_200F_200E_200F()
	{
		bool[] array = (bool[])(object)new int[21]
		{
			25, 546552668, 46406130, 2105700954, 256467468, -2023652049, 352741459, 268229307, -1962968592, 2103313866,
			1508511866, 2095461243, 1017699744, -1743385968, -306564870, 58292344, -1308730666, -1070361355, 1390880861, 1228378144,
			1409523882
		};
		if (_202A_200F_202B_202D_200E_200D_200E_202E_200E_200C_200E_202E_200E_202D_200E_200F == null)
		{
			goto IL_00c4;
		}
		goto IL_01f8;
		IL_00c4:
		int num = 1748757564;
		goto IL_00c9;
		IL_00c9:
		FieldInfo fieldInfo = default;
		Type typeFromHandle = default;
		OpCode opCode = default;
		byte b = default;
		int num10 = default;
		FieldInfo[] fields = default;
		ushort num12 = default;
		byte b2 = default;
		OpCode[] array3 = default;
		while (true)
		{
			uint num2 = (uint)num;
			switch ((uint)num % (uint)((int[])(object)array)[0])
			{
			case 0u:
				break;
			default:
				return;
			case 21u:
				goto IL_013f;
			case 5u:
				goto IL_0184;
			case 16u:
			{
				int num7;
				int num8;
				if (!(fieldInfo.FieldType == typeFromHandle))
				{
					num7 = -1907791833;
					num8 = num7;
				}
				else
				{
					num7 = -229179904;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * ((int[])(object)array)[11]);
				continue;
			}
			case 15u:
				goto IL_01f8;
			case 11u:
				goto IL_0213;
			case 3u:
				goto IL_025a;
			case 24u:
				goto IL_029f;
			case 4u:
				goto IL_02de;
			case 2u:
				goto IL_0314;
			case 1u:
			{
				int num5;
				int num6;
				if (_200F_200E_200D_202A_200F_200D_200F_200C_200F_200D_200E_200D_200F_200C_200F_200E == null)
				{
					num5 = -1462158518;
					num6 = num5;
				}
				else
				{
					num5 = -167340396;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * ((int[])(object)array)[3]);
				continue;
			}
			case 19u:
				goto IL_0374;
			case 10u:
				goto IL_03ab;
			case 6u:
				goto IL_03e2;
			case 7u:
				goto IL_0414;
			case 17u:
			{
				int num3;
				int num4;
				if (opCode.Size != 1)
				{
					num3 = 530352595;
					num4 = num3;
				}
				else
				{
					num3 = 157732867;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * ((int[])(object)array)[14]);
				continue;
			}
			case 23u:
				goto IL_0455;
			case 22u:
				goto IL_0495;
			case 18u:
				goto IL_04c8;
			case 13u:
				goto IL_0512;
			case 12u:
				goto IL_054d;
			case 14u:
				goto IL_058d;
			case 8u:
				goto IL_05cc;
			case 20u:
				goto IL_0603;
			case 9u:
				return;
			}
			break;
			IL_0603:
			int num9;
			if (_202C_200E_200D_200C_200E_200F_200F_200F_200F_202B_200F_202A_200E_202A_200F_200F == null)
			{
				num = 1923477610;
				num9 = num;
			}
			else
			{
				num = 198464976;
				num9 = num;
			}
			continue;
			IL_02de:
			num = ((((int[])(object)array)[6] + ((int[])(object)array)[0] == ((int[])(object)array)[3]) ? (((int)num2 * -1509634124) ^ ((int[])(object)array)[1]) : ((int)(num2 * 1948081392) ^ ((int[])(object)array)[9]));
			continue;
			IL_025a:
			_202C_200E_200D_200C_200E_200F_200F_200F_200F_202B_200F_202A_200E_202A_200F_200F[b] = opCode;
			num = ((((int[])(object)array)[2] + ((int[])(object)array)[11] != ((int[])(object)array)[8]) ? (((int)num2 * -207194683) ^ ((int[])(object)array)[16]) : (((int)num2 * -2076621716) ^ ((int[])(object)array)[0]));
			continue;
			IL_05cc:
			num = ((((int[])(object)array)[5] + ((int[])(object)array)[7] == ((int[])(object)array)[6]) ? (((int)num2 * -1561474032) ^ ((int[])(object)array)[9]) : (((int)num2 * -718252346) ^ ((int[])(object)array)[17]));
			continue;
			IL_0455:
			typeFromHandle = typeof(OpCode);
			num = ((((int[])(object)array)[3] + ((int[])(object)array)[0] != ((int[])(object)array)[3]) ? ((int)(num2 * 111356885) ^ ((int[])(object)array)[6]) : ((int)(num2 * 855976118) ^ ((int[])(object)array)[4]));
			continue;
			IL_0374:
			num10 = 0;
			num = ((((int[])(object)array)[0] + ((int[])(object)array)[1] > ((int[])(object)array)[7]) ? ((int)(num2 * 1594593454) ^ ((int[])(object)array)[8]) : (((int)num2 * -31841384) ^ ((int[])(object)array)[2]));
			continue;
			IL_058d:
			_202A_200F_202B_202D_200E_200D_200E_202E_200E_200C_200E_202E_200E_202D_200E_200F = new object();
			num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[0]) <= ((int[])(object)array)[0]) ? (((int)num2 * -1306056758) ^ ((int[])(object)array)[1]) : ((int)(num2 * 386199400) ^ ((int[])(object)array)[0]));
			continue;
			IL_0184:
			opCode = (OpCode)fieldInfo.GetValue(null);
			num = ((((int[])(object)array)[12] + ((int[])(object)array)[9] < ((int[])(object)array)[9]) ? (((int)num2 * -61588495) ^ ((int[])(object)array)[12]) : (((int)num2 * -1456536559) ^ ((int[])(object)array)[3]));
			continue;
			IL_0414:
			int num11;
			if (num10 < fields.Length)
			{
				num = 1892576247;
				num11 = num;
			}
			else
			{
				num = 746216884;
				num11 = num;
			}
			continue;
			IL_054d:
			num12 = (ushort)opCode.Value;
			num = ((((int[])(object)array)[7] + ((int[])(object)array)[5] <= ((int[])(object)array)[0]) ? ((int)(num2 * 152891449) ^ ((int[])(object)array)[13]) : ((int)(num2 * 1184699632) ^ ((int[])(object)array)[5]));
			continue;
			IL_029f:
			_200B_200E_200C_200C_200F_200C_200E_202E_200E_200B_200E_200D_200F_200E_200E_200F = new Dictionary<MethodBase, DynamicMethod>();
			num = ((((int[])(object)array)[0] + ((int[])(object)array)[1] > ((int[])(object)array)[1]) ? (((int)num2 * -1512053468) ^ ((int[])(object)array)[2]) : (((int)num2 * -684427074) ^ ((int[])(object)array)[0]));
			continue;
			IL_0314:
			b = (byte)num12;
			num = ((((int[])(object)array)[12] + ((int[])(object)array)[10] < ((int[])(object)array)[7]) ? ((int)(num2 * 244539684) ^ ((int[])(object)array)[15]) : ((int)(num2 * 1023203158) ^ ((int[])(object)array)[2]));
			continue;
			IL_0512:
			b2 = (byte)(num12 | 0xFE00);
			num = (((((int[])(object)array)[12] ^ ((int[])(object)array)[0]) <= ((int[])(object)array)[14]) ? (((int)num2 * -418147865) ^ ((int[])(object)array)[11]) : ((int[])(object)array)[18]);
			continue;
			IL_03e2:
			num10++;
			num = (((((int[])(object)array)[18] ^ ((int[])(object)array)[6]) < ((int[])(object)array)[4]) ? ((int)(num2 * 1855190353) ^ ((int[])(object)array)[4]) : ((int[])(object)array)[20]);
			continue;
			IL_013f:
			fields = typeof(OpCodes).GetFields();
			num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[4]) >= ((int[])(object)array)[0]) ? ((int)(num2 * 1593316187) ^ ((int[])(object)array)[3]) : ((int)(num2 * 1510768500) ^ ((int[])(object)array)[7]));
			continue;
			IL_04c8:
			OpCode[] array2 = new OpCode[256];
			_202C_200E_200D_200C_200E_200F_200F_200F_200F_202B_200F_202A_200E_202A_200F_200F = array3;
			_200F_200E_200D_202A_200F_200D_200F_200C_200F_200D_200E_200D_200F_200C_200F_200E = array2;
			num = ((((int[])(object)array)[2] + ((int[])(object)array)[2] == ((int[])(object)array)[0]) ? ((int)(num2 * 1494502962) ^ ((int[])(object)array)[3]) : ((int)(num2 * 2128786091) ^ ((int[])(object)array)[5]));
			continue;
			IL_0213:
			_200F_200E_200D_202A_200F_200D_200F_200C_200F_200D_200E_200D_200F_200C_200F_200E[b2] = opCode;
			num = ((((int[])(object)array)[9] + ((int[])(object)array)[11] <= ((int[])(object)array)[12]) ? ((int)(num2 * 1790821741) ^ ((int[])(object)array)[19]) : ((int)(num2 * 1237370534) ^ ((int[])(object)array)[5]));
			continue;
			IL_03ab:
			array3 = new OpCode[256];
			num = ((((int[])(object)array)[2] + ((int[])(object)array)[4] < ((int[])(object)array)[3]) ? ((int[])(object)array)[4] : ((int)(num2 * 1238039962) ^ ((int[])(object)array)[0]));
			continue;
			IL_0495:
			fieldInfo = fields[num10];
			num = ((((int[])(object)array)[8] + ((int[])(object)array)[8] < ((int[])(object)array)[10]) ? ((int[])(object)array)[10] : (((int)num2 * -1227615448) ^ ((int[])(object)array)[0]));
		}
		goto IL_00c4;
		IL_01f8:
		int num13;
		if (_200B_200E_200C_200C_200F_200C_200E_202E_200E_200B_200E_200D_200F_200E_200E_200F != null)
		{
			num = 1586616670;
			num13 = num;
		}
		else
		{
			num = 983314899;
			num13 = num;
		}
		goto IL_00c9;
	}

	internal static object _200B_200E_200E_200D_200F_200E_200F_202A_200E_200B_200E_200E_200E_200D_200F_200E(long P_0, object[] P_1)
	{
		bool[] array = (bool[])(object)new int[4] { 5, 96324910, 1032378111, -1056392393 };
		_200C_200F_200D_200F_200F_202C_200E_200F_200E_200C_200F_200E_200E_200F_200E_200F();
		MethodBase method = default;
		DynamicMethod value = default;
		while (true)
		{
			int num = 1234470331;
			while (true)
			{
				uint num2 = (uint)num;
				switch ((uint)num % (uint)((int[])(object)array)[0])
				{
				case 3u:
					break;
				case 1u:
					method = new StackTrace().GetFrame(1).GetMethod();
					num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[0]) < ((int[])(object)array)[0]) ? ((int)(num2 * 1634506943) ^ ((int[])(object)array)[1]) : ((int)(num2 * 59756784) ^ ((int[])(object)array)[1]));
					continue;
				case 4u:
					return value.Invoke(null, P_1);
				case 0u:
				{
					int num3;
					int num4;
					if (!_200B_200E_200C_200C_200F_200C_200E_202E_200E_200B_200E_200D_200F_200E_200E_200F.TryGetValue(method, out value))
					{
						num3 = -908618431;
						num4 = num3;
					}
					else
					{
						num3 = -499088386;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * ((int[])(object)array)[2]);
					continue;
				}
				default:
					return _200F_200E_202E_202B_200F_200F_200E_200D_200E_202A_200F_200D_200E_200B_200E_200E(P_0, P_1, method);
				}
				break;
			}
		}
	}

	private static object _200F_200E_202E_202B_200F_200F_200E_200D_200E_202A_200F_200D_200E_200B_200E_200E(long P_0, object[] P_1, MethodBase P_2)
	{
		bool[] array = (bool[])(object)new int[133]
		{
			40, -1256978522, 1826458185, -841592237, 1384419842, -652990973, -1078321754, 135506321, -1708674352, 1803294367,
			-523794487, -1029486512, -1441150398, 2119494661, 1916629804, -205184589, 1514055404, 376942717, 332969237, 598411219,
			-1325134583, 738591763, 1822347735, 1278426226, -971758034, 1871912853, -1222601795, -822320798, 1824377392, 391193922,
			-55275997, 213331922, 1539470689, 386143003, 378676012, -127740233, 1933714824, -2055103097, 5, 1703485387,
			-2143633453, 3, -1620469311, 5, -2129878293, 479759223, -1732606536, 14, 1576527498, 2075628812,
			603808729, 1486287712, 262600498, -1720205397, -1234251897, 654832394, -152733934, 919789956, 2, 2,
			15, 409206375, -1156314985, -1976555156, -1958498832, -1474565782, 590610281, -1417468090, 1983055667, -120032798,
			-306010527, 1677638863, 1812105422, 411034523, 7, 1318968440, 961798207, 58790772, -354118269, 2,
			20, 1196261671, 1224114634, -244581574, -820853203, 923755870, 208482125, 1208667687, 1458129814, 1254157141,
			-523191729, 1270370392, 250143235, -753040816, -1159120270, 1422797299, 1071327676, -928308639, -1475644475, 6,
			482712034, 1089402033, 1968280962, 2, 3, 87089520, 2, 24, 1190854887, 2115929917,
			1389684902, 675976380, 1069589167, -1902641275, 1546330055, 502097947, 272159734, -654204649, 635712703, 1933129984,
			-1459507762, 413627360, 1019005471, 729490903, 567162749, 273880030, -1916198651, 1484395604, 4, -2006183009,
			1418064288, 3, -87845275
		};
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(_202A_200F_202B_202B_200F_202A_200F_200B_200E_200E_200E_200C_200F_200D_200F_200F()));
		Dictionary<int, int> dictionary3 = default;
		ILGenerator iLGenerator = default;
		DynamicMethod dynamicMethod = default;
		int count = default;
		List<LocalBuilder> list = default;
		int num43 = default;
		ParameterInfo[] parameters = default;
		Type[] array2 = default;
		int num47 = default;
		ParameterInfo parameterInfo = default;
		List<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E> list2 = default;
		MethodBody methodBody = default;
		BinaryReader binaryReader2 = default;
		LocalVariableInfo current = default;
		Dictionary<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E, int> dictionary = default;
		List<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E> list3 = default;
		_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E current2 = default;
		List<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E> list5 = default;
		_200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E obj = default;
		_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E current4 = default;
		_200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E obj2 = default;
		_200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E obj3 = default;
		_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E current5 = default;
		short num36 = default;
		OpCode opCode = default;
		int num34 = default;
		int num35 = default;
		byte b = default;
		Dictionary<int, Label> dictionary2 = default;
		object obj4 = default;
		Label value = default;
		while (true)
		{
			int num = 2034818450;
			while (true)
			{
				uint num2 = (uint)num;
				switch ((uint)num % (uint)((int[])(object)array)[0])
				{
				case 12u:
					break;
				case 38u:
					dictionary3.Add(binaryReader.ReadInt32(), 4);
					num = ((((int[])(object)array)[0] + ((int[])(object)array)[3] < ((int[])(object)array)[4]) ? ((int)(num2 * 319820981) ^ ((int[])(object)array)[7]) : (((int)num2 * -1547891842) ^ ((int[])(object)array)[5]));
					continue;
				case 24u:
					iLGenerator = dynamicMethod.GetILGenerator();
					num = ((((int[])(object)array)[35] + ((int[])(object)array)[8] < ((int[])(object)array)[31]) ? ((int)(num2 * 41540146) ^ ((int[])(object)array)[37]) : (((int)num2 * -16228385) ^ ((int[])(object)array)[21]));
					continue;
				case 18u:
					count = binaryReader.ReadInt32();
					num = (((((int[])(object)array)[17] ^ ((int[])(object)array)[14]) != ((int[])(object)array)[2]) ? ((int)(num2 * 1611345553) ^ ((int[])(object)array)[19]) : (((int)num2 * -1886583262) ^ ((int[])(object)array)[18]));
					continue;
				case 7u:
					dictionary3.Add(binaryReader.ReadInt32(), 7);
					num = ((((int[])(object)array)[6] + ((int[])(object)array)[1] < ((int[])(object)array)[0]) ? (((int)num2 * -1335696785) ^ ((int[])(object)array)[10]) : ((int)(num2 * 1236807940) ^ ((int[])(object)array)[10]));
					continue;
				case 0u:
					dictionary3.Add(binaryReader.ReadInt32(), 6);
					num = ((((int[])(object)array)[5] + ((int[])(object)array)[5] <= ((int[])(object)array)[8]) ? (((int)num2 * -936829604) ^ ((int[])(object)array)[2]) : (((int)num2 * -1697390121) ^ ((int[])(object)array)[9]));
					continue;
				case 28u:
					dictionary3.Add(binaryReader.ReadInt32(), 10);
					num = ((((int[])(object)array)[6] + ((int[])(object)array)[9] > ((int[])(object)array)[11]) ? ((int)(num2 * 235660650) ^ ((int[])(object)array)[13]) : ((int)(num2 * 1659492505) ^ ((int[])(object)array)[4]));
					continue;
				case 5u:
					list = new List<LocalBuilder>();
					num = (((((int[])(object)array)[20] ^ ((int[])(object)array)[19]) == ((int[])(object)array)[3]) ? ((int)(num2 * 1464861405) ^ ((int[])(object)array)[15]) : (((int)num2 * -820022718) ^ ((int[])(object)array)[22]));
					continue;
				case 26u:
				{
					int num45;
					int num46;
					if (!P_2.IsStatic)
					{
						num45 = -1225089042;
						num46 = num45;
					}
					else
					{
						num45 = -367926677;
						num46 = num45;
					}
					num = num45 ^ ((int)num2 * ((int[])(object)array)[25]);
					continue;
				}
				case 29u:
					dictionary3.Add(binaryReader.ReadInt32(), 11);
					num = ((((int[])(object)array)[10] + ((int[])(object)array)[0] >= ((int[])(object)array)[3]) ? ((int)(num2 * 1075671217) ^ ((int[])(object)array)[14]) : (((int)num2 * -737732233) ^ ((int[])(object)array)[11]));
					continue;
				case 15u:
					num43 = 0;
					num = ((((int[])(object)array)[31] + ((int[])(object)array)[6] >= ((int[])(object)array)[29]) ? (((int)num2 * -1444140989) ^ ((int[])(object)array)[18]) : ((int[])(object)array)[31]);
					continue;
				case 31u:
					dictionary3.Add(binaryReader.ReadInt32(), 5);
					num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[3]) < ((int[])(object)array)[4]) ? ((int)(num2 * 425649696) ^ ((int[])(object)array)[0]) : ((int)(num2 * 4981584) ^ ((int[])(object)array)[8]));
					continue;
				case 19u:
				{
					int num44;
					if (num43 < parameters.Length)
					{
						num = 2072369691;
						num44 = num;
					}
					else
					{
						num = 1987954288;
						num44 = num;
					}
					continue;
				}
				case 3u:
					array2[num47 + num43] = parameterInfo.ParameterType;
					num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[31]) > ((int[])(object)array)[10]) ? (((int)num2 * -1239792842) ^ ((int[])(object)array)[18]) : (((int)num2 * -448334192) ^ ((int[])(object)array)[34]));
					continue;
				case 14u:
					dictionary3.Add(binaryReader.ReadInt32(), 1);
					num = ((((int[])(object)array)[1] + ((int[])(object)array)[2] > ((int[])(object)array)[2]) ? ((int)(num2 * 432673208) ^ ((int[])(object)array)[1]) : (((int)num2 * -1353515157) ^ ((int[])(object)array)[4]));
					continue;
				case 11u:
					parameterInfo = parameters[num43];
					num = (((((int[])(object)array)[5] ^ ((int[])(object)array)[22]) == ((int[])(object)array)[16]) ? ((int)(num2 * 979293658) ^ ((int[])(object)array)[4]) : ((int[])(object)array)[33]);
					continue;
				case 13u:
					dictionary3.Add(binaryReader.ReadInt32(), 8);
					num = ((((int[])(object)array)[5] + ((int[])(object)array)[10] <= ((int[])(object)array)[1]) ? ((int)(num2 * 301686295) ^ ((int[])(object)array)[8]) : ((int)(num2 * 2019463387) ^ ((int[])(object)array)[11]));
					continue;
				case 35u:
					num47 = 0;
					num = ((((int[])(object)array)[20] + ((int[])(object)array)[21] < ((int[])(object)array)[13]) ? ((int)(num2 * 658981148) ^ ((int[])(object)array)[24]) : ((int)(num2 * 1212946120) ^ ((int[])(object)array)[18]));
					continue;
				case 17u:
					dictionary3.Add(binaryReader.ReadInt32(), 0);
					num = ((((int[])(object)array)[0] + ((int[])(object)array)[3] != ((int[])(object)array)[2]) ? ((int)(num2 * 789943149) ^ ((int[])(object)array)[3]) : ((int)(num2 * 1190321583) ^ ((int[])(object)array)[0]));
					continue;
				case 23u:
					dictionary3.Add(binaryReader.ReadInt32(), 9);
					num = ((((int[])(object)array)[4] + ((int[])(object)array)[3] != ((int[])(object)array)[8]) ? ((int)(num2 * 1543047002) ^ ((int[])(object)array)[12]) : ((int)(num2 * 2078039105) ^ ((int[])(object)array)[5]));
					continue;
				case 2u:
					num = ((((int[])(object)array)[32] + ((int[])(object)array)[24] <= ((int[])(object)array)[9]) ? (((int)num2 * -2121026715) ^ ((int[])(object)array)[32]) : ((int)(num2 * 798638954) ^ ((int[])(object)array)[12]));
					continue;
				case 32u:
					array2[0] = P_2.DeclaringType;
					num = ((((int[])(object)array)[25] + ((int[])(object)array)[3] < ((int[])(object)array)[9]) ? (((int)num2 * -1393423167) ^ ((int[])(object)array)[29]) : ((int)(num2 * 474294163) ^ ((int[])(object)array)[21]));
					continue;
				case 20u:
					array2 = new Type[parameters.Length + 1];
					num = (((((int[])(object)array)[22] ^ ((int[])(object)array)[21]) < ((int[])(object)array)[22]) ? ((int[])(object)array)[28] : ((int)(num2 * 950291786) ^ ((int[])(object)array)[24]));
					continue;
				case 37u:
					list2 = new List<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E>();
					num = ((((int[])(object)array)[20] + ((int[])(object)array)[3] >= ((int[])(object)array)[7]) ? ((int)(num2 * 1063813453) ^ ((int[])(object)array)[23]) : ((int)(num2 * 1941645517) ^ ((int[])(object)array)[23]));
					continue;
				case 8u:
					dynamicMethod = new DynamicMethod("", (P_2.MemberType == MemberTypes.Constructor) ? null : ((MethodInfo)P_2).ReturnParameter.ParameterType, array2, typeof(_202B_200E_200F_200F_200E_202A_200E_200D_200E_202A_200F_202D_200E_200D_200E_200E).Module, skipVisibility: true);
					num = ((((int[])(object)array)[9] + ((int[])(object)array)[22] == ((int[])(object)array)[8]) ? ((int)(num2 * 567929528) ^ ((int[])(object)array)[17]) : ((int[])(object)array)[36]);
					continue;
				case 27u:
					dictionary3.Add(binaryReader.ReadInt32(), 3);
					num = (((((int[])(object)array)[2] ^ ((int[])(object)array)[5]) == ((int[])(object)array)[3]) ? ((int)(num2 * 1080893215) ^ ((int[])(object)array)[6]) : ((int)(num2 * 669369736) ^ ((int[])(object)array)[6]));
					continue;
				case 30u:
					dictionary3.Add(binaryReader.ReadInt32(), 14);
					num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[11]) >= ((int[])(object)array)[7]) ? ((int)(num2 * 1356395972) ^ ((int[])(object)array)[17]) : (((int)num2 * -1186787106) ^ ((int[])(object)array)[13]));
					continue;
				case 4u:
					dictionary3 = new Dictionary<int, int>();
					num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[0]) <= ((int[])(object)array)[2]) ? (((int)num2 * -1899925834) ^ ((int[])(object)array)[2]) : (((int)num2 * -320832943) ^ ((int[])(object)array)[0]));
					continue;
				case 33u:
					dictionary3.Add(binaryReader.ReadInt32(), 12);
					num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[4]) >= ((int[])(object)array)[8]) ? (((int)num2 * -1377391963) ^ ((int[])(object)array)[15]) : ((int)(num2 * 1956675135) ^ ((int[])(object)array)[14]));
					continue;
				case 34u:
					num47 = 1;
					num = ((((int[])(object)array)[21] + ((int[])(object)array)[4] < ((int[])(object)array)[25]) ? (((int)num2 * -2033440164) ^ ((int[])(object)array)[12]) : ((int)(num2 * 2081283874) ^ ((int[])(object)array)[30]));
					continue;
				case 16u:
					dictionary3.Add(binaryReader.ReadInt32(), 2);
					num = ((((int[])(object)array)[4] + ((int[])(object)array)[0] > ((int[])(object)array)[1]) ? (((int)num2 * -1431409975) ^ ((int[])(object)array)[5]) : ((int)(num2 * 647555281) ^ ((int[])(object)array)[4]));
					continue;
				case 1u:
					array2 = new Type[parameters.Length];
					num = ((((int[])(object)array)[26] + ((int[])(object)array)[20] == ((int[])(object)array)[23]) ? (((int)num2 * -19275426) ^ ((int[])(object)array)[8]) : (((int)num2 * -995824308) ^ ((int[])(object)array)[26]));
					continue;
				case 36u:
					num43++;
					num = (((((int[])(object)array)[2] ^ ((int[])(object)array)[1]) >= ((int[])(object)array)[6]) ? ((int)(num2 * 417251237) ^ ((int[])(object)array)[35]) : ((int)(num2 * 596609645) ^ ((int[])(object)array)[19]));
					continue;
				case 9u:
				{
					byte[] buffer = binaryReader.ReadBytes(count);
					methodBody = P_2.GetMethodBody();
					binaryReader2 = new BinaryReader(new MemoryStream(buffer));
					num = ((((int[])(object)array)[1] + ((int[])(object)array)[19] == ((int[])(object)array)[8]) ? ((int)(num2 * 784032511) ^ ((int[])(object)array)[16]) : (((int)num2 * -298585729) ^ ((int[])(object)array)[20]));
					continue;
				}
				case 10u:
					binaryReader.BaseStream.Position = P_0;
					num = ((((int[])(object)array)[0] + ((int[])(object)array)[1] >= ((int[])(object)array)[0]) ? ((int)(num2 * 1817463420) ^ ((int[])(object)array)[0]) : (((int)num2 * -1832213407) ^ ((int[])(object)array)[1]));
					continue;
				case 22u:
					parameters = P_2.GetParameters();
					num = ((((int[])(object)array)[14] + ((int[])(object)array)[9] > ((int[])(object)array)[21]) ? (((int)num2 * -1733937926) ^ ((int[])(object)array)[18]) : ((int)(num2 * 1216205841) ^ ((int[])(object)array)[21]));
					continue;
				case 21u:
					dictionary3.Add(binaryReader.ReadInt32(), 15);
					num = (((((int[])(object)array)[11] ^ ((int[])(object)array)[14]) < ((int[])(object)array)[1]) ? ((int)(num2 * 979000467) ^ ((int[])(object)array)[18]) : (((int)num2 * -1178356742) ^ ((int[])(object)array)[5]));
					continue;
				case 6u:
					dictionary3.Add(binaryReader.ReadInt32(), 13);
					num = (((((int[])(object)array)[14] ^ ((int[])(object)array)[16]) <= ((int[])(object)array)[7]) ? (((int)num2 * -2138308819) ^ ((int[])(object)array)[10]) : ((int)(num2 * 1525844599) ^ ((int[])(object)array)[16]));
					continue;
				case 25u:
					num = (((((int[])(object)array)[5] ^ ((int[])(object)array)[2]) != ((int[])(object)array)[7]) ? (((int)num2 * -678269163) ^ ((int[])(object)array)[27]) : (((int)num2 * -2069399438) ^ ((int[])(object)array)[20]));
					continue;
				default:
				{
					IList<LocalVariableInfo> localVariables = methodBody.LocalVariables;
					_ = new Type[localVariables.Count];
					IEnumerator<LocalVariableInfo> enumerator = localVariables.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0f56:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1925293446;
								num4 = num3;
							}
							else
							{
								num3 = 1892597338;
								num4 = num3;
							}
							while (true)
							{
								num2 = (uint)num3;
								switch ((uint)num3 % (uint)((int[])(object)array)[38])
								{
								case 0u:
									num3 = 1892597338;
									continue;
								default:
									goto end_IL_0efb;
								case 3u:
									current = enumerator.Current;
									num3 = ((((int[])(object)array)[28] + ((int[])(object)array)[9] >= ((int[])(object)array)[32]) ? (((int)num2 * -1740959922) ^ ((int[])(object)array)[34]) : ((int[])(object)array)[39]);
									continue;
								case 4u:
									break;
								case 2u:
									list.Add(iLGenerator.DeclareLocal(current.LocalType));
									num3 = (((((int[])(object)array)[21] ^ ((int[])(object)array)[26]) == ((int[])(object)array)[27]) ? ((int)(num2 * 395887460) ^ ((int[])(object)array)[13]) : (((int)num2 * -160385903) ^ ((int[])(object)array)[40]));
									continue;
								case 1u:
									goto end_IL_0efb;
								}
								goto IL_0f56;
								continue;
								end_IL_0efb:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								IL_0fc5:
								int num5 = 1563325756;
								while (true)
								{
									num2 = (uint)num5;
									switch ((uint)num5 % (uint)((int[])(object)array)[41])
									{
									case 2u:
										break;
									default:
										goto end_IL_0fca;
									case 1u:
										enumerator.Dispose();
										num5 = ((((int[])(object)array)[6] + ((int[])(object)array)[40] == ((int[])(object)array)[37]) ? ((int)(num2 * 398931851) ^ ((int[])(object)array)[12]) : (((int)num2 * -151746374) ^ ((int[])(object)array)[42]));
										continue;
									case 0u:
										goto end_IL_0fca;
									}
									goto IL_0fc5;
									continue;
									end_IL_0fca:
									break;
								}
								break;
							}
						}
					}
					int num6 = binaryReader2.ReadInt32();
					while (true)
					{
						int num7 = 283454066;
						while (true)
						{
							num2 = (uint)num7;
							switch ((uint)num7 % (uint)((int[])(object)array)[43])
							{
							case 4u:
								break;
							case 2u:
								dictionary = new Dictionary<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E, int>();
								num7 = (((((int[])(object)array)[39] ^ ((int[])(object)array)[6]) == ((int[])(object)array)[17]) ? (((int)num2 * -1889410828) ^ ((int[])(object)array)[37]) : ((int)(num2 * 1654750181) ^ ((int[])(object)array)[46]));
								continue;
							case 0u:
								list3 = new List<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E>();
								num7 = ((((int[])(object)array)[18] + ((int[])(object)array)[16] < ((int[])(object)array)[30]) ? ((int)(num2 * 936063537) ^ ((int[])(object)array)[16]) : (((int)num2 * -1334292222) ^ ((int[])(object)array)[45]));
								continue;
							case 1u:
								_202A_200E_202B_200D_200E_200D_200F_200F_200F_200C_200F_200F_200E_202D_200E_200E(binaryReader2, num6, P_2, list2);
								num7 = (((((int[])(object)array)[28] ^ ((int[])(object)array)[28]) > ((int[])(object)array)[38]) ? (((int)num2 * -1615443882) ^ ((int[])(object)array)[14]) : ((int)(num2 * 417716190) ^ ((int[])(object)array)[44]));
								continue;
							default:
							{
								List<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E>.Enumerator enumerator2 = list2.GetEnumerator();
								try
								{
									while (true)
									{
										IL_137a:
										int num8;
										int num9;
										if (enumerator2.MoveNext())
										{
											num8 = 1634550804;
											num9 = num8;
										}
										else
										{
											num8 = 1381610361;
											num9 = num8;
										}
										while (true)
										{
											num2 = (uint)num8;
											switch ((uint)num8 % (uint)((int[])(object)array)[47])
											{
											case 10u:
												num8 = 1634550804;
												continue;
											default:
												goto end_IL_112a;
											case 12u:
												current2 = enumerator2.Current;
												num8 = ((((int[])(object)array)[3] + ((int[])(object)array)[22] == ((int[])(object)array)[5]) ? (((int)num2 * -19288889) ^ ((int[])(object)array)[36]) : ((int[])(object)array)[48]);
												continue;
											case 0u:
											{
												int num13;
												int num14;
												if (current2._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E == 5)
												{
													num13 = -1735338020;
													num14 = num13;
												}
												else
												{
													num13 = -940318379;
													num14 = num13;
												}
												num8 = num13 ^ ((int)num2 * ((int[])(object)array)[49]);
												continue;
											}
											case 1u:
												num8 = (((((int[])(object)array)[14] ^ ((int[])(object)array)[47]) <= ((int[])(object)array)[17]) ? ((int)(num2 * 259190621) ^ ((int[])(object)array)[35]) : (((int)num2 * -1725573621) ^ ((int[])(object)array)[54]));
												continue;
											case 2u:
												dictionary.Add(current2, current2._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E);
												num8 = ((((int[])(object)array)[33] + ((int[])(object)array)[21] > ((int[])(object)array)[35]) ? ((int)(num2 * 411598757) ^ ((int[])(object)array)[50]) : ((int)(num2 * 1967583654) ^ ((int[])(object)array)[19]));
												continue;
											case 3u:
												list3.Add(current2);
												num8 = (((((int[])(object)array)[37] ^ ((int[])(object)array)[14]) < ((int[])(object)array)[54]) ? ((int)(num2 * 937938029) ^ ((int[])(object)array)[44]) : ((int[])(object)array)[55]);
												continue;
											case 4u:
											{
												int num11;
												int num12;
												if (current2._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E != null)
												{
													num11 = 1454089033;
													num12 = num11;
												}
												else
												{
													num11 = 878294949;
													num12 = num11;
												}
												num8 = num11 ^ ((int)num2 * ((int[])(object)array)[52]);
												continue;
											}
											case 13u:
												dictionary.Add(current2, current2._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E);
												num8 = ((((int[])(object)array)[1] + ((int[])(object)array)[44] >= ((int[])(object)array)[16]) ? ((int)(num2 * 634551199) ^ ((int[])(object)array)[0]) : (((int)num2 * -1266665894) ^ ((int[])(object)array)[53]));
												continue;
											case 11u:
												num8 = ((((int[])(object)array)[24] + ((int[])(object)array)[38] >= ((int[])(object)array)[7]) ? ((int)(num2 * 86671394) ^ ((int[])(object)array)[41]) : ((int)(num2 * 214911988) ^ ((int[])(object)array)[51]));
												continue;
											case 9u:
												dictionary.Add(current2, current2._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E);
												num8 = (((((int[])(object)array)[32] ^ ((int[])(object)array)[16]) >= ((int[])(object)array)[30]) ? ((int[])(object)array)[57] : ((int)(num2 * 424913774) ^ ((int[])(object)array)[55]));
												continue;
											case 8u:
												break;
											case 7u:
											{
												int num10;
												if (!dictionary.ContainsValue(current2._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E))
												{
													num8 = 1004936095;
													num10 = num8;
												}
												else
												{
													num8 = 1869057334;
													num10 = num8;
												}
												continue;
											}
											case 6u:
												num8 = (((((int[])(object)array)[40] ^ ((int[])(object)array)[28]) >= ((int[])(object)array)[7]) ? (((int)num2 * -2008738881) ^ ((int[])(object)array)[53]) : (((int)num2 * -680729969) ^ ((int[])(object)array)[56]));
												continue;
											case 5u:
												goto end_IL_112a;
											}
											goto IL_137a;
											continue;
											end_IL_112a:
											break;
										}
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
									while (true)
									{
										switch ((num2 = 1217644351u) % (uint)((int[])(object)array)[58])
										{
										case 0u:
											break;
										default:
											goto end_IL_1403;
										case 1u:
											goto end_IL_1403;
										}
										continue;
										end_IL_1403:
										break;
									}
								}
								List<_200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E> list4 = new List<_200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E>();
								while (true)
								{
									switch ((num2 = 1031531849u) % (uint)((int[])(object)array)[59])
									{
									case 0u:
										continue;
									}
									Dictionary<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E, int>.Enumerator enumerator3 = dictionary.GetEnumerator();
									try
									{
										while (true)
										{
											IL_20b2:
											KeyValuePair<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E, int> current3;
											if (enumerator3.MoveNext())
											{
												while (true)
												{
													current3 = enumerator3.Current;
													int num15 = (((((int[])(object)array)[0] ^ ((int[])(object)array)[59]) > ((int[])(object)array)[2]) ? ((int)(num2 * 1862827388) ^ ((int[])(object)array)[60]) : ((int[])(object)array)[61]);
													while (true)
													{
														num2 = (uint)num15;
														switch ((uint)num15 % (uint)((int[])(object)array)[60])
														{
														case 13u:
															num15 = 1679887931;
															continue;
														case 10u:
															break;
														case 5u:
															goto IL_14dc;
														case 3u:
															goto IL_1529;
														case 0u:
														{
															int num16;
															int num17;
															if (current3.Key._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E == 5)
															{
																num16 = -81131933;
																num17 = num16;
															}
															else
															{
																num16 = -1653456417;
																num17 = num16;
															}
															num15 = num16 ^ ((int)num2 * ((int[])(object)array)[62]);
															continue;
														}
														case 6u:
															goto IL_15e1;
														case 1u:
															goto IL_1633;
														case 9u:
															goto IL_167e;
														case 12u:
															goto IL_16be;
														case 7u:
															goto IL_170b;
														case 4u:
															goto IL_174d;
														case 2u:
															goto IL_179a;
														case 11u:
															goto end_IL_1458;
														default:
															goto end_IL_17ec;
														case 14u:
															goto IL_20b2;
														}
														list5 = new List<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E>();
														num15 = (((((int[])(object)array)[15] ^ ((int[])(object)array)[59]) < ((int[])(object)array)[41]) ? ((int[])(object)array)[73] : (((int)num2 * -1620315172) ^ ((int[])(object)array)[41]));
														continue;
														IL_179a:
														obj._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E.Add(current3.Key._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E);
														num15 = ((((int[])(object)array)[56] + ((int[])(object)array)[40] > ((int[])(object)array)[19]) ? (((int)num2 * -1635944982) ^ ((int[])(object)array)[70]) : (((int)num2 * -1471044073) ^ ((int[])(object)array)[28]));
														continue;
														IL_167e:
														obj = new _200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E();
														num15 = (((((int[])(object)array)[23] ^ ((int[])(object)array)[13]) == ((int[])(object)array)[38]) ? (((int)num2 * -709319342) ^ ((int[])(object)array)[6]) : ((int)(num2 * 1312502536) ^ ((int[])(object)array)[63]));
														continue;
														IL_15e1:
														obj._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E.Add(current3.Key._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E);
														num15 = (((((int[])(object)array)[53] ^ ((int[])(object)array)[15]) >= ((int[])(object)array)[52]) ? ((int)(num2 * 122998294) ^ ((int[])(object)array)[69]) : ((int)(num2 * 1405163899) ^ ((int[])(object)array)[9]));
														continue;
														IL_174d:
														obj._202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E = current3.Key._202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E;
														num15 = (((((int[])(object)array)[33] ^ ((int[])(object)array)[17]) >= ((int[])(object)array)[27]) ? (((int)num2 * -1368182895) ^ ((int[])(object)array)[65]) : ((int)(num2 * 124718615) ^ ((int[])(object)array)[36]));
														continue;
														IL_1529:
														obj._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E = current3.Key._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E;
														num15 = ((((int[])(object)array)[64] + ((int[])(object)array)[55] < ((int[])(object)array)[47]) ? ((int)(num2 * 1152886825) ^ ((int[])(object)array)[64]) : ((int)(num2 * 340340557) ^ ((int[])(object)array)[49]));
														continue;
														IL_1633:
														obj._202D_200E_200C_202A_200E_202E_200E_202A_200E_202C_200E_200E_200F_200D_200E_200E = current3.Key._202D_200E_200C_202A_200E_202E_200E_202A_200E_202C_200E_200E_200F_200D_200E_200E;
														num15 = (((((int[])(object)array)[2] ^ ((int[])(object)array)[4]) != ((int[])(object)array)[47]) ? ((int)(num2 * 886837446) ^ ((int[])(object)array)[66]) : (((int)num2 * -130458664) ^ ((int[])(object)array)[49]));
														continue;
														IL_170b:
														list4.Add(obj);
														num15 = ((((int[])(object)array)[24] + ((int[])(object)array)[3] < ((int[])(object)array)[38]) ? ((int)(num2 * 767444775) ^ ((int[])(object)array)[71]) : (((int)num2 * -1313963598) ^ ((int[])(object)array)[69]));
														continue;
														IL_14dc:
														obj._200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F = current3.Key._200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F;
														num15 = ((((int[])(object)array)[54] + ((int[])(object)array)[64] >= ((int[])(object)array)[33]) ? (((int)num2 * -662465096) ^ ((int[])(object)array)[67]) : (((int)num2 * -2139848484) ^ ((int[])(object)array)[54]));
														continue;
														IL_16be:
														obj._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E = current3.Key._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E;
														num15 = ((((int[])(object)array)[12] + ((int[])(object)array)[53] < ((int[])(object)array)[56]) ? (((int)num2 * -1089027104) ^ ((int[])(object)array)[50]) : (((int)num2 * -1877314289) ^ ((int[])(object)array)[68]));
														continue;
														end_IL_1458:
														break;
													}
													continue;
													end_IL_17ec:
													break;
												}
												enumerator2 = list3.GetEnumerator();
												try
												{
													while (true)
													{
														IL_1931:
														int num18;
														int num19;
														if (enumerator2.MoveNext())
														{
															num18 = 1763665355;
															num19 = num18;
														}
														else
														{
															num18 = 1057216646;
															num19 = num18;
														}
														while (true)
														{
															num2 = (uint)num18;
															switch ((uint)num18 % (uint)((int[])(object)array)[74])
															{
															case 2u:
																num18 = 1763665355;
																continue;
															default:
																goto end_IL_1837;
															case 4u:
																current4 = enumerator2.Current;
																num18 = ((((int[])(object)array)[25] + ((int[])(object)array)[42] > ((int[])(object)array)[11]) ? ((int[])(object)array)[75] : ((int)(num2 * 1509112183) ^ ((int[])(object)array)[25]));
																continue;
															case 6u:
															{
																int num20;
																int num21;
																if (current4._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E == current3.Value)
																{
																	num20 = -1262282715;
																	num21 = num20;
																}
																else
																{
																	num20 = -1893909037;
																	num21 = num20;
																}
																num18 = num20 ^ ((int)num2 * ((int[])(object)array)[76]);
																continue;
															}
															case 0u:
															{
																int num22;
																int num23;
																if (current4._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E == 5)
																{
																	num22 = 992347455;
																	num23 = num22;
																}
																else
																{
																	num22 = 1109114113;
																	num23 = num22;
																}
																num18 = num22 ^ ((int)num2 * ((int[])(object)array)[77]);
																continue;
															}
															case 5u:
																list5.Add(current4);
																num18 = ((((int[])(object)array)[40] + ((int[])(object)array)[74] < ((int[])(object)array)[49]) ? (((int)num2 * -548370184) ^ ((int[])(object)array)[78]) : ((int)(num2 * 241712856) ^ ((int[])(object)array)[32]));
																continue;
															case 1u:
																break;
															case 3u:
																goto end_IL_1837;
															}
															goto IL_1931;
															continue;
															end_IL_1837:
															break;
														}
														break;
													}
												}
												finally
												{
													((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
													while (true)
													{
														switch ((num2 = 702827813u) % (uint)((int[])(object)array)[79])
														{
														case 0u:
															break;
														default:
															goto end_IL_195d;
														case 1u:
															goto end_IL_195d;
														}
														continue;
														end_IL_195d:
														break;
													}
												}
												if (list5.Count == 0)
												{
													goto IL_1987;
												}
												goto IL_1c48;
											}
											int num24 = (((((int[])(object)array)[52] ^ ((int[])(object)array)[10]) == ((int[])(object)array)[73]) ? (((int)num2 * -1290308210) ^ ((int[])(object)array)[26]) : ((int[])(object)array)[105]);
											goto IL_2096;
											IL_1c48:
											obj2 = new _200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E();
											int num25 = (((((int[])(object)array)[84] ^ ((int[])(object)array)[46]) >= ((int[])(object)array)[26]) ? ((int[])(object)array)[91] : ((int)(num2 * 2013609835) ^ ((int[])(object)array)[39]));
											goto IL_198c;
											IL_2096:
											num2 = (uint)num24;
											switch ((uint)num24 % (uint)((int[])(object)array)[104])
											{
											case 2u:
												break;
											default:
												goto end_IL_20b2;
											case 1u:
												continue;
											case 0u:
												goto end_IL_20b2;
											}
											goto IL_2091;
											IL_198c:
											while (true)
											{
												num2 = (uint)num25;
												switch ((uint)num25 % (uint)((int[])(object)array)[80])
												{
												case 14u:
													break;
												case 17u:
													goto IL_19ef;
												case 11u:
													goto IL_1a3c;
												case 6u:
													goto IL_1a8e;
												case 12u:
													goto IL_1ace;
												case 8u:
													goto IL_1b1b;
												case 18u:
													goto IL_1b68;
												case 0u:
													goto IL_1bba;
												case 3u:
													goto IL_1bfc;
												case 16u:
													goto IL_1c48;
												case 7u:
													goto IL_1c80;
												case 5u:
													goto IL_1ccc;
												case 15u:
													goto IL_1d5d;
												case 2u:
													goto IL_1daa;
												case 4u:
													goto IL_1dfb;
												case 10u:
													goto IL_1e51;
												case 19u:
													goto IL_1e9c;
												case 1u:
													goto IL_1ee8;
												default:
													goto IL_1f34;
												case 9u:
													goto IL_20b2;
												}
												break;
												IL_1ee8:
												obj3._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E = current3.Key._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E;
												num25 = (((((int[])(object)array)[82] ^ ((int[])(object)array)[11]) > ((int[])(object)array)[50]) ? ((int)(num2 * 1317668827) ^ ((int[])(object)array)[1]) : (((int)num2 * -616490922) ^ ((int[])(object)array)[86]));
												continue;
												IL_1b1b:
												obj3._202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E = current3.Key._202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E;
												num25 = (((((int[])(object)array)[37] ^ ((int[])(object)array)[77]) > ((int[])(object)array)[25]) ? (((int)num2 * -1874493877) ^ ((int[])(object)array)[82]) : ((int)(num2 * 155308477) ^ ((int[])(object)array)[83]));
												continue;
												IL_1bba:
												list4.Add(obj3);
												num25 = ((((int[])(object)array)[59] + ((int[])(object)array)[39] >= ((int[])(object)array)[4]) ? ((int)(num2 * 1644599528) ^ ((int[])(object)array)[89]) : (((int)num2 * -544737517) ^ ((int[])(object)array)[44]));
												continue;
												IL_1e9c:
												obj2._202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E = current3.Key._202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E;
												num25 = (((((int[])(object)array)[64] ^ ((int[])(object)array)[39]) >= ((int[])(object)array)[3]) ? ((int)(num2 * 544596139) ^ ((int[])(object)array)[93]) : ((int)(num2 * 1715871544) ^ ((int[])(object)array)[41]));
												continue;
												IL_1ccc:
												obj2._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E.Add(current3.Key._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E);
												num25 = ((((int[])(object)array)[91] + ((int[])(object)array)[85] != ((int[])(object)array)[40]) ? ((int)(num2 * 1174381123) ^ ((int[])(object)array)[97]) : ((int)(num2 * 1704036402) ^ ((int[])(object)array)[81]));
												continue;
												IL_19ef:
												obj2._202D_200E_200C_202A_200E_202E_200E_202A_200E_202C_200E_200E_200F_200D_200E_200E = current3.Key._202D_200E_200C_202A_200E_202E_200E_202A_200E_202C_200E_200E_200F_200D_200E_200E;
												num25 = (((((int[])(object)array)[21] ^ ((int[])(object)array)[28]) >= ((int[])(object)array)[56]) ? ((int)(num2 * 602651186) ^ ((int[])(object)array)[94]) : (((int)num2 * -1657996924) ^ ((int[])(object)array)[18]));
												continue;
												IL_1e51:
												obj3._202D_200E_200C_202A_200E_202E_200E_202A_200E_202C_200E_200E_200F_200D_200E_200E = current3.Key._202D_200E_200C_202A_200E_202E_200E_202A_200E_202C_200E_200E_200F_200D_200E_200E;
												num25 = ((((int[])(object)array)[77] + ((int[])(object)array)[78] != ((int[])(object)array)[0]) ? (((int)num2 * -422071015) ^ ((int[])(object)array)[84]) : (((int)num2 * -1306102063) ^ ((int[])(object)array)[4]));
												continue;
												IL_1a8e:
												obj3 = new _200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E();
												num25 = ((((int[])(object)array)[31] + ((int[])(object)array)[0] < ((int[])(object)array)[55]) ? (((int)num2 * -534635094) ^ ((int[])(object)array)[81]) : (((int)num2 * -1588855071) ^ ((int[])(object)array)[24]));
												continue;
												IL_1c80:
												obj2._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E = current3.Key._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E;
												num25 = (((((int[])(object)array)[8] ^ ((int[])(object)array)[34]) == ((int[])(object)array)[89]) ? (((int)num2 * -287694326) ^ ((int[])(object)array)[89]) : ((int)(num2 * 2090681963) ^ ((int[])(object)array)[96]));
												continue;
												IL_1dfb:
												obj2._200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F = list5[list5.Count - 1]._200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F;
												num25 = ((((int[])(object)array)[18] + ((int[])(object)array)[11] < ((int[])(object)array)[58]) ? (((int)num2 * -1266419347) ^ ((int[])(object)array)[95]) : (((int)num2 * -860953668) ^ ((int[])(object)array)[9]));
												continue;
												IL_1b68:
												obj3._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E.Add(current3.Key._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E);
												num25 = (((((int[])(object)array)[27] ^ ((int[])(object)array)[82]) > ((int[])(object)array)[79]) ? ((int)(num2 * 821211453) ^ ((int[])(object)array)[77]) : ((int)(num2 * 1977193299) ^ ((int[])(object)array)[88]));
												continue;
												IL_1ace:
												obj2._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E = current3.Key._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E;
												num25 = ((((int[])(object)array)[42] + ((int[])(object)array)[9] == ((int[])(object)array)[64]) ? ((int)(num2 * 1328614750) ^ ((int[])(object)array)[42]) : (((int)num2 * -2100952330) ^ ((int[])(object)array)[92]));
												continue;
												IL_1daa:
												obj2._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E.Add(current3.Key._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E);
												num25 = ((((int[])(object)array)[22] + ((int[])(object)array)[15] >= ((int[])(object)array)[25]) ? ((int)(num2 * 403466237) ^ ((int[])(object)array)[8]) : (((int)num2 * -866899468) ^ ((int[])(object)array)[98]));
												continue;
												IL_1bfc:
												obj3._200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F = current3.Key._200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F;
												num25 = ((((int[])(object)array)[58] + ((int[])(object)array)[65] < ((int[])(object)array)[4]) ? ((int)(num2 * 1240531465) ^ ((int[])(object)array)[85]) : ((int)(num2 * 171697199) ^ ((int[])(object)array)[69]));
												continue;
												IL_1a3c:
												obj3._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E.Add(current3.Key._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E);
												num25 = ((((int[])(object)array)[59] + ((int[])(object)array)[13] > ((int[])(object)array)[66]) ? (((int)num2 * -373692853) ^ ((int[])(object)array)[87]) : (((int)num2 * -696986025) ^ ((int[])(object)array)[84]));
												continue;
												IL_1d5d:
												obj3._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E = current3.Key._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E;
												num25 = ((((int[])(object)array)[62] + ((int[])(object)array)[63] >= ((int[])(object)array)[22]) ? (((int)num2 * -2032682439) ^ ((int[])(object)array)[55]) : (((int)num2 * -1442817778) ^ ((int[])(object)array)[82]));
											}
											goto IL_1987;
											IL_2091:
											num24 = 1239069415;
											goto IL_2096;
											IL_1f34:
											enumerator2 = list5.GetEnumerator();
											try
											{
												while (true)
												{
													IL_203e:
													int num26;
													int num27;
													if (enumerator2.MoveNext())
													{
														num26 = 966664915;
														num27 = num26;
													}
													else
													{
														num26 = 2035158744;
														num27 = num26;
													}
													while (true)
													{
														num2 = (uint)num26;
														switch ((uint)num26 % (uint)((int[])(object)array)[99])
														{
														case 5u:
															num26 = 966664915;
															continue;
														default:
															goto end_IL_1f47;
														case 1u:
															current5 = enumerator2.Current;
															num26 = (((((int[])(object)array)[0] ^ ((int[])(object)array)[48]) == ((int[])(object)array)[70]) ? (((int)num2 * -1804994161) ^ ((int[])(object)array)[3]) : ((int[])(object)array)[100]);
															continue;
														case 4u:
															obj2._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E.Add(current5._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E);
															num26 = (((((int[])(object)array)[22] ^ ((int[])(object)array)[42]) == ((int[])(object)array)[35]) ? ((int)(num2 * 791385419) ^ ((int[])(object)array)[56]) : ((int)(num2 * 1966775873) ^ ((int[])(object)array)[101]));
															continue;
														case 3u:
															obj2._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E.Add(current5._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E);
															num26 = ((((int[])(object)array)[11] + ((int[])(object)array)[45] != ((int[])(object)array)[62]) ? ((int)(num2 * 547170310) ^ ((int[])(object)array)[102]) : (((int)num2 * -133388487) ^ ((int[])(object)array)[62]));
															continue;
														case 2u:
															break;
														case 0u:
															goto end_IL_1f47;
														}
														goto IL_203e;
														continue;
														end_IL_1f47:
														break;
													}
													break;
												}
											}
											finally
											{
												((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
												while (true)
												{
													switch ((num2 = 1715713689u) % (uint)((int[])(object)array)[103])
													{
													case 0u:
														break;
													default:
														goto end_IL_206a;
													case 1u:
														goto end_IL_206a;
													}
													continue;
													end_IL_206a:
													break;
												}
											}
											list4.Add(obj2);
											goto IL_2091;
											IL_1987:
											num25 = 439924126;
											goto IL_198c;
											continue;
											end_IL_20b2:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3/*cast due to constrained. prefix*/).Dispose();
										while (true)
										{
											switch ((num2 = 1882495271u) % (uint)((int[])(object)array)[106])
											{
											case 0u:
												break;
											default:
												goto end_IL_20f8;
											case 1u:
												goto end_IL_20f8;
											}
											continue;
											end_IL_20f8:
											break;
										}
									}
									int num28 = binaryReader2.ReadInt32();
									while (true)
									{
										int num29 = 973040289;
										while (true)
										{
											num2 = (uint)num29;
											switch ((uint)num29 % (uint)((int[])(object)array)[107])
											{
											case 17u:
												break;
											case 22u:
												num36 = binaryReader2.ReadInt16();
												num29 = ((((int[])(object)array)[33] + ((int[])(object)array)[58] == ((int[])(object)array)[56]) ? (((int)num2 * -1089947698) ^ ((int[])(object)array)[18]) : ((int)(num2 * 276640644) ^ ((int[])(object)array)[117]));
												continue;
											case 23u:
											{
												int num40;
												int num41;
												if (num36 < 0)
												{
													num40 = -2047142564;
													num41 = num40;
												}
												else
												{
													num40 = -1113724661;
													num41 = num40;
												}
												num29 = num40 ^ ((int)num2 * ((int[])(object)array)[118]);
												continue;
											}
											case 16u:
												opCode = _202C_200E_200D_200C_200E_200F_200F_200F_200F_202B_200F_202A_200E_202A_200F_200F[num36];
												num29 = ((((int[])(object)array)[6] + ((int[])(object)array)[2] < ((int[])(object)array)[20]) ? (((int)num2 * -2051611010) ^ ((int[])(object)array)[34]) : ((int)(num2 * 790011745) ^ ((int[])(object)array)[120]));
												continue;
											case 19u:
												num34++;
												num29 = ((((int[])(object)array)[105] + ((int[])(object)array)[55] == ((int[])(object)array)[31]) ? ((int)(num2 * 1292362831) ^ ((int[])(object)array)[2]) : ((int)(num2 * 1463413867) ^ ((int[])(object)array)[113]));
												continue;
											case 6u:
												num35 = 0;
												num29 = ((((int[])(object)array)[71] + ((int[])(object)array)[0] < ((int[])(object)array)[51]) ? ((int)(num2 * 321474837) ^ ((int[])(object)array)[36]) : ((int)(num2 * 818319516) ^ ((int[])(object)array)[114]));
												continue;
											case 7u:
												opCode = _200F_200E_200D_202A_200F_200D_200F_200C_200F_200D_200E_200D_200F_200C_200F_200E[b];
												num29 = (((((int[])(object)array)[88] ^ ((int[])(object)array)[92]) < ((int[])(object)array)[48]) ? (((int)num2 * -1216430079) ^ ((int[])(object)array)[123]) : (((int)num2 * -1624290737) ^ ((int[])(object)array)[8]));
												continue;
											case 0u:
												iLGenerator.MarkLabel(dictionary2[num35]);
												num29 = ((((int[])(object)array)[15] + ((int[])(object)array)[36] < ((int[])(object)array)[75]) ? (((int)num2 * -1583003888) ^ ((int[])(object)array)[7]) : ((int[])(object)array)[124]);
												continue;
											case 10u:
											{
												int num38;
												int num39;
												if (num36 >= _202C_200E_200D_200C_200E_200F_200F_200F_200F_202B_200F_202A_200E_202A_200F_200F.Length)
												{
													num38 = 1830372909;
													num39 = num38;
												}
												else
												{
													num38 = 1825348792;
													num39 = num38;
												}
												num29 = num38 ^ ((int)num2 * ((int[])(object)array)[119]);
												continue;
											}
											case 20u:
											{
												int num37;
												if (num35 >= num28)
												{
													num29 = 74936867;
													num37 = num29;
												}
												else
												{
													num29 = 928682041;
													num37 = num29;
												}
												continue;
											}
											case 1u:
												_202A_200E_200E_202D_200E_200C_200F_200B_200E_200B_200E_200E_200E_202B_200E_200E(list4, num35, iLGenerator);
												num29 = ((((int[])(object)array)[111] + ((int[])(object)array)[110] > ((int[])(object)array)[15]) ? ((int[])(object)array)[116] : (((int)num2 * -1874967717) ^ ((int[])(object)array)[67]));
												continue;
											case 14u:
												num29 = ((((int[])(object)array)[51] + ((int[])(object)array)[12] >= ((int[])(object)array)[6]) ? (((int)num2 * -1907887876) ^ ((int[])(object)array)[121]) : ((int)(num2 * 1174253532) ^ ((int[])(object)array)[2]));
												continue;
											case 11u:
												obj4 = _202A_200F_202B_202D_200E_200D_200E_202E_200E_200C_200E_202E_200E_202D_200E_200F;
												num29 = ((((int[])(object)array)[10] + ((int[])(object)array)[59] >= ((int[])(object)array)[53]) ? (((int)num2 * -1591571302) ^ ((int[])(object)array)[127]) : (((int)num2 * -678113414) ^ ((int[])(object)array)[4]));
												continue;
											case 8u:
												value = iLGenerator.DefineLabel();
												num29 = (((((int[])(object)array)[47] ^ ((int[])(object)array)[3]) != ((int[])(object)array)[50]) ? ((int[])(object)array)[111] : ((int)(num2 * 516008513) ^ ((int[])(object)array)[106]));
												continue;
											case 15u:
												num29 = (((((int[])(object)array)[46] ^ ((int[])(object)array)[99]) < ((int[])(object)array)[30]) ? (((int)num2 * -1957030671) ^ ((int[])(object)array)[115]) : (((int)num2 * -2016168701) ^ ((int[])(object)array)[39]));
												continue;
											case 9u:
												dictionary2 = new Dictionary<int, Label>();
												num29 = (((((int[])(object)array)[83] ^ ((int[])(object)array)[31]) > ((int[])(object)array)[61]) ? (((int)num2 * -680564828) ^ ((int[])(object)array)[69]) : ((int)(num2 * 775863844) ^ ((int[])(object)array)[108]));
												continue;
											case 4u:
											{
												int num42;
												if (num34 >= num28)
												{
													num29 = 1164113262;
													num42 = num29;
												}
												else
												{
													num29 = 941332064;
													num42 = num29;
												}
												continue;
											}
											case 18u:
												num29 = ((((int[])(object)array)[95] + ((int[])(object)array)[0] == ((int[])(object)array)[67]) ? ((int)(num2 * 215387062) ^ ((int[])(object)array)[5]) : ((int)(num2 * 21058021) ^ ((int[])(object)array)[110]));
												continue;
											case 5u:
												_200D_200E_202A_200D_200E_200E_200E_200E_200E_202A_200E_200B_200E_200E_200E_200E(dictionary3[binaryReader2.ReadInt32()], opCode, iLGenerator, binaryReader2, dictionary2, list);
												num29 = (((((int[])(object)array)[71] ^ ((int[])(object)array)[57]) == ((int[])(object)array)[109]) ? (((int)num2 * -1172977047) ^ ((int[])(object)array)[16]) : (((int)num2 * -671355921) ^ ((int[])(object)array)[125]));
												continue;
											case 13u:
												b = (byte)(num36 | 0xFE00);
												num29 = ((((int[])(object)array)[63] + ((int[])(object)array)[94] < ((int[])(object)array)[98]) ? ((int)(num2 * 1648723286) ^ ((int[])(object)array)[9]) : ((int[])(object)array)[122]);
												continue;
											case 3u:
												num34 = 0;
												num29 = ((((int[])(object)array)[8] + ((int[])(object)array)[103] == ((int[])(object)array)[32]) ? ((int)(num2 * 72826914) ^ ((int[])(object)array)[11]) : (((int)num2 * -1352446627) ^ ((int[])(object)array)[109]));
												continue;
											case 21u:
												num35++;
												num29 = ((((int[])(object)array)[19] + ((int[])(object)array)[32] >= ((int[])(object)array)[98]) ? (((int)num2 * -101899995) ^ ((int[])(object)array)[126]) : ((int)(num2 * 693902066) ^ ((int[])(object)array)[94]));
												continue;
											case 12u:
												dictionary2.Add(num34, value);
												num29 = ((((int[])(object)array)[26] + ((int[])(object)array)[80] <= ((int[])(object)array)[67]) ? ((int)(num2 * 1923715038) ^ ((int[])(object)array)[65]) : (((int)num2 * -1668901247) ^ ((int[])(object)array)[112]));
												continue;
											default:
											{
												bool lockTaken = false;
												try
												{
													Monitor.Enter(obj4, ref lockTaken);
													while (true)
													{
														IL_269f:
														int num30 = 499631115;
														while (true)
														{
															num2 = (uint)num30;
															switch ((uint)num30 % (uint)((int[])(object)array)[128])
															{
															case 0u:
																break;
															default:
																goto end_IL_26a4;
															case 3u:
															{
																int num31;
																int num32;
																if (!_200B_200E_200C_200C_200F_200C_200E_202E_200E_200B_200E_200D_200F_200E_200E_200F.ContainsKey(P_2))
																{
																	num31 = -495166008;
																	num32 = num31;
																}
																else
																{
																	num31 = -972807801;
																	num32 = num31;
																}
																num30 = num31 ^ ((int)num2 * ((int[])(object)array)[129]);
																continue;
															}
															case 1u:
																_200B_200E_200C_200C_200F_200C_200E_202E_200E_200B_200E_200D_200F_200E_200E_200F.Add(P_2, dynamicMethod);
																num30 = (((((int[])(object)array)[25] ^ ((int[])(object)array)[49]) < ((int[])(object)array)[129]) ? (((int)num2 * -1778781059) ^ ((int[])(object)array)[22]) : (((int)num2 * -1275553510) ^ ((int[])(object)array)[130]));
																continue;
															case 2u:
																goto end_IL_26a4;
															}
															goto IL_269f;
															continue;
															end_IL_26a4:
															break;
														}
														break;
													}
												}
												finally
												{
													if (lockTaken)
													{
														while (true)
														{
															IL_2744:
															int num33 = 1588319303;
															while (true)
															{
																num2 = (uint)num33;
																switch ((uint)num33 % (uint)((int[])(object)array)[131])
																{
																case 0u:
																	break;
																default:
																	goto end_IL_2749;
																case 2u:
																	Monitor.Exit(obj4);
																	num33 = ((((int[])(object)array)[105] + ((int[])(object)array)[39] <= ((int[])(object)array)[35]) ? (((int)num2 * -1087361008) ^ ((int[])(object)array)[68]) : (((int)num2 * -1940669032) ^ ((int[])(object)array)[132]));
																	continue;
																case 1u:
																	goto end_IL_2749;
																}
																goto IL_2744;
																continue;
																end_IL_2749:
																break;
															}
															break;
														}
													}
												}
												return dynamicMethod.Invoke(null, P_1);
											}
											}
											break;
										}
									}
								}
							}
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	private static void _200D_200E_202A_200D_200E_200E_200E_200E_200E_202A_200E_200B_200E_200E_200E_200E(int P_0, OpCode P_1, ILGenerator P_2, BinaryReader P_3, Dictionary<int, Label> P_4, List<LocalBuilder> P_5)
	{
		bool[] array = (bool[])(object)new int[90]
		{
			96, 1662948503, 513788715, 151646922, 767023727, -1266137910, 21530532, 1247326049, -929182868, -1900359746,
			-1159076400, 1718554182, 2115789812, -1434071798, -1579996490, 1293677291, -1835852039, -93691450, 548086858, -437052325,
			-213262454, 1476129513, -572590079, 1876435119, -1865667876, 1515131157, -2112959483, 472030025, -1835597769, 735079185,
			1828577065, 1017044059, 645715279, 1869472985, 218570457, -575954981, 1829883837, -577014267, -637488113, -231476177,
			400148718, 9721548, 611822002, 689923454, 1908547520, 27993858, -742494611, 1406947551, -1251083959, 2014911642,
			1518565523, 1155825491, 1768325141, -2138036973, -698255575, 1673606449, -1530677350, -524884852, -1807108969, 29532092,
			676994890, -1489852317, 305163805, 1454756120, 304198456, 547687891, -83854156, 1792810555, 1196996966, 1830927685,
			524024706, -1817714335, -1606063741, 703551814, -998889982, 1244689164, -947958075, 1807529131, 1041913692, 437643043,
			1100123497, -1739338395, -95291959, 1703239609, -2067457040, -1239006274, 1686420100, -1973697604, 309908768, 744386921
		};
		int num;
		uint num2 = default;
		int num8 = default;
		MethodBase methodBase2 = default;
		int num5 = default;
		byte b = default;
		MethodBase methodBase = default;
		FieldInfo field = default;
		Type cls = default;
		int arg = default;
		Type cls2 = default;
		int num21 = default;
		Label[] array2 = default;
		LocalBuilder local = default;
		int num22 = default;
		int num23 = default;
		LocalBuilder local2 = default;
		int num24 = default;
		FieldInfo field2 = default;
		int metadataToken = default;
		int metadataToken2 = default;
		Label label = default;
		byte arg2 = default;
		string str = default;
		Label label2 = default;
		int key = default;
		long arg3 = default;
		int key2 = default;
		double arg4 = default;
		float arg5 = default;
		switch (P_0)
		{
		default:
			num = 558209155;
			goto IL_0372;
		case 1:
			goto IL_06bc;
		case 11:
			goto IL_06ef;
		case 7:
			goto IL_0779;
		case 0:
			goto IL_0896;
		case 6:
			goto IL_090a;
		case 12:
			goto IL_0ba4;
		case 5:
			goto IL_0bdd;
		case 3:
			goto IL_0db0;
		case 2:
			goto IL_0e21;
		case 8:
			goto IL_0e56;
		case 13:
			goto IL_0e8e;
		case 4:
			goto IL_0f60;
		case 14:
			goto IL_1190;
		case 9:
			goto IL_123d;
		case 15:
			goto IL_12fb;
		case 10:
			goto IL_1334;
			IL_0372:
			while (true)
			{
				num2 = (uint)num;
				switch ((uint)num % (uint)((int[])(object)array)[0])
				{
				case 77u:
					break;
				default:
					return;
				case 81u:
				{
					int num9;
					int num10;
					if (num8 != 33554433)
					{
						num9 = -1865617381;
						num10 = num9;
					}
					else
					{
						num9 = -939396571;
						num10 = num9;
					}
					num = num9 ^ ((int)num2 * ((int[])(object)array)[30]);
					continue;
				}
				case 18u:
					return;
				case 22u:
					goto IL_0565;
				case 19u:
					return;
				case 34u:
					return;
				case 93u:
					goto IL_0616;
				case 90u:
					goto IL_0659;
				case 10u:
				{
					int num15;
					int num16;
					if (P_3.ReadByte() == 0)
					{
						num15 = -433110600;
						num16 = num15;
					}
					else
					{
						num15 = -1414820469;
						num16 = num15;
					}
					num = num15 ^ ((int)num2 * ((int[])(object)array)[19]);
					continue;
				}
				case 70u:
				{
					int num11;
					int num12;
					if (P_3.ReadByte() != 0)
					{
						num11 = -308845861;
						num12 = num11;
					}
					else
					{
						num11 = -1807465194;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * ((int[])(object)array)[74]);
					continue;
				}
				case 59u:
					goto IL_06bc;
				case 35u:
					goto IL_06ef;
				case 21u:
					goto IL_0727;
				case 95u:
					goto IL_0779;
				case 83u:
					goto IL_07b1;
				case 94u:
					goto IL_07f6;
				case 26u:
					goto IL_0835;
				case 69u:
					goto IL_084e;
				case 45u:
					goto IL_0896;
				case 29u:
					goto IL_08c9;
				case 44u:
					goto IL_090a;
				case 91u:
					return;
				case 37u:
					goto IL_097c;
				case 51u:
					goto IL_09be;
				case 27u:
				{
					int num17;
					int num18;
					if (!(methodBase2 is MethodInfo))
					{
						num17 = 1456883534;
						num18 = num17;
					}
					else
					{
						num17 = 46743139;
						num18 = num17;
					}
					num = num17 ^ ((int)num2 * ((int[])(object)array)[68]);
					continue;
				}
				case 78u:
					goto IL_0a26;
				case 38u:
					return;
				case 63u:
					goto IL_0aa0;
				case 7u:
					return;
				case 74u:
					goto IL_0b1a;
				case 72u:
					goto IL_0b5d;
				case 14u:
					goto IL_0ba4;
				case 61u:
					goto IL_0bdd;
				case 9u:
					return;
				case 36u:
					goto IL_0c4c;
				case 56u:
					return;
				case 67u:
					goto IL_0ca2;
				case 87u:
					goto IL_0cd7;
				case 54u:
					goto IL_0d1a;
				case 76u:
					goto IL_0d5d;
				case 75u:
					return;
				case 24u:
					goto IL_0db0;
				case 60u:
					return;
				case 6u:
					goto IL_0e21;
				case 30u:
					goto IL_0e56;
				case 43u:
					goto IL_0e8e;
				case 15u:
					return;
				case 12u:
				{
					int num6;
					int num7;
					if (num5 == 33554433)
					{
						num6 = 809151431;
						num7 = num6;
					}
					else
					{
						num6 = 304774459;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * ((int[])(object)array)[61]);
					continue;
				}
				case 88u:
					goto IL_0f26;
				case 80u:
					goto IL_0f60;
				case 86u:
					return;
				case 16u:
					return;
				case 66u:
					goto IL_1007;
				case 92u:
				{
					int num13;
					int num14;
					if (b != 0)
					{
						num13 = 284035562;
						num14 = num13;
					}
					else
					{
						num13 = 215230917;
						num14 = num13;
					}
					num = num13 ^ ((int)num2 * ((int[])(object)array)[57]);
					continue;
				}
				case 31u:
					goto IL_1079;
				case 28u:
					goto IL_10ca;
				case 71u:
					goto IL_1102;
				case 84u:
					goto IL_111c;
				case 57u:
					return;
				case 33u:
					goto IL_1190;
				case 17u:
					return;
				case 5u:
					goto IL_1203;
				case 42u:
					goto IL_123d;
				case 49u:
					goto IL_1275;
				case 58u:
					goto IL_12b6;
				case 79u:
					goto IL_12fb;
				case 82u:
					goto IL_1334;
				case 64u:
					throw new Exception("Operand Type Unknown " + P_0);
				case 89u:
					goto IL_13b5;
				case 52u:
					goto IL_13ed;
				case 85u:
					goto IL_143d;
				case 73u:
					goto IL_1476;
				case 25u:
					goto IL_14b8;
				case 2u:
					goto IL_14f9;
				case 55u:
					return;
				case 4u:
					goto IL_156d;
				case 13u:
					return;
				case 20u:
					goto IL_15e9;
				case 3u:
					goto IL_1629;
				case 40u:
					goto IL_1661;
				case 47u:
					goto IL_169d;
				case 0u:
					return;
				case 68u:
					return;
				case 8u:
					return;
				case 46u:
					goto IL_1794;
				case 50u:
					return;
				case 32u:
					goto IL_1810;
				case 62u:
					goto IL_1852;
				case 23u:
					goto IL_1893;
				case 65u:
					goto IL_18cc;
				case 11u:
					goto IL_1913;
				case 53u:
					goto IL_1953;
				case 48u:
					throw new Exception("Check resolvedMethodBase Type");
				case 39u:
				{
					int num3;
					int num4;
					if (methodBase is MethodInfo)
					{
						num3 = 1131505711;
						num4 = num3;
					}
					else
					{
						num3 = 1297633688;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * ((int[])(object)array)[6]);
					continue;
				}
				case 1u:
					return;
				case 41u:
					return;
				}
				break;
				IL_1953:
				field = typeof(_202B_200E_200F_200F_200E_202A_200E_200D_200E_202A_200F_202D_200E_200D_200E_200E).Module.ResolveField(num5);
				num = (((((int[])(object)array)[25] ^ ((int[])(object)array)[14]) == ((int[])(object)array)[21]) ? ((int)(num2 * 1519608055) ^ ((int[])(object)array)[11]) : (((int)num2 * -1255303435) ^ ((int[])(object)array)[58]));
				continue;
				IL_0f26:
				P_2.Emit(P_1, cls);
				num = ((((int[])(object)array)[26] + ((int[])(object)array)[21] >= ((int[])(object)array)[10]) ? ((int[])(object)array)[65] : ((int)(num2 * 809305519) ^ ((int[])(object)array)[24]));
				continue;
				IL_13ed:
				methodBase2 = typeof(_202B_200E_200F_200F_200E_202A_200E_200D_200E_202A_200F_202D_200E_200D_200E_200E).Module.ResolveMethod(num5);
				num = ((((int[])(object)array)[45] + ((int[])(object)array)[3] < ((int[])(object)array)[1]) ? (((int)num2 * -65385416) ^ ((int[])(object)array)[67]) : ((int)(num2 * 1766335899) ^ ((int[])(object)array)[14]));
				continue;
				IL_1913:
				P_2.Emit(P_1, arg);
				num = ((((int[])(object)array)[13] + ((int[])(object)array)[15] >= ((int[])(object)array)[2]) ? (((int)num2 * -502995039) ^ ((int[])(object)array)[3]) : ((int)(num2 * 45889809) ^ ((int[])(object)array)[16]));
				continue;
				IL_0b1a:
				P_2.Emit(P_1, (ConstructorInfo)methodBase);
				num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[4]) >= ((int[])(object)array)[4]) ? (((int)num2 * -545541017) ^ ((int[])(object)array)[3]) : ((int)(num2 * 1215169855) ^ ((int[])(object)array)[9]));
				continue;
				IL_0659:
				int num19;
				if (b == 2)
				{
					num = 173117044;
					num19 = num;
				}
				else
				{
					num = 744386921;
					num19 = num;
				}
				continue;
				IL_18cc:
				P_2.Emit(P_1, (MethodInfo)methodBase2);
				num = (((((int[])(object)array)[48] ^ ((int[])(object)array)[5]) <= ((int[])(object)array)[57]) ? (((int)num2 * -956075052) ^ ((int[])(object)array)[42]) : (((int)num2 * -427315113) ^ ((int[])(object)array)[69]));
				continue;
				IL_13b5:
				P_2.Emit(P_1, cls2);
				num = (((((int[])(object)array)[7] ^ ((int[])(object)array)[30]) < ((int[])(object)array)[28]) ? ((int)(num2 * 2080280739) ^ ((int[])(object)array)[5]) : ((int[])(object)array)[34]);
				continue;
				IL_0d5d:
				int num20;
				if (!(methodBase2 is ConstructorInfo))
				{
					num = 744386921;
					num20 = num;
				}
				else
				{
					num = 1729372389;
					num20 = num;
				}
				continue;
				IL_1893:
				P_2.Emit(P_1, num21);
				num = ((((int[])(object)array)[38] + ((int[])(object)array)[47] > ((int[])(object)array)[5]) ? ((int[])(object)array)[78] : (((int)num2 * -1538082) ^ ((int[])(object)array)[37]));
				continue;
				IL_08c9:
				P_2.Emit(P_1, array2);
				num = ((((int[])(object)array)[7] + ((int[])(object)array)[36] != ((int[])(object)array)[7]) ? ((int)(num2 * 1800984599) ^ ((int[])(object)array)[49]) : ((int)(num2 * 297138294) ^ ((int[])(object)array)[18]));
				continue;
				IL_12b6:
				local = P_5[num21];
				num = (((((int[])(object)array)[10] ^ ((int[])(object)array)[42]) == ((int[])(object)array)[56]) ? (((int)num2 * -1375052241) ^ ((int[])(object)array)[28]) : ((int)(num2 * 435613409) ^ ((int[])(object)array)[75]));
				continue;
				IL_1852:
				array2 = new Label[num22];
				num = (((((int[])(object)array)[19] ^ ((int[])(object)array)[23]) <= ((int[])(object)array)[2]) ? ((int)(num2 * 428252812) ^ ((int[])(object)array)[44]) : ((int)(num2 * 924898996) ^ ((int[])(object)array)[6]));
				continue;
				IL_0aa0:
				num23++;
				num = (((((int[])(object)array)[24] ^ ((int[])(object)array)[27]) <= ((int[])(object)array)[33]) ? (((int)num2 * -804771502) ^ ((int[])(object)array)[48]) : (((int)num2 * -272763278) ^ ((int[])(object)array)[3]));
				continue;
				IL_0d1a:
				local2 = P_5[num24];
				num = (((((int[])(object)array)[12] ^ ((int[])(object)array)[2]) >= ((int[])(object)array)[6]) ? ((int)(num2 * 895052607) ^ ((int[])(object)array)[20]) : (((int)num2 * -1990305961) ^ ((int[])(object)array)[15]));
				continue;
				IL_1810:
				P_2.Emit(P_1, local2);
				num = (((((int[])(object)array)[16] ^ ((int[])(object)array)[19]) != ((int[])(object)array)[7]) ? (((int)num2 * -1873222257) ^ ((int[])(object)array)[21]) : ((int)(num2 * 767858078) ^ ((int[])(object)array)[12]));
				continue;
				IL_1275:
				b = P_3.ReadByte();
				num = ((((int[])(object)array)[11] + ((int[])(object)array)[0] > ((int[])(object)array)[27]) ? (((int)num2 * -1735175130) ^ ((int[])(object)array)[56]) : (((int)num2 * -1896554629) ^ ((int[])(object)array)[24]));
				continue;
				IL_07f6:
				P_2.Emit(P_1, field2);
				num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[3]) <= ((int[])(object)array)[4]) ? ((int)(num2 * 277003710) ^ ((int[])(object)array)[27]) : ((int)(num2 * 1218511752) ^ ((int[])(object)array)[1]));
				continue;
				IL_1794:
				P_2.Emit(P_1, field);
				num = ((((int[])(object)array)[8] + ((int[])(object)array)[14] <= ((int[])(object)array)[38]) ? ((int)(num2 * 884553975) ^ ((int[])(object)array)[13]) : ((int)(num2 * 1065638570) ^ ((int[])(object)array)[59]));
				continue;
				IL_0727:
				field2 = typeof(_202B_200E_200F_200F_200E_202A_200E_200D_200E_202A_200F_202D_200E_200D_200E_200E).Module.ResolveField(metadataToken);
				num = ((((int[])(object)array)[20] + ((int[])(object)array)[24] != ((int[])(object)array)[17]) ? (((int)num2 * -107401969) ^ ((int[])(object)array)[26]) : (((int)num2 * -1356954248) ^ ((int[])(object)array)[18]));
				continue;
				IL_1203:
				P_2.Emit(P_1, num24);
				num = ((((int[])(object)array)[12] + ((int[])(object)array)[22] == ((int[])(object)array)[10]) ? ((int)(num2 * 852023829) ^ ((int[])(object)array)[16]) : ((int[])(object)array)[23]);
				continue;
				IL_169d:
				methodBase = typeof(_202B_200E_200F_200F_200E_202A_200E_200D_200E_202A_200F_202D_200E_200D_200E_200E).Module.ResolveMethod(metadataToken2);
				num = ((((int[])(object)array)[5] + ((int[])(object)array)[3] != ((int[])(object)array)[3]) ? ((int)(num2 * 274544547) ^ ((int[])(object)array)[5]) : ((int)(num2 * 191655491) ^ ((int[])(object)array)[5]));
				continue;
				IL_0cd7:
				P_2.Emit(P_1, label);
				num = (((((int[])(object)array)[28] ^ ((int[])(object)array)[13]) < ((int[])(object)array)[36]) ? (((int)num2 * -668342617) ^ ((int[])(object)array)[53]) : (((int)num2 * -1978410474) ^ ((int[])(object)array)[25]));
				continue;
				IL_0a26:
				P_2.Emit(P_1, arg2);
				num = ((((int[])(object)array)[36] + ((int[])(object)array)[3] <= ((int[])(object)array)[26]) ? (((int)num2 * -506640007) ^ ((int[])(object)array)[23]) : ((int)(num2 * 1016612982) ^ ((int[])(object)array)[41]));
				continue;
				IL_1661:
				num23 = 0;
				num = ((((int[])(object)array)[30] + ((int[])(object)array)[39] > ((int[])(object)array)[2]) ? ((int)(num2 * 1351887876) ^ ((int[])(object)array)[45]) : (((int)num2 * -1213670622) ^ ((int[])(object)array)[28]));
				continue;
				IL_111c:
				num = ((((int[])(object)array)[60] + ((int[])(object)array)[49] >= ((int[])(object)array)[40]) ? (((int)num2 * -1798837642) ^ ((int[])(object)array)[13]) : ((int)(num2 * 1727115880) ^ ((int[])(object)array)[63]));
				continue;
				IL_084e:
				P_2.Emit(P_1, (ConstructorInfo)methodBase2);
				num = (((((int[])(object)array)[24] ^ ((int[])(object)array)[42]) > ((int[])(object)array)[71]) ? ((int)(num2 * 1687090096) ^ ((int[])(object)array)[71]) : (((int)num2 * -118455042) ^ ((int[])(object)array)[54]));
				continue;
				IL_1629:
				cls = _202C_200E_202D_200D_200F_200F_200F_200F_200E_200C_200F_202D_200E_202A_200F_200E();
				num = (((((int[])(object)array)[16] ^ ((int[])(object)array)[62]) != ((int[])(object)array)[9]) ? ((int[])(object)array)[64] : ((int)(num2 * 1000527261) ^ ((int[])(object)array)[39]));
				continue;
				IL_0ca2:
				num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[0]) < ((int[])(object)array)[0]) ? (((int)num2 * -741278864) ^ ((int[])(object)array)[1]) : (((int)num2 * -743347267) ^ ((int[])(object)array)[1]));
				continue;
				IL_1102:
				int num25;
				if (num23 < num22)
				{
					num = 112839144;
					num25 = num;
				}
				else
				{
					num = 730669565;
					num25 = num;
				}
				continue;
				IL_15e9:
				P_2.Emit(P_1, str);
				num = (((((int[])(object)array)[11] ^ ((int[])(object)array)[11]) < ((int[])(object)array)[0]) ? (((int)num2 * -1208642689) ^ ((int[])(object)array)[13]) : ((int)(num2 * 882189463) ^ ((int[])(object)array)[6]));
				continue;
				IL_0616:
				label2 = P_4[key];
				num = (((((int[])(object)array)[6] ^ ((int[])(object)array)[32]) >= ((int[])(object)array)[1]) ? (((int)num2 * -1367533627) ^ ((int[])(object)array)[34]) : (((int)num2 * -1205995264) ^ ((int[])(object)array)[37]));
				continue;
				IL_09be:
				P_2.Emit(P_1, (MethodInfo)methodBase);
				num = ((((int[])(object)array)[0] + ((int[])(object)array)[4] > ((int[])(object)array)[7]) ? (((int)num2 * -922084553) ^ ((int[])(object)array)[2]) : (((int)num2 * -1199687987) ^ ((int[])(object)array)[7]));
				continue;
				IL_156d:
				P_2.Emit(P_1, arg3);
				num = ((((int[])(object)array)[54] + ((int[])(object)array)[44] < ((int[])(object)array)[34]) ? (((int)num2 * -679592377) ^ ((int[])(object)array)[2]) : ((int)(num2 * 792308079) ^ ((int[])(object)array)[87]));
				continue;
				IL_10ca:
				cls2 = _202C_200E_202D_200D_200F_200F_200F_200F_200E_200C_200F_202D_200E_202A_200F_200E();
				num = ((((int[])(object)array)[15] + ((int[])(object)array)[23] <= ((int[])(object)array)[26]) ? (((int)num2 * -2026988424) ^ ((int[])(object)array)[29]) : ((int[])(object)array)[33]);
				continue;
				IL_0c4c:
				int num26;
				if (methodBase is ConstructorInfo)
				{
					num = 235601546;
					num26 = num;
				}
				else
				{
					num = 397355952;
					num26 = num;
				}
				continue;
				IL_14f9:
				num = ((((int[])(object)array)[45] + ((int[])(object)array)[38] == ((int[])(object)array)[22]) ? (((int)num2 * -1504698107) ^ ((int[])(object)array)[2]) : ((int)(num2 * 1380684437) ^ ((int[])(object)array)[46]));
				continue;
				IL_07b1:
				label = P_4[key2];
				num = ((((int[])(object)array)[27] + ((int[])(object)array)[34] == ((int[])(object)array)[15]) ? (((int)num2 * -2065307026) ^ ((int[])(object)array)[28]) : ((int)(num2 * 758514582) ^ ((int[])(object)array)[52]));
				continue;
				IL_1079:
				cls = typeof(_202B_200E_200F_200F_200E_202A_200E_200D_200E_202A_200F_202D_200E_200D_200E_200E).Module.ResolveType(num5);
				num = (((((int[])(object)array)[49] ^ ((int[])(object)array)[41]) <= ((int[])(object)array)[52]) ? ((int)(num2 * 1877260459) ^ ((int[])(object)array)[2]) : (((int)num2 * -1426970025) ^ ((int[])(object)array)[62]));
				continue;
				IL_14b8:
				P_2.Emit(P_1, arg4);
				num = ((((int[])(object)array)[28] + ((int[])(object)array)[0] > ((int[])(object)array)[5]) ? ((int)(num2 * 1968479838) ^ ((int[])(object)array)[47]) : (((int)num2 * -406622257) ^ ((int[])(object)array)[84]));
				continue;
				IL_0835:
				int num27;
				if (b == 1)
				{
					num = 63220044;
					num27 = num;
				}
				else
				{
					num = 1757919162;
					num27 = num;
				}
				continue;
				IL_0b5d:
				array2[num23] = P_4[P_3.ReadInt32()];
				num = (((((int[])(object)array)[44] ^ ((int[])(object)array)[16]) == ((int[])(object)array)[35]) ? ((int)(num2 * 1477563150) ^ ((int[])(object)array)[38]) : ((int[])(object)array)[47]);
				continue;
				IL_1476:
				P_2.Emit(P_1, arg5);
				num = ((((int[])(object)array)[32] + ((int[])(object)array)[50] > ((int[])(object)array)[50]) ? (((int)num2 * -1356350425) ^ ((int[])(object)array)[3]) : ((int)(num2 * 923027033) ^ ((int[])(object)array)[81]));
				continue;
				IL_1007:
				cls2 = typeof(_202B_200E_200F_200F_200E_202A_200E_200D_200E_202A_200F_202D_200E_200D_200E_200E).Module.ResolveType(num8);
				num = ((((int[])(object)array)[9] + ((int[])(object)array)[0] < ((int[])(object)array)[18]) ? (((int)num2 * -1507052441) ^ ((int[])(object)array)[31]) : ((int)(num2 * 222242878) ^ ((int[])(object)array)[9]));
				continue;
				IL_097c:
				P_2.Emit(P_1, label2);
				num = (((((int[])(object)array)[29] ^ ((int[])(object)array)[27]) == ((int[])(object)array)[7]) ? ((int)(num2 * 2072941975) ^ ((int[])(object)array)[20]) : ((int)(num2 * 1679158616) ^ ((int[])(object)array)[38]));
				continue;
				IL_143d:
				num = (((((int[])(object)array)[30] ^ ((int[])(object)array)[1]) <= ((int[])(object)array)[11]) ? (((int)num2 * -1953447298) ^ ((int[])(object)array)[32]) : ((int)(num2 * 977977861) ^ ((int[])(object)array)[11]));
				continue;
				IL_0565:
				P_2.Emit(P_1, local);
				num = ((((int[])(object)array)[1] + ((int[])(object)array)[8] > ((int[])(object)array)[75]) ? ((int)(num2 * 1550135522) ^ ((int[])(object)array)[59]) : ((int)(num2 * 2030864861) ^ ((int[])(object)array)[76]));
			}
			goto default;
			IL_1334:
			key2 = P_3.ReadInt32();
			num = ((((int[])(object)array)[19] + ((int[])(object)array)[45] >= ((int[])(object)array)[24]) ? ((int[])(object)array)[51] : (((int)num2 * -532420606) ^ ((int[])(object)array)[27]));
			goto IL_0372;
			IL_090a:
			num8 = P_3.ReadInt32();
			num = (((((int[])(object)array)[2] ^ ((int[])(object)array)[1]) < ((int[])(object)array)[27]) ? (((int)num2 * -584956170) ^ ((int[])(object)array)[15]) : ((int[])(object)array)[29]);
			goto IL_0372;
			IL_0bdd:
			metadataToken = P_3.ReadInt32();
			num = ((((int[])(object)array)[3] + ((int[])(object)array)[4] < ((int[])(object)array)[5]) ? (((int)num2 * -1984385369) ^ ((int[])(object)array)[5]) : ((int[])(object)array)[25]);
			goto IL_0372;
			IL_12fb:
			arg3 = P_3.ReadInt64();
			num = ((((int[])(object)array)[37] + ((int[])(object)array)[43] == ((int[])(object)array)[61]) ? ((int)(num2 * 144186727) ^ ((int[])(object)array)[80]) : ((int[])(object)array)[86]);
			goto IL_0372;
			IL_0e56:
			arg2 = P_3.ReadByte();
			num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[21]) != ((int[])(object)array)[15]) ? ((int[])(object)array)[40] : ((int)(num2 * 1325268028) ^ ((int[])(object)array)[23]));
			goto IL_0372;
			IL_06bc:
			metadataToken2 = P_3.ReadInt32();
			num = ((((int[])(object)array)[2] + ((int[])(object)array)[0] == ((int[])(object)array)[2]) ? ((int)(num2 * 60756253) ^ ((int[])(object)array)[4]) : ((int[])(object)array)[4]);
			goto IL_0372;
			IL_123d:
			num22 = P_3.ReadInt32();
			num = (((((int[])(object)array)[33] ^ ((int[])(object)array)[9]) < ((int[])(object)array)[13]) ? (((int)num2 * -1513747808) ^ ((int[])(object)array)[0]) : ((int[])(object)array)[43]);
			goto IL_0372;
			IL_0779:
			key = P_3.ReadInt32();
			num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[20]) < ((int[])(object)array)[34]) ? ((int[])(object)array)[36] : (((int)num2 * -909107402) ^ ((int[])(object)array)[35]));
			goto IL_0372;
			IL_0e21:
			str = P_3.ReadString();
			num = ((((int[])(object)array)[9] + ((int[])(object)array)[8] > ((int[])(object)array)[3]) ? ((int[])(object)array)[12] : ((int)(num2 * 481356239) ^ ((int[])(object)array)[0]));
			goto IL_0372;
			IL_1190:
			arg4 = P_3.ReadDouble();
			num = (((((int[])(object)array)[54] ^ ((int[])(object)array)[45]) >= ((int[])(object)array)[81]) ? ((int[])(object)array)[83] : (((int)num2 * -491816412) ^ ((int[])(object)array)[17]));
			goto IL_0372;
			IL_0ba4:
			num21 = P_3.ReadInt32();
			num = ((((int[])(object)array)[30] + ((int[])(object)array)[70] >= ((int[])(object)array)[10]) ? (((int)num2 * -2066796418) ^ ((int[])(object)array)[39]) : ((int[])(object)array)[73]);
			goto IL_0372;
			IL_0896:
			P_2.Emit(P_1);
			num = (((((int[])(object)array)[1] ^ ((int[])(object)array)[1]) < ((int[])(object)array)[2]) ? ((int[])(object)array)[2] : (((int)num2 * -341660602) ^ ((int[])(object)array)[2]));
			goto IL_0372;
			IL_0f60:
			num24 = P_3.ReadInt32();
			num = (((((int[])(object)array)[8] ^ ((int[])(object)array)[5]) > ((int[])(object)array)[18]) ? ((int[])(object)array)[18] : (((int)num2 * -1666746032) ^ ((int[])(object)array)[14]));
			goto IL_0372;
			IL_0db0:
			arg = P_3.ReadInt32();
			num = (((((int[])(object)array)[4] ^ ((int[])(object)array)[14]) != ((int[])(object)array)[8]) ? ((int[])(object)array)[15] : ((int)(num2 * 995777611) ^ ((int[])(object)array)[11]));
			goto IL_0372;
			IL_06ef:
			num5 = P_3.ReadInt32();
			num = (((((int[])(object)array)[20] ^ ((int[])(object)array)[38]) > ((int[])(object)array)[1]) ? (((int)num2 * -32057206) ^ ((int[])(object)array)[45]) : ((int[])(object)array)[55]);
			goto IL_0372;
			IL_0e8e:
			arg5 = P_3.ReadSingle();
			num = (((((int[])(object)array)[23] ^ ((int[])(object)array)[10]) != ((int[])(object)array)[70]) ? ((int[])(object)array)[80] : ((int)(num2 * 324251945) ^ ((int[])(object)array)[17]));
			goto IL_0372;
		}
	}

	private static void _202A_200E_200E_202D_200E_200C_200F_200B_200E_200B_200E_200E_200E_202B_200E_200E(List<_200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E> P_0, int P_1, ILGenerator P_2)
	{
		bool[] array = (bool[])(object)new int[16]
		{
			22, 357181548, 1773573357, 1500036079, -945115969, -579849859, 534968040, 268149937, -299347188, 858449388,
			-1768945496, 1620283489, -1184267748, 1847841256, 278873910, 2
		};
		List<_200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E>.Enumerator enumerator = P_0.GetEnumerator();
		try
		{
			_200C_200F_200F_200B_200E_202E_200E_200E_200F_202D_200E_200F_200F_200D_200E_200E current = default;
			int index = default;
			while (true)
			{
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 154812482;
					num2 = num;
				}
				else
				{
					num = 1796193416;
					num2 = num;
				}
				while (true)
				{
					uint num3 = (uint)num;
					switch ((uint)num % (uint)((int[])(object)array)[0])
					{
					case 19u:
						num = 1796193416;
						continue;
					default:
						return;
					case 8u:
					{
						int num11;
						if (current._200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F == P_1)
						{
							num = 2046935049;
							num11 = num;
						}
						else
						{
							num = 2067052869;
							num11 = num;
						}
						continue;
					}
					case 1u:
					{
						int num4;
						int num5;
						if (current._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E == P_1)
						{
							num4 = -624133958;
							num5 = num4;
						}
						else
						{
							num4 = -1026248291;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * ((int[])(object)array)[3]);
						continue;
					}
					case 4u:
					{
						int num9;
						if (current._202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E != P_1)
						{
							num = 2113525768;
							num9 = num;
						}
						else
						{
							num = 2063497303;
							num9 = num;
						}
						continue;
					}
					case 9u:
						P_2.BeginExceptionBlock();
						num = ((((int[])(object)array)[1] + ((int[])(object)array)[7] > ((int[])(object)array)[8]) ? ((int)(num3 * 1898155241) ^ ((int[])(object)array)[10]) : ((int)(num3 * 160019225) ^ ((int[])(object)array)[0]));
						continue;
					case 21u:
						P_2.BeginFinallyBlock();
						num = ((((int[])(object)array)[9] + ((int[])(object)array)[5] <= ((int[])(object)array)[8]) ? ((int)(num3 * 427420829) ^ ((int[])(object)array)[5]) : ((int)(num3 * 705162226) ^ ((int[])(object)array)[14]));
						continue;
					case 20u:
					{
						int num12;
						int num13;
						if (current._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E == 1)
						{
							num12 = -200336957;
							num13 = num12;
						}
						else
						{
							num12 = -1162197827;
							num13 = num12;
						}
						num = num12 ^ ((int)num3 * ((int[])(object)array)[2]);
						continue;
					}
					case 2u:
						break;
					case 14u:
						num = (((((int[])(object)array)[3] ^ ((int[])(object)array)[8]) < ((int[])(object)array)[11]) ? ((int)(num3 * 515413039) ^ ((int[])(object)array)[13]) : (((int)num3 * -1500716817) ^ ((int[])(object)array)[1]));
						continue;
					case 11u:
						P_2.BeginExceptionBlock();
						num = ((((int[])(object)array)[2] + ((int[])(object)array)[0] != ((int[])(object)array)[3]) ? (((int)num3 * -1073435495) ^ ((int[])(object)array)[4]) : ((int)(num3 * 1798840236) ^ ((int[])(object)array)[1]));
						continue;
					case 18u:
					{
						int num14;
						if (current._200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F != P_1)
						{
							num = 832634510;
							num14 = num;
						}
						else
						{
							num = 2102005940;
							num14 = num;
						}
						continue;
					}
					case 6u:
						current = enumerator.Current;
						num = ((((int[])(object)array)[0] + ((int[])(object)array)[0] < ((int[])(object)array)[0]) ? ((int)(num3 * 29453420) ^ ((int[])(object)array)[0]) : ((int[])(object)array)[1]);
						continue;
					case 17u:
						num = ((((int[])(object)array)[6] + ((int[])(object)array)[9] > ((int[])(object)array)[9]) ? ((int)(num3 * 1852273105) ^ ((int[])(object)array)[11]) : (((int)num3 * -1109723618) ^ ((int[])(object)array)[4]));
						continue;
					case 16u:
						P_2.BeginCatchBlock(current._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E[index]);
						num = ((((int[])(object)array)[6] + ((int[])(object)array)[5] != ((int[])(object)array)[6]) ? ((int)(num3 * 1939540511) ^ ((int[])(object)array)[7]) : (((int)num3 * -1978565087) ^ ((int[])(object)array)[7]));
						continue;
					case 7u:
						num = (((((int[])(object)array)[7] ^ ((int[])(object)array)[1]) <= ((int[])(object)array)[3]) ? ((int)(num3 * 1308829108) ^ ((int[])(object)array)[8]) : (((int)num3 * -642849055) ^ ((int[])(object)array)[6]));
						continue;
					case 3u:
						index = current._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E.IndexOf(P_1);
						num = ((((int[])(object)array)[2] + ((int[])(object)array)[3] == ((int[])(object)array)[1]) ? ((int)(num3 * 1021423066) ^ ((int[])(object)array)[5]) : (((int)num3 * -1948623388) ^ ((int[])(object)array)[6]));
						continue;
					case 15u:
					{
						int num10;
						if (current._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E == 5)
						{
							num = 188534048;
							num10 = num;
						}
						else
						{
							num = 2113525768;
							num10 = num;
						}
						continue;
					}
					case 13u:
					{
						int num8;
						if (!current._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E.Contains(P_1))
						{
							num = 2113525768;
							num8 = num;
						}
						else
						{
							num = 745809353;
							num8 = num;
						}
						continue;
					}
					case 10u:
					{
						int num6;
						int num7;
						if (current._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E != P_1)
						{
							num6 = -1481259180;
							num7 = num6;
						}
						else
						{
							num6 = -1281938935;
							num7 = num6;
						}
						num = num6 ^ ((int)num3 * ((int[])(object)array)[9]);
						continue;
					}
					case 12u:
						P_2.EndExceptionBlock();
						num = (((((int[])(object)array)[0] ^ ((int[])(object)array)[7]) > ((int[])(object)array)[6]) ? (((int)num3 * -60144313) ^ ((int[])(object)array)[0]) : (((int)num3 * -152089557) ^ ((int[])(object)array)[12]));
						continue;
					case 5u:
						P_2.EndExceptionBlock();
						num = ((((int[])(object)array)[0] + ((int[])(object)array)[5] < ((int[])(object)array)[1]) ? (((int)num3 * -2135464840) ^ ((int[])(object)array)[5]) : (((int)num3 * -1801500349) ^ ((int[])(object)array)[5]));
						continue;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
			while (true)
			{
				uint num3;
				switch ((num3 = 1354855307u) % (uint)((int[])(object)array)[15])
				{
				case 0u:
					break;
				default:
					goto end_IL_04ab;
				case 1u:
					goto end_IL_04ab;
				}
				continue;
				end_IL_04ab:
				break;
			}
		}
	}

	private static void _202A_200E_202B_200D_200E_200D_200F_200F_200F_200C_200F_200F_200E_202D_200E_200E(BinaryReader P_0, int P_1, MethodBase P_2, List<_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E> P_3)
	{
		bool[] array = (bool[])(object)new int[33]
		{
			35, 801749931, 152552165, 1898552409, 80727526, -1544019199, 1775907729, 735105126, -529742998, 1757625022,
			876528517, -1053158803, 2088656065, -490068357, -1721107034, 55791360, 803331501, 1532260685, 308743811, -1726752193,
			844978877, -453167618, 920484605, 163327865, 652526899, 471154493, 1921518071, 1487583802, 588265440, -815605269,
			-296246502, 342464912, -1707973661
		};
		int num = 0;
		int num6 = default;
		int num10 = default;
		_202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E obj = default;
		int num11 = default;
		Type type = default;
		byte b = default;
		int num12 = default;
		int num5 = default;
		int num4 = default;
		while (true)
		{
			int num2 = 1612379348;
			while (true)
			{
				uint num3 = (uint)num2;
				switch ((uint)num2 % (uint)((int[])(object)array)[0])
				{
				case 23u:
					break;
				default:
					return;
				case 1u:
				{
					int num7;
					int num8;
					if (num6 != 0)
					{
						num7 = 1214111812;
						num8 = num7;
					}
					else
					{
						num7 = 659784798;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num3 * ((int[])(object)array)[4]);
					continue;
				}
				case 8u:
					num2 = (((((int[])(object)array)[4] ^ ((int[])(object)array)[7]) >= ((int[])(object)array)[16]) ? ((int)(num3 * 1885671324) ^ ((int[])(object)array)[1]) : (((int)num3 * -593779482) ^ ((int[])(object)array)[17]));
					continue;
				case 17u:
					num10 = P_0.ReadInt32();
					num2 = ((((int[])(object)array)[7] + ((int[])(object)array)[0] > ((int[])(object)array)[4]) ? ((int[])(object)array)[9] : (((int)num3 * -1745760025) ^ ((int[])(object)array)[6]));
					continue;
				case 30u:
					obj._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E = null;
					num2 = (((((int[])(object)array)[0] ^ ((int[])(object)array)[3]) > ((int[])(object)array)[2]) ? (((int)num3 * -2084430458) ^ ((int[])(object)array)[5]) : ((int)(num3 * 2105762616) ^ ((int[])(object)array)[0]));
					continue;
				case 22u:
					num2 = ((((int[])(object)array)[14] + ((int[])(object)array)[2] <= ((int[])(object)array)[10]) ? (((int)num3 * -1711709891) ^ ((int[])(object)array)[21]) : ((int)(num3 * 591576732) ^ ((int[])(object)array)[7]));
					continue;
				case 11u:
					num11 = P_0.ReadInt32();
					num2 = (((((int[])(object)array)[17] ^ ((int[])(object)array)[15]) < ((int[])(object)array)[4]) ? (((int)num3 * -820704300) ^ ((int[])(object)array)[20]) : ((int[])(object)array)[27]);
					continue;
				case 4u:
					obj._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E = 2;
					num2 = (((((int[])(object)array)[7] ^ ((int[])(object)array)[5]) < ((int[])(object)array)[0]) ? ((int[])(object)array)[20] : (((int)num3 * -2134687848) ^ ((int[])(object)array)[11]));
					continue;
				case 10u:
					num6 = P_0.ReadInt32();
					num2 = ((((int[])(object)array)[2] + ((int[])(object)array)[1] <= ((int[])(object)array)[1]) ? ((int)(num3 * 926621101) ^ ((int[])(object)array)[2]) : ((int)(num3 * 1315879881) ^ ((int[])(object)array)[3]));
					continue;
				case 12u:
					obj._202B_200E_202C_202B_200E_202E_200E_200D_200F_202A_200F_200D_200F_200F_200F_200E = num11;
					num2 = (((((int[])(object)array)[3] ^ ((int[])(object)array)[22]) != ((int[])(object)array)[11]) ? (((int)num3 * -1268143570) ^ ((int[])(object)array)[28]) : ((int)(num3 * 1927513058) ^ ((int[])(object)array)[26]));
					continue;
				case 13u:
					num2 = (((((int[])(object)array)[1] ^ ((int[])(object)array)[0]) != ((int[])(object)array)[1]) ? (((int)num3 * -1166893002) ^ ((int[])(object)array)[1]) : ((int)(num3 * 110205085) ^ ((int[])(object)array)[0]));
					continue;
				case 21u:
					obj._202B_200E_202E_202C_200E_202C_200E_200C_200F_200C_200F_200E = type;
					num2 = ((((int[])(object)array)[6] + ((int[])(object)array)[5] < ((int[])(object)array)[3]) ? (((int)num3 * -243875250) ^ ((int[])(object)array)[8]) : (((int)num3 * -1848430412) ^ ((int[])(object)array)[5]));
					continue;
				case 3u:
					type = P_2.Module.ResolveType(num6);
					num2 = ((((int[])(object)array)[0] + ((int[])(object)array)[2] >= ((int[])(object)array)[3]) ? (((int)num3 * -831285774) ^ ((int[])(object)array)[5]) : ((int[])(object)array)[7]);
					continue;
				case 16u:
					b = P_0.ReadByte();
					num2 = ((((int[])(object)array)[9] + ((int[])(object)array)[13] <= ((int[])(object)array)[12]) ? ((int)(num3 * 1671890083) ^ ((int[])(object)array)[15]) : ((int)(num3 * 1123126649) ^ ((int[])(object)array)[12]));
					continue;
				case 32u:
					goto IL_04a1;
				case 29u:
					num12 = P_0.ReadInt32();
					num2 = (((((int[])(object)array)[10] ^ ((int[])(object)array)[11]) < ((int[])(object)array)[11]) ? ((int)(num3 * 742568520) ^ ((int[])(object)array)[5]) : ((int)(num3 * 2094114570) ^ ((int[])(object)array)[11]));
					continue;
				case 6u:
					num2 = ((((int[])(object)array)[2] + ((int[])(object)array)[4] >= ((int[])(object)array)[2]) ? (((int)num3 * -1340729533) ^ ((int[])(object)array)[6]) : ((int)(num3 * 484166348) ^ ((int[])(object)array)[1]));
					continue;
				case 26u:
					num2 = (((((int[])(object)array)[6] ^ ((int[])(object)array)[17]) > ((int[])(object)array)[18]) ? ((int)(num3 * 1176638104) ^ ((int[])(object)array)[19]) : (((int)num3 * -1052127701) ^ ((int[])(object)array)[8]));
					continue;
				case 5u:
					num2 = ((((int[])(object)array)[13] + ((int[])(object)array)[11] < ((int[])(object)array)[2]) ? (((int)num3 * -1017837274) ^ ((int[])(object)array)[23]) : (((int)num3 * -1732330483) ^ ((int[])(object)array)[17]));
					continue;
				case 34u:
					P_3.Add(obj);
					num2 = (((((int[])(object)array)[13] ^ ((int[])(object)array)[18]) <= ((int[])(object)array)[11]) ? (((int)num3 * -999112704) ^ ((int[])(object)array)[11]) : (((int)num3 * -1731074642) ^ ((int[])(object)array)[31]));
					continue;
				case 9u:
					goto IL_0600;
				case 18u:
					goto IL_0637;
				case 20u:
					num5 = P_0.ReadInt32();
					num2 = (((((int[])(object)array)[8] ^ ((int[])(object)array)[4]) == ((int[])(object)array)[0]) ? ((int)(num3 * 1465563171) ^ ((int[])(object)array)[10]) : ((int)(num3 * 2053347539) ^ ((int[])(object)array)[13]));
					continue;
				case 2u:
					obj._200C_200F_200F_200F_200F_200E_200E_202D_200E_200F_200E_202B_200E_200C_200F_200E = num5;
					num2 = (((((int[])(object)array)[8] ^ ((int[])(object)array)[8]) <= ((int[])(object)array)[7]) ? ((int)(num3 * 1691483008) ^ ((int[])(object)array)[14]) : ((int)(num3 * 1936216010) ^ ((int[])(object)array)[10]));
					continue;
				case 27u:
					obj._202D_200E_200C_202A_200E_202E_200E_202A_200E_202C_200E_200E_200F_200D_200E_200E = num10;
					num2 = (((((int[])(object)array)[7] ^ ((int[])(object)array)[4]) >= ((int[])(object)array)[1]) ? ((int)(num3 * 1508621496) ^ ((int[])(object)array)[5]) : (((int)num3 * -266383436) ^ ((int[])(object)array)[10]));
					continue;
				case 19u:
					obj._202E_200E_200C_200F_200F_200F_200E_202A_200E_202B_200F_200D_200F_200E = num4;
					num2 = (((((int[])(object)array)[5] ^ ((int[])(object)array)[12]) != ((int[])(object)array)[8]) ? ((int)(num3 * 2125477161) ^ ((int[])(object)array)[30]) : (((int)num3 * -916973674) ^ ((int[])(object)array)[19]));
					continue;
				case 14u:
					switch (b)
					{
					case 2:
						break;
					case 1:
						goto IL_04a1;
					case 5:
						goto IL_0600;
					case 3:
						goto IL_0637;
					default:
						goto IL_0786;
					case 4:
						goto IL_0873;
					}
					goto case 4u;
				case 24u:
					num2 = ((((int[])(object)array)[24] + ((int[])(object)array)[1] >= ((int[])(object)array)[10]) ? (((int)num3 * -283125234) ^ ((int[])(object)array)[25]) : (((int)num3 * -1796981223) ^ ((int[])(object)array)[25]));
					continue;
				case 0u:
					obj._200E_200F_202B_200E_200E_202E_200E_202D_200E_200C_200E_202B_200F_202E_200E_200F = num12;
					num2 = ((((int[])(object)array)[8] + ((int[])(object)array)[4] <= ((int[])(object)array)[5]) ? ((int)(num3 * 272843027) ^ ((int[])(object)array)[12]) : ((int)(num3 * 2082893716) ^ ((int[])(object)array)[12]));
					continue;
				case 31u:
					num++;
					num2 = ((((int[])(object)array)[26] + ((int[])(object)array)[11] < ((int[])(object)array)[32]) ? (((int)num3 * -2140787794) ^ ((int[])(object)array)[21]) : (((int)num3 * -1595655256) ^ ((int[])(object)array)[32]));
					continue;
				case 7u:
					goto IL_0873;
				case 33u:
				{
					int num9;
					if (num < P_1)
					{
						num2 = 1168764825;
						num9 = num2;
					}
					else
					{
						num2 = 507570903;
						num9 = num2;
					}
					continue;
				}
				case 25u:
					obj = new _202C_200E_202D_202B_200F_200C_200F_200E_200F_202C_200E_200D_200E_202A_200E_200E();
					num2 = ((((int[])(object)array)[1] + ((int[])(object)array)[0] < ((int[])(object)array)[2]) ? (((int)num3 * -1048038780) ^ ((int[])(object)array)[0]) : ((int[])(object)array)[2]);
					continue;
				case 15u:
					num4 = P_0.ReadInt32();
					num2 = ((((int[])(object)array)[17] + ((int[])(object)array)[14] <= ((int[])(object)array)[19]) ? (((int)num3 * -1128473586) ^ ((int[])(object)array)[11]) : (((int)num3 * -1708970413) ^ ((int[])(object)array)[29]));
					continue;
				case 28u:
					return;
					IL_0637:
					obj._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E = 3;
					num2 = ((((int[])(object)array)[19] + ((int[])(object)array)[12] == ((int[])(object)array)[14]) ? ((int)(num3 * 1454082393) ^ ((int[])(object)array)[6]) : ((int[])(object)array)[22]);
					continue;
					IL_04a1:
					obj._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E = 1;
					num2 = (((((int[])(object)array)[13] ^ ((int[])(object)array)[4]) >= ((int[])(object)array)[11]) ? ((int[])(object)array)[18] : ((int)(num3 * 146020435) ^ ((int[])(object)array)[11]));
					continue;
					IL_0600:
					obj._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E = 5;
					num2 = ((((int[])(object)array)[24] + ((int[])(object)array)[26] == ((int[])(object)array)[13]) ? ((int)(num3 * 1673442023) ^ ((int[])(object)array)[0]) : ((int[])(object)array)[26]);
					continue;
					IL_0873:
					obj._200E_200E_200D_202B_200F_200F_200E_200B_200E_200C_200F_202D_200E_200C_200F_200E = 4;
					num2 = ((((int[])(object)array)[11] + ((int[])(object)array)[14] < ((int[])(object)array)[10]) ? (((int)num3 * -1821969148) ^ ((int[])(object)array)[0]) : ((int[])(object)array)[24]);
					continue;
					IL_0786:
					num2 = ((((int[])(object)array)[2] + ((int[])(object)array)[11] == ((int[])(object)array)[2]) ? ((int)(num3 * 1082927269) ^ ((int[])(object)array)[3]) : ((int)(num3 * 386438793) ^ ((int[])(object)array)[16]));
					continue;
				}
				break;
			}
		}
	}

	private static Type _202C_200E_202D_200D_200F_200F_200F_200F_200E_200C_200F_202D_200E_202A_200F_200E()
	{
		bool[] array = (bool[])(object)new int[0];
		return typeof(_003CModule_003E);
	}
}
