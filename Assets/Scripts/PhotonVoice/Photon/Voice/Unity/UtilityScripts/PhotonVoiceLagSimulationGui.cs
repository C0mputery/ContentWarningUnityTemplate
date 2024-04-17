using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

namespace Photon.Voice.Unity.UtilityScripts
{
	[RequireComponent(typeof(VoiceConnection))]
	public class PhotonVoiceLagSimulationGui : MonoBehaviour
	{
		private VoiceConnection voiceConnection;

		private Rect windowRect;

		private int windowId;

		private bool visible;

		private PhotonPeer peer;

		private float debugLostPercent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NetSimHasNoPeerWindow(int windowId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NetSimWindow(int windowId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonVoiceLagSimulationGui()
		{
			throw null;
		}
	}
}
