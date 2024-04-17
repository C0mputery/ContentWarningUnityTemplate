using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Photon.SocketServer.Security
{
	internal class DiffieHellmanCryptoProvider : ICryptoProvider, IDisposable
	{
		private static readonly BigInteger primeRoot;

		private readonly BigInteger prime;

		private readonly BigInteger secret;

		private readonly BigInteger publicKey;

		private Rijndael crypto;

		private byte[] sharedKey;

		public bool IsInitialized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public byte[] PublicKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiffieHellmanCryptoProvider()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiffieHellmanCryptoProvider(byte[] cryptoKey)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeriveSharedKey(byte[] otherPartyPublicKey)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] PhotonBigIntArrayToMsBigIntArray(byte[] array)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] MsBigIntArrayToPhotonBigIntArray(byte[] array)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] Encrypt(byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] Encrypt(byte[] data, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] Decrypt(byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] Decrypt(byte[] data, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Dispose(bool disposing)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private BigInteger CalculatePublicKey()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private BigInteger CalculateSharedKey(BigInteger otherPartyPublicKey)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private BigInteger GenerateRandomSecret(int secretLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DiffieHellmanCryptoProvider()
		{
			throw null;
		}
	}
}
