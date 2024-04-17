using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	[RequireComponent(typeof(AudioSource))]
	[AddComponentMenu("Photon Voice/Speaker")]
	[DisallowMultipleComponent]
	public class Speaker : VoiceComponent
	{
		protected IAudioOut<float> audioOutput;

		[SerializeField]
		protected AudioOutDelayControl.PlayDelayConfig playDelayConfig;

		[SerializeField]
		protected bool restartOnDeviceChange;

		private int restartPlaybackPending;

		public bool IsPlaying
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Lag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Action<Speaker> OnRemoteVoiceRemoveAction
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

		public RemoteVoiceLink RemoteVoice
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

		public bool IsLinked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public AudioOutDelayControl.PlayDelayConfig PlayDelayConfig
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

		public int PlayDelay
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

		public bool RestartOnDeviceChange
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
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AudioConfigurationChangeHandler(bool deviceWasChanged)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IAudioOut<float> CreateAudioOut()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool Link(RemoteVoiceLink stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRemoteVoiceRemove()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAudioFrame(FrameOut<float> frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool StartPlayback()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopPlayback()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Unlink()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RestartPlayback()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Speaker()
		{
			throw null;
		}
	}
}
