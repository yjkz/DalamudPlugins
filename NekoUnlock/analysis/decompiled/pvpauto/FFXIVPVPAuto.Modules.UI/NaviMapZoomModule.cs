using System.Runtime.CompilerServices;
using FFXIVPVPAuto.Abstracts;
using OmenTools.Interop.Game;
using OmenTools.Interop.Game.Models;

namespace FFXIVPVPAuto.Modules.UI;

public sealed class NaviMapZoomModule : ModuleBase
{
	private sealed class NaviMapZoomConfig
	{
		public float Zoom
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB1
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x87 0x53
			}
		}

		public NaviMapZoomConfig()
		{
			checked
			{
				_ = (uint)((byte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
				/*Error near IL_0002: starg 122 (out-of-bounds)*/;
				/*Error near IL_0004: Unknown opcode: 0x78*/;
			}
		}
	}

	private static readonly CompSig NaviMapZoomOffsetSig;

	private MemoryPatch? _minClampPatch;

	private MemoryPatch? _maxClampPatch;

	private NaviMapZoomConfig _config;

	private int _zoomOffset;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xF4*/;
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3C
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			_ = ((ushort[])/*Error near IL_0006: Stack underflow*/)[((long[])/*Error near IL_0005: Stack underflow*/)[checked((ushort)((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error: ldloca 115 (out-of-bounds)*/])]];
			/*Error near IL_0006: Unknown opcode: 0xCC*/;
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x03 0x1E
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x58
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7B 0x78
	}

	private void DrawConfig(ref bool hasChanged)
	{
		/*Error: Invalid metadata token*/;
	}

	private void ApplyZoom()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7D
	}

	public NaviMapZoomModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB1
	}

	static NaviMapZoomModule()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_002e: Stack underflow*/% /*Error near IL_002e: Stack underflow*/;
		/*Error near IL_002e: Unknown opcode: 0xA7*/;
	}
}
