using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class Pool<T> where T : class
	{
		private readonly Func<T> createFunction;

		private readonly Queue<T> pool;

		private readonly Action<T> resetFunction;

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Pool(Func<T> createFunction, Action<T> resetFunction, int poolCapacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Pool(Func<T> createFunction, int poolCapacity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreatePoolItems(int numItems)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use Release() rather than Push()")]
		public void Push(T item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Release(T item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use Acquire() rather than Pop()")]
		public T Pop()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Acquire()
		{
			throw null;
		}
	}
}
