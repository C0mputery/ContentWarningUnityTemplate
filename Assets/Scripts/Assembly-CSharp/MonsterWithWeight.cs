using System.Runtime.CompilerServices;
using DefaultNamespace;

public class MonsterWithWeight
{
	public IBudgetCost monster;

	public float weight;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MonsterWithWeight()
	{

	}
}
