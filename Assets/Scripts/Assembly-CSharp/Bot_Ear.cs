using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Bot_Ear : MonoBehaviour
{
	private Player player;

	private Bot bot;

	private PhotonView view;

	private bool fleeing;

	private float sinceStartFlee;

	private Vector3 fleeFromPos;

	private float hurtAmount;

	private bool otherClientsDisplayHurt;

	private float sinceHurtSync;

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
	[PunRPC]
	private void RPCA_EarSetHurt(bool setHurt)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_EarStopFlee()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_EarFlee()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Combat()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Investigate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DefaultState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bot_Ear()
	{
		throw null;
	}
}
