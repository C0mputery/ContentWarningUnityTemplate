using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class AudioSyncBuffer<T> : AudioOutDelayControl<T>
	{
		private T[] buffer;

		private int readPosSamples;

		private int sampleRate;

		private int channels;

		private int bufferSamples;

		private bool started;

		public override long OutPos
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioSyncBuffer(PlayDelayConfig playDelayConfig, ILogger logger, string logPrefix, bool debugInfo) : base(false, new PlayDelayConfig(), null, null, false)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OutCreate(int frequency, int channels, int bufferSamples)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OutStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OutWrite(T[] data, int offsetSamples)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Stop()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Read(T[] outBuf, int outChannels, int outSampleRate)
		{
			throw null;
		}
	}
}
