using System.Collections.Generic;

namespace FFXIVPVPAuto.Helpers;

internal static class PvPPurifyRules
{
	internal const uint BlotaActionId = 29081u;

	internal const uint WindsReplyActionId = 41509u;

	internal const uint SaltedEarthActionId = 29094u;

	internal static readonly uint[] SaltAndDarknessActionIds;

	internal static readonly uint[] PurifiableStatusPresets;

	internal static readonly uint[] SkillTriggerPresets;

	internal static readonly uint[] DefaultSkillTriggerActionIds;

	internal static bool IsTargetedSpecialSkillTrigger(uint actionId, bool targetedAtLocalPlayer, bool fastBlota, bool fastWindsReply)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6C
	}

	internal static bool IsNearbySkillTrigger(uint actionId, IReadOnlySet<uint> triggerActionIds, bool nearbyOpponent)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF0
	}

	static PvPPurifyRules()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF3 0x45
	}
}
