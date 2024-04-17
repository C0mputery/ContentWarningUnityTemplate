using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class ArtifactRadio : ItemInstanceBehaviour, IArtifactContent
{
	private IntRangeEntry chargesEntry;

	private OnOffEntry onOffEntry;

	private StashAbleEntry stashAbleEntry;

	private TimeEntry radioTimeEntry;

	public float maxBatteryCharge;

	private BatteryEntry batteryEntry;

	public MeshRenderer bright;

	public AudioLoop music;

	private float timeOnTheGround;

	public float maxTimeOnGround;

	private float timeToAlert;

	public float alertIntervall;

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
	public ArtifactRadio()
	{
		throw null;
	}
}
