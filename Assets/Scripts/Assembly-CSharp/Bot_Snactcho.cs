using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Bot_Snactcho : MonoBehaviour
{
	private Player player;

	private Bot bot;

	private PhotonView view;

	internal float sinceCapture;

	public Vector3 moveAwayPos;

	public Player snatchedPlayer;

	private float litLevel;

	private float litLevelInMat;

	private SkinnedMeshRenderer mr;

	private Material mat;

	private Transform headTrans;

	private float takeDamageCounter;

	private float tpCounter;

	private Joint joint;

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
	private bool CheckForLight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReturnToMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TeleportAway()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_TeleportAway(Vector3 targetPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Snatching()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_SetSnatchTarget(int setTarget)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoKilling()
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
	public Bot_Snactcho()
	{
		throw null;
	}
}
