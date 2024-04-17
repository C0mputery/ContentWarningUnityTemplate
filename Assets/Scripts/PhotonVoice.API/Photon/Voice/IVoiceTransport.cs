using System;

namespace Photon.Voice
{
	public interface IVoiceTransport
	{
		bool IsChannelJoined(int channelId);

		void SendVoiceInfo(LocalVoice voice, int channelId, bool targetMe, int[] targetPlayers);

		void SendVoiceRemove(LocalVoice voice, int channelId, bool targetMe, int[] targetPlayers);

		void SendFrame(ArraySegment<byte> data, FrameFlags flags, byte evNumber, byte frNumber, byte voiceId, int channelId, SendFrameParams par);

		string ChannelIdStr(int channelId);

		string PlayerIdStr(int playerId);

		int GetPayloadFragmentSize(SendFrameParams par);
	}
}
