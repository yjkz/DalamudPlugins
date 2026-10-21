using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dalamud.Game.Gui.Dtr;
using FFXIVPVPAuto.Abstracts;

namespace FFXIVPVPAuto.Managers;

[ManagerInitOrder(4)]
internal sealed class ServerBarManager : ManagerBase
{
	private readonly Dictionary<string, IDtrBarEntry> _entries;

	internal static ServerBarManager? Instance
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC7 0xB1
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD9
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x67 0xB6
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9B 0x00
	}

	internal void RequestSync()
	{
		((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (IntPtr)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xC4*/;
	}

	private void Sync()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x75
	}

	private IDtrBarEntry GetOrCreateEntry(string moduleName)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5B 0xBB
	}

	private static string BuildTooltip(ModuleManager.ModuleDescriptor descriptor, string title)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0F 0xB6
	}

	private void ToggleFromServerBar(ModuleManager.ModuleDescriptor descriptor)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF8
	}

	public ServerBarManager()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x8B 0x7B
	}
}
