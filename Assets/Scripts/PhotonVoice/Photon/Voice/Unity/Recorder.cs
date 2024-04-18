using System;
using System.Runtime.CompilerServices;
using POpusCodec.Enums;
using Photon.Voice.IOS;
using UnityEngine;
using UnityEngine.Serialization;

namespace Photon.Voice.Unity
{
	[AddComponentMenu("Photon Voice/Recorder")]
	[HelpURL("https://doc.photonengine.com/en-us/voice/v2/getting-started/recorder")]
	[DisallowMultipleComponent]
	public class Recorder : VoiceComponent
	{
		public enum InputSourceType
		{
			Microphone = 0,
			AudioClip = 1,
			Factory = 2
		}

		public enum MicType
		{
			Unity = 0,
			Photon = 1
		}

		public const int MIN_OPUS_BITRATE = 6000;

		public const int MAX_OPUS_BITRATE = 510000;

		[SerializeField]
		private bool voiceDetection;

		[SerializeField]
		private float voiceDetectionThreshold;

		[SerializeField]
		private int voiceDetectionDelayMs;

		private object userData;

		private LocalVoice voice;

		private IAudioDesc inputSource;

		private VoiceConnection voiceConnection;

		[SerializeField]
		[FormerlySerializedAs("audioGroup")]
		private byte interestGroup;

		[SerializeField]
		private bool useTargetPlayers;

		[SerializeField]
		private int[] targetPlayers;

		[SerializeField]
		private bool debugEchoMode;

		[SerializeField]
		private bool reliableMode;

		[SerializeField]
		private bool encrypt;

		[SerializeField]
		private bool transmitEnabled;

		[SerializeField]
		private SamplingRate samplingRate;

		[SerializeField]
		private OpusCodec.FrameDuration frameDuration;

		[SerializeField]
		[Range(6000f, 510000f)]
		private int bitrate;

		[SerializeField]
		private InputSourceType sourceType;

		[SerializeField]
		private MicType microphoneType;

		[SerializeField]
		private AudioClip audioClip;

		[SerializeField]
		private bool loopAudioClip;

		[SerializeField]
		private bool recordingEnabled;

		private Func<IAudioDesc> inputFactory;

		[SerializeField]
		private AudioSessionParameters audioSessionParameters;

		[SerializeField]
		private AndroidAudioInParameters androidMicrophoneSettings;

		private bool isPausedOrInBackground;

		[SerializeField]
		private bool stopRecordingWhenPaused;

		[SerializeField]
		private bool useOnAudioFilterRead;

		[SerializeField]
		private bool useMicrophoneTypeFallback;

		[SerializeField]
		private bool recordWhenJoined;

		private DeviceInfo microphoneDevice;

		private int microphoneDeviceChangePending;

		private int restartRecordingPending;

		public bool TransmitEnabled
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

		public bool Encrypt
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

		public bool DebugEchoMode
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

		public bool ReliableMode
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

		public bool VoiceDetection
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

		public float VoiceDetectionThreshold
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

		public int VoiceDetectionDelayMs
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

		public object UserData
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

		public Func<IAudioDesc> InputFactory
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

		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public byte InterestGroup
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

		public int[] TargetPlayers
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

		public bool IsCurrentlyTransmitting
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public AudioUtil.ILevelMeter LevelMeter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool VoiceDetectorCalibrating
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected ILocalVoiceAudio voiceAudio
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public InputSourceType SourceType
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

		public MicType MicrophoneType
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

		public AudioClip AudioClip
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

		public bool LoopAudioClip
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

		public SamplingRate SamplingRate
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

		public OpusCodec.FrameDuration FrameDuration
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

		public int Bitrate
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

		public bool RecordingEnabled
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

		public bool StopRecordingWhenPaused
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

		public bool UseOnAudioFilterRead
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

		public bool UseMicrophoneTypeFallback
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

		public bool RecordWhenJoined
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

		public DeviceInfo MicrophoneDevice
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

		public bool AndroidMicrophoneAGC
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool AndroidMicrophoneAEC
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool AndroidMicrophoneNS
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void MicrophoneDeviceChangeDetected()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool Init(VoiceConnection connection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool Deinit(VoiceConnection connection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RestartRecording()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VoiceDetectorCalibrate(int durationMs, Action<float> detectionEndedCallback = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartRecording()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopRecording()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetIosAudioSessionParameters(AudioSessionParameters asp)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetIosAudioSessionParameters(AudioSessionCategory category, AudioSessionMode mode, AudioSessionCategoryOption[] options)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetAndroidNativeMicrophoneSettings(bool aec = false, bool agc = false, bool ns = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ResetLocalAudio()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private LocalVoice CreateLocalVoiceAudioAndSource()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SendPhotonVoiceCreatedMessage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleDeviceChange()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationPause(bool paused)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationFocus(bool focused)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleApplicationPause(bool paused)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Recorder()
		{

		}
	}
}
