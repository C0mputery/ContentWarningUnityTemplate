using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Bot_Chaser : MonoBehaviour
{
	public float exhastionTime;

	public float fleeForSeconds;

	private Player player;

	private Bot bot;

	private PhotonView view;

	public float hidingExhastionMultiplier;

	public float timeToLoseTarget;

	public float targetDistance;

	public bool backUpIfTooClose;

	public float chaseTurnRate;

	public float fleeTurnRate;

	public float investigateTurnRate;

	public float patrolTurnRate;

	public float maxRange;

	public float maxAngle;

	public float timeToSeeTarget;

	private float exhaustion;

	private float fleeFor;

	private float hasFledFor;

	private Vector3 fleeFromPoint;

	private Transform head;

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
	private void Combat()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TargetIsHidingBehaviour()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Investigate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DefaultState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bot_Chaser()
	{

	}
}
