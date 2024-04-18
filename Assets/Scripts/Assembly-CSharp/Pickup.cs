using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Pickup : Interactable
{
	public PhotonView m_photonView;

	private Rigidbody m_rigidbody;

	private ItemInstanceData instanceData;

	private byte m_itemID;

	private Vector3 lastPos;

	public ItemInstance itemInstance;

	public Rigidbody Rigidbody
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Interact(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartHover(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndHover(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConfigurePickup(byte itemID, ItemInstanceData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConfigurePickup(byte itemID, ItemInstanceData data, Vector3 vel, Vector3 angVel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_ConfigurePickup(byte itemID, byte[] data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_SetVelocity(Vector3 vel, Vector3 angVel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_Remove()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_RequestPickup(int photonView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceSync()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_ForceSync(Vector3 pos, Quaternion rot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_FailedToPickup()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pickup()
	{

	}
}
