using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public static class Platform
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IDeviceEnumerator CreateAudioInEnumerator(ILogger logger)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IAudioInChangeNotifier CreateAudioInChangeNotifier(Action callback, ILogger logger)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEncoder CreateDefaultAudioEncoder<T>(ILogger logger, VoiceInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IAudioDesc CreateDefaultAudioSource(ILogger logger, DeviceInfo dev, int samplingRate, int channels, object otherParams = null)
		{
			throw null;
		}
	}
}
