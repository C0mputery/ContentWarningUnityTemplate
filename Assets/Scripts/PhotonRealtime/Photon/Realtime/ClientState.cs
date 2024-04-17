using System;

namespace Photon.Realtime
{
	public enum ClientState
	{
		PeerCreated = 0,
		Authenticating = 1,
		Authenticated = 2,
		JoiningLobby = 3,
		JoinedLobby = 4,
		DisconnectingFromMasterServer = 5,
		[Obsolete("Renamed to DisconnectingFromMasterServer")]
		DisconnectingFromMasterserver = 5,
		ConnectingToGameServer = 6,
		[Obsolete("Renamed to ConnectingToGameServer")]
		ConnectingToGameserver = 6,
		ConnectedToGameServer = 7,
		[Obsolete("Renamed to ConnectedToGameServer")]
		ConnectedToGameserver = 7,
		Joining = 8,
		Joined = 9,
		Leaving = 10,
		DisconnectingFromGameServer = 11,
		[Obsolete("Renamed to DisconnectingFromGameServer")]
		DisconnectingFromGameserver = 11,
		ConnectingToMasterServer = 12,
		[Obsolete("Renamed to ConnectingToMasterServer.")]
		ConnectingToMasterserver = 12,
		Disconnecting = 13,
		Disconnected = 14,
		ConnectedToMasterServer = 15,
		[Obsolete("Renamed to ConnectedToMasterServer.")]
		ConnectedToMasterserver = 15,
		[Obsolete("Renamed to ConnectedToMasterServer.")]
		ConnectedToMaster = 15,
		ConnectingToNameServer = 16,
		ConnectedToNameServer = 17,
		DisconnectingFromNameServer = 18,
		ConnectWithFallbackProtocol = 19,
		ConnectWithoutAuthOnceWss = 20
	}
}
