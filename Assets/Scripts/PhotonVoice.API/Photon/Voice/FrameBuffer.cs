using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Photon.Voice
{
	public struct FrameBuffer
	{
		private readonly byte[] array;

		private readonly int offset;

		private readonly int count;

		private readonly IDisposable disposer;

		private bool disposed;

		private int refCnt;

		private GCHandle gcHandle;

		private IntPtr ptr;

		private bool pinned;

		internal static int statDisposerCreated;

		internal static int statDisposerDisposed;

		internal static int statPinned;

		internal static int statUnpinned;

		public IntPtr Ptr
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public byte[] Array
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Length
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Offset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public readonly FrameFlags Flags
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public readonly byte FrameNum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsFEC
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsConfig
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsKeyframe
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FrameBuffer(byte[] array, int offset, int count, FrameFlags flags, byte frameNum, IDisposable disposer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FrameBuffer(byte[] array, FrameFlags flags, byte frameNum)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FrameBuffer(FrameBuffer from, int offset, int count, FrameFlags flags, byte frameNum)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Retain()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Release()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FrameBuffer()
		{
			throw null;
		}
	}
}
