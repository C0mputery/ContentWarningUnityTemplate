using System.Runtime.CompilerServices;
using DefaultNamespace.Artifacts;
using Photon.Pun;
using UnityEngine;

public class ArtifactGravityFlipperOn : ItemInstanceBehaviour, ISpawnedByArtifactSpawner
{
	private StashAbleEntry stashAbleEntry;

	private float upAmount;

	public GameObject flipCurse;

	public IntRangeEntry chargesEntry;

	public Item itemGravityOff;

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
	public void OnFinishSpawning()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArtifactGravityFlipperOn()
	{

	}
}
