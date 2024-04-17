using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, byte id, VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId, VoiceCreateOptions opt) : base(null, 69, new VoiceInfo(), null, 0, new VoiceCreateOptions())
		{
			throw null;
		}
	}
}
