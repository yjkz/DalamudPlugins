using System.Runtime.CompilerServices;
using FFXIVPVPAuto.Abstracts;
using OmenTools.Interop.Game;

namespace FFXIVPVPAuto.Modules.TestCode;

public sealed class IgnoreActionTargetBlockedModule : ModuleBase
{
	private const string TargetBlockedSignature = "75 ?? B8 ?? ?? ?? ?? EB ?? 41 81 FE";

	private MemoryPatch? _targetBlockedPatch;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x54
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA4
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE9
	}

	protected override void Uninit()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public unsafe IgnoreActionTargetBlockedModule()
	{
		//IL_0002: Expected I4, but got I8
		*(short*)(nint)/*Error near IL_0002: Stack underflow*/ = (short)(*(long*)(nint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xE4*/;
	}
}
