using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Clapper : ItemInstanceBehaviour, IArtifactContent
{
	public Transform top;

	private OnOffEntry onOffEntry;

	private StashAbleEntry stashAbleEntry;

	public SFX_Instance sfx;

	public float offAngle;

	public float onAngle;

	private float angle;

	public float spring;

	public float drag;

	public float bounce;

	public float vel;

	public float bounceThreshold;

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
	private void Start()
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
	public Clapper()
	{
		throw null;
	}
}
