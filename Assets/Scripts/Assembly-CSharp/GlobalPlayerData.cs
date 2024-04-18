using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using Photon.Realtime;

public class GlobalPlayerData : MonoBehaviourPunCallbacks
{
	private PhotonView m_photonView;

	public PlayerInventory inventory;

	public float localVoiceVolume;

	private static Dictionary<Photon.Realtime.Player, GlobalPlayerData> m_instances;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetPlayerData(Photon.Realtime.Player player, out GlobalPlayerData globalPlayerData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Cleanup()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GlobalPlayerData()
	{

	}
}
