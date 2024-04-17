using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

namespace Photon.Voice.Unity
{
	[AddComponentMenu("Photon Voice/Voice Logger")]
	[DisallowMultipleComponent]
	public class VoiceLogger : MonoBehaviour
	{
		public DebugLevel LogLevel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static VoiceLogger FindLogger(GameObject gameObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static VoiceLogger CreateRootLogger()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VoiceLogger()
		{
			throw null;
		}
	}
}
