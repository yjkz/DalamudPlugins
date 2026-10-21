namespace FFXIVPVPAuto.Verification;

public enum TestCodeExpiryResolution
{
	Derived,
	ServerTimeUnavailable,
	ClockSkewExceeded,
	QualificationWindowClosed,
	QualificationWindowUnbounded
}
