using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Attack_Throw : MonoBehaviour
{
	private Player player;

	private Bot bot;

	private PhotonView view;

	private MonsterAnimationHandler animator;

	public AnimationCurve grabForceCurve;

	public AnimationCurve throwCurve;

	public float force;

	public float throwForce;

	public float windupForce;

	internal MonsterAnimationValues val;

	public float damage;

	public float hitPlayerForce;

	private Joint jl;

	private Joint jr;

	private Coroutine grabCor;

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
	public void CallGrab(Player targetPlayer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_LarvaGrab(int targetPlayerID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LetGo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReachFor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_LarvaReachForTarget(int targetPlayerID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Attack_Throw()
	{
		throw null;
	}
}
