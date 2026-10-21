using System.Numerics;

namespace FFXIVPVPAuto.Helpers;

internal static class LineOfSight
{
	private const float EyeHeightYalms = 1.7f;

	private const float MinRaySq = 0.01f;

	private const int VisionBlockingMaterialMask = 16384;

	internal static bool IsVisible(Vector3 fromGround, Vector3 toGround, bool onUnavailable = true)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFD
	}
}
