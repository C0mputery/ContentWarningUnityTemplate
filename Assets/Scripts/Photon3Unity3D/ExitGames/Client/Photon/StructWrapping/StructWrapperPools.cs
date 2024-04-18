using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon.StructWrapping
{
	public class StructWrapperPools
	{
		public static readonly StructWrapper<byte>[] mappedByteWrappers;

		public static readonly StructWrapper<bool>[] mappedBoolWrappers;

		private readonly Dictionary<Type, StructWrapperPool> pools;

		private readonly List<IDisposable> used;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private StructWrapperPool<T> GetPoolForType<T>()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapper<byte> Acquire(byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapper<bool> Acquire(bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapper<T> Acquire<T>(T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapperPools()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static StructWrapperPools()
		{
			throw null;
		}
	}
}
