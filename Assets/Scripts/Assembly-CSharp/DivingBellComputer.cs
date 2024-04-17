using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class DivingBellComputer : MonoBehaviour
{
	public DivingBell m_divingBell;

	public TextMeshProUGUI m_statusText;

	public GameObject m_cellPrefab;

	public Dictionary<Player, DivingBellSuitCellUI> m_spawnedCells;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DivingBellComputer()
	{
		throw null;
	}
}
