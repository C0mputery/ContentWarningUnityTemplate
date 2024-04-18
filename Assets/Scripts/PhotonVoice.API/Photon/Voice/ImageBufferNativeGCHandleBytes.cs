using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Photon.Voice
{
	public class ImageBufferNativeGCHandleBytes : ImageBufferNative, IDisposable
	{
		private ImageBufferNativePool<ImageBufferNativeGCHandleBytes> pool;

		private readonly GCHandle[] planeHandle;

		private readonly byte[][] planeBytes;

		public byte[][] PlaneBytes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImageBufferNativeGCHandleBytes(ImageBufferNativePool<ImageBufferNativeGCHandleBytes> pool, ImageBufferInfo info) : base(new ImageBufferInfo())
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
