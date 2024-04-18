using System.Runtime.CompilerServices;
using UnityEngine;

public class ArtifactSpawner : MonoBehaviour
{
	public Item artifactToSpawn;

	public Pickup spawnedArtifact;

	public float spawnAbovePatrolPoint;

	public Vector2 minMaxThrowForce;

	public float maxWaitForRest;

	private readonly int maxNrOfThrows;

	private int nrOfThrows;

	private float timeSinceThrow;

	public bool debugDontMove;

	public Pickup completedSpawn;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArtifactSpawner()
	{

	}
}
