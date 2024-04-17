using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PerlinSampler
{
	public float scale;

	public int iterations;

	public float scaleIncrease;

	public float roughness;

	public float pow;

	public Vector2 minMax;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Sample(Vector2 pos, int seed = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float SampleValue(Vector2 pos, int seed = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PerlinSampler()
	{
		throw null;
	}
}
