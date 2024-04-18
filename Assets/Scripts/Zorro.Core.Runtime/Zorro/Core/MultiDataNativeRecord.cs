using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Zorro.Core
{
	public class MultiDataNativeRecord<T> : BookkeepingRecord where T : unmanaged
	{
		public int DataPerEntry;

		private NativeList<T> m_dataList;

		public NativeArray<T> NativeArray
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public T this[int index]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MultiDataNativeRecord(int dataPerEntry)
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
