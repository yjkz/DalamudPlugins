using System.Runtime.CompilerServices;
using System.Text;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Component.GUI;
using FFXIVPVPAuto.Abstracts;

namespace FFXIVPVPAuto.Modules.UI;

public sealed class FrontlineScorePredictionModule : ModuleBase
{
	private sealed class Config
	{
		public bool WriteToHeader
		{
			[CompilerGenerated]
			get
			{
				_ = 2;
				/*Error near IL_0001: Invalid branch target*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8F 0x18
			}
		}

		public bool ShowDebugInfo
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x7D
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x19
			}
		}

		public Config()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE4
		}
	}

	private static readonly uint[] ChannelBaseNodeIds;

	private const uint FactionTextNodeId = 2u;

	private Config _config;

	private PvPMapRadarModule? _radar;

	private readonly string[] _channelBaseTexts;

	private readonly string[] _channelLastWritten;

	private readonly int[] _channelRealScores;

	private readonly int[] _channelBonuses;

	private readonly nint[] _channelTextNodeAddresses;

	private readonly bool[] _channelWasWritten;

	private bool _restored;

	private nint _boundHeaderAddonAddress;

	private string _lastDumpText;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x51
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFD
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9D
		}
	}

	protected override void Init()
	{
		/*Error: Unknown opcode: 0xFA*/;
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9D
	}

	protected override void ConfigChanged()
	{
		_ = -1;
		/*Error near IL_0001: Unknown opcode: 0xAF*/;
	}

	private void OnTerritoryChanged(uint _)
	{
		ushort num = (ushort)2;
		/*Error near IL_0002: Unknown opcode: 0xBE*/;
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA5
	}

	private static bool IsContextValid()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDC
	}

	private static bool IsTerritoryTransitioning()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x70
	}

	private void UpdateChannels()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xED
	}

	private static string BuildTargetText(string baseText, int realScore, int bonus)
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	private static string ExtractBaseText(string text)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2F 0x98
	}

	private static PvPMapRadarModule.FrontlineFaction ParseFaction(string text)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x43 0xAB
	}

	private bool TryRestoreAllChannels()
	{
		/*Error: Unknown opcode: 0xC5*/;
	}

	private unsafe void BindHeaderAddon(AtkUnitBase* addon)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0x77DC183B
	}

	private unsafe void BindChannelTextNode(int channelIndex, AtkTextNode* textNode)
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	private void ResetRuntimeState()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA9
	}

	private void ResetChannelState(int channelIndex)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x95
	}

	private void ResetLiveSnapshots()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD7 0xFF
	}

	private unsafe bool TrySetChannelFactionText(AtkTextNode* textNode, uint baseNodeId, string text)
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Unknown opcode: 0xEC*/;
	}

	private unsafe int ReadChannelRealScore(AtkUnitBase* addon, uint baseNodeId)
	{
		/*Error: stloc 191 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xB2*/;
	}

	private unsafe static AtkUnitBase* GetHeaderAddon()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x10
	}

	private unsafe static AtkTextNode* FindChannelTextNode(AtkUnitBase* addon, uint baseNodeId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6F 0x7C
	}

	private unsafe static AtkComponentNode* FindChannelComponentNode(AtkUnitBase* addon, uint baseNodeId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x15
	}

	private unsafe static AtkTextNode* FindChildTextNode(AtkComponentNode* componentNode, uint nodeId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x09
	}

	private void DumpNodeTree()
	{
		/*Error: Unknown opcode: 0xF7*/;
	}

	private unsafe static void DumpNode(StringBuilder sb, AtkResNode* node, int indent)
	{
		/*Error: Unknown opcode: 0xEE*/;
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x30
	}

	public FrontlineScorePredictionModule()
	{
		//IL_0039: Expected I4, but got F8
		switch ((int)(double)/*Error near IL_0001: Stack underflow*/)
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
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		}
	}

	static FrontlineScorePredictionModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x23 0x13
	}
}
