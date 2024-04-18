using System.Runtime.CompilerServices;
using Photon.Realtime;
using Photon.Voice.Unity;
using UnityEngine;

namespace Photon.Voice.PUN
{
	[AddComponentMenu("Photon Voice/PUN/Pun Voice Client")]
	[HelpURL("https://doc.photonengine.com/en-us/voice/v2/getting-started/voice-for-pun")]
	public class PunVoiceClient : VoiceFollowClient
	{
		public const string VoiceRoomNameSuffix = "_voice_";

		private static PunVoiceClient instance;

		[SerializeField]
		private bool usePunAppSettings;

		[SerializeField]
		private bool usePunAuthValues;

		protected override bool LeaderInRoom
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override bool LeaderOfflineMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static PunVoiceClient Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool UsePunAppSettings
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

		public bool UsePunAuthValues
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
		protected override void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Speaker InstantiateSpeakerForRemoteVoice(int playerId, byte voiceId, object userData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override string GetVoiceRoomName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPunStateChange(ClientState s1, ClientState s2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool ConnectVoice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PunVoiceClient()
		{

		}
	}
}
