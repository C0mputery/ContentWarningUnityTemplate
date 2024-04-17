using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	internal class NCommandPool
	{
		private readonly Stack<NCommand> pool;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NCommand Acquire(EnetPeer peer, byte[] inBuff, ref int readingOffset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NCommand Acquire(EnetPeer peer, byte commandType, StreamBuffer payload, byte channel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Release(NCommand nCommand)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NCommandPool()
		{
			throw null;
		}
	}
}
