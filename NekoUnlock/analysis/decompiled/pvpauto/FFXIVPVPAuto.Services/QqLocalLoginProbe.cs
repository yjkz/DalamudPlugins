using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace FFXIVPVPAuto.Services;

internal sealed class QqLocalLoginProbe
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProbeAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<QqProbeResult> _003C_003Et__builder;

		public QqProbeOptions options;

		public CancellationToken cancellationToken;

		private CookieContainer _003CcookieContainer_003E5__2;

		private HttpClientHandler _003Chandler_003E5__3;

		private HttpClient _003ChttpClient_003E5__4;

		private Uri _003CxloginUri_003E5__5;

		private HttpRequestMessage _003CxloginRequest_003E5__6;

		private HttpResponseMessage _003CxloginResponse_003E5__7;

		private string _003CptLocalToken_003E5__8;

		private string _003CptLoginSig_003E5__9;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private IEnumerator<int> _003C_003E7__wrap9;

		private int _003Cport_003E5__11;

		private HttpRequestMessage _003Crequest_003E5__12;

		private HttpResponseMessage _003Cresponse_003E5__13;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x03 0xD0
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_ = 7;
			/*Error near IL_0001: Unknown opcode: 0xEC*/;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	internal const string DefaultXloginUrl = "https://xui.ptlogin2.qq.com/cgi-bin/xlogin?s_url=https://qzs.qq.com/qzone/v5/loginsucc.html?para=izone";

	private static readonly int[] DefaultPorts;

	[AsyncStateMachine(typeof(_003CProbeAsync_003Ed__2))]
	internal Task<QqProbeResult> ProbeAsync(QqProbeOptions options, CancellationToken cancellationToken)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF1
	}

	private static string BuildProbeUrl(int port, string ptLocalToken)
	{
		/*Error: Invalid metadata token*/;
	}

	private static IReadOnlyList<int> ParsePorts(string? rawPorts)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x90
	}

	private static IReadOnlyList<QqLocalAccount> ParseAccounts(string rawResponse)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x3D
	}

	private static string? ExtractValue(string fragment, string key)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public QqLocalLoginProbe()
	{
		/*Error: Unknown opcode: 0xF9*/;
	}

	static QqLocalLoginProbe()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF1
	}
}
