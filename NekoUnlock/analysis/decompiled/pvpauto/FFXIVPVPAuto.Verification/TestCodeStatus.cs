namespace FFXIVPVPAuto.Verification;

public enum TestCodeStatus
{
	NotConfigured,
	WaitingForCredential,
	WaitingForAuthorization,
	Pending,
	Active,
	Expired,
	Revoked,
	Invalid,
	Error
}
