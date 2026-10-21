using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using FFXIVPVPAuto.Verification.Models;

namespace FFXIVPVPAuto.Verification.Clients;

internal sealed class TestCodeVerifyClient : VerifyClientBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendGrantAsync_003Ed__7<T> : IAsyncStateMachine where T : notnull
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TestCodeGrantClientResult> _003C_003Et__builder;

		public TestCodeVerifyClient _003C_003E4__this;

		public T payload;

		public string path;

		public CancellationToken cancellationToken;

		public string expectedClientNonce;

		private byte[] _003CsessionKey_003E5__2;

		private StringContent _003Ccontent_003E5__3;

		private HttpResponseMessage _003Cresponse_003E5__4;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xCD*/;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			/*Error: Metadata token must be either a methoddef, memberref or methodspec*/;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const int MaxResponseBytes = 65536;

	private static readonly JsonSerializerOptions JsonOptions;

	private HttpClient? _httpClient;

	internal override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x51
	}

	internal override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x43 0xA2
	}

	internal Task<TestCodeGrantClientResult> RequestAsync(string credential, CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x34
	}

	internal Task<TestCodeGrantClientResult> StatusAsync(string requestToken, string grantToken, string credential, CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF1
	}

	[AsyncStateMachine(typeof(_003CSendGrantAsync_003Ed__7<>))]
	private Task<TestCodeGrantClientResult> SendGrantAsync<T>(string path, T payload, string expectedClientNonce, CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xBC
	}

	private static TestCodeGrantClientResult ReadGrantResult(HttpStatusCode statusCode, ReadOnlySpan<byte> plaintext, string expectedNonce)
	{
		((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
		_ = ((double[])/*Error near IL_0004: Stack underflow*/)[((ushort[])/*Error near IL_0003: Stack underflow*/)[(int)statusCode]];
		/*Error near IL_0004: Invalid branch target*/;
	}

	private static bool TryReadEnvelope(ReadOnlySpan<byte> responseBytes, out TestCodeEnvelope envelope)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x83 0x17
	}

	private static bool IsTransient(HttpStatusCode statusCode, string errorCode)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD4
	}

	private static bool IsSuccessStatusCode(HttpStatusCode statusCode)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEC
	}

	private static Uri BuildUri(string path)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCF 0xDA
	}

	private static bool TryGetObject(JsonElement element, out JsonElement value, params string[] names)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x14
	}

	private static bool? ReadBoolean(JsonElement element, params string[] names)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC1
	}

	private static string? ReadString(JsonElement element, params string[] names)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x37 0xD7
	}

	private unsafe static DateTimeOffset? ReadDateTimeOffset(JsonElement element, params string[] names)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got Unknown
		*(double*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/+ *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0003: Unknown opcode: 0xEB*/;
	}

	private static bool TryGetProperty(JsonElement element, out JsonElement value, params string[] names)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x37 0xF0
	}

	public TestCodeVerifyClient()
	{
		/*Error: Not a type handle*/;
	}

	static TestCodeVerifyClient()
	{
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xA6*/;
		}
	}
}
