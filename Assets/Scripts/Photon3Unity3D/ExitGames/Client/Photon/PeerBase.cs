using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.SocketServer.Security;

namespace ExitGames.Client.Photon
{
	public abstract class PeerBase
	{
		internal delegate void MyAction();

		private static class GpBinaryV3Parameters
		{
			public const byte CustomObject = 0;

			public const byte ExtraPlatformParams = 1;
		}

		internal PhotonPeer photonPeer;

		public IProtocol SerializationProtocol;

		internal ConnectionProtocol usedTransportProtocol;

		internal IPhotonSocket PhotonSocket;

		internal ConnectionStateValue peerConnectionState;

		internal int ByteCountLastOperation;

		internal int ByteCountCurrentDispatch;

		internal NCommand CommandInCurrentDispatch;

		internal int packetLossByCrc;

		internal int packetLossByChallenge;

		internal readonly Queue<MyAction> ActionQueue;

		internal short peerID;

		internal int serverTimeOffset;

		internal bool serverTimeOffsetIsAvailable;

		internal int roundTripTime;

		internal int roundTripTimeVariance;

		internal int lastRoundTripTime;

		internal int lowestRoundTripTime;

		internal int highestRoundTripTimeVariance;

		internal int timestampOfLastReceive;

		internal static short peerCount;

		internal long bytesOut;

		internal long bytesIn;

		internal object PhotonToken;

		internal object CustomInitData;

		public string AppId;

		internal EventData reusableEventData;

		private Stopwatch watch;

		internal int timeoutInt;

		internal int timeLastAckReceive;

		internal int longestSentCall;

		internal int timeLastSendAck;

		internal int timeLastSendOutgoing;

		internal bool ApplicationIsInitialized;

		internal bool isEncryptionAvailable;

		internal int outgoingCommandsInStream;

		protected internal static Queue<StreamBuffer> MessageBufferPool;

		internal byte[] messageHeader;

		internal ICryptoProvider CryptoProvider;

		private readonly Random lagRandomizer;

		internal readonly LinkedList<SimulationItem> NetSimListOutgoing;

		internal readonly LinkedList<SimulationItem> NetSimListIncoming;

		private readonly NetworkSimulationSet networkSimulationSettings;

		internal int TrafficPackageHeaderSize;

		public string ServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public string ProxyServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		internal IPhotonPeerListener Listener
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public DebugLevel debugOut
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal int DisconnectTimeout
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal int timePingInterval
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal byte ChannelCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal long BytesOut
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal long BytesIn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal abstract int QueuedIncomingCommandsCount { get; }

		internal abstract int QueuedOutgoingCommandsCount { get; }

		internal virtual int SentReliableCommandsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public virtual string PeerID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal int timeInt
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal static int outgoingStreamBufferSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal int mtu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected internal bool IsIpv6
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public NetworkSimulationSet NetworkSimulationSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal bool TrafficStatsEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal TrafficStats TrafficStatsIncoming
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal TrafficStats TrafficStatsOutgoing
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal TrafficStatsGameLevel TrafficStatsGameLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PeerBase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StreamBuffer MessageBufferPoolGet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MessageBufferPoolPut(StreamBuffer buff)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void Reset()
		{
			throw null;
		}

		internal abstract bool Connect(string serverAddress, string proxyServerAddress, string appID, object photonToken);

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetHttpKeyValueString(Dictionary<string, string> dic)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] WriteInitRequest()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] WriteInitV3()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string PepareWebSocketUrl(string serverAddress, string appId, object photonToken)
		{
			throw null;
		}

		public abstract void OnConnect();

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InitCallback()
		{
			throw null;
		}

		internal abstract void Disconnect();

		internal abstract void StopConnection();

		internal abstract void FetchServerTimestamp();

		internal abstract bool IsTransportEncrypted();

		internal abstract bool EnqueuePhotonMessage(StreamBuffer opBytes, SendOptions sendParams);

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StreamBuffer SerializeOperationToMessage(byte opCode, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StreamBuffer SerializeOperationToMessage(byte opCode, ParameterDictionary parameters, EgMessageType messageType, bool encrypt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StreamBuffer SerializeMessageToMessage(object message, bool encrypt)
		{
			throw null;
		}

		internal abstract bool SendOutgoingCommands();

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual bool SendAcksOnly()
		{
			throw null;
		}

		internal abstract void ReceiveIncomingCommands(byte[] inBuff, int dataLength);

		internal abstract bool DispatchIncomingCommands();

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual bool DeserializeMessageAndCallback(StreamBuffer stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void UpdateRoundTripTimeAndVariance(int lastRoundtripTime)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool ExchangeKeysForEncryption(object lockObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void DeriveSharedKey(OperationResponse operationResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void InitEncryption(byte[] secret)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void EnqueueActionForDispatch(MyAction action)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void EnqueueDebugReturn(DebugLevel level, string debugReturn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void EnqueueStatusCallback(StatusCode statusValue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SendNetworkSimulated(byte[] dataToSend)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ReceiveNetworkSimulated(byte[] dataReceived)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void NetworkSimRun()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PeerBase()
		{
			throw null;
		}
	}
}
