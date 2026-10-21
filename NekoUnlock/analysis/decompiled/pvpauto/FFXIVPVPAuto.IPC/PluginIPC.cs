using System;
using Dalamud.Plugin.Ipc;

namespace FFXIVPVPAuto.IPC;

public static class PluginIPC
{
	private static ICallGateProvider<Version>? _versionProvider;

	private static ICallGateProvider<string, bool>? _isModuleEnabledProvider;

	internal static void Init()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x1D
	}

	internal static void Uninit()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9D
	}

	private static Version GetVersion()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x37 0x61
	}

	private static bool IsModuleEnabled(string moduleName)
	{
		//Invalid MethodBodyBlock: Invalid method header: 0xF4
	}
}
