using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ShopViewScreen : MonoBehaviour
{
	[SerializeField]
	private GameObject m_ItemCell;

	[SerializeField]
	private GameObject m_CategoryCell;

	[SerializeField]
	private Transform m_CategoriesGrid;

	[SerializeField]
	private Transform m_ItemsGrid;

	[SerializeField]
	private TextMeshProUGUI m_CurrentCategoryNameText;

	[SerializeField]
	private TextMeshProUGUI m_CartValueText;

	[SerializeField]
	private TextMeshProUGUI m_CartNumberOfItemsText;

	private Dictionary<ShopItem, ShopInteractibleItem> m_ShopItemToInteractable;

	private ShopHandler m_ShopHandler;

	private ShopItemCategory m_CurrentCategoryScreenIndex;

	public List<ShopItemCategory> excludeCategories;

	private int m_ItemsInShop;

	private string m_ItemsLocalized;

	public ShopItem CurrentSelectedShopItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public ShopItem[] CurrentShopItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public ShopItemCategory CurrentCategoryIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(ShopHandler handler)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseShop()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawItems()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawCategories()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnCategoryCell(ShopItemCategory category)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnItemCell(ShopItem item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyItemGrid()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyCategoryGrid()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIndex(ShopItemCategory newIndex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateView()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateViewScreen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCategory(ShopItemCategory argument)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetScreenIndex()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitListeners()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCartUpdated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateCartTexts()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateShopInteractablesInCart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopViewScreen()
	{

	}
}
