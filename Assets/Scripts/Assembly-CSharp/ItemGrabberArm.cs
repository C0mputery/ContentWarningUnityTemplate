using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using Zorro.Core.Serizalization;

public class ItemGrabberArm : ItemInstanceBehaviour
{
	private class ClawRotator
	{
		public Transform claw;

		private float currentZ;

		public ItemGrabberArm itemGrabberArm;

		public float targetAngle;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClawRotator()
		{
			throw null;
		}
	}

	public Transform rightClaw;

	public Transform leftClaw;

	public Transform grabPoint;

	public float clawSpeed;

	public float closedAngle;

	public Vector2 breakForceStartEnd;

	public float breakForceTransitionTime;

	private ConfigurableJoint joint;

	private float jointLifeTime;

	private ClawRotator leftClawRotator;

	private ClawRotator rightClawRotator;

	private OnOffEntry onOffEntry;

	private Player playerHoldingItem;

	private bool wasOn;

	private Rigidbody attachedTo;

	private Bodypart ItemBodyPart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
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
	private bool TryGrabItem(Collider hit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RPCA_AttachToItem(BinaryDeserializer deserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TryGrabPlayer(Collider hit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RPCA_AttachToPlayer(BinaryDeserializer deserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AttachJoint(Rigidbody otherRig, bool lockRotation = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RPCA_DestroyJoint(BinaryDeserializer binaryDeserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemGrabberArm()
	{
		throw null;
	}
}
