using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	[RequireComponent(typeof(Recorder))]
	[AddComponentMenu("Photon Voice/WebRTC Audio DSP")]
	[DisallowMultipleComponent]
	public class WebRtcAudioDsp : VoiceComponent
	{
		[SerializeField]
		private bool aec;

		[SerializeField]
		private bool aecHighPass;

		[SerializeField]
		private bool agc;

		[SerializeField]
		[Range(0f, 90f)]
		private int agcCompressionGain;

		[SerializeField]
		[Range(0f, 31f)]
		private int agcTargetLevel;

		[SerializeField]
		private bool vad;

		[SerializeField]
		private bool highPass;

		private bool bypass;

		[SerializeField]
		private bool noiseSuppression;

		[SerializeField]
		private int reverseStreamDelayMs;

		private int reverseChannels;

		private WebRTCAudioProcessor proc;

		private static readonly Dictionary<AudioSpeakerMode, int> channelsMap;

		private LocalVoiceAudioShort localVoice;

		private int outputSampleRate;

		public bool AEC
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

		public bool AecHighPass
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

		public int ReverseStreamDelayMs
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

		public bool NoiseSuppression
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

		public bool HighPass
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

		public bool Bypass
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

		public bool AGC
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

		public int AgcCompressionGain
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

		public int AgcTargetLevel
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

		public bool VAD
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

		public bool IsSupported
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AdjustVoiceInfo(ref VoiceInfo voiceInfo, ref AudioSampleType st)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAudioConfigurationChanged(bool deviceWasChanged)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAudioOutFrameFloat(float[] data, int outChannels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PhotonVoiceCreated(PhotonVoiceCreatedParams p)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PhotonVoiceRemoved()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartProc(LocalVoiceAudioShort v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopProc(LocalVoiceAudioShort v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Restart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setOutputListener(bool set)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void applyToProc()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebRtcAudioDsp()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WebRtcAudioDsp()
		{
			throw null;
		}
	}
}
