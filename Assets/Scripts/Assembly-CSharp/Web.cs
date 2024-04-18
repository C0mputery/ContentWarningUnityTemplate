using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Web : MonoBehaviour
{
	private PhotonView view;

	private WebParent webParent;

	private LineRenderer line;

	private BoxCollider col;

	internal Rigidbody heldPart;

	private Player heldPlayer;

	internal Vector3 p1;

	internal Vector3 p2;

	internal Vector3 mid;

	private float stuckFor;

	public float force;

	public float drag;

	public float wholeBodyFactor;

	public float distanceFactor;

	private float sinceSpawn;

	public SFX_Instance stuck;

	public SFX_Instance unStuck;

	private Vector3 vel;

	private Vector3 currentPos;

	private float sinceLetGo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void StickToPlayer(Rigidbody playerPart, Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTriggerEnter(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetRefs()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ConfigWeb()
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
	internal void LetGo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool TryInit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetCustom(Vector3 vec1, Vector3 vec2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Web()
	{

	}
}
