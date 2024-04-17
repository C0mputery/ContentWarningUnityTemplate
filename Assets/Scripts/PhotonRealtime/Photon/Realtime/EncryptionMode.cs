namespace Photon.Realtime
{
	public enum EncryptionMode
	{
		PayloadEncryption = 0,
		DatagramEncryption = 10,
		DatagramEncryptionRandomSequence = 11,
		DatagramEncryptionGCM = 13
	}
}
