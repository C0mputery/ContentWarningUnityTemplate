using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public static class DelegateExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Func<TResult> Memoize<TResult>(this Func<TResult> getValue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Func<T, TResult> Memoize<T, TResult>(this Func<T, TResult> func)
		{
			throw null;
		}
	}
}
