using System;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Events;
using Zorro.Core;
using Zorro.Core.Serizalization;

public class ItemInstance : MonoBehaviour
{
	public Item item;

	internal Rigidbody rig;

	public Bodypart itemBody;

	public UnityEvent<Player> onItemEquipped;

	private ItemDataSyncer m_syncer;

	public Optionable<Guid> m_guid;

	public UnityEvent<Player> onUnequip;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitItem(Item setItem, ItemInstanceData data, PhotonView playerView, PhotonView pickupView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterRPC(ItemRPC rpc, Action<BinaryDeserializer> action)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionEnter(Collision other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetItemBody(Bodypart part)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ConfigItemPosition(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallRPC(ItemRPC rpc, BinarySerializer binarySerializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemInstance()
	{
		throw null;
	}
}
