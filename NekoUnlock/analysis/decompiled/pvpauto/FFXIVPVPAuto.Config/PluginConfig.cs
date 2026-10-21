using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Dalamud.Configuration;

namespace FFXIVPVPAuto.Config;

public sealed class PluginConfig : IPluginConfiguration
{
	private static PluginConfig? _instance;

	public static PluginConfig Instance
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4B 0xE1
		}
	}

	[JsonPropertyName("version")]
	public int Version
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x81
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x85
		}
	}

	[JsonPropertyName("selected_language")]
	public string SelectedLanguage
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4B 0x98
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4B 0x49
		}
	}

	[JsonPropertyName("selected_theme")]
	public string SelectedTheme
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xC7*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Unknown opcode: 0xC4*/;
		}
	}

	[JsonPropertyName("module_enabled")]
	public Dictionary<string, bool> ModuleEnabled
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB7 0x59
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4F 0x2C
		}
	}

	[JsonPropertyName("module_window_open")]
	public Dictionary<string, bool> ModuleWindowOpen
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3C
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA9
		}
	}

	[JsonPropertyName("module_overlay_open")]
	public Dictionary<string, bool> ModuleOverlayOpen
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x80
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB7 0x63
		}
	}

	[JsonPropertyName("quick_toggles")]
	public List<QuickToggleEntry> QuickToggles
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x99
		}
		[CompilerGenerated]
		set
		{
			/*Error: Unknown opcode: 0xED*/;
		}
	}

	[JsonPropertyName("send_online_auth_info")]
	public bool SendOnlineAuthInfo
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE4
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x81
		}
	}

	[JsonPropertyName("test_code_suffix")]
	public string TestCodeSuffix
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x85
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFD
		}
	}

	[JsonPropertyName("test_code_refresh_token_ciphertext")]
	public string TestCodeRefreshTokenCiphertext
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBB 0x54
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x98
		}
	}

	[JsonPropertyName("test_code_request_token_ciphertext")]
	public string TestCodeRequestTokenCiphertext
	{
		[CompilerGenerated]
		get
		{
			_ = ((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Unknown opcode: 0xBC*/;
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9C
		}
	}

	[JsonPropertyName("test_code_grant_token_ciphertext")]
	public unsafe string TestCodeGrantTokenCiphertext
	{
		[CompilerGenerated]
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ != /*Error near IL_0002: Stack underflow*/)
			{
				/*Error near IL_0003: Unknown opcode: 0xE5*/;
			}
			Unsafe.Read<object>((void*)4);
			/*Error near IL_0032: Unknown opcode: 0xE8*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Read out of bounds.*/;
		}
	}

	[JsonPropertyName("test_code_last_checked_at")]
	public DateTimeOffset? TestCodeLastCheckedAt
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xCF 0xFE
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE9
		}
	}

	[JsonPropertyName("report_server_url")]
	public string ReportServerUrl
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x14
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xEF 0xFF
		}
	}

	[JsonPropertyName("report_public_key_base64")]
	public unsafe string ReportPublicKeyBase64
	{
		[CompilerGenerated]
		get
		{
			//IL_0002: Expected F8, but got I4
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = checked((short)/*Error near IL_0001: Stack underflow*/);
			_ = /*Error near IL_0008: Stack underflow*/<< 0;
			_ = (double)/*Error near IL_0008: ldloc 2 (out-of-bounds)*/;
			/*Error: End of method reached without returning.*/;
		}
		[CompilerGenerated]
		set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xDD
		}
	}

	public static void Reload()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		throw ~checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/);
	}

	public void Save()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFF 0x49
	}

	private static PluginConfig Load()
	{
		/*Error: Unknown opcode: 0xFEC0*/;
	}

	public PluginConfig()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC5
	}
}
