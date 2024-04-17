namespace Photon.Realtime
{
	public enum DisconnectCause
	{
		None = 0,
		ExceptionOnConnect = 1,
		DnsExceptionOnConnect = 2,
		ServerAddressInvalid = 3,
		Exception = 4,
		SendException = 5,
		ReceiveException = 6,
		ServerTimeout = 7,
		ClientTimeout = 8,
		DisconnectByServerLogic = 9,
		DisconnectByServerReasonUnknown = 10,
		InvalidAuthentication = 11,
		CustomAuthenticationFailed = 12,
		AuthenticationTicketExpired = 13,
		MaxCcuReached = 14,
		InvalidRegion = 15,
		OperationNotAllowedInCurrentState = 16,
		DisconnectByClientLogic = 17,
		DisconnectByOperationLimit = 18,
		DisconnectByDisconnectMessage = 19,
		ApplicationQuit = 20
	}
}
