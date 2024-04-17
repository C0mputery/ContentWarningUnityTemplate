using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Zorro.Core
{
	public class UnmanagedNativeBookkeeper<T> : IDisposable, INativeBookkeeper where T : unmanaged
	{
		protected List<BookkeepingRecord> m_bookKeepingRecords;

		protected BidirectionalDictionary<T, int> m_bookkeepingIndexer;

		public NativeList<T> Keys;

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
		public UnmanagedNativeBookkeeper(int defaultCapacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterRecord(BookkeepingRecord record)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
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
		public bool HasKey(T key)
		{
			throw null;
		}
	}
}
