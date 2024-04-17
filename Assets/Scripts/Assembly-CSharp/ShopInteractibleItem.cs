using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopInteractibleItem : Interactable
{
	private string m_Name;

	private int m_Price;

	[SerializeField]
	private TMP_Text m_ItemNameText;

	[SerializeField]
	private TMP_Text m_PriceText;

	[SerializeField]
	private TMP_Text m_NumberInBagText;

	[SerializeField]
	private GameObject m_DiscountObject;

	[SerializeField]
	private GameObject m_NumberInBagObject;

	public Image m_icon;

	public Sprite defaultIcon;

	private int m_NumberInCart;

	private static ShopHandler m_Handler;

	private bool m_Valid;

	public byte ItemID
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsValid(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Interact(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Setup(ShopHandler handler, ShopItem item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddOneToCartVisual()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCartVisual()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CartTextUpdated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopInteractibleItem()
	{
		throw null;
	}
}
