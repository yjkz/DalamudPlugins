using System.Runtime.CompilerServices;

namespace FFXIVPVPAuto.Verification.Crypto;

internal static class HotpHelper
{
	private const string Base32Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

	internal static byte[] Secret
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x38
		}
	}

	internal static string Compute(byte[] secret, long counter)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA9
	}

	internal static bool VerifyHotp(string code, long counter, int window = 10)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x11
	}

	internal static byte[] Base32Decode(string input)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0xA9227299
	}

	static HotpHelper()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x58
	}
}
