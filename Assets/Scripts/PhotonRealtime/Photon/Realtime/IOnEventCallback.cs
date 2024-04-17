using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public interface IOnEventCallback
	{
		void OnEvent(EventData photonEvent);
	}
}
