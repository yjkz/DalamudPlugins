using System;
using System.Runtime.InteropServices;

namespace FFXIVPVPAuto.Verification.Models;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct VerificationRequestPacket
{
	internal uint Nonce;

	internal ushort FunctionCode;

	internal ushort PluginID;

	internal UInt128 IDHash;

	internal ushort IDType;

	internal ushort NekoVersion;

	internal ushort LoadWay;

	internal ushort GameLanguage;

	internal uint DalamudVersion;

	internal uint PluginVersion;

	internal uint GameVersion;

	internal uint SelfHash;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
	internal string Message;
}
