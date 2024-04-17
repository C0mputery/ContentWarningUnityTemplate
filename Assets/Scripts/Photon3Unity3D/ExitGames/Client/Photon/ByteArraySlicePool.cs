using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class ByteArraySlicePool
	{
		private int minStackIndex;

		internal readonly Stack<ByteArraySlice>[] poolTiers;

		private int allocationCounter;

		public int MinStackIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public int AllocationCounter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ByteArraySlicePool()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ByteArraySlice Acquire(byte[] buffer, int offset = 0, int count = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ByteArraySlice Acquire(int minByteCount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ByteArraySlice PopOrCreate(Stack<ByteArraySlice> stack, int stackIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool Release(ByteArraySlice slice, int stackIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearPools(int lower = 0, int upper = int.MaxValue)
		{
			throw null;
		}
	}
}
