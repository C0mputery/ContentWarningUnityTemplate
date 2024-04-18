using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

namespace Photon.Voice.Unity
{
	[AddComponentMenu("Photon Voice/Unity Voice Client")]
	[HelpURL("https://doc.photonengine.com/en-us/voice/v2/getting-started/voice-intro")]
	public class UnityVoiceClient : VoiceConnection
	{
		[SerializeField]
		public bool UseVoiceAppSettings;

		public override bool AlwaysUsePrimaryRecorder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ConnectUsingSettings(AppSettings overwriteSettings = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Speaker InstantiateSpeakerForRemoteVoice(int playerId, byte voiceId, object userData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnityVoiceClient()
		{

		}
	}
}
