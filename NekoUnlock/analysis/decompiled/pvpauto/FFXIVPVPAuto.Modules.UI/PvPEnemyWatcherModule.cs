using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Dalamud.Bindings.ImGui;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin.Services;
using FFXIVPVPAuto.Abstracts;
using FFXIVPVPAuto.Managers;

namespace FFXIVPVPAuto.Modules.UI;

public sealed class PvPEnemyWatcherModule : ModuleBase, IModuleWindowProvider
{
	private sealed class EnemyWatcherWindow : Window
	{
		private static readonly ImGuiWindowFlags WindowFlags;

		private readonly PvPEnemyWatcherModule _owner;

		public EnemyWatcherWindow(PvPEnemyWatcherModule owner)
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Invalid metadata token*/;
		}

		public override void PreDraw()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9C
		}

		public override void Draw()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x25
		}

		private void DrawEnemiesTargetingLocal(ImDrawListPtr drawList, PlayerSnapshot localPlayer, PvPEnemyWatcherConfig config)
		{
			/*Error: Unknown opcode: 0xEF*/;
		}

		private static void DrawCurrentTargetLine(ImDrawListPtr drawList, PlayerSnapshot localPlayer, PvPEnemyWatcherConfig config)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xDD
		}

		private void DrawEnemiesTargetingTeammates(ImDrawListPtr drawList, PvPEnemyWatcherConfig config)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x13 0x5F
		}

		private static bool TryWorldToScreen(Vector3 worldPos, out Vector2 screenPos, out bool inView)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x91
		}

		private static Vector2 ClampToViewportEdge(Vector2 point, Vector2 anchor)
		{
			if (/*Error near IL_0001: Stack underflow*/ <= /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = 1;
			/*Error: End of method reached without returning.*/;
		}

		static EnemyWatcherWindow()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC3 0x6E
		}
	}

	private sealed class PvPEnemyWatcherConfig
	{
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x85
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xF5
			}
		}

		public bool ShowEnemyTargetingLocalLines
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x39
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x33 0xFC
			}
		}

		public bool ShowCurrentTargetLine
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x84
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x3C
			}
		}

		public bool ShowTeammateTargetingLines
		{
			[CompilerGenerated]
			get
			{
				/*Error: Unknown opcode: 0xE3*/;
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0xAE*/;
			}
		}

		public bool ShowEnemyTargetingLocalDots
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x45
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x54
			}
		}

		[JsonConverter(typeof(Vector4ColorJsonConverter))]
		public Vector4 EnemyTargetingColor
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x55
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x58
			}
		}

		[JsonConverter(typeof(Vector4ColorJsonConverter))]
		public Vector4 CurrentTargetColor
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8B 0xCE
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x67 0x67
			}
		}

		[JsonConverter(typeof(Vector4ColorJsonConverter))]
		public Vector4 TeammateTargetingColor
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xEC
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x87 0xC5
			}
		}

		public float EnemyTargetingLineThickness
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x20
			}
			[CompilerGenerated]
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				checked
				{
					_ = (ushort)unchecked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
					/*Error near IL_0002: Unknown opcode: 0xBC*/;
				}
			}
		}

		public float CurrentTargetLineThickness
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x40
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xE0
			}
		}

		public float TeammateTargetingLineThickness
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x27 0xE5
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x53 0x26
			}
		}

		public float AlertDotRadius
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC5
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB4
			}
		}

		public bool NormalizeColors()
		{
			/*Error: Unknown opcode: 0xE7*/;
		}

		public PvPEnemyWatcherConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4B 0xC0
		}
	}

	private sealed class TeammateWatchInfo
	{
		public PlayerSnapshot Teammate
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x70
			}
		}

		public List<PlayerSnapshot> Watchers
		{
			[CompilerGenerated]
			get
			{
				/*Error: Invalid metadata token*/;
			}
		}

		public TeammateWatchInfo(PlayerSnapshot teammate)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF5
		}
	}

	private static class CollectionsMarshalShim
	{
		public static TeammateWatchInfo GetOrAdd(Dictionary<ulong, TeammateWatchInfo> dict, ulong key, PlayerSnapshot teammate)
		{
			/*Error: Unknown opcode: 0xC0*/;
		}
	}

	private sealed class Vector4ColorJsonConverter : JsonConverter<Vector4>
	{
		public override Vector4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			// ILSpy could not decompile this. Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// System.ArgumentException: Invalid token. (Parameter 'token')
			//    at System.Reflection.Throw.InvalidToken()
			//    at System.Reflection.Metadata.Ecma335.MetadataTokens.EntityHandle(Int32 token)
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeMetadataToken() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 227
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeFieldReference() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 251
			//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 1227
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 539
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 506
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 726
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2391
		}

		public override void Write(Utf8JsonWriter writer, Vector4 value, JsonSerializerOptions options)
		{
			/*Error: Not a type handle*/;
		}

		public Vector4ColorJsonConverter()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x80
		}
	}

	private readonly EnemyWatcherWindow _window;

	private readonly List<PlayerSnapshot> _watchingEnemies;

	private readonly Dictionary<ulong, TeammateWatchInfo> _teammateWatchers;

	private PvPEnemyWatcherConfig _config;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xCD
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			/*Error: Not a type handle*/;
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xDD
		}
	}

	public PvPEnemyWatcherModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x87 0xD7
	}

	public IReadOnlyList<Window> GetWindows()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x60
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x85
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x75
	}

	protected override void ConfigChanged()
	{
		if (/*Error near IL_0002: Stack underflow*/ != /*Error near IL_0002: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xCD*/;
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x79
	}

	private void OnPlayersAroundUpdated(IReadOnlyList<PlayerSnapshot> players)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBD
	}

	private void OnPlayersTargetingLocalPlayerUpdated(IReadOnlyList<PlayerSnapshot> players)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x20
	}

	private void OnTerritoryChanged(uint _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x47 0x2C
	}

	private void RebuildTeammateSnapshots(IReadOnlyList<PlayerSnapshot> players)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB1
	}

	private bool IsContextValid()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x8D
	}

	private void ClearSnapshots()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC1
	}

	private void DrawConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA4
	}

	private static bool DrawCheckbox(string label, ref bool value)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6D
	}

	private static bool DrawColorEdit(string label, ref Vector4 color)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x48
	}

	private static bool DrawThicknessSlider(string label, ref float thickness)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7C
	}
}
