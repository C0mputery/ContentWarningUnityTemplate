using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float movementForce;

	public float sprintMultiplier;

	public bool canSprintInAnyDirection;

	public float bodyRotationTorque;

	public float maxStamina;

	public float staminaRegRate;

	public float staminaReActivationThreshold;

	public float jumpImpulse;

	public float jumpForceOverTime;

	public float jumpForceDuration;

	private float jumpForceTime;

	public float standForce;

	public float standForcePerGroundCol;

	public bool groundRaycast;

	public bool alwaysGroundRaycast;

	public bool wallClimb;

	public float wallClimbGravityAdjustSpeed;

	public float gravity;

	public float constantGravity;

	private Player player;

	private PlayerRagdoll ragdoll;

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
	public void TryJump()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_Jump()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyJumpForce()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MovementStateChanges()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Look()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetRotations()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SimpleMovement()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConstantGravity()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BodyRotation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Movement()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Standing()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Gravity()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerController()
	{
		throw null;
	}
}
