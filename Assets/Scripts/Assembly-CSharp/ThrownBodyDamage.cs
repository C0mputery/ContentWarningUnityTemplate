using System.Runtime.CompilerServices;
using UnityEngine;

public class ThrownBodyDamage : MonoBehaviour
{
	public float damage;

	public float force;

	internal Vector3 direction;

	private Player player;

	private bool done;

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
	private void Collide(Collision collision, Bodypart bodypart)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ThrownBodyDamage()
	{

	}
}
