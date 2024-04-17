using System;

namespace Photon.Voice
{
	public interface ILocalVoiceAudio
	{
		AudioUtil.IVoiceDetector VoiceDetector { get; }

		AudioUtil.ILevelMeter LevelMeter { get; }

		bool VoiceDetectorCalibrating { get; }

		void VoiceDetectorCalibrate(int durationMs, Action<float> onCalibrated = null);
	}
}
