using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class FactoryReusableArray<T> : ObjectFactory<T[], int>, IDisposable
	{
		private T[] arr;

		public int Info
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FactoryReusableArray(int size)
		{
			throw null;
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
