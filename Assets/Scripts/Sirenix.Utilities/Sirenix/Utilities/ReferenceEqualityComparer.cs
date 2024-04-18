using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public class ReferenceEqualityComparer<T> : IEqualityComparer<T> where T : class
	{
		public static readonly ReferenceEqualityComparer<T> Default;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(T x, T y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashCode(T obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReferenceEqualityComparer()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ReferenceEqualityComparer()
		{
			throw null;
		}
	}
}
