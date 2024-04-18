using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Zorro.Core
{
	public class NativeListRecord<T> : BookkeepingRecord where T : unmanaged
	{
		public NativeList<T> NativeList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NativeListRecord(int initialCapacity)
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
