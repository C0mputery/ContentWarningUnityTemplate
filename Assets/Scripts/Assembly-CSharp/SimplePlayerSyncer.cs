using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class SimplePlayerSyncer : MonoBehaviour, IPunObservable
{
	private SimplePlayer player;

	private Vector3 targetPos;

	private float distance;

	private Vector2 targetLook;

	private float lookDistance;

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
	public SimplePlayerSyncer()
	{

	}
}
