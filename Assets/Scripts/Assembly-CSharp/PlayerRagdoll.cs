using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using Unity.Profiling;
using UnityEngine;

public class PlayerRagdoll : MonoBehaviour
{
	public float force;

	public float torque;

	public float drag;

	public float angularDrag;

	public bool addOpposingForce;

	internal Player player;

	internal List<Rigidbody> rigList;

	internal Dictionary<BodypartType, Bodypart> bodypartDict;

	internal List<Bodypart> bodypartList;

	private List<BodyPartCollision> collisionsToHandle;

	private ProfilerMarker followAnimMarker;

	private ProfilerMarker simplifiedFollowAnimMarker;

	private ProfilerMarker dragMarker;

	private ProfilerMarker groundRaycastMarker;

	private ProfilerMarker handleCollisionsMarker;

	private ProfilerMarker clearSavedCollisionsMarker;

	internal Action<Collision, Bodypart> collisionAction;

	public SFX_Instance[] ragdollSound;

	private float ragdollSoundTime;

	public static float RagdollIfFellForLongerThan;

	private bool isSplit;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void DoInit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StripRagdoll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BodyChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Bodypart GetRandomBodypart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleSimplifiedRagdoll(bool setSimple)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixedUpdateHandled()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToggleGravity(bool setGrav)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Bodypart GetBodypartFromID(int bodyPartID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int GetBodypartIDFromCollider(Collider col)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int GetBodyPartID(Bodypart part)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Drag()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FollowAnimSimplified()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FollowAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Bodypart GetBodypart(BodypartType bodypartType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RaycastHit GroundRaycast(bool justChecking = false, bool justTryingToGetTheRaycastHit = false, bool ignoreAngle = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RegisterGroundRaycast(RaycastHit hit, Bodypart bodypart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal BodyPartCollision RaycastHitToBodyPartCollision(RaycastHit hit, Bodypart bodypart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void BodyPartCollision(Collision collision, Bodypart bodypart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RegCollision(BodyPartCollision col)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearSavedCollisions()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleCollisions()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleGroundCollision(BodyPartCollision bestGroundCollision)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AddForce(Vector3 force, ForceMode forceMode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AddForce(Vector3 force, ForceMode forceMode, Vector3 position, float radius)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RemoveItem(ItemInstance item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AddItem(ItemInstance item)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void MoveAllRigsInDirection(Vector3 delta)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void MoveAllRigsTo(Vector3 targetPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Fall(float fallTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ExtraDrag(float extraDrag)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void TaseShock(float shockSeconds)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CallFall(float seconds)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	internal void RPCA_Fall(float seconds)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Bodypart GetBodypartFromCollider(Collider col)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerRagdoll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PlayerRagdoll()
	{
		throw null;
	}
}
