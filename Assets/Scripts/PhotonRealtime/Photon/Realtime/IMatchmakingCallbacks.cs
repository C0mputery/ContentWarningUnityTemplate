using System.Collections.Generic;

namespace Photon.Realtime
{
	public interface IMatchmakingCallbacks
	{
		void OnFriendListUpdate(List<FriendInfo> friendList);

		void OnCreatedRoom();

		void OnCreateRoomFailed(short returnCode, string message);

		void OnJoinedRoom();

		void OnJoinRoomFailed(short returnCode, string message);

		void OnJoinRandomFailed(short returnCode, string message);

		void OnLeftRoom();
	}
}
