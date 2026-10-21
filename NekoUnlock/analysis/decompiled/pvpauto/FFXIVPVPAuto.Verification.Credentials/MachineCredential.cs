using System;
using System.Collections.Generic;

namespace FFXIVPVPAuto.Verification.Credentials;

internal sealed class MachineCredential : CredentialBase
{
	private static string CachedMachineCredential;

	private static readonly HashSet<string> Bogus;

	protected override char Prefix
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x78
		}
	}

	public MachineCredential()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x63 0xA1
	}

	protected override string GetID()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x51
	}

	public static string GenerateCredential()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF7 0x69
	}

	internal static string GetRawMachineId()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4C
	}

	private unsafe static string? TryGetTpmEkPublicHex()
	{
		//IL_0002: Invalid comparison between Unknown and I8
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if ((long)/*Error near IL_0007: Stack underflow*/ <= checked((long)(*unchecked((int*)(nint)/*Error near IL_0001: Stack underflow*/))))
		{
			/*Error: Invalid branch target*/;
		}
		((IntPtr[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (IntPtr)/*Error near IL_0007: ldloc 2 (out-of-bounds)*/;
		if ((int)/*Error near IL_000b: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0010: Stack underflow*/ < /*Error near IL_0010: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0012: Stack underflow*/| checked(/*Error near IL_0011: Stack underflow*/ * /*Error near IL_0011: Stack underflow*/);
		/*Error near IL_0012: Unknown opcode: 0xB2*/;
	}

	private static string? Wmi(string wmiClass, string prop)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x49
	}

	private unsafe static string? RegBios(string name)
	{
		//IL_0003: Invalid comparison between Unknown and I4
		if (!float.IsFinite(/*Error near IL_0001: Stack underflow*/))
		{
			throw new ArithmeticException();
		}
		if ((int)/*Error near IL_0005: Stack underflow*/ == *(ushort*)((short[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/])
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	private static string? MachineGuid()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x54
	}

	private static string Normalize(string value)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x29
	}

	private static bool IsBogus(string value)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA7 0x05
	}

	private static string ToHex(ReadOnlySpan<byte> bytes)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x24
	}

	static MachineCredential()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x60
	}
}
