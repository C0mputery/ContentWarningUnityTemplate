using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class RigCreator : MonoBehaviour
{
	public List<RigCreatorBodypart> bodyparts;

	public GameObject source;

	public GameObject sphereCol;

	public GameObject capsuleCol;

	public GameObject boxColldier;

	public PhysicMaterial slipperyMat;

	public int setDefaultLayer;

	public int smartFillLegs;

	public bool useGravity;

	public float massMultiplier;

	public bool useTargetRotation;

	public float targetRotationSpring;

	public float targetRotationDragFactor;

	public UnityEvent createRigEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateRig()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetColliders()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SmartFillLegs()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyDataTo(RigCreatorBodypart from, RigCreatorBodypart to)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RigCreatorBodypart GetOrAddBodypart(BodypartType bodypartType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RigCreatorBodypart GetBodypart(BodypartType targetBodypart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddScripts()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddRigs()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddJoints()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConfigRotations()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RegisterParts()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MigrateColliders()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddCollision()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddColliders(RigCreatorBodypart bodypart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearMesh(GameObject spawned)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ClearColliderData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SaveBodypartCollider(string colliderObjectName, Transform colTrans)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SaveJoint(RigCreatorBodypart targetPart, ConfigurableJoint configurableJoint)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Transform GetBodypartTransform(BodypartType target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RigCreator()
	{

	}
}
