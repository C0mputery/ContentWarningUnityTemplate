using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UnityEngine;

namespace Photon.Pun
{
	public static class PhotonNetwork
	{
		private struct RaiseEventBatch : IEquatable<RaiseEventBatch>
		{
			public byte Group;

			public bool Reliable;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override int GetHashCode()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Equals(RaiseEventBatch other)
			{
				throw null;
			}
		}

		private class SerializeViewBatch : IEquatable<SerializeViewBatch>, IEquatable<RaiseEventBatch>
		{
			public readonly RaiseEventBatch Batch;

			public List<object> ObjectUpdates;

			private int defaultSize;

			private int offset;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SerializeViewBatch(RaiseEventBatch batch, int offset)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override int GetHashCode()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Equals(SerializeViewBatch other)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Equals(RaiseEventBatch other)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Clear()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Add(List<object> viewData)
			{
				throw null;
			}
		}

		public const string PunVersion = "2.43";

		private static string gameVersion;

		public static LoadBalancingClient NetworkingClient;

		public static readonly int MAX_VIEW_IDS;

		public const string ServerSettingsFileName = "PhotonServerSettings";

		private static ServerSettings photonServerSettings;

		private const string PlayerPrefsKey = "PUNCloudBestRegion";

		public static ConnectMethod ConnectMethod;

		public static PunLogLevel LogLevel;

		public static bool EnableCloseConnection;

		public static float PrecisionForVectorSynchronization;

		public static float PrecisionForQuaternionSynchronization;

		public static float PrecisionForFloatSynchronization;

		private static bool offlineMode;

		private static Room offlineModeRoom;

		private static bool automaticallySyncScene;

		private static int sendFrequency;

		private static int serializationFrequency;

		private static bool isMessageQueueRunning;

		private static double frametime;

		private static int frame;

		private static Stopwatch StartupStopwatch;

		public static float MinimalTimeScaleToDispatchInFixedUpdate;

		private static int lastUsedViewSubId;

		private static int lastUsedViewSubIdStatic;

		private static readonly HashSet<string> PrefabsWithoutMagicCallback;

		private static DisableIntercept m_DisableIntercept;

		private static readonly Hashtable SendInstantiateEvHashtable;

		private static readonly RaiseEventOptions SendInstantiateRaiseEventOptions;

		private static HashSet<byte> allowedReceivingGroups;

		private static HashSet<byte> blockedSendingGroups;

		private static HashSet<PhotonView> reusablePVHashset;

		private static NonAllocDictionary<int, PhotonView> photonViewList;

		internal static byte currentLevelPrefix;

		public static bool loadingLevelAndPausedNetwork;

		internal const string CurrentSceneProperty = "curScn";

		internal const string CurrentScenePropertyLoadAsync = "curScnLa";

		private static IPunPrefabPool prefabPool;

		public static bool UseRpcMonoBehaviourCache;

		private static readonly Dictionary<Type, List<MethodInfo>> monoRPCMethodsCache;

		private static Dictionary<string, int> rpcShortcuts;

		public static bool RunRpcCoroutines;

		private static AsyncOperation _AsyncLevelLoadingOperation;

		private static float _levelLoadingProgress;

		private static readonly Type typePunRPC;

		private static readonly Type typePhotonMessageInfo;

		private static readonly object keyByteZero;

		private static readonly object keyByteOne;

		private static readonly object keyByteTwo;

		private static readonly object keyByteThree;

		private static readonly object keyByteFour;

		private static readonly object keyByteFive;

		private static readonly object keyByteSix;

		private static readonly object keyByteSeven;

		private static readonly object keyByteEight;

		private static readonly object[] emptyObjectArray;

		private static readonly Type[] emptyTypeArray;

		internal static List<PhotonView> foundPVs;

		private static readonly Hashtable removeFilter;

		private static readonly Hashtable ServerCleanDestroyEvent;

		private static readonly RaiseEventOptions ServerCleanOptions;

		internal static RaiseEventOptions SendToAllOptions;

		internal static RaiseEventOptions SendToOthersOptions;

		internal static RaiseEventOptions SendToSingleOptions;

		private static readonly Hashtable rpcFilterByViewId;

		private static readonly RaiseEventOptions OpCleanRpcBufferOptions;

		private static Hashtable rpcEvent;

		private static RaiseEventOptions RpcOptionsToAll;

		public static int ObjectsInOneUpdate;

		private static readonly PhotonStream serializeStreamOut;

		private static readonly PhotonStream serializeStreamIn;

