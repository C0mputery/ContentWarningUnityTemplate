using System;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class ItemDataSyncer : MonoBehaviour
{
	private PhotonView m_photonView;

	private ItemInstanceData m_instanceData;

	private ItemInstance m_itemInstance;

	private Guid m_guid;

	public bool isMine
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
	[PunRPC]
	public void RPC_SetInstanceData(byte[] id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_Update(byte[] buffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemDataSyncer()
	{

	}
}
