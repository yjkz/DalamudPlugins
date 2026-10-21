using System;
using System.Runtime.InteropServices;

namespace FFXIVPVPAuto.Verification.Models;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct LicenseResponsePacket
{
	internal uint Nonce;

	internal ushort Status;

	internal ushort PluginID;

	internal uint ExpiredTime;

	internal uint ShowExpiredTime;

	internal uint Reverse;

	internal UInt128 IDHash;

	internal ushort IDType;

	internal ushort NekoVersion;
}
