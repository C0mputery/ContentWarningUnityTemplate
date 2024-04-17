using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		private AudioUtil.LevelMeterDummy levelMeter;

		public static LocalVoiceAudioDummy Dummy;

		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public AudioUtil.ILevelMeter LevelMeter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool VoiceDetectorCalibrating
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VoiceDetectorCalibrate(int durationMs, Action<float> onCalibrated = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocalVoiceAudioDummy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LocalVoiceAudioDummy()
		{
			throw null;
		}
	}
}
