namespace FFXIVPVPAuto.Verification;

internal abstract class VerifyClientBase
{
	protected const ushort PLUGIN_ID = 1006;

	internal abstract void Init();

	internal abstract void Uninit();

	protected VerifyClientBase()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x3B 0x8F
	}
}
