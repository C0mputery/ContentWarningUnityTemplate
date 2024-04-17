using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Photon.Voice
{
	[Obsolete("Requres regular allocations of byte[]. May leak if used w/o pool. Use ImageBufferNativeGCHandleBytes with Texture2D.GetRawTextureData<byte>().CopyTo(b.PlaneBytes)) instead")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		private GCHandle planeHandle;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info) : base(new ImageBufferInfo())
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PinPlane(byte[] plane)
		{
			throw null;
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
