using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public enum PostHitBehaviour
	{
		Destroy = 0,
		Disable = 1,
		None = 2
	}

	public HelperFunctions.LayerType layerType;

	public PostHitBehaviour postHitBehavior;

	public float velocity;

	public float upVelocity;

	public float gravity;

	private Vector3 vel;

	public float damage;

	public float force;

	public float fall;

	public Action<RaycastHit> hitAction;

	public Action<RaycastHit> postHitAction;

	private List<Transform> ignoredRoots;

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
	private void Hit(RaycastHit hit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PostHit(RaycastHit hit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Ignore(Transform rootToIgnore, float seconds)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Projectile()
	{

	}
}
