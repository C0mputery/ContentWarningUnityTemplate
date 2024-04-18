using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class FactoryPrimitiveArrayPool<T> : ObjectFactory<T[], int>, IDisposable
	{
		private PrimitiveArrayPool<T> pool;

		public int Info
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FactoryPrimitiveArrayPool(int capacity, string name)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FactoryPrimitiveArrayPool(int capacity, string name, int info)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T[] New()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T[] New(int size)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Free(T[] obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Free(T[] obj, int info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}
	}
}
