using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class RingBuffer<T>
	{
		private readonly T[] _entries;

		private readonly int _modMask;

		private Volatile.PaddedLong _consumerCursor;

		private Volatile.PaddedLong _producerCursor;

		public int Capacity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public T this[long index]
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

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RingBuffer(int capacity)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Dequeue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryDequeue(out T obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Enqueue(T item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int NextPowerOfTwo(int x)
		{
			throw null;
		}
	}
}
