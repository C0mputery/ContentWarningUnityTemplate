using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Photon.Voice
{
	public class WebRTCAudioProcessor : WebRTCAudioLib, IProcessor<short>, IDisposable
	{
		private const int REVERSE_BUFFER_POOL_CAPACITY = 50;

		private int reverseStreamDelayMs;

		private bool aec;

		private bool aecHighPass;

		private bool aecm;

		private bool highPass;

		private bool ns;

		private bool agc;

		private int agcCompressionGain;

		private int agcTargetLevel;

		private bool agc2;

		private bool vad;

		private bool reverseStreamThreadRunning;

		private Queue<short[]> reverseStreamQueue;

		private AutoResetEvent reverseStreamQueueReady;

		private FactoryPrimitiveArrayPool<short> reverseBufferFactory;

		private bool bypass;

		private int inFrameSize;

		private int processFrameSize;

		private int samplingRate;

		private int channels;

		private IntPtr proc;

		private bool disposed;

		private Framer<float> reverseFramer;

		private int reverseSamplingRate;

		private int reverseChannels;

		private ILogger logger;

		private const int supportedFrameLenMs = 10;

		public static readonly int[] SupportedSamplingRates;

		private bool aecInited;

		private int lastProcessErr;

		private int lastProcessReverseErr;

		public int AECStreamDelayMs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool AEC
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool AECHighPass
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool AECMobile
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool HighPass
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool NoiseSuppression
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool AGC
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public int AGCCompressionGain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public int AGCTargetLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool AGC2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool VAD
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool Bypass
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			private get
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
		public WebRTCAudioProcessor(ILogger logger, int frameSize, int samplingRate, int channels, int reverseSamplingRate, int reverseChannels)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitReverseStream()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public short[] Process(short[] buf)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnAudioOutFrameFloat(float[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReverseStreamThread()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int setParam(Param param, int v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WebRTCAudioProcessor()
		{
			throw null;
		}
	}
}
