using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zorro.Core
{
	public static class Volatile
	{
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		public struct PaddedLong
		{
			[FieldOffset(64)]
			private long _value;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PaddedLong(long value)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public long ReadUnfenced()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public long ReadAcquireFence()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public long ReadFullFence()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
			public long ReadCompilerOnlyFence()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void WriteReleaseFence(long newValue)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void WriteFullFence(long newValue)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
			public void WriteCompilerOnlyFence(long newValue)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void WriteUnfenced(long newValue)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool AtomicCompareExchange(long newValue, long comparand)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public long AtomicExchange(long newValue)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public long AtomicAddAndGet(long delta)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public long AtomicIncrementAndGet()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public long AtomicDecrementAndGet()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}
		}

		private const int CacheLineSize = 64;
	}
}
