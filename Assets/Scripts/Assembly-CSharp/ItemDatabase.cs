using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(menuName = "Database/ItemDatabase", order = 9999, fileName = "ItemDatabase")]
public class ItemDatabase : ObjectDatabaseAsset<ItemDatabase, Item>
{
	public List<string> lastLoadedPersistentIDs;

	public List<Item> lastLoadedItems;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetItemFromID(byte id, out Item item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetItemFromPersistentID(Guid id, out Item item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemDatabase()
	{
		throw null;
	}
}
