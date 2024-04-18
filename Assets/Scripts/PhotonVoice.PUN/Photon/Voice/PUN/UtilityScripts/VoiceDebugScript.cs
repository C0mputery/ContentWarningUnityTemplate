using System.Runtime.CompilerServices;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace Photon.Voice.PUN.UtilityScripts
{
	[RequireComponent(typeof(PhotonVoiceView))]
	public class VoiceDebugScript : MonoBehaviourPun
	{
		private PhotonVoiceView photonVoiceView;

		public bool ForceRecordingAndTransmission;

		public AudioClip TestAudioClip;

		public bool TestUsingAudioClip;

		public bool DisableVad;

		public bool IncreaseLogLevels;

		public bool LocalDebug;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[ContextMenu("CantHearYou")]
		public void CantHearYou()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void CantHearYou(string roomName, string serverIp, string appVersion, PhotonMessageInfo photonMessageInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reply(string why, Player player)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void HeresWhy(string why, PhotonMessageInfo photonMessageInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MaxLogs()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VoiceDebugScript()
		{

		}
	}
}
