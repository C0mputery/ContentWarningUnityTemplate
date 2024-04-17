using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "NetworkDeal", menuName = "W/NetworkDeal", order = -1)]
public class NetworkDealSO : ScriptableObject
{
	public string title;

	public string description;

	public Sprite icon;

	public RARITY rarity;

	public DIFFICULTY difficulty;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkDealSO()
	{
		throw null;
	}
}
