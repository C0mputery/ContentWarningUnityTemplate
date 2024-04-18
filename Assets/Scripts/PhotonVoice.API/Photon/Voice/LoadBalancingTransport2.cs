using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Voice
{
	public class LoadBalancingTransport2 : LoadBalancingTransport
	{
		private const int MAX_DATA_OFFSET = 5;

		protected override byte FrameCode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoadBalancingTransport2(ILogger logger = null, ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp, bool cppCompatibilityMode = false)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetPayloadFragmentSize(SendFrameParams par)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override object buildFrameMessage(byte voiceId, byte evNumber, byte frNumber, ArraySegment<byte> data, FrameFlags flags)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void onEventActionVoiceClient(EventData ev)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void onVoiceFrameEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
			throw null;
		}
	}
}
