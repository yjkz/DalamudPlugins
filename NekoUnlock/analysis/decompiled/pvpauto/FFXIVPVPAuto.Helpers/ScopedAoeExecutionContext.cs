using System;

namespace FFXIVPVPAuto.Helpers;

internal sealed class ScopedAoeExecutionContext : IDisposable
{
	[ThreadStatic]
	private static ScopedAoeExecutionContext? _current;

	private readonly ScopedAoeExecutionContext? _previous;

	private readonly uint _actionId;

	private bool _disposed;

	internal ScopedAoeExecutionContext(uint actionId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xEF 0x9B
	}

	internal static bool IsOptimizedAction(uint actionId)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x6F 0x91
	}

	public void Dispose()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x0F 0xBB
	}
}
