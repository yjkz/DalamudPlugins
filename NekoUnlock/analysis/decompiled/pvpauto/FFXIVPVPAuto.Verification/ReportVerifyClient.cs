using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace FFXIVPVPAuto.Verification;

internal sealed class ReportVerifyClient : VerifyClientBase
{
	private sealed class DeviceReportPayload
	{
		[JsonPropertyName("cid")]
		public string Cid
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x31
			}
			[CompilerGenerated]
			init
			{
				// ILSpy could not decompile this. Please report the exception below,
				// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
				// System.ArgumentException: Invalid token. (Parameter 'token')
				//    at System.Reflection.Throw.InvalidToken()
				//    at System.Reflection.Metadata.Ecma335.MetadataTokens.EntityHandle(Int32 token)
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeMetadataToken() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 227
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeFieldReference() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 251
				//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 1220
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 539
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 506
				//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 726
				//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2391
			}
		}

		[JsonPropertyName("sid")]
		public string Sid
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xDF 0x48
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x89
			}
		}

		[JsonPropertyName("mid")]
		public string Mid
		{
			[CompilerGenerated]
			get
			{
				if (/*Error near IL_0002: Stack underflow*/ < /*Error near IL_0002: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0002: Read out of bounds.*/;
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9F 0x1D
			}
		}

		[JsonPropertyName("mac")]
		public unsafe string Mac
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xF7 0x48
			}
			[CompilerGenerated]
			init
			{
				checked
				{
					_ = (uint)(*unchecked((double*)(nint)/*Error near IL_0001: Stack underflow*/));
					/*Error near IL_0002: Not a type handle*/;
				}
			}
		}

		[JsonPropertyName("qq")]
		public string Qq
		{
			[CompilerGenerated]
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid metadata token*/;
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xC9
			}
		}

		public DeviceReportPayload()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x1D
		}
	}

	private sealed class HybridTransmissionData
	{
		[JsonPropertyName("encryptedKey")]
		public string EncryptedKey
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x19
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xB5
			}
		}

		[JsonPropertyName("encryptedData")]
		public string EncryptedData
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x54
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x77 0x82
			}
		}

		public HybridTransmissionData()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (nint)(~/*Error near IL_0001: Stack underflow*/);
				/*Error near IL_0002: Unknown opcode: 0xF8*/;
			}
		}
	}

	internal sealed class ReportResult
	{
		public bool Success
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x41
			}
			[CompilerGenerated]
			init
			{
				/*OpCode not supported: DebugBreak*/;
				/*Error near IL_0001: Read out of bounds.*/;
			}
		}

		public int StatusCode
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0xCF 0x50
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x8C
			}
		}

		public string Message
		{
			[CompilerGenerated]
			get
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x83 0xD9
			}
			[CompilerGenerated]
			init
			{
				//Invalid MethodBodyBlock: Invalid method header: 0x9C
			}
		}

		internal static ReportResult Ok(int statusCode, string message)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/<< (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xCF*/;
		}

		internal static ReportResult Failed(int statusCode, string message)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x74
		}

		internal static ReportResult Skipped(string message)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBC
		}

		public ReportResult()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x97 0xBF
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCollectPayloadAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DeviceReportPayload> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		private string _003Ccid_003E5__2;

		private string _003Csid_003E5__3;

		private string _003Cmid_003E5__4;

		private string _003Cmac_003E5__5;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA3 0x78
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x08
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetQqListAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<FFXIVPVPAuto.Services.QqProbeResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x41
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xDC
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReportAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ReportResult> _003C_003Et__builder;

		public ReportVerifyClient _003C_003E4__this;

		public CancellationToken cancellationToken;

		private string _003CserverUrl_003E5__2;

		private string _003CpublicKey_003E5__3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<DeviceReportPayload>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<ReportResult>.ConfiguredTaskAwaiter _003C_003Eu__3;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x4C
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_ = ((object[])/*Error near IL_0002: Stack underflow*/)[((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]];
			_ = 5807991076458878185L;
			/*Error near IL_000b: Unknown opcode: 0xA9*/;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ReportResult> _003C_003Et__builder;

		public HybridTransmissionData data;

		public string serverUrl;

		public CancellationToken cancellationToken;

		private HttpClientHandler _003Chandler_003E5__2;

		private HttpClient _003Cclient_003E5__3;

		private StringContent _003Ccontent_003E5__4;

		private HttpResponseMessage _003Cresponse_003E5__5;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB9
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x97 0x7E
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const string DefaultReportServerUrl = "https://api.ffxivcharacrad.xyz";

	private const string DefaultReportPublicKeyBase64 = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAs+MePXng0aaDB0akjvD5PNnP5UDHtMG9AQVVq6tlMt2GylQ3Ss6KVfaNPU1pp286lNo6/wfwWL/O6hDpdLmJsGqYCHxAspDcohm6I3L312NslEBUJjKy/ufvapKOG6/2rRSrDI48nkZOr/fIzg+NDycfB7aaDiyx7rR2J0VxW6HbyAP2Wcaed//1xD3oHLF2Eg1w4SWqGovuMysWOijqiBlKyjBDTAQ1CKIDmWd15FLir8QNOOOmJTgp3opT4no5uP5FWcjK31my3J9NEJhQ26ewYz+VRlHguY93016gO3vQZ2s7wvtOaMRDj7/B9P1AxPBjEkj3z7YbkxlwpGhwlQIDAQAB";

	private static readonly int[] ProbePorts;

	private const string DefaultUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/139.0.0.0 Safari/537.36";

	private readonly SemaphoreSlim _reportGate;

	private CancellationTokenSource? _cancelSource;

	private CancellationTokenSource? _loginReportSource;

	private bool _hasReportedForCurrentLogin;

	internal override void Init()
	{
		if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_ = (ushort)((long[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
			/*Error near IL_0007: Unknown opcode: 0xCA*/;
		}
	}

	internal unsafe override void Uninit()
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0006: Stack underflow*/ > (int)(*(ushort*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Unknown opcode: 0xC8*/;
	}

	private void OnLogin()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((ushort[])/*Error near IL_0002: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)];
		/*Error near IL_0002: Unknown opcode: 0xF8*/;
	}

	private void OnLogout(int type, int code)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB3 0x88
	}

	private void BeginLoginReport()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF1
	}

	private void CancelLoginReport()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xB5
	}

	private void QueueReport(CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x21
	}

	[AsyncStateMachine(typeof(_003CReportAsync_003Ed__15))]
	internal Task<ReportResult> ReportAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		/*Error: Unknown opcode: 0xF4*/;
	}

	[AsyncStateMachine(typeof(_003CCollectPayloadAsync_003Ed__16))]
	private static Task<DeviceReportPayload> CollectPayloadAsync(CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC8
	}

	private static HybridTransmissionData EncryptPayload(DeviceReportPayload payload, string publicKeyBase64)
	{
		/*Error: Unknown opcode: 0xA8*/;
	}

	[AsyncStateMachine(typeof(_003CSendAsync_003Ed__18))]
	private static Task<ReportResult> SendAsync(HybridTransmissionData data, string serverUrl, CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid local signature token: 0x408E16B3
	}

	private static string ResolveReportServerUrl()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x74
	}

	private static string ResolveReportPublicKey()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x21
	}

	private static bool IsValidPublicKey(string publicKeyBase64)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5D
	}

	private static string BuildReportUrl(string serverUrl)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7F 0x57
	}

	private static string GetMd5Hash(string input)
	{
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static byte[] AesGcmEncrypt(string plaintext, byte[] key)
	{
		/*Error: Not a type handle*/;
	}

	private static byte[] RsaEncrypt(byte[] data, string publicKeyBase64)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x75
	}

	[AsyncStateMachine(typeof(_003CGetQqListAsync_003Ed__26))]
	private static Task<string> GetQqListAsync(CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x98
	}

	public ReportVerifyClient()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x85
	}

	static ReportVerifyClient()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2F 0xA4
	}
}
