using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Recorder
{
	public class VideoRecorder : MonoBehaviour
	{
		public enum VideoInputMode
		{
			Camera = 0,
			RenderTexture = 1
		}

		public string OutputPath;

		public bool m_record;

		public bool m_recordMicrophone;

		public VideoInputMode m_inputMode;

		public Camera m_camera;

		public RenderTexture m_renderTexture;

		public RecorderAudioListener m_audioListener;

		public uint m_width;

		public uint m_height;

		public byte frameRate;

		private RenderTexture m_cameraTexture;

		private RecordingSession m_session;

		private float m_timer;

		private bool m_recordLastFrame;

		public RecordingSession Session
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool HasRecorded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecordFrame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AudioRead(float[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushMicData(float[] buffer, int sampleRate, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VideoRecorder()
		{

		}
	}
}
