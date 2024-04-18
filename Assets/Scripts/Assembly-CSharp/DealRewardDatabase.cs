using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(fileName = "DealRewardDatabase", menuName = "DealRewardDatabase")]
public class DealRewardDatabase : SingletonAsset<DealRewardDatabase>
{
	public List<DealRewardBase> rewards;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadRewards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DealRewardBase GetRewardFromIndex(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DealRewardBase GetRandom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DealRewardDatabase()
	{

	}
}
