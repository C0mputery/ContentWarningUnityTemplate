using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	public class MicWrapperPusher : IAudioPusher<float>, IAudioDesc, IDisposable
	{
		private AudioSource audioSource;

		private AudioClip mic;

		private string device;

		private ILogger logger;

		private MicWrapperPusherOnAudioFilterRead onRead;

		private int sampleRate;

		private int channels;

		public int SamplingRate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Channels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Error
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MicWrapperPusher(GameObject parent, string device, int suggestedFrequency, ILogger logger)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCallback(Action<float[]> callback, ObjectFactory<float[], int> bufferFactory)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}
	}
}
