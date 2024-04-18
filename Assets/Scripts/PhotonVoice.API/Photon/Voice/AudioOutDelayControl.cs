using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class AudioOutDelayControl
	{
		[Serializable]
		public struct PlayDelayConfig
		{
			public static PlayDelayConfig Default;

			public int Low;

			public int High;

			public int Max;

			public int SpeedUpPerc;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static PlayDelayConfig()
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioOutDelayControl()
		{

		}
	}
	public abstract class AudioOutDelayControl<T> : AudioOutDelayControl, IAudioOut<T>
	{
		protected readonly int sizeofT;

		private const int TEMPO_UP_SKIP_GROUP = 6;

		private int frameSamples;

		private int frameSize;

		private int bufferSamples;

		private int bufferSamplesHalf;

		private int frequency;

		private int writeSamplePos;

		private int clearSamplePos;

		private int playSamplePos;

		private PlayDelayConfig playDelayConfig;

		private int channels;

		private bool started;

		private bool flushed;

		private int targetDelaySamples;

		private int upperTargetDelaySamples;

		private int maxDelaySamples;

		private const int NO_PUSH_TIMEOUT_MS = 120;

		private int lastPushTime;

		protected readonly ILogger logger;

		protected readonly string logPrefix;

		private readonly bool debugInfo;

		private readonly bool processInService;

		private T[] zeroFrame;

		private T[] resampledFrame;

		private AudioUtil.TempoUp<T> tempoUp;

		private bool tempoChangeHQ;

		private ConcurrentQueue<T[]> frameQueue;

		public const int FRAME_POOL_CAPACITY = 50;

		private PrimitiveArrayPool<T> framePool;

		private bool catchingUp;

		public abstract long OutPos { get; }

		public int Lag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsFlushed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsPlaying
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public abstract void OutCreate(int frequency, int channels, int bufferSamples);

		public abstract void OutStart();

		public abstract void OutWrite(T[] data, int offsetSamples);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsZeroFrame(T[] f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioOutDelayControl(bool processInService, PlayDelayConfig playDelayConfig, ILogger logger, string logPrefix, bool debugInfo)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start(int frequency, int channels, int frameSamples)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void processFrame(T[] frame, int playSamplePos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Service()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int writeResampled(T[] f, int resampledLenSamples)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Push(T[] frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Flush()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Stop()
		{
			throw null;
		}
	}
}
