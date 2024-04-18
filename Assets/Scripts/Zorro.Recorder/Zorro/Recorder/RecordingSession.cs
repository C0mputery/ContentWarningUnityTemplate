using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;
using Zorro.Core;

namespace Zorro.Recorder
{
	public class RecordingSession : IDisposable
	{
		private RecordingPipe m_pipe;

		private NativeList<float> m_audioData;

		private NativeList<float> m_micAudioData;

		private Material m_blitMaterial;

		private List<AsyncGPUReadbackRequest> _readbackQueue;

		private ProfilerMarker m_processQueueMarker;

		private ProfilerMarker m_queueFrameMarker;

		public int Frames
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public int AudioFrames
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

		public int MicAudioFrames
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

		public int AudioDataSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public int MicAudioDataSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public Optionable<int> MicSampleRate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public Optionable<int> MicChannels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public RecordingPipe Pipe
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RecordingSession(uint width, uint height, string directory)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushFrame(RenderTexture frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QueueFrame(RenderTexture frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ProcessQueue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushAudio(float[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] GetAudioBlob()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] GetMicAudioBlob()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetAudioPath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetMicAudioPath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushMicAudio(float[] data, int sampleRate, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float MicrophoneLevelMax(float[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float MicrophoneLevelMaxDecibels(float level)
		{
			throw null;
		}
	}
}
