using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		protected AudioUtil.LevelMeter<T> levelMeter;

		protected int channels;

		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public virtual AudioUtil.ILevelMeter LevelMeter
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
		internal static LocalVoiceAudio<T> Create(VoiceClient voiceClient, byte voiceId, VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId, VoiceCreateOptions options = default(VoiceCreateOptions))
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VoiceDetectorCalibrate(int durationMs, Action<float> onCalibrated = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LocalVoiceAudio(VoiceClient voiceClient, byte id, VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId, VoiceCreateOptions opt) : base(null, 69, new VoiceInfo(), 69, 0, new VoiceCreateOptions())
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void initBuiltinProcessors()
		{
			throw null;
		}
	}
}
