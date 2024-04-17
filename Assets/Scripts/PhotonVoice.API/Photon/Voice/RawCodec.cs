using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class RawCodec
	{
		public class Encoder<T> : IEncoderDirect<T[]>, IEncoder, IDisposable
		{
			private int sizeofT;

			private byte[] byteBuf;

			private static readonly ArraySegment<byte> EmptyBuffer;

			public string Error
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

			public Action<ArraySegment<byte>, FrameFlags> Output
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
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
			public ArraySegment<byte> DequeueOutput(out FrameFlags flags)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void EndOfStream()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public I GetPlatformAPI<I>() where I : class
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Input(T[] buf)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Encoder()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Encoder()
			{
				throw null;
			}
		}

		public class Decoder<T> : IDecoder, IDisposable
		{
			private T[] buf;

			private int sizeofT;

			private Action<FrameOut<T>> output;

			public string Error
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
			public Decoder(Action<FrameOut<T>> output)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Open(VoiceInfo info)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Input(ref FrameBuffer byteBuf)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		public class ShortToFloat
		{
			private Action<FrameOut<float>> output;

			private float[] buf;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ShortToFloat(Action<FrameOut<float>> output)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Output(FrameOut<short> shortBuf)
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RawCodec()
		{
			throw null;
		}
	}
}
