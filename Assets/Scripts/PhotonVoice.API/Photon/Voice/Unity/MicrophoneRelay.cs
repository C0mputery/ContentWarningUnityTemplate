using System;
using System.Runtime.CompilerServices;
using Zorro.Core;

namespace Photon.Voice.Unity
{
	public class MicrophoneRelay : Singleton<MicrophoneRelay>
	{
		public Action<float> onMicData;

		public float m_lastRead;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendMic(float[] buffer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterMicListener(Action<float> listen)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnregisterMicListener(Action<float> listen)
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MicrophoneRelay()
		{

		}
	}
}
