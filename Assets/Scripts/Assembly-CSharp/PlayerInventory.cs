using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
	public Item[] itemsToSpawnWith;

	public const int ARTIFACT_SLOT = 3;

	public InventorySlot[] slots;

	public Item emote;

	private PhotonView m_photonView;

	private bool m_syncedInitialState;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetSlotWithItem(Item item, out InventorySlot slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetSlotWithItemType(Item.ItemType itemType, out InventorySlot slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetFeeSlot(out InventorySlot slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetSlot(int slotID, out InventorySlot slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAddItem(ItemDescriptor item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAddItem(ItemDescriptor item, out InventorySlot slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryRemoveItemFromSlot(int slotID, out ItemDescriptor item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryRemoveItemOfType(Item item, out InventorySlot slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetItemInSlot(int slotID, out ItemDescriptor item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SyncAddToSlot(int slotID, ItemDescriptor itemDescriptor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SyncClearSlot(int slotID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_AddToSlot(int slotID, byte itemID, byte[] data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_ClearSlot(int slotID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] SerializeInventory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateInventory(byte[] inventory)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SyncInventoryToOthers()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_SyncInventoryToOthers(byte[] inventory)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<ItemDescriptor> GetItems()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerInventory()
	{
		throw null;
	}
}
