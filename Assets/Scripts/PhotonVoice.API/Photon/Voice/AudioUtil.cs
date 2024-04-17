using System;
using System.Runtime.CompilerServices;
using System.Timers;

namespace Photon.Voice
{
	public static class AudioUtil
	{
		public abstract class GeneratorReader<T> : IAudioReader<T>, IDataReader<T>, IDisposable, IAudioDesc
		{
			private long timeSamples;

			private Func<double> clockSec;

			public int Channels
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public int SamplingRate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

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
			public GeneratorReader(Func<double> clockSec = null, int samplingRate = 48000, int channels = 1)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Read(T[] buf)
			{
				throw null;
			}

			protected abstract int Gen(T[] buf, long timeSamples);
		}

		public abstract class GeneratorPusher<T> : IAudioPusher<T>, IAudioDesc, IDisposable
		{
			private Timer timer;

			private Action<T[]> callback;

			private ObjectFactory<T[], int> bufferFactory;

			protected long timeSamples;

			private int bufSamples;

			public int Channels
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public int SamplingRate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

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
			public GeneratorPusher(int bufSizeMs = 100, int samplingRate = 48000, int channels = 1)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetCallback(Action<T[]> callback, ObjectFactory<T[], int> bufferFactory)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void OnTimedEvent(object source, ElapsedEventArgs e)
			{
				throw null;
			}

			protected abstract int Gen(T[] buf, long timeSamples);

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		public class ToneAudioReader<T> : GeneratorReader<T>
		{
			private double k;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ToneAudioReader(Func<double> clockSec = null, double frequency = 440.0, int samplingRate = 48000, int channels = 1)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override int Gen(T[] buf, long timeSamples)
			{
				throw null;
			}
		}

		public class ToneAudioPusher<T> : GeneratorPusher<T>
		{
			private double k;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ToneAudioPusher(int frequency = 440, int bufSizeMs = 100, int samplingRate = 48000, int channels = 1)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override int Gen(T[] buf, long timeSamples)
			{
				throw null;
			}
		}

		public class WaveformAudioReader<T> : GeneratorReader<T>
		{
			public T[] Waveform
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				private get
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
			public WaveformAudioReader(Func<double> clockSec = null, int samplingRate = 48000, int channels = 1)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override int Gen(T[] buf, long timeSamples)
			{
				throw null;
			}
		}

		public class WaveformAudioPusher<T> : GeneratorPusher<T>
		{
			public T[] Waveform
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				private get
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
			public WaveformAudioPusher(int bufSizeMs = 100, int samplingRate = 48000, int channels = 1)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override int Gen(T[] buf, long timeSamples)
			{
				throw null;
			}
		}

		public class TempoUp<T>
		{
			private readonly int sizeofT;

			private int channels;

			private int skipGroup;

			private int skipFactor;

			private int sign;

			private int waveCnt;

			private bool skipping;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Begin(int channels, int changePerc, int skipGroup)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Process(T[] s, T[] d)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int End(T[] s)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private int processFloat(float[] s, float[] d)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int endFloat(float[] s)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private int processShort(short[] s, short[] d)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int endShort(short[] s)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TempoUp()
			{
				throw null;
			}
		}

		public class Resampler<T> : IProcessor<T>, IDisposable
		{
			protected T[] frameResampled;

			private int channels;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Resampler(int dstSize, int channels)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public T[] Process(T[] buf)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		public interface ILevelMeter
		{
			float CurrentAvgAmp { get; }

			float CurrentPeakAmp { get; }

			float AccumAvgPeakAmp { get; }

			void ResetAccumAvgPeakAmp();
		}

		public class LevelMeterDummy : ILevelMeter
		{
			public float CurrentAvgAmp
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public float CurrentPeakAmp
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public float AccumAvgPeakAmp
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ResetAccumAvgPeakAmp()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LevelMeterDummy()
			{
				throw null;
			}
		}

		public abstract class LevelMeter<T> : IProcessor<T>, IDisposable, ILevelMeter
		{
			protected float ampSum;

