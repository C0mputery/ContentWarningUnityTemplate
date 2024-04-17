using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity.UtilityScripts
{
	[RequireComponent(typeof(Recorder))]
	[DisallowMultipleComponent]
	public class SaveOutgoingStreamToFile : VoiceComponent
	{
		private class OutgoingStreamSaverFloat : IProcessor<float>, IDisposable
		{
			private WaveWriter wavWriter;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public OutgoingStreamSaverFloat(WaveWriter waveWriter)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public float[] Process(float[] buf)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		private class OutgoingStreamSaverShort : IProcessor<short>, IDisposable
		{
			private WaveWriter wavWriter;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public OutgoingStreamSaverShort(WaveWriter waveWriter)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public short[] Process(short[] buf)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}
		}

		private WaveWriter wavWriter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PhotonVoiceCreated(PhotonVoiceCreatedParams photonVoiceCreatedParams)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetFilePath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PhotonVoiceRemoved()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveOutgoingStreamToFile()
		{
			throw null;
		}
	}
}
