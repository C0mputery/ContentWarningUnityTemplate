using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	internal class TPeer : PeerBase
	{
		internal const int TCP_HEADER_BYTES = 7;

		internal const int MSG_HEADER_BYTES = 2;

		public const int ALL_HEADER_BYTES = 9;

		private Queue<StreamBuffer> incomingList;

		internal List<StreamBuffer> outgoingStream;

		private int lastPingResult;

		private byte[] pingRequest;

		internal static readonly byte[] tcpFramedMessageHead;

		internal static readonly byte[] tcpMsgHead;

		protected internal bool DoFraming;

		internal override int QueuedIncomingCommandsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal override int QueuedOutgoingCommandsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TPeer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool IsTransportEncrypted()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool Connect(string serverAddress, string proxyServerAddress, string appID, object photonToken)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnConnect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void Disconnect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void StopConnection()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void FetchServerTimestamp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnqueueInit(byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool DispatchIncomingCommands()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool SendOutgoingCommands()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool SendAcksOnly()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool EnqueuePhotonMessage(StreamBuffer opBytes, SendOptions sendParams)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool EnqueueMessageAsPayload(DeliveryMode deliveryMode, StreamBuffer opMessage, byte channelId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SendPing()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal PhotonSocketError SendData(byte[] data, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void ReceiveIncomingCommands(byte[] inbuff, int dataLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadPingResult(byte[] inbuff)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void ReadPingResult(OperationResponse operationResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TPeer()
		{
			throw null;
		}
	}
}
