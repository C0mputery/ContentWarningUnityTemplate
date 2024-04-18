using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(fileName = "NetworkDealDataBase", menuName = "NetworkDealDataBase")]
public class NetworkDealDataBase : SingletonAsset<NetworkDealDataBase>
{
	public List<NetworkDealBase> deals;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadDeals()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkDealBase CreateDeal(DIFFICULTY difficulty)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkDealBase GetDealFromIndex(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<NetworkDealBase> GetDeals(DIFFICULTY difficulty)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<NetworkDealBase> GetDeals(List<DIFFICULTY> difficulties)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkDealDataBase()
	{

	}
}
