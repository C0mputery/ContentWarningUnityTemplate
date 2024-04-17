using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity.UtilityScripts
{
	[RequireComponent(typeof(VoiceConnection))]
	[DisallowMultipleComponent]
	public class SaveIncomingStreamToFile : VoiceComponent
	{
		private VoiceConnection voiceConnection;

		[SerializeField]
		private bool muteLocalSpeaker;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSpeakerLinked(Speaker speaker)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRemoteVoiceAdded(RemoteVoiceLink remoteVoiceLink)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetFilePath(RemoteVoiceLink remoteVoiceLink)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveIncomingStreamToFile()
		{
			throw null;
		}
	}
}
