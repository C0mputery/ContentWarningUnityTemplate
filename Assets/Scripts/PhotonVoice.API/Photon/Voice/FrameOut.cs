using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class FrameOut<T>
	{
		public T[] Buf
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
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

		public bool EndOfStream
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
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
		public FrameOut(T[] buf, bool endOfStream)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FrameOut<T> Set(T[] buf, bool endOfStream)
		{
			throw null;
		}
	}
}
