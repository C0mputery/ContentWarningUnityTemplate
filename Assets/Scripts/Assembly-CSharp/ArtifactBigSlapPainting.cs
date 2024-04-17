using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using Zorro.Core.Serizalization;

public class ArtifactBigSlapPainting : ItemInstanceBehaviour, IArtifactContent
{
	public GameObject bigSlapPrefab;

	private IntRangeEntry chargesEntry;

	private StashAbleEntry stashAbleEntry;

	private float timeInHand;

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
	private void RPCA_SpawnSlap(BinaryDeserializer deserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArtifactBigSlapPainting()
	{
		throw null;
	}
}
