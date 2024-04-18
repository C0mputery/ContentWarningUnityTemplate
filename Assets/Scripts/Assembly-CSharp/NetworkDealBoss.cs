using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using Zorro.Core.CLI;

public class NetworkDealBoss : MonoBehaviour
{
	public static NetworkDealBoss me;

	public NetworkDealBase activeDeal;

	private PhotonView view;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void PickDeal(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void CompleteDeal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void FailDeal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrintActiveDeal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDeal(NetworkDealBase deal)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HardSyncDeal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_HardSyncDeal(int progress, NetworkDealBase.DEAL_STATE dealState, int dealIndex, int rewardIndex, DIFFICULTY difficulty)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SyncDealProgress()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_SyncDealProgress(int progress, NetworkDealBase.DEAL_STATE dealState)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_AddDeal(int dealIndex, int rewardIndex, DIFFICULTY difficulty)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveDeal(NetworkDealBase deal)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_RemoveDeal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReviewUploadContent(ContentBuffer contentBuffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAddedMoney(int money)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAddQuota(int quotaToAdd)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnMoneyRemoved(int money)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkDealBoss()
	{

	}
}
