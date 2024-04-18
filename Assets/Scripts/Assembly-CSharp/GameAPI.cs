using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameAPI : MonoBehaviour
{
	public static int seed;

	public static GameAPI instance;

	public Action<GameObject> objectSpawnedAction;

	private static readonly int BASE_BUDGET;

	private static readonly float BUDGET_FACTOR;

	public static int MonsterBudget
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public static int MaxSingleMonsterCost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public static int ArtifactBudget
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public static int CurrentDay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GetSeededPositionProbability(Vector3 position, double probability)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GenerateNewBudget(int currentDay, int quotaDay, bool supressLogs = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameAPI()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GameAPI()
	{
		throw null;
	}
}
