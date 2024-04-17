using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class SurfaceCollisionEffect : MonoBehaviour
{
	public abstract void CollideWithSurface(Collision col, Bodypart part);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected SurfaceCollisionEffect()
	{
		throw null;
	}
}
