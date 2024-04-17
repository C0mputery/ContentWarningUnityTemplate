using System.Runtime.CompilerServices;
using Photon.Pun;
using Steamworks;

public class Connection : MonoBehaviourPunCallbacks
{
	public bool connectToGlobalDev;

	public bool findCustomSpawnPoint;

	public bool offline;

	public static Connection instance;

	public bool hasJoined;

	private HAuthTicket m_Ticket;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnConnectedToMaster()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnJoinedRoom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCustomAuthenticationFailed(string debugMessage)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnLocalPlayer(ConnectionState state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnJoinRoomFailed(short returnCode, string message)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreateRoomFailed(short returnCode, string message)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Connection()
	{
		throw null;
	}
}
