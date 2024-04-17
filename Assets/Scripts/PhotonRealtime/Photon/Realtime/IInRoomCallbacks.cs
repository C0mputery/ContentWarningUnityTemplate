using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public interface IInRoomCallbacks
	{
		void OnPlayerEnteredRoom(Player newPlayer);

		void OnPlayerLeftRoom(Player otherPlayer);

		void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged);

		void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps);

		void OnMasterClientSwitched(Player newMasterClient);
	}
}
