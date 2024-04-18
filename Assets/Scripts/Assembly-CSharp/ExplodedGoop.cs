using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class ExplodedGoop : MonoBehaviour
{
	public float lifeTime;

	private PhotonView view_g;

	private float timeUntilRemove;

	public float slowAmount;

	private Collider col;

	private bool hasLeft;

	public SFX_Instance dissapear;

	public SFX_Instance enter;

	public SFX_Instance exit;

	private float t;

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
	private void OnTriggerStay(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerEnter(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsNotBlobbable(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerExit(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExplodedGoop()
	{

	}
}
