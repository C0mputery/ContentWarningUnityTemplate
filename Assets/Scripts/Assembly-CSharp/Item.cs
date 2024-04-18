using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using Zorro.Core.CLI;

[CreateAssetMenu(fileName = "Item", menuName = "W/Item", order = -1)]
public class Item : ScriptableObject
{
	public enum ItemType
	{
		Camera = 0,
		Tool = 1,
		Artifact = 2,
		Disc = 3
	}

	[FormerlySerializedAs("shopName")]
	public string displayName;

	public Sprite icon;

	public GameObject itemObject;

	public ItemType itemType;

	[FormerlySerializedAs("toolBudget")]
	public int toolBudgetCost;

	public bool spawnable;

	public RARITY toolSpawnRarity;

	public int budgetCost;

	public float rarity;

	public PropContent content;

	public float groundSizeMultiplier;

	public float groundMassMultiplier;

	public float mass;

	public Vector3 holdPos;

	public bool useAlternativeHoldingPos;

	public Vector3 alternativeHoldPos;

	public Vector3 holdRotation;

	public bool useAlternativeHoldingRot;

	public Vector3 alternativeHoldRot;

	public byte id;

	public string persistentID;

	public bool purchasable;

	public ShopItemCategory Category;

	public int price;

	public int quantity;

	public Emote emoteInfo;

	public List<ItemKeyTooltip> Tooltips;

	public float ToolRarity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Guid PersistentID
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ShowEmoteInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void SpawnItem(Item item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void EquipItem(Item item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IHaveUIData> GetTootipData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetLocalizedDisplayName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item()
	{

	}
}
