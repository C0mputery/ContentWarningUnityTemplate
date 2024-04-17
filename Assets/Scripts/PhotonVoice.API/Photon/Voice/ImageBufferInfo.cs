using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public struct ImageBufferInfo
	{
		public struct StrideSet
		{
			private int stride0;

			private int stride1;

			private int stride2;

			private int stride3;

			public int this[int key]
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
			public StrideSet(int length, int s0 = 0, int s1 = 0, int s2 = 0, int s3 = 0)
			{
				throw null;
			}
		}

		public readonly int Width
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public readonly int Height
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public readonly StrideSet Stride
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public readonly ImageFormat Format
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Rotation Rotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public Flip Flip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImageBufferInfo(int width, int height, StrideSet stride, ImageFormat format)
		{
			throw null;
		}
	}
}
