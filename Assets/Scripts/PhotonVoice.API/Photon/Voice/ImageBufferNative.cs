using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class ImageBufferNative
	{
		public struct PlaneSet
		{
			private IntPtr plane0;

			private IntPtr plane1;

			private IntPtr plane2;

			private IntPtr plane3;

			public IntPtr this[int key]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					throw null;
				}
			}

			public int Length
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				readonly get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				private set
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PlaneSet(int length, IntPtr p0 = default(IntPtr), IntPtr p1 = default(IntPtr), IntPtr p2 = default(IntPtr), IntPtr p3 = default(IntPtr))
			{
				throw null;
			}
		}

		public ImageBufferInfo Info;

		public PlaneSet Planes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImageBufferNative(ImageBufferInfo info)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImageBufferNative(IntPtr buf, int width, int height, int stride, ImageFormat imageFormat)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Release()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}
	}
}
