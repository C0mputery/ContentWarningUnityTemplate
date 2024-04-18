using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon.StructWrapping
{
	public class StructWrapperPool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static WrappedType GetWrappedType(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapperPool()
		{

		}
	}
	public class StructWrapperPool<T> : StructWrapperPool
	{
		public const int GROWBY = 4;

		public readonly Type tType;

		public readonly WrappedType wType;

		public Stack<StructWrapper<T>> pool;

		public readonly bool isStaticPool;

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapperPool(bool isStaticPool)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapper<T> Acquire()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapper<T> Acquire(T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Release(StructWrapper<T> obj)
		{
			throw null;
		}
	}
}
