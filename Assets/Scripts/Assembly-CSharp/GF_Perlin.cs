using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class GF_Perlin : Gamefeel
{
	public float amount;

	public float duration;

	public float scale;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Apply(Vector3 position = default(Vector3), Vector3 direction = default(Vector3), float multiplier = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GF_Perlin()
	{
		throw null;
	}
}
