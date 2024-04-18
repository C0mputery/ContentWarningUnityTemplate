using System.Runtime.CompilerServices;
using Photon.Pun;
using Photon.Voice.Unity;
using UnityEngine;

namespace Photon.Voice.PUN
{
	[AddComponentMenu("Photon Voice/PUN/Photon Voice View")]
	[RequireComponent(typeof(PhotonView))]
	[HelpURL("https://doc.photonengine.com/en-us/voice/v2/getting-started/voice-for-pun")]
	public class PhotonVoiceView : VoiceComponent
	{
		private PhotonView photonView;

		private PunVoiceClient punVoiceClient;

		public Recorder RecorderInUse
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

		public Speaker SpeakerInUse
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

		public bool IsSpeaking
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsRecording
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
		private void SetupRecorder()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupSpeaker()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonVoiceView()
		{

		}
	}
}
