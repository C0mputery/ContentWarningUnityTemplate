using System.Runtime.CompilerServices;
using DefaultNamespace;
using UnityEngine;

public class BudgetCost : MonoBehaviour, IBudgetCost
{
	public int budgetCost;

	public float rarity;

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
	public BudgetCost()
	{

	}
}
