using System.Runtime.CompilerServices;

namespace FFXIVPVPAuto.Helpers;

internal sealed class KuzushiShieldSequence
{
	private ulong _playerId;

	private uint _jobId;

	private long _nextAttemptTick;

	private long _pendingUntilTick;

	private bool _pendingIsShield;

	private bool _accepted;

	internal bool Active
	{
		[CompilerGenerated]
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xE8*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB9
		}
	}

	internal bool Succeeded
	{
		[CompilerGenerated]
		get
		{
			_ = (byte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x73 0xB7
		}
	}

	internal uint PendingAction
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xC9
		}
		[CompilerGenerated]
		private set
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xDD
		}
	}

	internal unsafe bool ConfirmationTimedOut
	{
		[CompilerGenerated]
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x14
		}
		[CompilerGenerated]
		private set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected I4, but got Unknown
			checked
			{
				_ = (short)unchecked(/*Error near IL_0004: Stack underflow*/ % (/*Error near IL_0003: Stack underflow*/ & (float)checked((nint)/*Error near IL_0001: Stack underflow*/)));
				/*Error near IL_0005: starg 246 (out-of-bounds)*/;
				if (/*Error near IL_000c: Stack underflow*/ < /*Error near IL_000c: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
			}
			((int[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/] = /*Error near IL_000f: Stack underflow*/- checked((ushort)/*Error near IL_000d: Stack underflow*/);
			*(short*)(nint)/*Error near IL_0012: Stack underflow*/ = (short)checked((int)/*Error near IL_0011: Stack underflow*/);
			/*Error near IL_0012: Unknown opcode: 0xAA*/;
		}
	}

	internal bool IsWaiting
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0x09
		}
	}

	internal void Observe(bool hasKuzushi, ulong playerId, uint jobId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x01
	}

	internal bool TryBegin(long now, uint actionId, bool isShield)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xC1
	}

	internal void ExpirePending(long now)
	{
		checked
		{
			_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xBD*/;
		}
	}

	internal unsafe void CancelPending()
	{
		_ = *(float*)(int)(*(ushort*)(nint)/*Error near IL_0001: Stack underflow*/);
	}

	internal void Submitted(bool accepted)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6F 0xCF
	}

	internal void Confirm(uint actionId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xA4
	}

	internal void ConfirmShieldStatus()
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

	internal void Reset()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xD7 0xB0
	}

	public KuzushiShieldSequence()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x7B 0xF4
	}
}
