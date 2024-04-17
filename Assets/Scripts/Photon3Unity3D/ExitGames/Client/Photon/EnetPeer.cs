using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	internal class EnetPeer : PeerBase
	{
		private const int CRC_LENGTH = 4;

		private const int EncryptedDataGramHeaderSize = 7;

		private const int EncryptedHeaderSize = 5;

		private const int QUICK_RESEND_QUEUELIMIT = 25;

		internal NCommandPool nCommandPool;

		private List<NCommand> sentReliableCommands;

		private StreamBuffer outgoingAcknowledgementsPool;

		internal const int UnsequencedWindowSize = 128;

		internal readonly int[] unsequencedWindow;

		internal int outgoingUnsequencedGroupNumber;

		internal int incomingUnsequencedGroupNumber;

		private byte udpCommandCount;

		private byte[] udpBuffer;

		private int udpBufferIndex;

		private byte[] bufferForEncryption;

		private int commandBufferSize;

		internal int challenge;

		internal int reliableCommandsRepeated;

		internal int reliableCommandsSent;

		internal int serverSentTime;

		internal static readonly byte[] udpHeader0xF3;

		protected bool datagramEncryptedConnection;

		private EnetChannel[] channelArray;

		private const byte ControlChannelNumber = byte.MaxValue;

		protected internal const short PeerIdForConnect = -1;

		protected internal const short PeerIdForConnectTrace = -2;

		private Queue<int> commandsToRemove;

		private int fragmentLength;

		private int fragmentLengthDatagramEncrypt;

		private int fragmentLengthMtuValue;

		private Queue<NCommand> CommandQueue;

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

		internal override int SentReliableCommandsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EnetPeer()
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
		internal void ApplyRandomizedSequenceNumbers()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private EnetChannel GetChannel(byte channelNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool Connect(string ipport, string proxyServerAddress, string appID, object photonToken)
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
		internal override bool DispatchIncomingCommands()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetFragmentLength()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int CalculatePacketSize(int inSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int CalculateInitialOffset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool SendAcksOnly()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool SendOutgoingCommands()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool EnqueuePhotonMessage(StreamBuffer opBytes, SendOptions sendParams)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool CreateAndEnqueueCommand(byte commandType, StreamBuffer payload, byte channelNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int SerializeAckToBuffer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int SerializeToBuffer(Queue<NCommand> commandList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SerializeCommandToBuffer(NCommand command, bool commandIsInSentQueue = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SendData(byte[] data, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendToSocket(byte[] data, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendDataEncrypted(byte[] data, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void QueueSentCommand(NCommand command, bool commandIsAlreadyInSentQueue = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void QueueOutgoingReliableCommand(NCommand command)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void QueueOutgoingUnreliableCommand(NCommand command)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void QueueOutgoingAcknowledgement(NCommand readCommand, int sendTime)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void ReceiveIncomingCommands(byte[] inBuff, int inDataLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ExecuteCommand(NCommand command)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool QueueIncomingCommand(NCommand command)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal NCommand RemoveSentReliableCommand(int ackReceivedReliableSequenceNumber, int ackReceivedChannel, bool isUnsequenced)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string CommandListToString(NCommand[] list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static EnetPeer()
		{
			throw null;
		}
	}
}
