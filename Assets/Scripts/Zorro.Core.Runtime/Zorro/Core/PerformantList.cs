using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class PerformantList<T>
	{
		public int Count;

		private T[] array;

		private int count;

		private int capacity;

		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerformantList(int capacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(T entry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveAtSwapBack(int index)
		{
			throw null;
		}
	}
}
