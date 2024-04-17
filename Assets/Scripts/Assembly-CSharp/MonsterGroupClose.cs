using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using DefaultNamespace;
using UnityEngine;

public class MonsterGroupClose : MonoBehaviour, IHasPatrolGroup, IBudgetCost
{
	public bool allOnSamePatrolPoint;

	public bool firstMonsterIsLeader;

	public List<GameObject> monsters;

	public List<Bot> spanwedMonsters;

	private IHasPatrolGroup monsterPG;

	private List<IBudgetCost> budgetCosts;

	public int extraCost;

	public float rarity;

	private List<IBudgetCost> BudgetCosts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int Cost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float Rarity
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
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<PatrolPoint.PatrolGroup> GetGroup()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintCost()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MonsterGroupClose()
	{
		throw null;
	}
}
