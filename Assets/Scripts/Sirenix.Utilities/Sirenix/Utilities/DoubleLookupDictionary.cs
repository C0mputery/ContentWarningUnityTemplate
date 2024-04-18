using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	[Serializable]
	public class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>
	{
		private readonly IEqualityComparer<TSecondKey> secondKeyComparer;

		public new Dictionary<TSecondKey, TValue> this[TFirstKey firstKey]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DoubleLookupDictionary()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DoubleLookupDictionary(IEqualityComparer<TFirstKey> firstKeyComparer, IEqualityComparer<TSecondKey> secondKeyComparer)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int InnerCount(TFirstKey firstKey)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int TotalInnerCount()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ContainsKeys(TFirstKey firstKey, TSecondKey secondKey)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetInnerValue(TFirstKey firstKey, TSecondKey secondKey, out TValue value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TValue AddInner(TFirstKey firstKey, TSecondKey secondKey, TValue value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RemoveInner(TFirstKey firstKey, TSecondKey secondKey)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveWhere(Func<TValue, bool> predicate)
		{
			throw null;
		}
	}
}
