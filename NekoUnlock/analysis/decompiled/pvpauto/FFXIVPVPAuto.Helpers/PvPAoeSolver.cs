using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace FFXIVPVPAuto.Helpers;

internal static class PvPAoeSolver
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public PvPAoeRequest request;

		public PvPAoeGeometry geometry;

		public _003C_003Ec__DisplayClass5_0()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFF 0x54
		}

		internal bool _003CGroundCenters_003Eb__0(PvPAoeEnemy enemy)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x30
		}
	}

	[CompilerGenerated]
	private sealed class _003CEnumeratePlans_003Ed__4 : IEnumerable<PvPAoePlan>, IEnumerable, IEnumerator<PvPAoePlan>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private PvPAoePlan _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private PvPAoeRequest request;

		public PvPAoeRequest _003C_003E3__request;

		private PvPAoeGeometry _003Cgeometry_003E5__2;

		private List<float> _003Cangles_003E5__3;

		private IEnumerator<Vector3> _003C_003E7__wrap3;

		private IEnumerator<PvPAoeEnemy> _003C_003E7__wrap4;

		private int _003Ci_003E5__6;

		private float _003Cangle_003E5__7;

		private float _003Cnext_003E5__8;

		PvPAoePlan IEnumerator<PvPAoePlan>.Current
		{
			[DebuggerHidden]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x14
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x87 0xA1
			}
		}

		[DebuggerHidden]
		public _003CEnumeratePlans_003Ed__4(int _003C_003E1__state)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xAB 0x6B
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9B 0xEE
		}

		private bool MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3F 0x5F
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB9
		}

		private void _003C_003Em__Finally2()
		{
			/*Error: Invalid metadata token*/;
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			//IL_0005: Invalid comparison between Unknown and I4
			if ((int)/*Error near IL_000a: Stack underflow*/ >= -336651276)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_000a: Unknown opcode: 0xC7*/;
		}

		[DebuggerHidden]
		IEnumerator<PvPAoePlan> IEnumerable<PvPAoePlan>.GetEnumerator()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x37 0x97
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x53 0x98
		}
	}

	[CompilerGenerated]
	private sealed class _003CGroundCenters_003Ed__5 : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Vector3 _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private PvPAoeRequest request;

		public PvPAoeRequest _003C_003E3__request;

		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		private Vector2 _003Corigin_003E5__2;

		private IEnumerator<Vector2> _003C_003E7__wrap2;

		Vector3 IEnumerator<Vector3>.Current
		{
			[DebuggerHidden]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC3 0xCB
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xF9
			}
		}

		[DebuggerHidden]
		public _003CGroundCenters_003Ed__5(int _003C_003E1__state)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF8
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			if (/*Error near IL_0002: Stack underflow*/ < /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = ((long[])/*Error near IL_0004: Stack underflow*/)[checked((short)/*Error near IL_0003: Stack underflow*/)];
			/*Error: End of method reached without returning.*/;
		}

		private bool MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x09
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x95
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			if (/*Error near IL_0002: Stack underflow*/ > /*Error near IL_0002: Stack underflow*/)
			{
				/*Error near IL_0002: Invalid metadata token*/;
			}
		}

		[DebuggerHidden]
		IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x10
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x8C
		}
	}

	private const float Epsilon = 0.0001f;

	internal static bool TryFindBestPlan(PvPAoeRequest request, out PvPAoePlan best, Func<PvPAoePlan, bool>? isLegalPlan = null)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0xD7ED18A2
	}

	internal static int CountHits(PvPAoeRequest request, PvPAoePlan plan)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB9
	}

	internal static bool Contains(PvPAoeGeometry geometry, Vector3 origin, PvPAoePlan plan, Vector3 position)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x71
	}

	[IteratorStateMachine(typeof(_003CEnumeratePlans_003Ed__4))]
	private static IEnumerable<PvPAoePlan> EnumeratePlans(PvPAoeRequest request)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB5
	}

	[IteratorStateMachine(typeof(_003CGroundCenters_003Ed__5))]
	private static IEnumerable<Vector3> GroundCenters(PvPAoeRequest request)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD7 0xC1
	}

	private static void AddCircleIntersections(List<Vector2> output, Vector2 a, float radiusA, Vector2 b, float radiusB)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x33 0x94
	}

	private static bool IsBetter(PvPAoeRequest request, PvPAoePlan candidate, PvPAoePlan best)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x8C
	}

	private static void AddPair(List<float> angles, float angle, float offset)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5C
	}

	internal static float Turn(float from, float to)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x90
	}

	internal static bool IsFinite(Vector3 value)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2C
	}

	private static Vector2 Horizontal(Vector3 value)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x45
	}

	private static float Normalize(float angle)
	{
		/*Error: Unknown opcode: 0xBF*/;
	}
}