		private static RaiseEventOptions serializeRaiseEvOptions;

		private static readonly Dictionary<RaiseEventBatch, SerializeViewBatch> serializeViewBatches;

		public const int SyncViewId = 0;

		public const int SyncCompressed = 1;

		public const int SyncNullValues = 2;

		public const int SyncFirstValue = 3;

		private static RegionHandler _cachedRegionHandler;

		public static string GameVersion
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

		public static string AppVersion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static ServerSettings PhotonServerSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		public static string ServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static string CloudRegion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static string CurrentCluster
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static string BestRegionSummaryInPreferences
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
				throw null;
			}
		}

		public static bool IsConnected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static bool IsConnectedAndReady
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static ClientState NetworkClientState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static ServerConnection Server
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static AuthenticationValues AuthValues
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

		public static TypedLobby CurrentLobby
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static Room CurrentRoom
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static Player LocalPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static string NickName
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

		public static Player[] PlayerList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static Player[] PlayerListOthers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static bool OfflineMode
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

		public static bool AutomaticallySyncScene
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

		public static bool EnableLobbyStatistics
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static bool InLobby
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static int SendRate
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

		public static int SerializationRate
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

		public static bool IsMessageQueueRunning
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

		public static double Time
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static int ServerTimestamp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static float KeepAliveInBackground
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

		public static bool IsMasterClient
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static Player MasterClient
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static bool InRoom
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static int CountOfPlayersOnMaster
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static int CountOfPlayersInRooms
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static int CountOfPlayers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static int CountOfRooms
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static bool NetworkStatisticsEnabled
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

		public static int ResentReliableCommands
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static bool CrcCheckEnabled
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

		public static int PacketLossByCrcCheck
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static int MaxResendsBeforeDisconnect
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

		public static int QuickResends
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

		[Obsolete("Set port overrides in ServerPortOverrides. Not used anymore!")]
		public static bool UseAlternativeUdpPorts
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

		public static PhotonPortDefinition ServerPortOverrides
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

		[Obsolete("Use PhotonViewCollection instead for an iterable collection of current photonViews.")]
		public static PhotonView[] PhotonViews
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static NonAllocDictionary<int, PhotonView>.ValueIterator PhotonViewCollection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static int ViewCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static IPunPrefabPool PrefabPool
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

		public static float LevelLoadingProgress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private static event Action<PhotonView, Player> OnOwnershipRequestEv
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

		private static event Action<PhotonView, Player> OnOwnershipTransferedEv
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

		private static event Action<PhotonView, Player> OnOwnershipTransferFailedEv
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
		static PhotonNetwork()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void StaticReset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ConnectUsingSettings()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ConnectUsingSettings(AppSettings appSettings, bool startInOfflineMode = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ConnectToMaster(string masterServerAddress, int port, string appID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ConnectToBestCloudServer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ConnectToRegion(string region)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Disconnect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Reconnect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NetworkStatisticsReset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string NetworkStatisticsToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool VerifyCanUseNetwork()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetPing()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FetchServerTimestamp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendAllOutgoingCommands()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CloseConnection(Player kickPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SetMasterClient(Player masterClientPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool JoinRandomRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchingType, TypedLobby typedLobby, string sqlLobbyFilter, string[] expectedUsers = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool JoinRandomOrCreateRoom(Hashtable expectedCustomRoomProperties = null, byte expectedMaxPlayers = 0, MatchmakingMode matchingType = MatchmakingMode.FillRoom, TypedLobby typedLobby = null, string sqlLobbyFilter = null, string roomName = null, RoomOptions roomOptions = null, string[] expectedUsers = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CreateRoom(string roomName, RoomOptions roomOptions = null, TypedLobby typedLobby = null, string[] expectedUsers = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, string[] expectedUsers = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool JoinRoom(string roomName, string[] expectedUsers = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool RejoinRoom(string roomName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ReconnectAndRejoin()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LeaveRoom(bool becomeInactive = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void EnterOfflineRoom(string roomName, RoomOptions roomOptions, bool createdRoom)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool JoinLobby()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool JoinLobby(TypedLobby typedLobby)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LeaveLobby()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FindFriends(string[] friendsToFind)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetCustomRoomList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SetPlayerCustomProperties(Hashtable customProperties)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemovePlayerCustomProperties(string[] customPropertiesToDelete)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool RaiseEvent(byte eventCode, object eventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool RaiseEventInternal(byte eventCode, object eventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AllocateViewID(PhotonView view)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Renamed. Use AllocateRoomViewID instead")]
		public static bool AllocateSceneViewID(PhotonView view)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AllocateRoomViewID(PhotonView view)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int AllocateViewID(bool roomObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int AllocateViewID(int ownerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group = 0, object[] data = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Renamed. Use InstantiateRoomObject instead")]
		public static GameObject InstantiateSceneObject(string prefabName, Vector3 position, Quaternion rotation, byte group = 0, object[] data = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GameObject InstantiateRoomObject(string prefabName, Vector3 position, Quaternion rotation, byte group = 0, object[] data = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static GameObject NetworkInstantiate(Hashtable networkEvent, Player creator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static GameObject NetworkInstantiate(InstantiateParameters parameters, bool roomObject = false, bool instantiateEvent = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool InterceptNetworkspawn(ref InstantiateParameters parameters, bool roomObject, bool instantiateEvent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SendInstantiate(InstantiateParameters parameters, bool roomObject = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Destroy(PhotonView targetView)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Destroy(GameObject targetGo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DestroyPlayerObjects(Player targetPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DestroyPlayerObjects(int targetPlayerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DestroyAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveRPCs(Player targetPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveRPCs(PhotonView targetPhotonView)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RPC(PhotonView view, string methodName, RpcTarget target, bool encrypt, params object[] parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RPC(PhotonView view, string methodName, Player targetPlayer, bool encrypt, params object[] parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static HashSet<GameObject> FindGameObjectsWithComponent(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetInterestGroups(byte group, bool enabled)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadLevel(int levelNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadLevel(string levelName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool WebRpc(string name, object parameters, bool sendAuthCookie = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SetupLogging()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadOrCreateSettings(bool reload = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddCallbackTarget(object target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveCallbackTarget(object target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string CallbacksToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void LeftRoomCleanup()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LocalCleanupAnythingInstantiated(bool destroyInstantiatedGameObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ResetPhotonViewsOnSerialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ExecuteRpc(Hashtable rpcData, Player sender)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool CheckTypeMatch(ParameterInfo[] methodParameters, Type[] callParameterTypes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DestroyPlayerObjects(int playerId, bool localOnly)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DestroyAll(bool localOnly)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RemoveInstantiatedGO(GameObject go, bool localOnly)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ServerCleanInstantiateAndDestroy(PhotonView photonView)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SendDestroyOfPlayer(int actorNr)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SendDestroyOfAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void OpRemoveFromServerInstantiationsOfPlayer(int actorNr)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RequestOwnership(int viewID, int fromOwner)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TransferOwnership(int viewID, int playerID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OwnershipUpdate(int[] viewOwnerPairs, int targetActor = -1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LocalCleanPhotonView(PhotonView view)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PhotonView GetPhotonView(int viewID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RegisterPhotonView(PhotonView netView)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void OpCleanActorRpcBuffer(int actorNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void OpRemoveCompleteCacheOfPlayer(int actorNumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void OpRemoveCompleteCache()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RemoveCacheOfLeftPlayers()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CleanRpcBufferIfMine(PhotonView view)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void OpCleanRpcBuffer(PhotonView view)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveRPCsInGroup(int group)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool RemoveBufferedRPCs(int viewId = 0, string methodName = null, int[] callersActorNumbers = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetLevelPrefix(byte prefix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RPC(PhotonView view, string methodName, RpcTarget target, Player player, bool encrypt, params object[] parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetInterestGroups(byte[] disableGroups, byte[] enableGroups)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetSendingEnabled(byte group, bool enabled)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetSendingEnabled(byte[] disableGroups, byte[] enableGroups)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NewSceneLoaded()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RunViewUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SendSerializeViewBatch(SerializeViewBatch batch)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<object> OnSerializeWrite(PhotonView view)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void OnSerializeRead(object[] data, Player sender, int networkTime, short correctPrefix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<object> DeltaCompressionWrite(List<object> previousContent, List<object> currentContent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object[] DeltaCompressionRead(object[] lastOnSerializeDataReceived, object[] incomingData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool AlmostEquals(IList<object> lastData, IList<object> currentContent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool AlmostEquals(object one, object two)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GetMethod(MonoBehaviour monob, string methodType, out MethodInfo mi)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LoadLevelIfSynced()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SetLevelInPropsIfSynced(object levelId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void OnEvent(EventData photonEvent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void OnOperation(OperationResponse opResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void OnClientStateChanged(ClientState previousState, ClientState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void OnRegionsPinged(RegionHandler regionHandler)
		{
			throw null;
		}
	}
}
