using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class Buffer<T> : IDisposable
	{
		private static readonly object LOCK;

		private static readonly List<Buffer<T>> FreeBuffers;

		private int count;

		private T[] array;

		private volatile bool isFree;

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public T[] Array
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsFree
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Buffer(int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Buffer<T> Claim(int minimumCapacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Free(Buffer<T> buffer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Free()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int NextPowerOfTwo(int v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Buffer()
		{
			throw null;
		}
	}
}
