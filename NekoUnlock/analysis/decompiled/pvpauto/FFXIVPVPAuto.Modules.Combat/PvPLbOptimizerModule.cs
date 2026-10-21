using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Managers;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.Combat;

public sealed class PvPLbOptimizerModule : ModuleBase
{
	private sealed class PvPLbOptimizerConfig
	{
		public bool EnableDarkKnight
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xCF 0x5D
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0xAF*/;
			}
		}

		public bool EnableWarrior
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x85
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC9
			}
		}

		public int MinimumEnemies
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x23 0xEB
			}
			[CompilerGenerated]
			set
			{
				/*Error: Read out of bounds.*/;
			}
		}

		public int DarkKnightMode
		{
			[CompilerGenerated]
			get
			{
				/*Error: Unknown opcode: 0xF0*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xDC
			}
		}

		public int WarriorMode
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x57 0xD9
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC4
			}
		}

		public bool ShowLogs
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x65
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x14
			}
		}

		public PvPLbOptimizerConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA8
		}
	}

	[CompilerGenerated]
	private sealed class _003CEnumerateEnemies_003Ed__22 : IEnumerable<PlayerSnapshot>, IEnumerable, IEnumerator<PlayerSnapshot>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private PlayerSnapshot _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private float range;

		public float _003C_003E3__range;

		private Vector3 origin;

		public Vector3 _003C_003E3__origin;

		private float _003CrangeSquared_003E5__2;

		private IEnumerator<PlayerSnapshot> _003C_003E7__wrap2;

		PlayerSnapshot IEnumerator<PlayerSnapshot>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Unknown opcode: 0xEC*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x28
			}
		}

		[DebuggerHidden]
		public _003CEnumerateEnemies_003Ed__22(int _003C_003E1__state)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x57 0x79
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			/*Error: Invalid branch target*/;
		}

		private bool MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBF 0xEA
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xAB 0x77
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			/*Error: Unknown opcode: 0xC8*/;
		}

		[DebuggerHidden]
		IEnumerator<PlayerSnapshot> IEnumerable<PlayerSnapshot>.GetEnumerator()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA8
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB0
		}
	}

	private const uint DarkKnightJobId = 32u;

	private const uint WarriorJobId = 21u;

	private const uint ActionEventide = 29518u;

	private const uint ActionPrimalScream = 29083u;

	private PvPLbOptimizerConfig _config;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1D
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA3 0x93
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x97 0xE9
		}
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA4
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x84
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE1
	}

	private void OnPreUseAction(ref bool isPrevented, ref ActionType actionType, ref uint actionID, ref ulong targetID, ref uint extraParam, ref UseActionMode queueState, ref uint comboRouteID)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2D
	}

	private void HandleDarkKnight(ref bool isPrevented, ref ulong targetID)
	{
		_ = ((double[])/*Error near IL_0002: Stack underflow*/)[3];
		/*Error: End of method reached without returning.*/;
	}

	private void HandleWarrior(ref bool isPrevented, ref ulong targetID)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAF 0x65
	}

	private (PlayerSnapshot? target, int hitCount) FindBestDarkKnightTarget(IGameObject localPlayer)
	{
		_ = 3L;
		/*Error near IL_0002: Unknown opcode: 0xCD*/;
	}

	private (PlayerSnapshot? target, int hitCount) FindBestWarriorTarget(IGameObject localPlayer)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private int CollectEnemies(Vector3 origin, float range)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x44
	}

	[IteratorStateMachine(typeof(_003CEnumerateEnemies_003Ed__22))]
	private IEnumerable<PlayerSnapshot> EnumerateEnemies(Vector3 origin, float range)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF5
	}

	private static int CountEnemiesInCircle(Vector3 center, float radius)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x71
	}

	private int CountEnemiesInSector(PlayerSnapshot candidate, Vector3 origin, float sectorAngle, float range)
	{
		/*Error: Unknown opcode: 0xAF*/;
	}

	private static bool IsWithinFacingAngle(Vector3 playerPos, float playerRotation, Vector3 targetPos, float maxAngleDegrees)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7B 0xB7
	}

	private unsafe void DrawConfig(ref bool hasChanged)
	{
		//IL_0001: Invalid comparison between Unknown and I
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if ((nint)/*Error near IL_0006: Stack underflow*/ <= (nint)(*(IntPtr*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0008: Stack underflow*/* (nint)((Array)/*Error near IL_0007: Stack underflow*/).LongLength;
		/*Error near IL_0008: Unknown opcode: 0xAE*/;
	}

	public PvPLbOptimizerModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7B 0x8E
	}
}
