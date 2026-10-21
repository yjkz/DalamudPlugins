using System.Numerics;
using System.Runtime.CompilerServices;

namespace FFXIVPVPAuto.Helpers;

internal sealed class DancerLbDiagnostics
{
	internal const int ObservationWindowMs = 2000;

	private ulong _actorId;

	private long _startedAt;

	private long _lastUpdatedAt;

	private Vector3 _origin;

	private Vector3 _forward;

	internal unsafe bool HasObservation
	{
		[CompilerGenerated]
		get
		{
			checked
			{
				_ = unchecked((uint)checked((short)Unsafe.Read<object>(unchecked((void*)(int)((uint[])(-6.4177644E-27f))[/*Error near IL_0005: ldarg 3 (out-of-bounds)*/])))) * 2u;
				/*Error near IL_000b: Unknown opcode: 0xCE*/;
			}
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x15
		}
	}

	internal bool HasValidOrigin
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x88
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x51
		}
	}

	internal bool HasPost
	{
		[CompilerGenerated]
		get
		{
			/*Error: Unknown opcode: 0xCA*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x47 0x58
		}
	}

	internal unsafe bool Observing
	{
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_ = 6 & /*Error near IL_0001: ldloc 3 (out-of-bounds)*/;
			_ = *(double*)(nint)/*Error near IL_0003: ldloc 0 (out-of-bounds)*/ >> 0;
			/*Error near IL_000f: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0010: Not a type handle*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x8B 0xD0
		}
	}

	internal int PreCount
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xEC
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x08
		}
	}

	internal int PostCount
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE5
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB8
		}
	}

	internal int InputCount
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB8
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE1
		}
	}

	internal bool PostReturn
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x41
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xFC
		}
	}

	internal float CurrentForwardDistance
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x39
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x13 0x03
		}
	}

	internal float CurrentHorizontalDistance
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3F 0x84
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5F 0x66
		}
	}

	internal unsafe float MaxForwardDistance
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE3 0xF4
		}
		[CompilerGenerated]
		private set
		{
			_ = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid field token*/;
		}
	}

	internal float MaxHorizontalDistance
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x98
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC7 0xB8
		}
	}

	internal int ElapsedMs
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3B 0x9C
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3C
		}
	}

	internal ushort Sequence
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD7 0x1F
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9F 0x11
		}
	}

	internal void RecordPre(ulong actorId, ushort sequence, Vector3 position, float rotation, long now)
	{
		_ = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Invalid branch target*/;
	}

	internal void RecordPost(ulong actorId, ushort sequence, bool result, long now)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7C
	}

	internal void RecordInput()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC9
	}

	internal void Update(Vector3 position, long now)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFB 0x25
	}

	internal void Reset()
	{
		/*Error: Unknown opcode: 0xA8*/;
	}

	private bool AdvanceTime(long now)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x30
	}

	private static int Increment(int value)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFF 0x18
	}

	private static bool IsFinite(Vector3 value)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public DancerLbDiagnostics()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0005: Stack underflow*/ >= checked(/*Error near IL_0003: Stack underflow*/ - /*Error near IL_0003: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Unknown opcode: 0xB2*/;
	}
}
