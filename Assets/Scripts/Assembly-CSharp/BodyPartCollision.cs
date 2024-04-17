using System.Runtime.CompilerServices;
using UnityEngine;

public class BodyPartCollision
{
	public Bodypart bodyPart;

	public Vector3 point;

	public Vector3 normal;

	public Rigidbody rigidbody;

	public Collider collider;

	public GameObject gameObject;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConfigFromCollision(Collision collision)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ConfigFromRaycastHit(RaycastHit hit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BodyPartCollision()
	{
		throw null;
	}
}
