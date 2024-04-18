using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class ArtifactZombieBook : ItemInstanceBehaviour, IArtifactContent
{
	public int maxCharges;

	public GameObject cursePrefab;

	private IntRangeEntry chargesEntry;

	private OnOffEntry onOffEntry;

	private StashAbleEntry stashAbleEntry;

	public bool IsHeld
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
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
	public ArtifactZombieBook()
	{

	}
}
