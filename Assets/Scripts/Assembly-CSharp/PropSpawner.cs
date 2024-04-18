using System.Runtime.CompilerServices;
using UnityEngine;

public class PropSpawner : MonoBehaviour
{
	public enum SamplerType
	{
		Sphere = 0,
		Box = 1
	}

	public enum CollisionType
	{
		none = 0,
		any = 1,
		sameSpawner = 2
	}

	public bool useFirstChild;

	public GameObject[] objectsToSpawn;

	public int nrOfSpawns;

	public SamplerType samplerType;

	public BoxSampler boxSampler;

	public SphereSampler sphereSampler;

	public bool groundPosition;

	public CollisionType collisionType;

	public float allowedPenetration;

	public float minHeight;

	public bool usePerlin;

	public PerlinSampler perlin;

	public float minScale;

	public float maxScale;

	public float scalePow;

	[Range(0f, 1f)]
	public float randomRotation;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Spawn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool SpawnObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Collides(GameObject spawned)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConfigTransform(GameObject spawned)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Quaternion GetRotation(Quaternion currentRotation)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 GetPosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameObject GetSourceObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropSpawner()
	{

	}
}
