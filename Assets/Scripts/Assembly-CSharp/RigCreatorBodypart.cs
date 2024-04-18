using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class RigCreatorBodypart
{
	public enum ColliderMaterial
	{
		Default = 0,
		Slippery = 1
	}

	[Serializable]
	public class RigCreatorColliderData
	{
		public ColliderType colliderType;

		public Vector3 colliderPosition;

		public Vector3 colliderRotation;

		public Vector3 colliderScale;

		public ColliderMaterial physicsMaterial;

		public int overrideLayer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RigCreatorColliderData()
		{
			throw null;
		}
	}

	public BodypartType partType;

	public float mass;

	public Vector3 rotation;

	public List<RigCreatorColliderData> colliders;

	[HideInInspector]
	public ColliderType colliderType;

	[HideInInspector]
	public Vector3 colliderPosition;

	[HideInInspector]
	public Vector3 colliderRotation;

	[HideInInspector]
	public Vector3 colliderScale;

	[HideInInspector]
	public ColliderMaterial physicsMaterial;

	[HideInInspector]
	public int overrideLayer;

	public JointConfig joint;

	public GameObject rigObject;

	public Rigidbody rig;

	public Transform rigObjectParent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnRig()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RigCreatorBodypart()
	{

	}
}
