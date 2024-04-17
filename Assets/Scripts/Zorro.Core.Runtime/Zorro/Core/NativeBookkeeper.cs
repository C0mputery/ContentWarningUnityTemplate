using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class NativeBookkeeper<T> : IDisposable, INativeBookkeeper
	{
		protected List<BookkeepingRecord> m_bookKeepingRecords;

		protected BidirectionalDictionary<T, int> m_bookkeepingIndexer;

		protected PerformantList<T> m_keys;

		protected int recordsCount;

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NativeBookkeeper(int defaultCapacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PerformantList<T> GetKeyList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterRecord(BookkeepingRecord record)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int Add(T newEntry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T GetKeyFromIndex(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual BookkeperRemovalInfo Remove(T entry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetIndex(T entry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T GetFromIndex(int i)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(T mesh)
		{
			throw null;
		}
	}
}
