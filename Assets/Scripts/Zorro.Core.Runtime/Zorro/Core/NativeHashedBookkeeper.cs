using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class NativeHashedBookkeeper<T> : NativeBookkeeper<T> where T : unmanaged, IEquatable<T>
	{
		public BidirectionalNativeDictionary<T, int> IndexHashMap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NativeHashedBookkeeper(int defaultCapacity) : base(69)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int Add(T newEntry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BookkeperRemovalInfo Remove(T entry)
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
