using System;

namespace FFXIVPVPAuto.Helpers;

[Flags]
internal enum PvPGroundIssue
{
	None = 0,
	OutOfRange = 1,
	BlockedLineOfSight = 2,
	HeightMismatch = 4,
	ActionStatus = 8
}
