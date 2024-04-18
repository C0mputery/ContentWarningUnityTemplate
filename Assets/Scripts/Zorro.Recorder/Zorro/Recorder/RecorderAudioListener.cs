using System.Runtime.CompilerServices;
using Zorro.Core;

namespace Zorro.Recorder
{
	public class RecorderAudioListener : Singleton<RecorderAudioListener>
	{
		private VideoRecorder m_videoRecorder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAudioFilterRead(float[] data, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendAudioTo(VideoRecorder recorder)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveRecorder(VideoRecorder recorder)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendMic(float[] buffer, int sampleRate, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool CanRecordMic()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RecorderAudioListener()
		{

		}
	}
}
