using System;
using System.Runtime.CompilerServices;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Component.GUI;
using FFXIVPVPAuto.Abstracts;

namespace FFXIVPVPAuto.Modules.UI;

public sealed class LimitBreakTimerModule : ModuleBase
{
	private sealed class Config
	{
		public bool ShowDebugInfo
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid local signature token: 0xE06F53CD
			}
			[CompilerGenerated]
			set
			{
				_ = (short)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Unknown opcode: 0xED*/;
			}
		}

		public Config()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xEB 0xE1
		}
	}

	private const string AddonName = "_LimitBreak";

	private const uint TextNodeId = 2u;

	private Config _config;

	private string _originalText;

	private string _lastWritten;

	private bool _hasOriginal;

	private bool _restored;

	private nint _boundAddonAddress;

	private nint _boundTextNodeAddress;

	private uint _dbgJob;

	private uint _dbgUnits;

	private uint _dbgBarUnits;

	private float _dbgPercent;

	private bool _dbgFrontline;

	private int _dbgTotal;

	private int _dbgSeconds;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x29
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			_ = 0;
			/*Error near IL_0001: ldloca 102 (out-of-bounds)*/;
			/*Error near IL_0004: Read out of bounds.*/;
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x79
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x98
	}

	protected override void Uninit()
	{
		/*Error: Unknown opcode: 0x78*/;
	}

	protected override void ConfigChanged()
	{
		if (!float.IsFinite(4))
		{
			throw new ArithmeticException();
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	private void OnTerritoryChanged(uint _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x74
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x93 0xE9
	}

	private static bool IsContextValid()
	{
		((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCB*/;
	}

	private static bool IsTerritoryTransitioning()
	{
		/*Error: Invalid metadata token*/;
	}

	private void UpdateTimer()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD0
	}

	private void WriteText(string text)
	{
		_ = 5;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private unsafe void BindAddon(AtkUnitBase* addon, AtkTextNode* node)
	{
		/*Error: Unknown opcode: 0xF8*/;
	}

	private bool TryRestore()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x00
	}

	private void ResetRuntimeState()
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	private void ResetAddonState()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x61
	}

	private void ResetDebugState()
	{
		/*Error: Invalid branch target*/;
	}

	private unsafe static AtkUnitBase* GetAddon()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x14
	}

	private unsafe static AtkTextNode* GetTextNode(AtkUnitBase* addon)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x43 0x60
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFD
	}

	public LimitBreakTimerModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x65
	}
}
