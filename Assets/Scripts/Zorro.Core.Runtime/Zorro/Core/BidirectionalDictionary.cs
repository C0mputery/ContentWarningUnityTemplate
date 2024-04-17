using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class BidirectionalDictionary<T1, T2> : IEnumerable
	{
		private Dictionary<T1, T2> t1ToT2Dict;

		private Dictionary<T2, T1> t2ToT1Dict;

		public IEnumerable<T1> FirstTypes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IEnumerable<T2> SecondTypes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
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
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidirectionalDictionary(int capacity)
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
		public bool ContainsKey(T1 key)
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
		public IEnumerable<T2> GetValues()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<T1> GetKeys()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}
	}
}
