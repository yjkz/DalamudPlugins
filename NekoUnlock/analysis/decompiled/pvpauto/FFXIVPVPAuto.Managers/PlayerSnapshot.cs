using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace FFXIVPVPAuto.Managers;

internal sealed class PlayerSnapshot
{
	private readonly PlayerStatusSnapshot[] _statuses;

	internal ulong GameObjectId
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9D
		}
	}

	internal uint EntityId
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3C
		}
	}

	internal ulong ContentId
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x65
		}
	}

	internal string Name
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x2F 0xEE
		}
	}

	internal uint JobId
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x80
		}
	}

	internal Vector3 Position
	{
		[CompilerGenerated]
		get
		{
			_ = null;
			/*Error near IL_0001: Unknown opcode: 0xCD*/;
		}
	}

	internal float Rotation
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF3 0xC1
		}
	}

	internal float Height
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x7F 0xEB
		}
	}

	internal uint CurrentHp
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xCF 0x8F
		}
	}

	internal uint MaxHp
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x80
		}
	}

	internal bool IsDead
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x7B 0x18
		}
	}

	internal bool IsTargetable
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xEF 0xC3
		}
	}

	internal bool IsEnemy
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xEF 0xEA
		}
	}

	internal ulong TargetObjectId
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x37 0x1D
		}
	}

	internal byte Battalion
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x48
		}
	}

	internal bool IsFriend
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE8
		}
	}

	internal bool IsPartyMember
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x33 0x57
		}
	}

	internal bool IsAllianceMember
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xAF 0xD3
		}
	}

	internal byte ShieldPercentage
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x7F 0xCA
		}
	}

	internal bool StatusesComplete
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x68
		}
	}

	internal long CapturedAtTick
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB5
		}
	}

	internal float HitboxRadius
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x8C
		}
	}

	internal long CaptureSequence
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE9
		}
	}

	internal ReadOnlySpan<PlayerStatusSnapshot> Statuses
	{
		get
		{
			((short[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = checked((sbyte)(-1221203779));
			if (/*Error near IL_000c: Stack underflow*/ < /*Error near IL_000c: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_000c: Read out of bounds.*/;
		}
	}

	internal PlayerSnapshot(ulong gameObjectId, uint entityId, ulong contentId, string name, uint jobId, Vector3 position, float rotation, float height, uint currentHp, uint maxHp, bool isDead, bool isTargetable, bool isEnemy, ulong targetObjectId, byte battalion, bool isFriend, bool isPartyMember, bool isAllianceMember, PlayerStatusSnapshot[] statuses, byte shieldPercentage = 0, bool statusesComplete = true, long capturedAtTick = 0L, float hitboxRadius = 0f, long captureSequence = 0L)
	{
		/*Error: Invalid branch target*/;
	}

	internal bool TryGetStatus(uint statusId, out PlayerStatusSnapshot result)
	{
		if (/*Error near IL_0001: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error: End of method reached without returning.*/;
	}

	internal bool HasStatus(uint statusId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5D
	}

	internal bool HasAnyStatus(IReadOnlySet<uint> statusIds)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9B 0x0B
	}

	internal bool TryFindStatus(IReadOnlySet<uint> statusIds, out uint statusId)
	{
		/*Error: Invalid metadata token*/;
	}

	internal bool HasStatusFrom(uint statusId, ulong sourceGameObjectId, uint sourceEntityId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBD
	}
}
