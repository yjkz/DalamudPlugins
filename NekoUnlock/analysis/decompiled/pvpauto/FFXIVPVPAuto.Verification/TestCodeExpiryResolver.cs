using System;

namespace FFXIVPVPAuto.Verification;

internal static class TestCodeExpiryResolver
{
	internal static readonly TimeSpan MaximumObservedClockSkew;

	internal static readonly TimeSpan MaximumQualificationWindow;

	internal static TestCodeExpiryResolutionResult Resolve(DateTimeOffset? serverTime, DateTimeOffset? qualificationExpiresAt, DateTimeOffset? pendingExpiresAt, long issuedAtTickCount, DateTimeOffset? localUtc = null)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x3B 0xF1
	}

	private static long? AddWindow(TimeSpan window, long issuedAtTickCount)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x44
	}

	private unsafe static DateTimeOffset TickCountToUtcApproximation(long tickCount, long issuedAtTickCount, DateTimeOffset serverTime)
	{
		_ = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0x77*/;
	}

	unsafe static TestCodeExpiryResolver()
	{
		//IL_001e: Expected F8, but got I4
		if (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
		{
			/*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
			/*Error near IL_0003: Unknown opcode: 0xC0*/;
		}
		if (/*Error near IL_001c: Stack underflow*/ < /*Error near IL_001c: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		*(double*)(nint)/*Error near IL_001e: Stack underflow*/ = 7.0;
		if (/*Error near IL_0023: Stack underflow*/ <= /*Error near IL_0023: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(short*)(nint)/*Error near IL_0024: Stack underflow*/;
		/*Error near IL_0024: Unknown opcode: 0xA9*/;
	}
}
