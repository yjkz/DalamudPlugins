using System;
using System.Security.Cryptography;
using FFXIVPVPAuto.Verification.Models;

namespace FFXIVPVPAuto.Verification.Crypto;

internal static class TestCodeCrypto
{
	private const int EnvelopeVersion = 1;

	private const int AesKeySize = 32;

	private const int NonceSize = 12;

	private const int TagSize = 16;

	private const int RsaKeySize = 3072;

	internal static TestCodeEncryptedRequest EncryptRequest<T>(T payload, string keyId, string publicKey)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x1C
	}

	internal static byte[] VerifyAndDecryptResponse(TestCodeEnvelope envelope, ReadOnlySpan<byte> sessionKey, string expectedKeyId, string publicKey)
	{
		((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFA*/;
	}

	internal static string CreateClientNonce()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4F 0xB0
	}

	internal static string ToBase64Url(ReadOnlySpan<byte> value)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2F 0x58
	}

	internal static byte[] FromBase64Flexible(string value)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4C
	}

	private static void ValidateResponseEnvelope(TestCodeEnvelope envelope, string expectedKeyId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFD
	}

	private static byte[] CreateCanonicalEnvelope(TestCodeEnvelope envelope)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCF 0x26
	}

	private unsafe static byte[] CreateAad(string kind, int version, string keyId)
	{
		_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xBE*/;
	}

	private static RSA CreateRsa(string publicKey)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE3 0x7E
	}
}
