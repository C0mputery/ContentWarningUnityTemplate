using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ShopInteractibleCategory : Interactable
{
	[SerializeField]
	private TextMeshProUGUI m_CategoryText;

	private ShopItemCategory m_Category;

	private static ShopHandler m_ShopHandler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Interact(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Setup(ShopHandler handler, ShopItemCategory category)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopInteractibleCategory()
	{
		throw null;
	}
}
