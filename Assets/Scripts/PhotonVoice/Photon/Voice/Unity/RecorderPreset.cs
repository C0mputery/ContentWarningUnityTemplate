using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	[AddComponentMenu("Photon Voice/Recorder Preset")]
	public class RecorderPreset : VoiceComponent
	{
		[Serializable]
		public struct DSP
		{
			[Tooltip("Acoustic Echo Cancellation")]
			public bool AEC;

			[Tooltip("Voice Activity Detection")]
			public bool VAD;
		}

		[Tooltip("On which platform to apply the filter.")]
		public RuntimePlatform Platform;

		[Tooltip("Which microphone API to use when the Source is set to Microphone.")]
		[Header("Overrides:")]
		public Recorder.MicType MicrophoneType;

		[Tooltip("Enable WebRtcAudioDsp component.")]
		public bool DSPEnabled;

		public DSP DSPSettings;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RecorderPreset()
		{
			throw null;
		}
	}
}
