using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ExitGames.Client.Photon.Encryption
{
	public class EncryptorNet : IPhotonEncryptor
	{
		protected Aes encryptorIn;

		protected Aes encryptorOut;

		protected HMACSHA256 hmacsha256In;

		protected HMACSHA256 hmacsha256Out;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(byte[] encryptionSecret, byte[] hmacSecret, byte[] ivBytes = null, bool chainingModeGCM = false, int mtu = 1200)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Encrypt2(byte[] data, int len, byte[] header, byte[] output, int outOffset, ref int outSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] Decrypt2(byte[] data, int offset, int len, byte[] header, out int outLen)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateEncryptedSize(int unencryptedSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateFragmentLength()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EncryptorNet()
		{
			throw null;
		}
	}
}
