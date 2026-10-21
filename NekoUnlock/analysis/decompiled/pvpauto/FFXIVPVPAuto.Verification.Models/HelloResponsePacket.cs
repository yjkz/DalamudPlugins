using System.Runtime.InteropServices;

namespace FFXIVPVPAuto.Verification.Models;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct HelloResponsePacket
{
	internal uint Nonce;
}
