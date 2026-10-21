using System;
using System.Collections.Generic;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Config;

namespace FFXIVPVPAuto.Helpers;

internal static class QuickToggleRules
{
	internal const int MaxEntries = 24;

	internal static List<QuickToggleEntry> Normalize(IEnumerable<QuickToggleEntry>? entries, Func<string, bool> moduleExists)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x39
	}

	internal static QuickToggleEntry? Find(List<QuickToggleEntry>? entries, string moduleName)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x3B 0x13
	}

	internal static bool SetPlacement(List<QuickToggleEntry> entries, string moduleName, bool showInMiniPanel, bool showInServerBar)
	{
		checked
		{
			_ = (long)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Read out of bounds.*/;
		}
	}

	internal static bool SetLabel(List<QuickToggleEntry> entries, string moduleName, string? label)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xED
	}

	internal static bool Move(List<QuickToggleEntry> entries, string moduleName, int offset)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x47 0x2F
	}

	internal static bool IsBlocked(ModulePermission permission, bool authorized, bool testCodeAuthorized)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2D
	}

	internal static string ResolveLabel(string? label, string fallbackTitle)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x25
	}

	internal static string BuildServerBarText(string label, bool enabled, string stateOn, string stateOff)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x8D
	}

	internal static int CountRows(IReadOnlyList<float> widths, float availableWidth, float spacing)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC8
	}
}
