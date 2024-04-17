using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class LoadBalancingClient : IPhotonPeerListener
	{
		private class EncryptionDataParameters
		{
			public const byte Mode = 0;

			public const byte Secret1 = 1;

			public const byte Secret2 = 2;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EncryptionDataParameters()
			{
				throw null;
			}
		}

		private class CallbackTargetChange
		{
			public readonly object Target;

			public readonly bool AddTarget;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public CallbackTargetChange(object target, bool addTarget)
			{
				throw null;
			}
		}

		public AuthModeOption AuthMode;

		public EncryptionMode EncryptionMode;

		private object tokenCache;

		public string NameServerHost;

		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		public PhotonPortDefinition ServerPortOverrides;

		public string ProxyServerAddress;

		private ClientState state;

		public ConnectionCallbacksContainer ConnectionCallbackTargets;

		public MatchMakingCallbacksContainer MatchMakingCallbackTargets;

		internal InRoomCallbacksContainer InRoomCallbackTargets;

		internal LobbyCallbacksContainer LobbyCallbackTargets;

		internal WebRpcCallbacksContainer WebRpcCallbackTargets;

		internal ErrorInfoCallbacksContainer ErrorInfoCallbackTargets;

		public SystemConnectionSummary SystemConnectionSummary;

		public bool EnableLobbyStatistics;

		private readonly List<TypedLobbyInfo> lobbyStatistics;

		private JoinType lastJoinType;

		private EnterRoomParams enterRoomParamsCache;

		private OperationResponse failedRoomEntryOperation;

		private const int FriendRequestListMax = 512;

		private string[] friendListRequested;

		public RegionHandler RegionHandler;

		private string bestRegionSummaryFromStorage;

		public string SummaryToCache;

		private bool connectToBestRegion;

		private readonly Queue<CallbackTargetChange> callbackTargetChanges;

		private readonly HashSet<object> callbackTargets;

		public int NameServerPortInAppSettings;

		public LoadBalancingPeer LoadBalancingPeer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public SerializationProtocol SerializationProtocol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public string AppVersion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string AppId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public ClientAppType ClientType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public AuthenticationValues AuthValues
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public ConnectionProtocol? ExpectedProtocol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private object TokenForInit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsUsingNameServer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string NameServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[Obsolete("Set port overrides in ServerPortOverrides. Not used anymore!")]
		public bool UseAlternativeUdpPorts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public bool EnableProtocolFallback
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string CurrentServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string MasterServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string GameServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected internal set
			{
				throw null;
			}
		}

		public ServerConnection Server
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public ClientState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool IsConnected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsConnectedAndReady
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public DisconnectCause DisconnectedCause
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public bool InLobby
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public TypedLobby CurrentLobby
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

		public Player LocalPlayer
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

		public string NickName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public string UserId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Room CurrentRoom
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public bool InRoom
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int PlayersOnMasterCount
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

		public int PlayersInRoomsCount
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

		public int RoomsCount
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

		public bool IsFetchingFriendList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string CloudRegion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public string CurrentCluster
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public event Action<ClientState, ClientState> StateChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event Action<EventData> EventReceived
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event Action<OperationResponse> OpResponseReceived
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetNameServerAddress()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool ConnectUsingSettings(AppSettings appSettings)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use ConnectToMasterServer() instead.")]
		public bool Connect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool ConnectToMasterServer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ConnectToNameServer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ConnectToRegionMaster(string region)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Conditional("UNITY_WEBGL")]
		private void CheckConnectSetupWebGl()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool Connect(string serverAddress, string proxyServerAddress, ServerConnection serverType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ReconnectToMaster()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ReconnectAndRejoin()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disconnect(DisconnectCause cause = DisconnectCause.DisconnectByClientLogic)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DisconnectToReconnect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SimulateConnectionLoss(bool simulateTimeout)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CallAuthenticate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Service()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool OpGetRegions()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpFindFriends(string[] friendsToFind, FindFriendsOptions options = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpLeaveLobby()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpJoinRandomOrCreateRoom(OpJoinRandomRoomParams opJoinRandomRoomParams, EnterRoomParams createRoomParams)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpCreateRoom(EnterRoomParams enterRoomParams)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpJoinOrCreateRoom(EnterRoomParams enterRoomParams)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpJoinRoom(EnterRoomParams enterRoomParams)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpRejoinRoom(string roomName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal bool OpSetPropertyOfRoom(byte propCode, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeLocalID(int newID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatedActorList(int[] actorsInGame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckIfOpAllowedOnServer(byte opCode, ServerConnection serverConnection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckIfOpCanBeSent(byte opCode, ServerConnection serverConnection, string opName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckIfClientIsReadyToCallOperation(byte opCode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CallbackRoomEnterFailed(OperationResponse operationResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnEvent(EventData photonEvent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnMessage(object message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisconnectMessageReceived(DisconnectMessage obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRegionPingCompleted(RegionHandler regionHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal static string ReplacePortWithAlternative(string address, ushort replacementPort)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCallbackTarget(object target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveCallbackTarget(object target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void UpdateCallbackTargets()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateCallbackTarget<T>(CallbackTargetChange change, List<T> container) where T : class
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LoadBalancingClient()
		{
			throw null;
		}
	}
}
