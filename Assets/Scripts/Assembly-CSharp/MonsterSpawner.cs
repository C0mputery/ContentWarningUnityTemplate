using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core.CLI;

public class MonsterSpawner : MonoBehaviour
{
	[Range(0f, 1f)]
	public float spawnChance;

	public string monster;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void SpawnMonster(string monster)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject SpawnMonster(string monster, Vector3 position)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SpawnWithConditionalObject(GameObject conditionalObject)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TestSpawnChance()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MonsterSpawner()
	{
		throw null;
	}
}
