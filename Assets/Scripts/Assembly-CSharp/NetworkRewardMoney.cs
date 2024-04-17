using System.Runtime.CompilerServices;
using UnityEngine;

public class NetworkRewardMoney : MonoBehaviour, NetworkReward
{
	public int veryEasyReward;

	public int easyReward;

	public int mediumReward;

	public int hardReward;

	public int veryHardReward;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GiveReward(DIFFICULTY difficulty)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRewardDescription(DIFFICULTY difficulty)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCashRewardAmount(DIFFICULTY difficulty)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkRewardMoney()
	{
		throw null;
	}
}
