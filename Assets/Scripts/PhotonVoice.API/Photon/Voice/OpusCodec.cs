using System;
using System.Runtime.CompilerServices;
using POpusCodec;

namespace Photon.Voice
{
	public class OpusCodec
	{
		public enum FrameDuration
		{
			Frame2dot5ms = 2500,
			Frame5ms = 5000,
			Frame10ms = 10000,
			Frame20ms = 20000,
			Frame40ms = 40000,
			Frame60ms = 60000
		}

		public static class Factory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static IEncoder CreateEncoder<B>(VoiceInfo i, ILogger logger)
			{
				throw null;
			}
		}

		public abstract class Encoder<T> : IEncoderDirect<T[]>, IEncoder, IDisposable
		{
			protected OpusEncoder encoder;

			protected bool disposed;

			private Action<ArraySegment<byte>, FrameFlags> output;

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

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected Encoder(VoiceInfo i, ILogger logger)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Input(T[] buf)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void EndOfStream()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ArraySegment<byte> DequeueOutput(out FrameFlags flags)
			{
				throw null;
			}

			protected abstract void encodeTyped(T[] buf);

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
			static Encoder()
			{
				throw null;
			}
		}

		public class EncoderFloat : Encoder<float>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EncoderFloat(VoiceInfo i, ILogger logger) : base(i, logger)
			{
                throw null;
            }

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void encodeTyped(float[] buf)
			{
				throw null;
			}
		}

		public class EncoderShort : Encoder<short>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EncoderShort(VoiceInfo i, ILogger logger) : base(i, logger)
			{
                throw null;
            }

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void encodeTyped(short[] buf)
			{
				throw null;
			}
		}

		public class Decoder<T> : IDecoder, IDisposable
		{
			protected OpusDecoder<T> decoder;

			private ILogger logger;

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
			public Decoder(Action<FrameOut<T>> output, ILogger logger)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Open(VoiceInfo i)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Input(ref FrameBuffer buf)
			{
				throw null;
			}
		}

		public class Util
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static int bestEncoderSampleRate(int f)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Util()
			{
				throw null;
			}
		}

		public static string Version
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpusCodec()
		{

		}
	}
}
