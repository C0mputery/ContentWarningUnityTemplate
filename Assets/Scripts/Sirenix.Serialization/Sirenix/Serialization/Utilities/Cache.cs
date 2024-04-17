using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization.Utilities
{
	public sealed class Cache<T> : ICache, IDisposable where T : class, new()
	{
		private static readonly bool IsNotificationReceiver;

		private static object[] FreeValues;

		private bool isFree;

		private static volatile int THREAD_LOCK_TOKEN;

		private static int maxCacheSize;

		public T Value;

		public static int MaxCacheSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
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

		object ICache.Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Cache()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Cache<T> Claim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Release(Cache<T> cache)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator T(Cache<T> cache)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Release()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Cache()
		{
			throw null;
		}
	}
}
