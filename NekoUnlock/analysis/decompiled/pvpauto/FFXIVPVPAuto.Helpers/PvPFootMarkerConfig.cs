using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace FFXIVPVPAuto.Helpers;

internal sealed class PvPFootMarkerConfig
{
	public bool Enabled
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x15
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x71
		}
	}

	public float Radius
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x88
		}
	}

	public float Red
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3F 0x81
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x80
		}
	}

	public float Green
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE9
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xCD
		}
	}

	public float Blue
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x04
		}
		[CompilerGenerated]
		set
		{
			checked
			{
				_ = (nint)/*Error: ldarg 2 (out-of-bounds)*/;
				/*Error near IL_0002: Unknown opcode: 0xAA*/;
			}
		}
	}

	public unsafe float Alpha
	{
		[CompilerGenerated]
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected F8, but got Unknown
			//IL_000f: Invalid comparison between Unknown and I4
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)/*Error near IL_0003: Stack underflow*/, (nint)/*Error near IL_0003: Stack underflow*/, /*Error: ldarg 3 (out-of-bounds)*/);
			checked
			{
				((double[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = unchecked((uint)((short[])/*Error near IL_0005: Stack underflow*/)[4]) + -9.505052E+28f;
			}
			if ((int)/*Error near IL_0010: Stack underflow*/ != 8)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0010: Unknown opcode: 0xE7*/;
		}
		[CompilerGenerated]
		set
		{
			Unsafe.Read<object>((void*)(nint)/*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0001: Unknown opcode: 0xF2*/;
		}
	}

	[JsonIgnore]
	internal Vector4 Color
	{
		get
		{
			/*Error: Unknown opcode: 0xC7*/;
		}
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x79
		}
	}

	internal void Normalize()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x94
	}

	private static float ClampColor(float value, float fallback)
	{
		_ = 8.886928E-10f;
		/*Error near IL_0005: Invalid field token*/;
	}

	public PvPFootMarkerConfig()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDF 0x29
	}
}
