using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class PickupSpawner : MonoBehaviourPunCallbacks
{
	[SerializeField]
	private Item m_ItemToSpawn;

	private Transform m_Transform;

	private bool m_Spawned;

	public Item ItemToSpawn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnJoinedRoom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnMe(bool force = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyMe()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PickupSpawner()
	{

	}
}
