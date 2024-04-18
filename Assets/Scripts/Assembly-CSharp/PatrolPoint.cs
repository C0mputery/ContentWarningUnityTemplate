using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PatrolPoint : MonoBehaviour
{
	public enum PatrolGroup
	{
		Dog = 0,
		Cat = 1,
		Bird = 2,
		Fish = 3,
		Bear = 4,
		Wolf = 5,
		Ant = 6
	}

	internal bool temporaryPoint;

	public PatrolGroup group;

	public float spawnWeight;

	public List<PatrolPoint> connectedPoints;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetClosestPoints_All()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetClosestPoints()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color GetColorByGroup(PatrolGroup group)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal PatrolPoint GetNeighbor(List<PatrolGroup> groups, PatrolPoint currentPoint)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal PatrolPoint GetNeighbor(List<PatrolGroup> groups, PatrolPoint currentPoint, Vector3 direction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PatrolPoint()
	{

	}
}
