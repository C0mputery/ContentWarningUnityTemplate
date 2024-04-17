using System.Runtime.CompilerServices;
using UnityEngine;

public class Drone : MonoBehaviour
{
	public GameObject dropSound;

	public Item[] items;

	public AnimationCurve forceCurve;

	public float spring;

	public float grav;

	public float drag;

	public float angularDrag;

	public float ropeLength;

	public Vector3 localPos;

	private Rigidbody rig;

	private Transform dron;

	private float counter;

	private bool done;

	private Vector3 lastForce;

	private Vector3 lastForceTarget;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Drone()
	{
		throw null;
	}
}
