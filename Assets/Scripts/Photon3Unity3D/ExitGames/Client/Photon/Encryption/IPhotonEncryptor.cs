namespace ExitGames.Client.Photon.Encryption
{
	public interface IPhotonEncryptor
	{
		void Init(byte[] encryptionSecret, byte[] hmacSecret, byte[] ivBytes = null, bool chainingModeGCM = false, int mtu = 1200);

		void Encrypt2(byte[] data, int len, byte[] header, byte[] output, int outOffset, ref int outSize);

		byte[] Decrypt2(byte[] data, int offset, int len, byte[] header, out int outLen);

		int CalculateEncryptedSize(int unencryptedSize);

		int CalculateFragmentLength();
	}
}
