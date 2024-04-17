using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, byte id, VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId, VoiceCreateOptions opt) : base(null, 69, new VoiceInfo(), null, 0, new VoiceCreateOptions())
		{
            throw null;
        }
	}
}
