using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	internal class PhotonTransportProtocol
	{
		private enum EventSubcode : byte
		{
			VoiceInfo = 1,
			VoiceRemove = 2,
			Frame = 3
		}

		private enum EventParam : byte
		{
			VoiceId = 1,
			SamplingRate = 2,
			Channels = 3,
			FrameDurationUs = 4,
			Bitrate = 5,
			Width = 6,
			Height = 7,
			FPS = 8,
			KeyFrameInt = 9,
			UserData = 10,
			EventNumber = 11,
			Codec = 12
		}

		private VoiceClient voiceClient;

		private ILogger logger;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTransportProtocol(VoiceClient voiceClient, ILogger logger)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object[] buildVoicesInfo(LocalVoice v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object[] buildFrameMessage(byte voiceId, byte evNumber, byte frNumber, ArraySegment<byte> data, FrameFlags flags)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void onVoiceEvent(object content0, int channelId, int playerId, bool isLocalPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private VoiceInfo createVoiceInfoFromEventPayload(Dictionary<byte, object> h)
		{
			throw null;
		}
	}
}
