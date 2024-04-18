using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class MultiDataManagedRecord<T> : BookkeepingRecord
	{
		public int DataPerEntry;

		private PerformantList<T> m_dataList;

		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MultiDataManagedRecord(int dataPerEntry, int defaultCapacity)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void RemoveAtSwapBack(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(T data)
		{
			throw null;
		}
	}
}
