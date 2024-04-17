using System.Collections.Generic;

namespace Photon.Realtime
{
	public interface IConnectionCallbacks
	{
		void OnConnected();

		void OnConnectedToMaster();

		void OnDisconnected(DisconnectCause cause);

		void OnRegionListReceived(RegionHandler regionHandler);

		void OnCustomAuthenticationResponse(Dictionary<string, object> data);

		void OnCustomAuthenticationFailed(string debugMessage);
	}
}
