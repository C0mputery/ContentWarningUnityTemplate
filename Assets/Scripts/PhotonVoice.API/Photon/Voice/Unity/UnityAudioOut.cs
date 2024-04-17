using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	public class UnityAudioOut : AudioOutDelayControl<float>
	{
		protected readonly AudioSource source;

		protected AudioClip clip;

		public override long OutPos
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnityAudioOut(AudioSource audioSource, PlayDelayConfig playDelayConfig, ILogger logger, string logPrefix, bool debugInfo) : base(false, new PlayDelayConfig(), null, null, false)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OutCreate(int frequency, int channels, int bufferSamples)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OutStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OutWrite(float[] data, int offsetSamples)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Stop()
		{
			throw null;
		}
	}
}
