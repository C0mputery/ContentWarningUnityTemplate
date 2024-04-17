using Photon.Realtime;

namespace Photon.Pun
{
	public interface IPunOwnershipCallbacks
	{
		void OnOwnershipRequest(PhotonView targetView, Player requestingPlayer);

		void OnOwnershipTransfered(PhotonView targetView, Player previousOwner);

		void OnOwnershipTransferFailed(PhotonView targetView, Player senderOfFailedRequest);
	}
}
