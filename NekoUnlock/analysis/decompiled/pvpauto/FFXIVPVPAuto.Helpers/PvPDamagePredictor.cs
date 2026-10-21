using System.Collections.Generic;
using FFXIVPVPAuto.Managers;

namespace FFXIVPVPAuto.Helpers;

internal static class PvPDamagePredictor
{
	internal static PvPExecutePrediction Predict(uint actionId, PlayerSnapshot attacker, PlayerSnapshot target, PvPDamageContext context)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x83 0x23
	}

	internal static PvPExecutePrediction Predict(PvPActionDamageRule? rule, PlayerSnapshot attacker, PlayerSnapshot target, PvPDamageContext context)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC4
	}

	private static bool CollectStatusScales(PvPActionDamageRule rule, PvPDamageInput input, PlayerSnapshot player, PvPStatusOwner owner, List<PvPDamageScale> scales)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x97 0xE7
	}

	internal static PvPValueBounds? ShieldFromTruncatedPercent(uint maxHp, byte rawPercent, byte saturation)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA3 0x90
	}
}
