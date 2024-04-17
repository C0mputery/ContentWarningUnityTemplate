using Photon.Realtime;

namespace Photon.Pun
{
	public interface IOnPhotonViewOwnerChange : IPhotonViewCallback
	{
		void OnOwnerChange(Player newOwner, Player previousOwner);
	}
}
