using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	public class AndroidAudioInAEC : IAudioPusher<short>, IAudioDesc, IDisposable, IResettable
	{
		private class DataCallback : AndroidJavaProxy
		{
			private Action<short[]> callback;

			private IntPtr javaBuf;

			private int cntFrame;

			private int cntShort;

            public DataCallback(string javaInterface) : base(javaInterface)
            {
				throw null;
            }

            /*[MethodImpl(MethodImplOptions.NoInlining)]
			public DataCallback()
			{
                throw null;
            }*/

            [MethodImpl(MethodImplOptions.NoInlining)]
			public void SetCallback(Action<short[]> callback, IntPtr javaBuf)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OnData()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OnStop()
			{
				throw null;
			}
		}

		private AndroidJavaObject audioIn;

		private IntPtr javaBuf;

		private ILogger logger;

		private int audioInSampleRate;

		private DataCallback callback;

		public int Channels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int SamplingRate
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
		public AndroidAudioInAEC(ILogger logger, bool enableAEC = false, bool enableAGC = false, bool enableNS = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCallback(Action<short[]> callback, ObjectFactory<short[], int> bufferFactory)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
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
