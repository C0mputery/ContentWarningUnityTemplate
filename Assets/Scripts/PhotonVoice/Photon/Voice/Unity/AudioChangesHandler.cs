using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	[RequireComponent(typeof(Recorder))]
	[AddComponentMenu("Photon Voice/Audio Changes Handler")]
	[DisallowMultipleComponent]
	public class AudioChangesHandler : VoiceComponent
	{
		private IAudioInChangeNotifier photonMicChangeNotifier;

		private Recorder recorder;

		[Tooltip("React to device change notification when Recorder is started.")]
		public bool HandleDeviceChange;

		[Tooltip("iOS: React to device change notification when Recorder is started.")]
		public bool HandleDeviceChangeIOS;

		[Tooltip("Android: React to device change notification when Recorder is started.")]
		public bool HandleDeviceChangeAndroid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PhotonMicrophoneChangeDetected()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDeviceChange()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAudioConfigChanged(bool deviceWasChanged)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioChangesHandler()
		{
			throw null;
		}
	}
}
