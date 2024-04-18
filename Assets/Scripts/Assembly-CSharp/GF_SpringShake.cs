using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class GF_SpringShake : Gamefeel
{
	public SpringType springType;

	public float amount;

	public Vector3 shakeDirection;

	public float spring;

	public float damper;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Apply(Vector3 position = default(Vector3), Vector3 direction = default(Vector3), float multiplier = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GF_SpringShake()
	{

	}
}
