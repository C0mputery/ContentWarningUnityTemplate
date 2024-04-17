namespace DefaultNamespace.Artifacts
{
	public interface IArtifactCurse
	{
		float Rarity { get; }

		float BudgetCost { get; }

		void CastCurse(ItemInstanceBehaviour cursedItem, Player playerHoldingItem);
	}
}
