using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class PhysicsObjectSyncer : MonoBehaviour, IPunObservable
{
	private Rigidbody m_rigidbody;

	private PhotonView m_photonView;

	private Vector3 m_newPos;

	private Vector3 m_oldPos;

	private Quaternion m_newRot;

	private Quaternion m_oldRot;

	private float m_tickTime;

	private bool m_firstRead;

	private float m_lastTickRead;

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
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInitialPos(Vector3 pos, Quaternion rot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PhysicsObjectSyncer()
	{

	}
}
