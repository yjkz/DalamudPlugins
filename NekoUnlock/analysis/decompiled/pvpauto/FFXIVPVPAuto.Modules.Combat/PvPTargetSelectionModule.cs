using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Plugin.Services;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Managers;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.Combat;

public sealed class PvPTargetSelectionModule : ModuleBase
{
	private sealed class PvPTargetSelectionConfig
	{
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x75
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x45
			}
		}

		public bool AutoSetHardTarget
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9D
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC4
			}
		}

		public bool OnlySelectLowHp
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xFB 0x79
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x73 0xED
			}
		}

		public bool OnlySelectInLineOfSight
		{
			[CompilerGenerated]
			get
			{
				/*Error: Invalid metadata token*/;
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0x78*/;
			}
		}

		public bool ExcludeProtectedTargets
		{
			[CompilerGenerated]
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Unknown opcode: 0xC0*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x59
			}
		}

		public bool AvoidChitenTargets
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA4
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x50
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x44
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0xCA*/;
			}
		}

		public float TargetRange
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x94
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9C
			}
		}

		public float TargetHpPercent
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x2B 0xF3
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA1
			}
		}

		public int UpdateIntervalMs
		{
			[CompilerGenerated]
			get
			{
				/*Error: Invalid metadata token*/;
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0xE4*/;
			}
		}

		public PvPTargetSelectionConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x6B 0x62
		}
	}

	private PvPTargetSelectionConfig _config;

	private DateTime _nextScanTime;

	private ulong _ownedTargetId;

	private uint _ownedTargetEntityId;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x8D
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x18
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1B 0x2D
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9B 0x4F
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x97 0x25
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB0
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6D
	}

	private PlayerSnapshot? FindBestTarget(Vector3 localPosition, ulong excludedTargetId = 0uL)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAC
	}

	private bool CanSelect(PlayerSnapshot player, Vector3 localPosition)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF1
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
		_ = ~/*Error near IL_0001: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0003: Unknown opcode: 0xE4*/;
	}

	private void OnExternalHardTarget(bool result, IGameObject? target, bool ignoreTargetModes, bool a4, int a5)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE1
	}

	private void ClearOwnedChitenTarget()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFC
	}

	private void ForgetOwnedTarget()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB7 0x5A
	}

	public unsafe PvPTargetSelectionModule()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/));
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[checked((short)/*Error near IL_0003: Stack underflow*/)] = 0;
		/*Error near IL_0005: Unknown opcode: 0xEE*/;
	}
}
