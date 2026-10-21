using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace FFXIVPVPAuto.Config;

public sealed class QuickToggleEntry
{
	[JsonPropertyName("module")]
	public string ModuleName
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xB1*/;
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1F 0x15
		}
	}

	[JsonPropertyName("mini_panel")]
	public bool ShowInMiniPanel
	{
		[CompilerGenerated]
		get
		{
			((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0006: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFC
		}
	}

	[JsonPropertyName("server_bar")]
	public bool ShowInServerBar
	{
		[CompilerGenerated]
		get
		{
			_ = (uint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
			checked
			{
				_ = (ulong)/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
				/*Error: End of method reached without returning.*/;
			}
		}
		[CompilerGenerated]
		set
		{
			/*Error: Invalid metadata token*/;
		}
	}

	[JsonPropertyName("label")]
	public string Label
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xED
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x65
		}
	}

	public QuickToggleEntry()
	{
		_ = 2;
		/*Error near IL_0001: Unknown opcode: 0xC1*/;
	}
}
