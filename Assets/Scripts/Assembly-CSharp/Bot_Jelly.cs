using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Bot_Jelly : MonoBehaviour
{
	private Player player;

	internal Bot bot;

	public Player jellyPlayer;

	public bool fleeing;

	public PhotonView view;

	public Vector3 moveAwayPos;

	internal float sinceCapture;

	private float sinceStartFlee;

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
	private void RPCA_DropAndFlee()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_SetJelloTarget(int setTarget)
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
	public Bot_Jelly()
	{
		throw null;
	}
}
