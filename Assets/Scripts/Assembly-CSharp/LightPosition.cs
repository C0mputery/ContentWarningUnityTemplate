using System.Runtime.CompilerServices;
using UnityEngine;

public class LightPosition
{
	public Vector3 position;

	public float radius;

	public int stepsTaken;

	public bool neverTouched;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LightPosition Sample(Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightPosition()
	{
		throw null;
	}
}
