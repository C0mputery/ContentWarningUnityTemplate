using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
	public Transform leftDoor;

	public Transform rightDoor;

	public Transform leftEdge;

	public Transform rightEdge;

	private BoxCollider trigger;

	private bool isOpen;

	public float sinceTryClose;

	private PhotonView view;

	private Animator anim;

	public bool alwaysOpen;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConfigEdges()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerEnter(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryClose()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_Open()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_Close()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SlidingDoor()
	{
		throw null;
	}
}
