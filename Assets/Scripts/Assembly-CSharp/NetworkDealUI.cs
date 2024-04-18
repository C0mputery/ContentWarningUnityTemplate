using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NetworkDealUI : MonoBehaviour
{
	public GameObject dealSelection;

	public GameObject dealProgress;

	public GameObject dealComplete;

	public GameObject dealFailed;

	private List<GameObject> allScreens;

	private GameObject currentScreen;

	public NetworkDealBase ActiveDeal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HideAllScreens()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowNewDeals()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkDealUI()
	{

	}
}
