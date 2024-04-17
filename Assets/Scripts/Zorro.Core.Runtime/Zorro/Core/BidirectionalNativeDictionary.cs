using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Zorro.Core
{
	public struct BidirectionalNativeDictionary<T1, T2> : IDisposable where T1 : unmanaged, IEquatable<T1> where T2 : unmanaged, IEquatable<T2>
	{
		private NativeParallelHashMap<T1, T2> t1ToT2Dict;

		private NativeParallelHashMap<T2, T1> t2ToT1Dict;

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidirectionalNativeDictionary(int capacity, Allocator allocator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(T1 key, T2 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T2 GetFromKey(T1 key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T1 GetKeyFromValue(T2 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T1 Get(T2 key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetValue(T1 key, out T2 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetValue(T2 key, out T1 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(T1 key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(T2 key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFromKey(T1 key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T1 RemoveFromValue(T2 key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NativeParallelHashMap<T1, T2> GetNativeHashMapT1toT2()
		{
			throw null;
		}
	}
}
