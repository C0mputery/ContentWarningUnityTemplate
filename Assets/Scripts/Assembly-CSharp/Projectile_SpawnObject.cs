using System.Runtime.CompilerServices;
using UnityEngine;

public class Projectile_SpawnObject : MonoBehaviour
{
	public bool photonSpawn;

	public GameObject objectToSpawn;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Hit(RaycastHit hit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Projectile_SpawnObject()
	{

	}
}
