using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info) : base(new ImageBufferInfo())
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Release()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}
	}
}
