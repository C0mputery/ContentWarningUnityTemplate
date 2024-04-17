using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class ShadowRealmHandler : MonoBehaviour
{
	public static ShadowRealmHandler instance;

	private PhotonView view;

	private GameObject[] currentRealms;

	public List<GameObject> realms;

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
	public void TeleportPlayerToRandomRealm(Player target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetSpotID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_AddRealm(int realmID, int spotID, int targetID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 GetRealmPosition(int spotID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_RemovePlayerFromRealm(int spotID, int targetID, Vector3 returnPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void PlayerLeaveRealm(Player p, GameObject realm)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetRealmID(GameObject realm)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowRealmHandler()
	{
		throw null;
	}
}
