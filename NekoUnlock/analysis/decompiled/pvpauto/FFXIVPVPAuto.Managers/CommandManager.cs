using FFXIVPVPAuto.Abstracts;

namespace FFXIVPVPAuto.Managers;

[ManagerInitOrder(2)]
internal sealed class CommandManager : ManagerBase
{
	private const string MainCommand = "/pvpauto";

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7D
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCF 0xE1
	}

	private static void OnMainCommand(string command, string arguments)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x95
	}

	public CommandManager()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAC
	}
}
