using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class ItemHugger : ItemInstanceBehaviour
{
	public Item hugEmote;

	private Player playerHoldingItem;

	public float healInterval;

	public float fullHealTime;

	private float timeSinceLastHeal;

	private OnOffEntry onOffEntry;

	private bool playedEmote;

	public GameObject trigger;

	[SerializeField]
	public float hugForce;

	public float hugBoxDistance;

	public PlayerEmotes PlayerEmotes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TriggerSaysTriggerStay(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemHugger()
	{
		throw null;
	}
}
