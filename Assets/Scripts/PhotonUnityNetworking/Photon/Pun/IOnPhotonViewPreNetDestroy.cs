namespace Photon.Pun
{
	public interface IOnPhotonViewPreNetDestroy : IPhotonViewCallback
	{
		void OnPreNetDestroy(PhotonView rootView);
	}
}
