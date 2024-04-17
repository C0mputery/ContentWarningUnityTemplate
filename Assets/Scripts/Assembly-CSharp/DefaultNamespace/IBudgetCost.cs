using UnityEngine;

namespace DefaultNamespace
{
	public interface IBudgetCost
	{
		int Cost { get; }

		float Rarity { get; }

		GameObject gameObject { get; }
	}
}
