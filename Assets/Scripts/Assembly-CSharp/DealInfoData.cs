using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DealInfoData : ScriptableObject
{
	public List<NetworkDealBase> deals;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DealInfoData()
	{

	}
}
