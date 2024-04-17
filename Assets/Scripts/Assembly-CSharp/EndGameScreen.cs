using System;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class EndGameScreen : MonoBehaviour
{
	private Canvas canvas;

	public Transform firstGo;

	public Transform secondGo;

	public Transform thirdGo;

	private PhotonView view;

	private float watchedFor;

	private Action m_OnDoneAction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartWatching(Action a = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_StartWatching(int first, int second, int third)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Skip()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoneWatching()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EndGameScreen()
	{
		throw null;
	}
}
