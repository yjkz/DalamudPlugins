using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace FFXIVPVPAuto.Verification.Models;

internal sealed class TestCodeRequestPayload
{
	[JsonPropertyName("pluginId")]
	public int PluginId
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB0
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x11
		}
	}

	[JsonPropertyName("pluginVersion")]
	public unsafe string PluginVersion
	{
		[CompilerGenerated]
		get
		{
			Unsafe.Read<object>((void*)(nint)/*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0001: Unknown opcode: 0xEB*/;
		}
		[CompilerGenerated]
		init
		{
			//IL_0005: Expected F8, but got I4
			/*Error: stloc 1 (out-of-bounds)*/;
			((double[])/*Error near IL_0005: Stack underflow*/)[*(double*)(nint)/*Error near IL_0002: Stack underflow*/] = -46.0;
			/*Error near IL_0005: Unknown opcode: 0xB0*/;
		}
	}

	[JsonPropertyName("machineCredential")]
	public string MachineCredential
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x79
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4D
		}
	}

	[JsonPropertyName("timestamp")]
	public long Timestamp
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x43 0x50
		}
		[CompilerGenerated]
		init
		{
			//IL_0005: Invalid comparison between F8 and I8
			if ((double)/*Error near IL_0001: Stack underflow*/ > 3.0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0007: ldloc 233 (out-of-bounds)*/;
			/*Error near IL_0009: Unknown opcode: 0xE4*/;
		}
	}

	[JsonPropertyName("nonce")]
	public string Nonce
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA4
		}
		[CompilerGenerated]
		init
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD0
		}
	}

	public TestCodeRequestPayload()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xF1*/;
		}
	}
}
