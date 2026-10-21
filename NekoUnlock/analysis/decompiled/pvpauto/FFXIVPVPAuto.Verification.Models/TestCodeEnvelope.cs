using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace FFXIVPVPAuto.Verification.Models;

internal sealed class TestCodeEnvelope
{
	[JsonPropertyName("version")]
	public int Version
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x55
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x24
		}
	}

	[JsonPropertyName("keyId")]
	public string KeyId
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB0
		}
		[CompilerGenerated]
		init
		{
			_ = 8;
			_ = 8;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[JsonPropertyName("encryptedKey")]
	public string EncryptedKey
	{
		[CompilerGenerated]
		get
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Unknown opcode: 0xFC*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5F 0xA6
		}
	}

	[JsonPropertyName("nonce")]
	public string Nonce
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1D
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x85
		}
	}

	[JsonPropertyName("ciphertext")]
	public string Ciphertext
	{
		[CompilerGenerated]
		get
		{
			((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (short)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xE8*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD8
		}
	}

	[JsonPropertyName("tag")]
	public string Tag
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xAD
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE1
		}
	}

	[JsonPropertyName("signature")]
	public string Signature
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x25
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x60
		}
	}

	public TestCodeEnvelope()
	{
		/*Error: Unknown opcode: 0xAF*/;
	}
}
