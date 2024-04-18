using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	[Serializable]
	public class ImmutableHashSet<T> : IEnumerable<T>, IEnumerable
	{
		private readonly HashSet<T> hashSet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImmutableHashSet(HashSet<T> hashSet)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(T item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<T> GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
