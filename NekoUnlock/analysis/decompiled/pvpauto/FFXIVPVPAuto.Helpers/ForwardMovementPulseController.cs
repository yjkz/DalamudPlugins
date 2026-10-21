using System;
using Dalamud.Hooking;

namespace FFXIVPVPAuto.Helpers;

internal sealed class ForwardMovementPulseController : IDisposable
{
	private unsafe delegate bool IsInputEnabledDelegate(void* self);

	private unsafe delegate void WalkInputDelegate(void* self, float* sumLeft, float* sumForward, float* sumTurnLeft, byte* haveBackwardOrStrafe, byte* a6, byte additive);

	private readonly DancerLbSequenceState _state;

	private readonly Func<bool> _canContinue;

	private readonly Action _stop;

	private readonly Action<Exception> _onError;

	private readonly Action _onInput;

	private readonly IsInputEnabledDelegate _isInputEnabled1;

	private readonly IsInputEnabledDelegate _isInputEnabled2;

	private readonly Hook<WalkInputDelegate> _walkHook;

	internal unsafe ForwardMovementPulseController(DancerLbSequenceState state, Func<bool> canContinue, Action stop, Action<Exception> onError, Action onInput)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I
		if ((nint)/*Error near IL_0005: Stack underflow*/ < checked((nint)(/*Error near IL_0002: Stack underflow*/ ^ *unchecked((long*)(nint)/*Error near IL_0001: Stack underflow*/))))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: Unknown opcode: 0xC9*/;
	}

	internal void Update()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x2C
	}

	private unsafe void OnWalkInput(void* self, float* sumLeft, float* sumForward, float* sumTurnLeft, byte* haveBackwardOrStrafe, byte* a6, byte additive)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x99
	}

	public void Dispose()
	{
		_ = (int)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCC*/;
	}
}
