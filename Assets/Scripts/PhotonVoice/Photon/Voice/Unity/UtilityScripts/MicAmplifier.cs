using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity.UtilityScripts
{
	[RequireComponent(typeof(Recorder))]
	public class MicAmplifier : VoiceComponent
	{
		[SerializeField]
		private float amplificationFactor;

		private MicAmplifierFloat floatProcessor;

		private MicAmplifierShort shortProcessor;

		public float AmplificationFactor
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
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PhotonVoiceCreated(PhotonVoiceCreatedParams p)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MicAmplifier()
		{
			throw null;
		}
	}
}
