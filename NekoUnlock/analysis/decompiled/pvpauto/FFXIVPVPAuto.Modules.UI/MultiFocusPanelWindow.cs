using System.Numerics;
using Dalamud.Bindings.ImGui;
using Dalamud.Interface.Windowing;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.UI;

public sealed class MultiFocusPanelWindow : Window
{
	private static readonly ImGuiWindowFlags WindowFlags;

	private static readonly Vector4 PanelBackgroundColor;

	private static readonly Vector4 EntryHoverColor;

	private static readonly Vector4 TextColor;

	private static readonly Vector4 DeadTextColor;

	private static readonly Vector4 LostTextColor;

	private static readonly Vector4 HpColor;

	private static readonly Vector4 HpLowColor;

	private static readonly Vector4 CastColor;

	private static readonly Vector4 CastInterruptibleColor;

	private static readonly Vector4 BarBackgroundColor;

	private static readonly Vector4 GameFocusTagColor;

	private const float EntryHeight = 36f;

	private const float BarHeight = 13f;

	private readonly MultiFocusTargetModule _owner;

	public MultiFocusPanelWindow(MultiFocusTargetModule owner)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x1B 0xCE
	}

	public override void PreDraw()
	{
		/*Error: Unknown opcode: 0xAC*/;
	}

	public override void Draw()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x81
	}

	private void DrawEntry(MultiFocusTargetModule.FocusTargetEntry entry, IGameObject? gameFocusTarget, MultiFocusTargetModule.MultiFocusTargetConfig config, ref MultiFocusTargetModule.FocusTargetEntry? toRemove)
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	static MultiFocusPanelWindow()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x60
	}
}
