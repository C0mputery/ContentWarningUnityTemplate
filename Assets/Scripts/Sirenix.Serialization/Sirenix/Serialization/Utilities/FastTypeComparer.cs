using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization.Utilities
{
	public class FastTypeComparer : IEqualityComparer<Type>
	{
		public static readonly FastTypeComparer Instance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Type x, Type y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashCode(Type obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FastTypeComparer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FastTypeComparer()
		{
			throw null;
		}
	}
}