			protected float ampPeak;

			protected int bufferSize;

			protected float[] prevValues;

			protected int prevValuesHead;

			protected float accumAvgPeakAmpSum;

			protected int accumAvgPeakAmpCount;

			protected float currentPeakAmp;

			protected float norm;

			public float CurrentAvgAmp
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public float CurrentPeakAmp
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			public float AccumAvgPeakAmp
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal LevelMeter(int samplingRate, int numChannels)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ResetAccumAvgPeakAmp()
			{
				throw null;
			}

			public abstract T[] Process(T[] buf);

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		public class LevelMeterFloat : LevelMeter<float>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public LevelMeterFloat(int samplingRate, int numChannels) : base(samplingRate, numChannels)
			{
                throw null;
            }

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override float[] Process(float[] buf)
			{
				throw null;
			}
		}

		public class LevelMeterShort : LevelMeter<short>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public LevelMeterShort(int samplingRate, int numChannels) : base(samplingRate, numChannels)
			{
                throw null;
            }

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override short[] Process(short[] buf)
			{
				throw null;
			}
		}

		public interface IVoiceDetector
		{
			bool On { get; set; }

			float Threshold { get; set; }

			bool Detected { get; }

			DateTime DetectedTime { get; }

			int ActivityDelayMs { get; set; }

			event Action OnDetected;
		}

		public class VoiceDetectorCalibration<T> : IProcessor<T>, IDisposable
		{
			private IVoiceDetector voiceDetector;

			private ILevelMeter levelMeter;

			private int valuesPerSec;

			protected int calibrateCount;

			private Action<float> onCalibrated;

			public bool IsCalibrating
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Calibrate(int durationMs, Action<float> onCalibrated = null)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public T[] Process(T[] buf)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		public class VoiceDetectorDummy : IVoiceDetector
		{
			public bool On
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

			public float Threshold
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

			public bool Detected
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public int ActivityDelayMs
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

			public DateTime DetectedTime
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

			public event Action OnDetected
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				add
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				remove
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VoiceDetectorDummy()
			{
				throw null;
			}
		}

		public abstract class VoiceDetector<T> : IProcessor<T>, IDisposable, IVoiceDetector
		{
			protected float norm;

			protected float threshold;

			private bool detected;

			protected int activityDelay;

			protected int autoSilenceCounter;

			protected int valuesCountPerSec;

			protected int activityDelayValuesCount;

			public bool On
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

			public float Threshold
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

			public bool Detected
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			public DateTime DetectedTime
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

			public int ActivityDelayMs
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

			public event Action OnDetected
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				add
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				remove
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
				throw null;
			}

			public abstract T[] Process(T[] buf);

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public VoiceDetectorFloat(int samplingRate, int numChannels) : base(samplingRate, numChannels)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override float[] Process(float[] buffer)
			{
				throw null;
			}
		}

		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public VoiceDetectorShort(int samplingRate, int numChannels) : base(samplingRate, numChannels)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override short[] Process(short[] buffer)
			{
				throw null;
			}
		}

		public class VoiceLevelDetectCalibrate<T> : IProcessor<T>, IDisposable
		{
			private VoiceDetectorCalibration<T> calibration;

			public ILevelMeter LevelMeter
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

			public IVoiceDetector VoiceDetector
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

			public bool IsCalibrating
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Calibrate(int durationMs, Action<float> onCalibrated = null)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public T[] Process(T[] buf)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int ToneToBuf<T>(T[] buf, long timeSamples, int channels, double amp, double k, double phaseMod = 0.0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int ToneToBuf<T>(T[] buf, int offset, int length, long timeSamples, int channels, double amp, double k, double phaseMod = 0.0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int WaveformToBuf<T>(T[] buf, T[] waveform, long timePos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Resample<T>(T[] src, int srcOffset, int srcCount, T[] dst, int dstOffset, int dstCount, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Resample<T>(T[] src, int srcOffset, int srcCount, int srcChannels, T[] dst, int dstOffset, int dstCount, int dstChannels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			throw null;
		}
	}
}
