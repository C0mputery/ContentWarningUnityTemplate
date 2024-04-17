using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public static class IEnumerableExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T RandomElement<T>(this IEnumerable<T> enumerable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T MaxBy<T>(this IEnumerable<T> enumerable, Func<T, IComparable> selector)
		{
			throw null;
		}
	}
}
