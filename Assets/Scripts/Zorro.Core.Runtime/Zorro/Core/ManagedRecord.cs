using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class ManagedRecord<T> : BookkeepingRecord
	{
		public PerformantList<T> PerformantList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ManagedRecord(int initialCapacity)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(T value)
		{
			throw null;
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
	}
}
