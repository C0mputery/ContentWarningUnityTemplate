using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Steamworks;

public class SteamLobbyHandler
{
	private const string PHOTON_ROOM_KEY = "Photon";

	private const string PHOTON_REGION_KEY = "PhotonRegion";

	private const string PRIVATE_MATCH_KEY = "PrivateMatch";

	private const string GAME_VERSION_KEY = "ContentWarningVersion";

	private const string PLUGINS_KEY = "Plugins";

	private Action<ulong> OnHostedAction;

	private Action<string, string, bool> OnJoinedAction;

	private CallResult<LobbyCreated_t> m_OnLobbyCreatedCallBack;

	private CallResult<LobbyEnter_t> m_OnLobbyEnterCallBack;

	private CallResult<LobbyMatchList_t> m_OnMatchListCallResult;

	private Callback<LobbyChatUpdate_t> m_OnLobbyChatUpdateCallBack;

	private Callback<LobbyDataUpdate_t> m_OnLobbyUpdateCallBack;

	private Callback<GameLobbyJoinRequested_t> m_OnInviteCallResult;

	private Callback<SteamNetworkingMessagesSessionRequest_t> m_OnMessageSessionRequest;

	private Callback<SteamNetworkingMessagesSessionFailed_t> m_OnMessageSessionFailed;

	public bool UseSteamNetwork;

	private int m_MaxPlayers;

	private CSteamID m_CurrentLobby;

	private List<SteamNetworkingIdentity> m_Members;

	private bool m_Joined;

	private Thread m_ReceiveThread;

	private bool m_isJoining;

	private bool m_isPrivateMatch;

	private bool m_isHostingPrivate;

	private CSteamID m_JoiningLobby;

	private IntPtr[] receiveBuffers;

	private IntPtr sendBuffer;

	public bool MasterClient
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SteamLobbyHandler(Action<string, string, bool> onJoinedRoomAction, int maxPlayers, bool useSteamNetwork)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitThread()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitCallbacks()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HostMatch(Action<ulong> _action, bool privateMatch)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLobbyDataUpdate(LobbyDataUpdate_t param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnChatUpdateCallback(LobbyChatUpdate_t data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnIniviteCallback(GameLobbyJoinRequested_t param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryToJoinLobby(CSteamID lobbyID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JoinLobby(CSteamID lobbyID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LeaveLobby()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseConnections()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLobbyCreatedCallback(LobbyCreated_t param, bool bioFailure)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnMatchListReceived(LobbyMatchList_t param, bool biofailure)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLobbyEnterCallback(LobbyEnter_t param, bool bioFailure)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetEChatRoomEnterResponse(uint code)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitHandshakeWithEveryone()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendPackageToAll(byte[] buffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendPackage(byte[] buffer, ref SteamNetworkingIdentity identity)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReceiveMessage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnMessageReceived(byte[] msg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IntPtr makePtrFromBytes(byte[] message)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnNetworkingSessionRequest(SteamNetworkingMessagesSessionRequest_t param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnNetworkingSessionRequestFailed(SteamNetworkingMessagesSessionFailed_t param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddSteamClient(CSteamID cSteamID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveSteamClient(CSteamID cSteamID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetSteamClientsInLobby()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLobbyName(string roomName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLobbyRegion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InviteScreen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void JoinRandom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideLobby()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenLobby()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayingWithRandoms()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHostLobbyType()
	{
		throw null;
	}
}
