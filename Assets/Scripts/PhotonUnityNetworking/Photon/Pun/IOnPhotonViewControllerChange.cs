using Photon.Realtime;

namespace Photon.Pun
{
	public interface IOnPhotonViewControllerChange : IPhotonViewCallback
	{
		void OnControllerChange(Player newController, Player previousController);
	}
}
