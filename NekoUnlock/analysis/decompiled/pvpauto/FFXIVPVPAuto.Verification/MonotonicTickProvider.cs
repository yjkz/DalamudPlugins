using System;

namespace FFXIVPVPAuto.Verification;

internal static class MonotonicTickProvider
{
	private static readonly object SyncLock;

	private static Func<long> _provider;

	internal unsafe static long TickCount
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (object)/*Error near IL_0002: Stack underflow*/;
			switch ((int)/*Error near IL_0022: Stack underflow*/)
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
			}
		}
	}

	internal static void Override(Func<long>? provider)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF4
	}

	private static long DefaultProvider()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x54
	}

	static MonotonicTickProvider()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x67 0xE7
	}
}
