using System.Collections.Generic;

namespace Photon.Realtime
{
	public interface ILobbyCallbacks
	{
		void OnJoinedLobby();

		void OnLeftLobby();

		void OnRoomListUpdate(List<RoomInfo> roomList);

		void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics);
	}
}
