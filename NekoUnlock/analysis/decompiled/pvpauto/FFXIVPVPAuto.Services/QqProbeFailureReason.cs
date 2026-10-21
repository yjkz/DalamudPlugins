namespace FFXIVPVPAuto.Services;

internal enum QqProbeFailureReason
{
	None,
	NoPtLocalToken,
	ConnectionFailed,
	Timeout,
	HttpNonSuccess,
	NoAccountsReturned,
	Unknown
}
