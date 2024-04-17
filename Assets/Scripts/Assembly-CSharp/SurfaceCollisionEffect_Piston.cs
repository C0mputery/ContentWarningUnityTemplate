using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SurfaceCollisionEffect_Piston : SurfaceCollisionEffect
{
	public float fall;

	public float force;

	public float damage;

	public float playerCooldown;

	private List<Player> hitPlayers;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CollideWithSurface(Collision col, Bodypart part)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SurfaceCollisionEffect_Piston()
	{
		throw null;
	}
}
