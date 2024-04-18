using System;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class ByteArraySlice : IDisposable
	{
		public byte[] Buffer;

		public int Offset;

		public int Count;

		private readonly ByteArraySlicePool returnPool;

		private readonly int stackIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ByteArraySlice(ByteArraySlicePool returnPool, int stackIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ByteArraySlice(byte[] buffer, int offset = 0, int count = 0)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ByteArraySlice()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Release()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}
	}
}
