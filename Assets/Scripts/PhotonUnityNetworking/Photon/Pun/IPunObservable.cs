namespace Photon.Pun
{
	public interface IPunObservable
	{
		void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info);
	}
}
