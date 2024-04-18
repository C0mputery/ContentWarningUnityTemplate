using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		private Factory factory;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImageBufferNativePool(int capacity, Factory factory, string name) : base(69, null)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info) : base(69, null)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override T createObject(ImageBufferInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void destroyObject(T obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			throw null;
		}
	}
}
