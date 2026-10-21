using System;

namespace FFXIVPVPAuto.Verification;

internal sealed class DailyFallbackVerifier
{
	internal const int PluginId = 1006;

	private const string TemporaryDailySecret = "Errerhuqijun";

	private const int DailyCodeLength = 8;

	private readonly string _dailySecret;

	private readonly Func<long> _tickCountProvider;

	internal DailyFallbackVerifier(string? dailySecret = null, Func<long>? tickCountProvider = null)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x40
	}

	internal unsafe bool TryActivate(string? inputCode, DateTimeOffset trustedUtc, out DailyFallbackLease lease)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (short)unchecked(/*Error near IL_0006: Stack underflow*/ % checked((nint)(*unchecked((ulong*)(-1))) - /*Error near IL_0003: ldloc 2 (out-of-bounds)*/));
			/*Error near IL_0007: Unknown opcode: 0xF3*/;
		}
	}

	internal bool IsActive(in DailyFallbackLease lease)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFB 0x6D
	}

	internal TimeSpan GetRemaining(in DailyFallbackLease lease)
	{
		/*Error: Invalid metadata token*/;
	}

	internal static string NormalizeCode(string? input)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x43 0xAA
	}

	internal static string ComputeCode(DateTimeOffset trustedUtc, string dailySecret)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x01
	}

	private static long CeilingMilliseconds(TimeSpan duration)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x74
	}

	private static long AddMilliseconds(long start, long durationMilliseconds)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x90
	}
}
