using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dalamud.Interface.Windowing;
using FFXIVPVPAuto.Abstracts;

namespace FFXIVPVPAuto.Managers;

[ManagerInitOrder(4)]
internal sealed class ModuleUiManager : ManagerBase
{
	private readonly Dictionary<string, List<Window>> _moduleWindows;

	private readonly Dictionary<string, IModuleOverlayProvider> _moduleOverlays;

	internal static ModuleUiManager? Instance
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF5
		}
		[CompilerGenerated]
		private set
		{
			throw /*Error near IL_0001: Stack underflow*/;
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x70
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x31
	}

	internal bool HasWindow(ModuleManager.ModuleDescriptor descriptor)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9B 0xF6
	}

	internal bool HasOverlay(ModuleManager.ModuleDescriptor descriptor)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x54
	}

	internal bool IsWindowOpen(string moduleName)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2F 0x0A
	}

	internal bool IsOverlayOpen(string moduleName)
	{
		/*Error near IL_0001: Read out of bounds.*/;
	}

	internal void SetWindowOpen(ModuleManager.ModuleDescriptor descriptor, bool open)
	{
		/*Error: Invalid metadata token*/;
	}

	internal void SetOverlayOpen(ModuleManager.ModuleDescriptor descriptor, bool open)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x81
	}

	private void OnModulesChanged()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xE5*/;
	}

	private unsafe void RegisterModuleUi(ModuleManager.ModuleDescriptor descriptor, WindowSystem? windowSystem)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0006: Stack underflow*/ >= 1)
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(sbyte*)(nint)/*Error near IL_0007: Stack underflow*/;
		/*Error: End of method reached without returning.*/;
	}

	private void UnregisterModuleUi(string moduleName, WindowSystem? windowSystem)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD3 0x7A
	}

	private void ClearAll()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x4D
	}

	private void DrawOverlays()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0B 0x2D
	}

	private static void EnsureConfigEntry(Dictionary<string, bool> dict, string key, bool defaultValue)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD0
	}

	public ModuleUiManager()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC4
	}
}
