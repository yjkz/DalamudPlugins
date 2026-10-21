using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Hooking;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.Game.Character;
using FFXIVClientStructs.FFXIV.Client.Game.Object;
using FFXIVPVPAuto.Abstracts;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Managers;

[ManagerInitOrder(2)]
internal sealed class ActionEffectManager : ManagerBase
{
	private unsafe delegate void ReceiveDelegate(uint casterEntityId, Character* casterPtr, Vector3* targetPos, Header* header, TargetEffects* effects, GameObjectId* targetEntityIds);

	public delegate void PreActionEffectDelegate(ref bool isPrevented, ref uint sourceEntityId, ref IBattleChara source, ref ActionType actionType, ref uint actionId, ref uint spellId, ref ulong targetId, ref Vector3 location, ref byte targetCount);

	public delegate void PostActionEffectDelegate(uint sourceEntityId, IBattleChara source, ActionType actionType, uint actionId, uint spellId, ulong targetId, Vector3 location, byte targetCount, IReadOnlyList<ulong> effectTargetIds);

	private static Hook<ReceiveDelegate>? ReceiveHook;

	private readonly ConcurrentDictionary<Type, ImmutableList<Delegate>> methodsCollection;

	public static ActionEffectManager? Instance
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x08
		}
		[CompilerGenerated]
		private set
		{
			/*Error: Read out of bounds.*/;
		}
	}

	internal static bool IsUsableLocation(Vector3 location)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6B 0x12
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Read out of bounds.
	}

	private unsafe void ReceiveDetour(uint casterEntityId, Character* casterPtr, Vector3* targetPos, Header* header, TargetEffects* effects, GameObjectId* targetEntityIds)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x30
	}

	private unsafe static ulong[] ReadEffectTargetIds(GameObjectId* targetEntityIds, byte targetCount)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDF 0x1F
	}

	private unsafe bool RegisterGeneric<T>(T method, params T[] methods) where T : Delegate
	{
		//IL_0002: Expected native int or pointer, but got Obj
		/*Error: stloc 3 (out-of-bounds)*/;
		_ = *(short*)(nint)methods;
		/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xC1*/;
	}

	private bool UnregisterGeneric<T>(params T[] methods) where T : Delegate
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEB 0xD6
	}

	public bool RegPreActionEffect(PreActionEffectDelegate method, params PreActionEffectDelegate[] methods)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = (short)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Unknown opcode: 0xAF*/;
	}

	public bool RegPostActionEffect(PostActionEffectDelegate method, params PostActionEffectDelegate[] methods)
	{
		/*Error: Not a type handle*/;
	}

	public bool Unreg(params PreActionEffectDelegate[] methods)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x51
	}

	public bool Unreg(params PostActionEffectDelegate[] methods)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0F 0xFD
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xDF 0x89
	}

	public ActionEffectManager()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0002: Stack underflow*/ > /*Error near IL_0002: Stack underflow*/)
		{
			((long[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (long)/*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
			/*Error near IL_0005: Not a type handle*/;
		}
		_ = /*Error near IL_0007: Stack underflow*// /*Error near IL_0007: Stack underflow*/;
		/*Error near IL_0007: stloc 56 (out-of-bounds)*/;
		((short[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = checked((byte)(-7900085364347119332L));
		((float[])/*Error near IL_0015: Stack underflow*/)[/*Error near IL_0015: Stack underflow*/] = (float)/*Error near IL_0015: Stack underflow*/;
		_ = /*Error near IL_0016: Stack underflow*/% /*Error near IL_0016: Stack underflow*/;
		/*Error near IL_0016: Unknown opcode: 0xB1*/;
	}
}
