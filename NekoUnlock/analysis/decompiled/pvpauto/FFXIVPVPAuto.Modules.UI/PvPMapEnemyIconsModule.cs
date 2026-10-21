using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Dalamud.Bindings.ImGui;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Component.GUI;
using FFXIVPVPAuto.Abstracts;
using Lumina.Excel.Sheets;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.UI;

public sealed class PvPMapEnemyIconsModule : ModuleBase, IModuleWindowProvider
{
	private enum TransformMode
	{
		None,
		PairCalibration,
		SingleAnchor,
		Cached
	}

	private sealed class MapNodeSearch
	{
		public uint LocalJobId
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x6F 0x27
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9D
			}
		}

		public List<(uint JobId, Vector2 Center)> JobMarkers
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xFB 0x51
			}
		}

		public Vector2 LocalMarkerCenter
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x89
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB3 0x15
			}
		}

		public bool HasLocalMarker
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x2D
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x3D
			}
		}

		public List<Vector2> LocalMarkerCandidates
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xD5
			}
		}

		public Vector2 LargestNodePos
		{
			[CompilerGenerated]
			get
			{
				//IL_0001: Invalid comparison between Unknown and I4
				if ((int)/*Error near IL_0006: Stack underflow*/ < (int)(uint)/*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0006: Unknown opcode: 0xE8*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x11
			}
		}

		public Vector2 LargestNodeSize
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC4
			}
			[CompilerGenerated]
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0003: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_0003: Stack underflow*/ <= /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/)
				{
					checked
					{
						_ = /*Error near IL_0004: Stack underflow*/* /*Error near IL_0004: Stack underflow*/;
						/*Error near IL_0004: Unknown opcode: 0xF5*/;
					}
				}
				/*Error near IL_000f: Unknown opcode: 0xEB*/;
			}
		}

		public unsafe bool HasLargestNode
		{
			get
			{
				_ = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Unknown opcode: 0x77*/;
			}
		}

		public int ImageNodeCount
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x0F 0xFD
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x63 0xFA
			}
		}

		public MapNodeSearch()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x7B 0xF1
		}
	}

	private sealed class Config
	{
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xD0
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x2C
			}
		}

		public float IconSize
		{
			[CompilerGenerated]
			get
			{
				_ = 3;
				/*Error near IL_0001: Unknown opcode: 0xAF*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9F 0x02
			}
		}

		public int JobIconStyle
		{
			[CompilerGenerated]
			get
			{
				_ = 2.1246609744797082E-130;
				/*Error near IL_0009: Read out of bounds.*/;
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x5F 0x93
			}
		}

		public bool ShowDeadEnemies
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB4
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x20
			}
		}

		public bool Debug
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x38
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x24
			}
		}

		public Config()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC5
		}
	}

	private sealed class EnemyIconsWindow : Window
	{
		public EnemyIconsWindow(PvPMapEnemyIconsModule owner)
		{
			/*Error: Invalid metadata token*/;
		}

		public override void PreDraw()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE0
		}

		public override void Draw()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x07 0xC7
		}
	}

	private static readonly uint[] JobIconBaseIds;

	private static readonly TimeSpan DebugLogInterval;

	private readonly EnemyIconsWindow _window;

	private Config _config;

	private float _mapScale;

	private Vector2 _mapOffset;

	private bool _hasTransform;

	private uint _lastTerritoryType;

	private uint _lastMapId;

	private nint _lastPvPMapAddonAddress;

	private nint _lastPvPMapRootNodeAddress;

	private nint _lastPvPMapNodeListAddress;

	private bool _wasPvPMapUsable;

	private bool? _lastLocalPlayerDead;

	private int _lastCalibScore;

	private int _debugLine;

	private DateTime _nextDebugLogTime;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x60
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			/*Error: Read out of bounds.*/;
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid local signature token: 0x367630D1
		}
	}

	public PvPMapEnemyIconsModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x8F 0xE0
	}

	public IReadOnlyList<Window> GetWindows()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x91
	}

	protected override void Init()
	{
		/*Error: Unknown opcode: 0xF3*/;
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9C
	}

	private void OnUpdate(IFramework _)
	{
		int num = 6;
		/*Error near IL_0001: Invalid branch target*/;
	}

	private void OnTerritoryChanged(uint _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x03 0xCD
	}

	private void ResetTransformState()
	{
		/*Error: Invalid metadata token*/;
	}

	private void InvalidateTransform()
	{
		checked
		{
			_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA1
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x14
	}

	private void DumpNodeTree()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x98
	}

	private unsafe static void DumpNodes(AtkUldManager* uldManager, Vector2 baseOffset, int depth, StringBuilder sb)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xAB 0x7B
	}

	private unsafe void DrawOverlay()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
	}

	private bool IsContextValid()
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	private unsafe void UpdatePvPMapLifecycle(AtkUnitBase* addon, bool usable)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x63 0x46
	}

	private TransformMode ResolveTransform(MapNodeSearch search, Vector2 localTexPos, IReadOnlyList<(uint JobId, Vector2 Tex)> players, bool localPlayerIsDead)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB9
	}

	private void ApplyTransform(float scale, Vector2 offset)
	{
		_ = (ushort)/*Error near IL_0001: Stack underflow*/;
		/*Error: End of method reached without returning.*/;
	}

	private List<(uint JobId, Vector2 Tex)> CollectPlayers(IPlayerCharacter localPlayer, Map map)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2B 0xAB
	}

	private void DrawEnemyIcon(ImDrawListPtr drawList, Vector2 pos, uint jobId, uint jobIconBaseId, bool isDead)
	{
		/*Error: Empty body found. Decompiled assembly might be a reference assembly.*/;
	}

	private unsafe static void ScanNodes(AtkUldManager* uldManager, Vector2 baseOffset, Vector2 baseScale, MapNodeSearch search)
	{
		/*Error: Empty body found. Decompiled assembly might be a reference assembly.*/;
	}

	private unsafe static bool TryGetJobIconId(AtkImageNode* imageNode, out uint jobId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6B 0x17
	}

	private unsafe static uint? TryGetIconId(AtkImageNode* imageNode)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE3 0x5E
	}

	private void DrawDebugText(string text)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0xF22B4DB4
	}

	private void LogDebugThrottled(string message)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBB 0x1E
	}

	private unsafe static AtkUnitBase* GetPvPMapAddon()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE8
	}

	static PvPMapEnemyIconsModule()
	{
		checked
		{
			_ = (long)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}
}
