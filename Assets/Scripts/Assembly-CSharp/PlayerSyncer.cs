using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class PlayerSyncer : MonoBehaviour, IPunObservable
{
	private Player player;

	private Vector3 targetPos;

	private Vector3 lastPos;

	private float sinceLastPackage;

	private Vector2 targetLook;

	private float lookDistance;

	private bool first;

	private bool hasRecieved;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerSyncer()
	{

	}
}
