using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Serialization;

public class ItemGooBall : ItemInstanceBehaviour
{
	private StashAbleEntry stashAbleEntry;

	private LifeTimeEntry m_lifeTimeEntry;

	[FormerlySerializedAs("maxLifeTime")]
	public float explodeTime;

	private OnOffEntry usedEntry;

	public GameObject explodedGoopPref;

	[FormerlySerializedAs("sphereCollider_gc")]
	public SphereCollider sphereCollider;

	public AudioLoop tickingSound;

	public GameObject lightObj;

	private bool exploded;

	private float timeNotHeld;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnExplosive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionEnter(Collision other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckCollision(Collision other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionStay(Collision other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemGooBall()
	{
		throw null;
	}
}
