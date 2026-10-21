using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.Game.Object;
using FFXIVPVPAuto.Abstracts;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.UI;

public sealed class DancerLbRangeModule : ModuleBase, IModuleWindowProvider
{
	private sealed class DancerLbRangeConfig
	{
		public bool ShowRange
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x3C
			}
			[CompilerGenerated]
			set
			{
				/*Error near IL_0001: Not a type handle*/;
			}
		}

		public float RangeRadiusMeters
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xED
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x50
			}
		}

		internal void Normalize()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD0
		}

		public DancerLbRangeConfig()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
			/*Error: End of method reached without returning.*/;
		}
	}

	private const long DisplayWindowMs = 2000L;

	private DancerLbRangeConfig _config;

	private DancerLbRangeOverlayWindow? _window;

	private bool _registered;

	private ulong _actorId;

	private uint _entityId;

	private ushort _sequence;

	private bool _hasSequence;

	private long _expiresAt;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x8F 0x14
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3D
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x38
		}
	}

	internal bool IsActive
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x10
		}
	}

	public IReadOnlyList<Window> GetWindows()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x87 0x92
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE4
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x50
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC4
	}

	private void Cleanup()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x93 0xC5
	}

	private bool IsContextValid()
	{
		((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (short)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xEB*/;
	}

	internal bool TryGetRangeOverlayData(out Vector3 center, out float radius)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA1
	}

	private static bool IsDancerLb(IBattleChara player, ActionType type, uint actionId, uint spellId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB4
	}

	private bool TryGetActorPosition(out Vector3 position)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x44
	}

	private void OnPreCharacterCompleteCast(ref bool isPrevented, ref IBattleChara player, ref ActionType type, ref uint actionId, ref uint spellId, ref GameObjectId animationTargetId, ref Vector3 location, ref float rotation, ref short lastUsedActionSequence, ref int animationVariation, ref int ballistaEntityId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCB 0x7B
	}

	private void OnPostCharacterCompleteCast(bool result, IBattleChara player, ActionType type, uint actionId, uint spellId, GameObjectId animationTargetId, Vector3 location, float rotation, short lastUsedActionSequence, int animationVariation, int ballistaEntityId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x75
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5C
	}

	private void ClearActive()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x31
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x30
	}

	public DancerLbRangeModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x77 0x4E
	}
}
