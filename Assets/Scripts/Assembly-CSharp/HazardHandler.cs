using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HazardHandler : MonoBehaviour
{
	public List<Hazard> hazards;

	public static HazardHandler instance;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hazard GetNearbyHazard(float range, Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HazardHandler()
	{
		throw null;
	}
}
