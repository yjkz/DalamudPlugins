using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.Game.Object;
using FFXIVPVPAuto.Abstracts;
using OmenTools.Dalamud.Services.Game.Object.Abstractions.ObjectKinds;

namespace FFXIVPVPAuto.Modules.UI;

public sealed class MultiFocusTargetModule : ModuleBase, IModuleWindowProvider
{
	internal sealed class FocusTargetEntry
	{
		public ulong GameObjectId
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA0
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA3 0x05
			}
			[CompilerGenerated]
			internal set
			{
				/*Error: Invalid branch target*/;
			}
		}

		public bool IsAutoTracked
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x00
			}
		}

		public unsafe bool IsMarkerEnabled
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xBB 0xA4
			}
			[CompilerGenerated]
			set
			{
				_ = *(ushort*)checked((ulong)/*Error near IL_0001: Stack underflow*/);
				/*Error near IL_0002: starg 178 (out-of-bounds)*/;
				/*Error near IL_0004: starg 13 (out-of-bounds)*/;
				/*Error near IL_0006: Unknown opcode: 0xF7*/;
			}
		}

		public FocusTargetEntry(ulong gameObjectId, string name, bool isAutoTracked)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x59
		}
	}

	internal enum MarkerStyleKind
	{
		Native,
		Diamond,
		GameNative
	}

	internal sealed class MultiFocusTargetConfig
	{
		public int MaxFocusTargets
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x43 0x42
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x59
			}
		}

		public bool OnlyInPvP
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA1
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xE5
			}
		}

		public bool SyncGameFocusTarget
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB9
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xD1
			}
		}

		public bool RefocusWhenLost
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x38
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x6F 0x74
			}
		}

		public bool RemoveWhenDead
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA5
			}
			[CompilerGenerated]
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				_ = /*Error near IL_0001: Stack underflow*/<< (int)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Unknown opcode: 0xB2*/;
			}
		}

		public bool ShowOverheadMarkers
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x43 0x20
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x7C
			}
		}

		public bool AnchorToNamePlate
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid local signature token: 0xD2ABC79A
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8B 0x5B
			}
		}

		public float NamePlateAnchorOffsetY
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x28
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x89
			}
		}

		public bool EnableMarkerPulse
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x83 0xEE
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xF9
			}
		}

		public MarkerStyleKind MarkerStyle
		{
			[CompilerGenerated]
			get
			{
				checked
				{
					if (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
					{
						_ = (nint)/*Error near IL_0003: Stack underflow*/;
						/*Error near IL_0003: Unknown opcode: 0xF0*/;
					}
					/*Error near IL_002b: Unknown opcode: 0xEA*/;
				}
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x60
			}
		}

		public float NativeMarkerScale
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xEC
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x84
			}
		}

		[JsonConverter(typeof(Vector4ColorJsonConverter))]
		public Vector4 NativeMarkerTint
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x69
			}
			[CompilerGenerated]
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Not a type handle*/;
			}
		}

		public float MarkerSize
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xA1
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC5
			}
		}

		[JsonConverter(typeof(Vector4ColorJsonConverter))]
		public Vector4 MarkerColor
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x3B 0x93
			}
			[CompilerGenerated]
			set
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_0006: Stack underflow*/ == /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = 5;
				/*Error near IL_0007: Unknown opcode: 0xBB*/;
			}
		}

		public bool ShowMarkerIndex
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xDD
			}
			[CompilerGenerated]
			set
			{
				if ((int)/*Error near IL_0005: Stack underflow*/ != 0)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0005: Unknown opcode: 0xA7*/;
			}
		}

		public bool ShowName
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x75
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid local signature token: 0xBDA596F1
			}
		}

		public bool ShowJobIcon
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x57 0x46
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC0
			}
		}

		public bool ShowHpBar
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xEB 0x56
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0x24*/;
			}
		}

		public bool ShowCastBar
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x28
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x1C
			}
		}

		public bool ShowDistance
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9B 0x42
			}
			[CompilerGenerated]
			set
			{
				/*Error: Stack underflow*/;
				/*Error near IL_0001: Unknown opcode: 0x24*/;
			}
		}

		public float HeadHeightScale
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x78
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8D
			}
		}

		public float HeadOffsetY
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x05
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xEF 0x59
			}
		}

		public bool ShowMonitorPanel
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x00
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x13 0xFA
			}
		}

		public float PanelWidth
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x54
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x81
			}
		}

		public float PanelOffsetX
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x00
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x00
			}
		}

		public float PanelOffsetY
		{
			[CompilerGenerated]
			get
			{
				/*Error: Unknown opcode: 0xCE*/;
			}
			[CompilerGenerated]
			set
			{
				/*Error: Unknown opcode: 0xE7*/;
			}
		}

		[JsonConverter(typeof(Vector2JsonConverter))]
		public Vector2 PanelFallbackPosition
		{
			[CompilerGenerated]
			get
			{
				// ILSpy could not decompile this. Please report the exception below,
				// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
				// System.ArgumentException: Invalid token. (Parameter 'token')
				//    at System.Reflection.Throw.InvalidToken()
				//    at System.Reflection.Metadata.Ecma335.MetadataTokens.EntityHandle(Int32 token)
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeMetadataToken() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 227
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 239
				//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 1153
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 539
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 506
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 726
				//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2391
			}
			[CompilerGenerated]
			set
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xFD
			}
		}

		public bool Normalize()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5C
		}

		public MultiFocusTargetConfig()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE0
		}
	}

	private sealed class Vector4ColorJsonConverter : JsonConverter<Vector4>
	{
		public override Vector4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xD1
		}

		public override void Write(Utf8JsonWriter writer, Vector4 value, JsonSerializerOptions options)
		{
		}

		public Vector4ColorJsonConverter()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x21
		}
	}

	private sealed class Vector2JsonConverter : JsonConverter<Vector2>
	{
		public override Vector2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x6C
		}

		public override void Write(Utf8JsonWriter writer, Vector2 value, JsonSerializerOptions options)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x3D
		}

		public Vector2JsonConverter()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xDB 0x92
		}
	}

	private const ulong EmptyGameObjectId = 3758096384uL;

	internal readonly List<FocusTargetEntry> TrackedTargets;

	private MultiFocusTargetConfig _config;

	private GameObjectId _lastFocusTargetId;

	private readonly MultiFocusOverlayWindow _overlayWindow;

	private readonly MultiFocusPanelWindow _panelWindow;

	public override ModuleInfo Info
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC9
		}
	}

	public override ModulePermission Permission
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF3 0x0C
		}
	}

	public override IReadOnlyList<ModuleCommand> Commands
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x80
		}
	}

	protected override DrawConfigDelegate? DrawConfigTree
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE1
		}
	}

	internal MultiFocusTargetConfig Config
	{
		get
		{
			/*Error: Empty body found. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public MultiFocusTargetModule()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2D
	}

	public IReadOnlyList<Window> GetWindows()
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	protected override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x59
	}

	protected override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xFD
	}

	protected override void ConfigChanged()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEF 0x5A
	}

	internal override void ExecuteCommand(string actionId, string arguments)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x00
	}

	internal bool AddTarget(IGameObject? target, bool manual)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF4
	}

	internal unsafe bool AddTarget(ulong gameObjectId, string name, bool autoTracked)
	{
		_ = *(double*)gameObjectId;
		/*Error near IL_0002: Unknown opcode: 0x24*/;
	}

	internal bool RemoveTarget(IGameObject? target)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x64
	}

	private void OnGameFocusTargetChanged(GameObjectId gameObjectId)
	{
		/*Error: Unknown opcode: 0xC4*/;
	}

	private void OnTerritoryChanged(uint _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA9
	}

	private void OnUpdate(IFramework _)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF4
	}

	private void TryRefocusLostTarget()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7F 0x18
	}

	private bool ShouldPrune(FocusTargetEntry entry)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7D
	}

	internal static bool IsValidToUpdate()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB3 0xFC
	}

	internal unsafe bool IsContextValid()
	{
		_ = *(sbyte*)5;
		/*Error near IL_0002: Unknown opcode: 0xF4*/;
	}

	private void DrawConfig(ref bool hasChanged)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	private void DrawGeneralConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0F 0x89
	}

	private void DrawMarkerConfig(ref bool hasChanged)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE3 0x2D
	}

	private void DrawPanelConfig(ref bool hasChanged)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken()
		//    at System.Reflection.Metadata.Ecma335.MetadataTokens.EntityHandle(Int32 token)
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeMetadataToken() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 227
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 1165
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2391
	}

	private void DrawTrackedList(ref bool hasChanged)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 4;
		/*Error near IL_0003: Unknown opcode: 0x24*/;
	}
}
