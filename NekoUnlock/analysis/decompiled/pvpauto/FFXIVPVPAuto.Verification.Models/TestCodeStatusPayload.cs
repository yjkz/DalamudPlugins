using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace FFXIVPVPAuto.Verification.Models;

internal sealed class TestCodeStatusPayload
{
	[JsonPropertyName("pluginId")]
	public int PluginId
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB5
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD5
		}
	}

	[JsonPropertyName("pluginVersion")]
	public string PluginVersion
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x80
		}
		[CompilerGenerated]
		init
		{
			checked
			{
				_ = (nint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Not a type handle*/;
			}
		}
	}

	[JsonPropertyName("machineCredential")]
	public string MachineCredential
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x27 0x93
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1B 0x40
		}
	}

	[JsonPropertyName("requestToken")]
	public string RequestToken
	{
		[CompilerGenerated]
		get
		{
			//IL_0000: Unsupported input type for neg.
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = 0 - /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9F 0x18
		}
	}

	[JsonPropertyName("grantToken")]
	public string GrantToken
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xDB 0xB7
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC1
		}
	}

	[JsonPropertyName("timestamp")]
	public long Timestamp
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x08
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA0
		}
	}

	[JsonPropertyName("nonce")]
	public string Nonce
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE3 0x0A
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x74
		}
	}

	public TestCodeStatusPayload()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE9
	}
}
