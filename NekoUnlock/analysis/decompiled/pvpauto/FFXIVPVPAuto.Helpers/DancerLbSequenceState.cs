using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace FFXIVPVPAuto.Helpers;

internal sealed class DancerLbSequenceState
{
	internal const int MaximumWindowMs = 2000;

	internal const int PostWindowMs = 250;

	internal const int NoProgressTimeoutMs = 250;

	internal const float DefaultTargetDistance = 0.1f;

	internal const float MinimumTargetDistance = 0.1f;

	internal const float MaximumTargetDistance = 5f;

	internal const float DirectionPrecision = 0.001f;

	private const double MinimumProgressMeters = 0.001;

	private const int RecentSequenceCapacity = 64;

	private ulong _actorId;

	private ushort _sequence;

	private readonly HashSet<(ulong ActorId, ushort Sequence)> _recentSequences;

	private readonly Queue<(ulong ActorId, ushort Sequence)> _sequenceOrder;

	private bool _inputEmitted;

	private long _startedAt;

	private long _lastCheckedAt;

	private long _lastProgressAt;

	private double _furthestProgress;

	private Vector3 _origin;

	internal DancerLbPhase Phase
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x45
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x58
		}
	}

	internal long ExpiresAt
	{
		[CompilerGenerated]
		get
		{
			switch ((int)/*Error near IL_001f: Stack underflow*/)
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			case 5:
				/*Error: Invalid branch target*/;
			}
		}
		[CompilerGenerated]
		private set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (uint)(/*Error near IL_0001: Stack underflow*/ << unchecked((int)/*Error near IL_0001: Stack underflow*/));
				/*Error near IL_0002: Unknown opcode: 0xAA*/;
			}
		}
	}

	internal long PostExpiresAt
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xBF*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x63 0x60
		}
	}

	internal DancerLbStopReason StopReason
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF0
		}
		[CompilerGenerated]
		private set
		{
			((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xE5*/;
		}
	}

	internal unsafe Vector3 Forward
	{
		[CompilerGenerated]
		get
		{
			/*Error: Read out of bounds.*/;
		}
		[CompilerGenerated]
		private set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			*(int*)(nint)/*Error near IL_0002: Stack underflow*/ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			if (/*Error near IL_0003: Stack underflow*/ % /*Error near IL_0003: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0008: Read out of bounds.*/;
		}
	}

	internal bool InputEmitted
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE9
		}
	}

	internal float TargetDistance
	{
		[CompilerGenerated]
		get
		{
			/*Error: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
		[CompilerGenerated]
		private set
		{
			/*Error: Unknown opcode: 0xC0*/;
		}
	}

	internal unsafe bool TryArm(ulong actorId, ushort sequence, long now, float targetDistance = 0.1f)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF6*/;
	}

	internal bool Matches(ulong actorId, ushort sequence)
	{
		/*Error: Invalid metadata token*/;
	}

	internal bool MatchesActor(ulong actorId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x54
	}

	internal bool TryStartPulse(ulong actorId, ushort sequence, Vector3 origin, float rotation, long now)
	{
		/*Error: Unknown opcode: 0xF3*/;
	}

	internal bool ShouldStop(Vector3 position, long now)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB7 0x07
	}

	internal bool TryGetPulseInput(Vector3 position, long now, out Vector3 worldDirection)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE5
	}

	internal bool IsExpired(long now)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x61
	}

	internal void Cancel()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2B 0xD8
	}

	internal void Reset()
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0xFA3BA1ED
	}

	private bool Stop(DancerLbStopReason reason)
	{
		/*Error: Read out of bounds.*/;
	}

	private static bool IsFinite(Vector3 value)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCF 0xB5
	}

	public DancerLbSequenceState()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7F 0x68
	}
}
