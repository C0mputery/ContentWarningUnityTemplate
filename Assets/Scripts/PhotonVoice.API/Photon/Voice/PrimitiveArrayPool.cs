using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrimitiveArrayPool(int capacity, string name) : base(69, null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrimitiveArrayPool(int capacity, string name, int info) : base(69, null)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override T[] createObject(int info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void destroyObject(T[] obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool infosMatch(int i0, int i1)
		{
			throw null;
		}
	}
}
