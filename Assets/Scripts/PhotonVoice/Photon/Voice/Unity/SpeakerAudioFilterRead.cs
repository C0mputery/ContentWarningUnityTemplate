using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	[AddComponentMenu("Photon Voice/Speaker AudioFilterRead")]
	public class SpeakerAudioFilterRead : Speaker
	{
		private AudioSyncBuffer<float> outBuffer;

		private int outputSampleRate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IAudioOut<float> CreateAudioOut()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAudioFilterRead(float[] data, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpeakerAudioFilterRead()
		{

		}
	}
}
