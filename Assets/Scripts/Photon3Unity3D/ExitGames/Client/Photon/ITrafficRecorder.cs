namespace ExitGames.Client.Photon
{
	public interface ITrafficRecorder
	{
		bool Enabled { get; set; }

		void Record(byte[] inBuffer, int length, bool incoming, short peerId, IPhotonSocket connection);
	}
}
