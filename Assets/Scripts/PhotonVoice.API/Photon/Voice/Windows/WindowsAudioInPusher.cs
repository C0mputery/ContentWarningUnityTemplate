using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Photon.Voice.Windows
{
	public class WindowsAudioInPusher : IAudioPusher<short>, IAudioDesc, IDisposable
	{
		private enum SystemMode
		{
			SINGLE_CHANNEL_AEC = 0,
			OPTIBEAM_ARRAY_ONLY = 2,
			OPTIBEAM_ARRAY_AND_AEC = 4,
			SINGLE_CHANNEL_NSAGC = 5
		}

		private delegate void CallbackDelegate(int instanceID, IntPtr buf, int len);

		private IntPtr handle;

		private int instanceID;

		private Action<short[]> pushCallback;

		private ObjectFactory<short[], int> bufferFactory;

		private static int instanceCnt;

		private static Dictionary<int, WindowsAudioInPusher> instancePerHandle;

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

		[DllImport("AudioIn")]
		private static extern IntPtr Photon_Audio_In_Create(int instanceID, SystemMode systemMode, int micDevIdx, int spkDevIdx, Action<int, IntPtr, int> callback, bool featrModeOn, bool noiseSup, bool agc, bool cntrClip);

		[DllImport("AudioIn")]
		private static extern void Photon_Audio_In_Destroy(IntPtr handler);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WindowsAudioInPusher(int deviceID, ILogger logger)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[MonoPInvokeCallback(typeof(CallbackDelegate))]
		private static void nativePushCallback(int instanceID, IntPtr buf, int len)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCallback(Action<short[]> callback, ObjectFactory<short[], int> bufferFactory)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void push(IntPtr buf, int lenBytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WindowsAudioInPusher()
		{
			throw null;
		}
	}
}
