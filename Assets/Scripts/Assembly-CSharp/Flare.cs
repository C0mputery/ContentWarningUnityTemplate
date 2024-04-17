using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Flare : ItemInstanceBehaviour
{
	public Light m_light;

	public MeshRenderer lightBeam;

	public MeshRenderer brightPart;

	public GameObject trigger;

	private LifeTimeEntry m_lifeTimeEntry;

	private OnOffEntry m_onOffEntry;

	public float maxLifeTime;

	private StashAbleEntry stashAbleEntry;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Flare()
	{
		throw null;
	}
}
