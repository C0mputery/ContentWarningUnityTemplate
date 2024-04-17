using System;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class MonsterSyncer : MonoBehaviour, IPunObservable
{
	private Player player;

	private Bot bot;

	private Vector3 targetPos;

	private Vector3 lastPos;

	private float sinceLastPackage;

	private Vector2 targetLook;

	private float lookDistance;

	private bool hasNotRecievedFirstPackage;

	public Action<int> AttackAction;

	private PhotonView view;

	private bool m_Inited;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_SyncMe(Vector3 position, Vector3 lookDir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SimpleSync(float timeBetweenPackages)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PhysicsSync(float timeBetweenPackages)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CallAttack(int viewID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_Attack(int viewID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MonsterSyncer()
	{
		throw null;
	}
}
