using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Bindings.ImGui;
using Dalamud.Interface.Windowing;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.UI;

public sealed class MultiFocusOverlayWindow : Window
{
	private const uint JobIconBaseId = 62225u;

	private static readonly ImGuiWindowFlags WindowFlags;

	private static readonly Vector4 EdgeColor;

	private static readonly Vector4 HpColor;

	private static readonly Vector4 HpLowColor;

	private static readonly Vector4 CastColor;

	private static readonly Vector4 CastInterruptibleColor;

	private static readonly Vector4 BarBackgroundColor;

	private static readonly Vector4 DeadColor;

	private static readonly Vector4 TargetingYouColor;

	private static readonly Vector4 PartyNameColor;

	private static readonly Vector4 AllianceNameColor;

	private static readonly Vector4 HostileEngagedNameColor;

	private static readonly Vector4 HostileUnengagedNameColor;

	private readonly MultiFocusTargetModule _owner;

	public MultiFocusOverlayWindow(MultiFocusTargetModule owner)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x93 0x8A
	}

	public override void PreDraw()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x39
	}

	public override void Draw()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x3C
	}

	private static Vector4 GetNamePlateColor(IGameObject obj)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF9
	}

	private static Vector2 DrawMarker(ImDrawListPtr drawList, Vector2 center, float markerScale, int index, bool isDead, bool isGameFocus, Vector4 namePlateColor, MultiFocusTargetModule.MultiFocusTargetConfig config, out float topY)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x00
	}

	private static Vector2 DrawNativeTextureMarker(ImDrawListPtr drawList, Vector2 center, float markerScale, int index, bool isDead, bool isGameFocus, Vector4 namePlateColor, TargetCursorMarkerTexture.MarkerTexture texture, MultiFocusTargetModule.MultiFocusTargetConfig config, out float topY)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9D
	}

	private unsafe static Vector2 DrawFocusVMarker(ImDrawListPtr drawList, Vector2 center, float markerScale, int index, bool isDead, bool isGameFocus, MultiFocusTargetModule.MultiFocusTargetConfig config, out float topY)
	{
		//IL_0007: Expected native int or pointer, but got Obj
		checked
		{
			_ = (sbyte)4294967246L;
		}
		_ = *(byte*)(nint)Unsafe.Read<object>((void*)16);
		/*Error near IL_0008: Unknown opcode: 0xCA*/;
	}

	private static void DrawArrowBand(ImDrawListPtr drawList, Vector2 pivot, float scale, Vector2 outerL, Vector2 tip, Vector2 outerR, Vector2 innerR, Vector2 notch, Vector2 innerL, uint color)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x71
	}

	private static Vector2 DrawDiamondMarker(ImDrawListPtr drawList, Vector2 center, int index, bool isDead, bool isGameFocus, MultiFocusTargetModule.MultiFocusTargetConfig config, out float topY)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x81
	}

	private static Vector2 DrawCastBar(ImDrawListPtr drawList, Vector2 cursor, IBattleChara battleChara, MultiFocusTargetModule.MultiFocusTargetConfig config)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x65
	}

	private static Vector2 DrawHpBar(ImDrawListPtr drawList, Vector2 cursor, IBattleChara battleChara, bool isDead, MultiFocusTargetModule.MultiFocusTargetConfig config)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x09
	}

	private void DrawJobIcon(ImDrawListPtr drawList, Vector2 center, uint jobId, float markerSize)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x51
	}

	private static Vector2 DrawStrokedText(ImDrawListPtr drawList, Vector2 cursor, string text, Vector4 color)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5D
	}

	static MultiFocusOverlayWindow()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x40
	}
}
