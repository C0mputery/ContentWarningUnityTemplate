using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Serialization;

public class ArtifactSkull : ItemInstanceBehaviour, IArtifactContent
{
	private StashAbleEntry stashAbleEntry;

	[FormerlySerializedAs("curse")]
	[SerializeReference]
	public GameObject cursePrefab;

	public GameObject spawnedCurse;

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
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnItemEquipped(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArtifactSkull()
	{

	}
}
