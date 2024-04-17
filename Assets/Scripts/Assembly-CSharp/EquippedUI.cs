using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EquippedUI : MonoBehaviour
{
	public TextMeshProUGUI m_textPrefab;

	public TextMeshProUGUI m_itemNameText;

	private ItemDescriptor m_lastItemDescriptor;

	private List<(IHaveUIData, TextMeshProUGUI)> m_entries;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(ItemDescriptor itemDescriptor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EquippedUI()
	{
		throw null;
	}
}
