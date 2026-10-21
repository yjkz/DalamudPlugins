using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FFXIVPVPAuto.Verification.Credentials;

internal sealed class AccountCredential : CredentialBase
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate nint GetAccountInfoInstanceDelegate();

	protected override char Prefix
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x69
		}
	}

	internal AccountCredential()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6C
	}

	protected override string GetID()
	{
		/*Error: Unknown opcode: 0xF3*/;
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and Obj
		checked
		{
			object obj = ((object[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/ + unchecked(/*Error near IL_0003: Stack underflow*/ - ((int[])/*Error near IL_0002: Stack underflow*/)[checked((nuint)/*Error near IL_0001: Stack underflow*/)])];
			if (Unsafe.As<_003F, UIntPtr>(ref /*Error near IL_0007: Stack underflow*/) <= Unsafe.As<object, UIntPtr>(ref obj))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0007: Unknown opcode: 0xC0*/;
		}
	}

	private void OnLogin()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9C
	}

	private void OnLogout(int type, int code)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x57 0xA0
	}

	private void OnZoneChanged(uint _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB1
	}

	internal static string GetAidValue()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAF 0x8B
	}
}
