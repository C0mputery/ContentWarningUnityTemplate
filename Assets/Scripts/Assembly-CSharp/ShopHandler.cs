using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using TMPro;
using UnityEngine;

public class ShopHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowItemAddedToCart_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopHandler _003C_003E4__this;

		public ShopItem item;

		public float f;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CShowItemAddedToCart_003Ed__37(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public GameObject droneObject;

	[SerializeField]
	private Transform m_BoughtItemPosition;

	[SerializeField]
	private TextMeshProUGUI m_ItemAddedToCartText;

	public SFX_Instance clickSFX;

	public SFX_Instance addSFX;

	public SFX_Instance noMoneySFX;

	public SFX_Instance emptykSFX;

	public SFX_Instance purchaseSFX;

	private RoomStatsHolder m_RoomStats;

	private Dictionary<byte, ShopItem> m_ItemsForSaleDictionary;

	private ShoppingCart m_ShoppingCart;

	private Dictionary<ShopItemCategory, List<ShopItem>> m_CategoryItemDic;

	private Action m_OnBuyAction;

	private ShopViewScreen m_ShopView;

	private PhotonView m_PhotonView;

	public static ShopHandler Instance
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

	public int NumberOfItemsInShop
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
	public void InitShopHandler()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitShopScreen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitShop()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SortShopItemsByPrice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAddToCartItemClicked(byte itemID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeCategoryClicked(byte category)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClearCartClicked()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnOrderCartClicked()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCM_RequestShop(int playerRequesting)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCO_UpdateShop(byte category, byte[] itemsInCart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetCart(byte[] itemsInCart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCM_RequestShopAction(byte shopAction, byte argument)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_ClearCart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_AddItemToCart(byte itemID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CShowItemAddedToCart_003Ed__37))]
	private IEnumerator ShowItemAddedToCart(float f, ShopItem item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_ChangeCategory(byte categoryID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetShopItem(byte index, ref ShopItem item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetShopCategoryItems(ShopItemCategory categoryIndex, ref ShopItem[] items)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuyItem(ShoppingCart cart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BuyItem(int cost, byte[] itemIDs, float x, float y, float z)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_SpawnDrone(byte[] itemIDs)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckIfBoughtCameraUpgrade(Item item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddOnBuyListeners(Action a)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrentCartValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetNumberOfItemsInCart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<ShopItem> GetItemsInCart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopHandler()
	{

	}
}
