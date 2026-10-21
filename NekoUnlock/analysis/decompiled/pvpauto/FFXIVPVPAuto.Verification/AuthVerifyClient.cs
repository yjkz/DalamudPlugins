using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using FFXIVPVPAuto.Verification.Models;

namespace FFXIVPVPAuto.Verification;

internal sealed class AuthVerifyClient : VerifyClientBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCheckLiveAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<NekoLiveCheckResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			_ = (double)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xA9*/;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x94
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCheckLiveResultAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<NekoLiveCheckResult> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public AuthVerifyClient _003C_003E4__this;

		private List<NekoRequestFailureKind> _003Cfailures_003E5__2;

		private string[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private string _003Cendpoint_003E5__5;

		private VerificationRequestPacket _003Crequest_003E5__6;

		private ConfiguredTaskAwaitable<NekoQueryResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xE4
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xDF 0x54
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCheckValidityAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool IsValid, uint ExpiredTime)> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		public UInt128 credential;

		public ushort idType;

		public string message;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<NekoCredentialCheckResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xAC
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x59
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCheckValidityResultAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<NekoCredentialCheckResult> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		public UInt128 credential;

		public ushort idType;

		public string message;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<NekoLicenseQueryResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x0F 0xA4
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBD
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEnsureActiveEndpointAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		private ConfiguredTaskAwaitable<string?>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF3 0x8C
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			/*Error: Unknown opcode: 0xBE*/;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetLicenseMessageAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<LicenseResponsePacket> _003C_003Et__builder;

		public UInt128 credential;

		public ushort idType;

		public string message;

		public AuthVerifyClient _003C_003E4__this;

		private VerificationRequestPacket _003Crequest_003E5__2;

		private ConfiguredTaskAwaitable<string?>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF4
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			/*Error: Unknown opcode: 0xC5*/;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetLicenseMessageResultAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<NekoLicenseQueryResult> _003C_003Et__builder;

		public UInt128 credential;

		public ushort idType;

		public string message;

		public AuthVerifyClient _003C_003E4__this;

		public CancellationToken cancellationToken;

		private VerificationRequestPacket _003Crequest_003E5__2;

		private ConfiguredTaskAwaitable<NekoQueryResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xBD
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC5
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProbeEndpointAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		public string endpoint;

		private VerificationRequestPacket _003Crequest_003E5__2;

		private ConfiguredTaskAwaitable<NekoQueryResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA4
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xF1
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProbeEndpointsAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private string[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private string _003Cendpoint_003E5__4;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x13 0xD0
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xA5
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendQueryAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		public string payload;

		private ConfiguredTaskAwaitable<NekoQueryResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5D
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			/*Error: Unknown opcode: 0xF1*/;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendQueryCoreAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		public string endpoint;

		public string payload;

		private ConfiguredTaskAwaitable<NekoQueryResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xFF*/;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x9C
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendQueryCoreResultAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<NekoQueryResult> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		public string payload;

		public string endpoint;

		public CancellationToken cancellationToken;

		private StringContent _003Ccontent_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			checked
			{
				_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: ldloc 2 (out-of-bounds)*/;
				/*Error near IL_0002: Unknown opcode: 0xB1*/;
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x5B 0x00
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendQueryResultAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<NekoQueryResult> _003C_003Et__builder;

		public AuthVerifyClient _003C_003E4__this;

		public CancellationToken cancellationToken;

		public string payload;

		private List<NekoRequestFailureKind> _003Cfailures_003E5__2;

		private IEnumerator<string> _003C_003E7__wrap2;

		private string _003Cendpoint_003E5__4;

		private ConfiguredTaskAwaitable<NekoQueryResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x8D
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			if (/*Error near IL_0002: Stack underflow*/ < /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xCD*/;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	internal new const ushort PLUGIN_ID = 1006;

	private const string OverseasEndpoint = "https://auth.n4ko.com/";

	private const string DomesticEndpoint = "https://auth.n3ko.fun/";

	private const string QueryPath = "api/v1/query";

	private const string RsaPrivateKeyPem = "-----BEGIN RSA PRIVATE KEY-----\r\nMIIEpAIBAAKCAQEAxbsEDUqLUx3Bc3orE4Voi/qnTaXZVfjDMNvo+pG2Pc6ZjqK6\r\nbVoSsi2W+jiEsYSNyty4+kjgmJuXHk+3qwnfzDXZxthMHOWyDxbg2+J6RWkNKrP8\r\nRmd48gRUp2Si/NCy4p7uvo/WntWrJo9rtOh3FiY6ILRuGP78VO96ybL+Dmd7S3gS\r\niUb452WNp0yxN2oJ7j2aCHk3xMmKVEnVT2l1jTQ8MR0J5egcviO5XWNXu0zwELT3\r\nAmZ+GMvp/9JZgxgYnuPhoTo6/xyM0H5tiDv2SU2BPla3We7ukzQxPmbVAY8zI+eF\r\nDD43w1MapDmxpPnob0AtYdqvvuJwks6fpOEdDwIDAQABAoIBABYA6sGD4x87t3Rf\r\nSv3gIbM6EHYel6HujeIZBsMjhfE41XO+/hn/JQd49U0hDvsmMhU6HMeVZpD094si\r\n+eBpt+Lktzheh5HLqdXuCNXPTSX+O73dy5wWFapw+u6pz01s+Asp/o1sOkjwpBwl\r\nZ6n5GI95b4yGJ55WecQF5lcduRHnFgRc8K75JbQNam0qGr6UK1Ghu0kLcJuZxZaa\r\nLQzDOa/lnWU4r8Sj5NTNrXwcIpylw8mHhKcdwnEcql87Hb+ikYprE8sDhvnE0uzG\r\nZw2OGLBgznOKLGOwu5auZERT+6fPReBjTcz4F/SaC6clCdHqsFe6zLMO/ckDn0RM\r\nUCZJxEkCgYEA2sQf7jlIW0cvSivX1JnYyNTH6TKCDCzpIF9ZF093z5hn3iTC0ObC\r\n+ETIol1tZXXzdNcb6E+/HGzM2txkMmaQUMVPVgcQTeuPG7LEE7V2EeGjgyLT7MV4\r\nlHdFesyQXkwKNan7pCHkvxr1GbJWebdDjPsS73EsuURaPoYSD4eUQtUCgYEA52JZ\r\nH4GrilAI0xmSs6mTSzdCeslNo5sps1ee7mhl9gUcNupD7uJxghokExxoJLhmsxjo\r\nNNTmKOGO9gJG1s5zuy2yy8QHhr5C5UiBhspp2IYUiJvAktetu7+vSO+QnGqCOmPw\r\n7ToI/BdBPv+xjNedfu1qIQ5aCf7IWjWcN9i2qlMCgYEAucvQApcL6NnwQ+IwkBOJ\r\nlieBEYEgCg8qf5/7Hl0TuHAL5xL5kkoqVIi2jY8jlgQzHIyE2yy/dvjAkzCSuGt7\r\nLd4lnz6ojkT9adzNwp9fA5jLMlil/HVKD22syLpr8mpKUYFoguF2UQgoGgbogr8u\r\n09F5J3rLLR3sNyXOuPnA5XECgYBHSiXrbyhLFR2i7N4mPLkFE6GH8z3YipXui7CM\r\nA95mTmzC/qqvj1UpoKQ8vyPXLHl39NSWcoH3VoeVhF4PEMzXftz3qw4mlbhGrHA7\r\n92FlNOperJ5In+sHTafT8Pu9NZOqKeCxNpBOG1we7OjnXAdKdBue060qJzXTlXDs\r\nQ/kDwQKBgQCuQBOcXoikFsf/lF8kuPjo2BM6fzKyFpbVHMEHa4XDXvWX6uZpdRL7\r\n6BwiobCwflnvc+NGyLmraXDbF6RoS+JwEisBXdGKo8HfW6YJu/3u4MCVW+MEDPO2\r\nGBBLAiOwrMP8SgLZ4TzfGvLxE/F36nngunY+XDmx5Lc2GLgkq+u8eA==\r\n-----END RSA PRIVATE KEY-----";

	private static readonly string[] AuthEndpoints;

	private static readonly TimeSpan RequestTimeout;

	private readonly SemaphoreSlim _endpointProbeSemaphore;

	private HttpClient? _httpClient;

	private int _ownsHttpClient;

	private string? _activeEndpoint;

	internal string ActiveEndpoint
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x20
		}
	}

	internal override void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x17 0xB2
	}

	internal override void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9B 0x97
	}

	[AsyncStateMachine(typeof(_003CCheckLiveAsync_003Ed__15))]
	internal Task<bool> CheckLiveAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2D
	}

	[AsyncStateMachine(typeof(_003CCheckLiveResultAsync_003Ed__16))]
	internal Task<NekoLiveCheckResult> CheckLiveResultAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x93 0x62
	}

	[AsyncStateMachine(typeof(_003CCheckValidityAsync_003Ed__17))]
	internal Task<(bool IsValid, uint ExpiredTime)> CheckValidityAsync(UInt128 credential, ushort idType, string message = "", CancellationToken cancellationToken = default(CancellationToken))
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x39
	}

	[AsyncStateMachine(typeof(_003CCheckValidityResultAsync_003Ed__18))]
	internal Task<NekoCredentialCheckResult> CheckValidityResultAsync(UInt128 credential, ushort idType, string message = "", CancellationToken cancellationToken = default(CancellationToken))
	{
		checked
		{
			_ = (long)(float)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xE1*/;
		}
	}

	[AsyncStateMachine(typeof(_003CGetLicenseMessageAsync_003Ed__19))]
	private Task<LicenseResponsePacket> GetLicenseMessageAsync(UInt128 credential, ushort idType, string message)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2D
	}

	[AsyncStateMachine(typeof(_003CGetLicenseMessageResultAsync_003Ed__20))]
	private Task<NekoLicenseQueryResult> GetLicenseMessageResultAsync(UInt128 credential, ushort idType, string message, CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xE3 0xFC
	}

	private static VerificationRequestPacket CreateCheckAliveRequest()
	{
		/*Error: Not a type handle*/;
	}

	private static VerificationRequestPacket CreateLicenseRequest(UInt128 credential, ushort idType, string message)
	{
		/*Error: Unknown opcode: 0xE6*/;
	}

	private bool ValidateHelloResponse(string encryptedResponse, uint nonce)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA1
	}

	[AsyncStateMachine(typeof(_003CEnsureActiveEndpointAsync_003Ed__24))]
	private Task<string?> EnsureActiveEndpointAsync()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xCC
	}

	[AsyncStateMachine(typeof(_003CProbeEndpointsAsync_003Ed__25))]
	private Task<string?> ProbeEndpointsAsync()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9F 0x46
	}

	[AsyncStateMachine(typeof(_003CProbeEndpointAsync_003Ed__26))]
	private Task<bool> ProbeEndpointAsync(string endpoint)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA1
	}

	[AsyncStateMachine(typeof(_003CSendQueryAsync_003Ed__27))]
	private Task<string?> SendQueryAsync(string payload)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF7 0x72
	}

	[AsyncStateMachine(typeof(_003CSendQueryCoreAsync_003Ed__28))]
	private Task<string?> SendQueryCoreAsync(string endpoint, string payload)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF7 0xA4
	}

	[AsyncStateMachine(typeof(_003CSendQueryResultAsync_003Ed__29))]
	private Task<NekoQueryResult> SendQueryResultAsync(string payload, CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x10
	}

	[AsyncStateMachine(typeof(_003CSendQueryCoreResultAsync_003Ed__30))]
	private Task<NekoQueryResult> SendQueryCoreResultAsync(string endpoint, string payload, CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x47 0xEC
	}

	private static NekoRequestFailureKind MapFailureKind(IReadOnlyList<NekoRequestFailureKind> failures)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x67 0xFE
	}

	private void SetActiveEndpoint(string endpoint)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			_ = /*Error near IL_0001: ldloc 181 (out-of-bounds)*/<< 7;
			/*Error near IL_0005: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private static byte[] DecryptFromBase64(string encryptedResponse)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA9
	}

	private static string GetAlternateEndpoint(string endpoint)
	{
		throw (nuint)/*Error near IL_0001: Stack underflow*/;
	}

	private static string BuildQueryUrl(string endpoint)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x08
	}

	private static uint ToPackedVersion(Version version)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA4
	}

	public AuthVerifyClient()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x5D
	}

	static AuthVerifyClient()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x43 0x4E
	}
}
