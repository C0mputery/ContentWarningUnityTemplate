namespace Photon.Chat
{
	public enum ChatDisconnectCause
	{
		None = 0,
		ExceptionOnConnect = 1,
		DisconnectByServerLogic = 2,
		DisconnectByServerReasonUnknown = 3,
		ServerTimeout = 4,
		ClientTimeout = 5,
		Exception = 6,
		InvalidAuthentication = 7,
		MaxCcuReached = 8,
		InvalidRegion = 9,
		OperationNotAllowedInCurrentState = 10,
		CustomAuthenticationFailed = 11,
		AuthenticationTicketExpired = 12,
		DisconnectByClientLogic = 13
	}
}
