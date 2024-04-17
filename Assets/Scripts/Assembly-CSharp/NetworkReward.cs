public interface NetworkReward
{
	void GiveReward(DIFFICULTY difficulty);

	string GetRewardDescription(DIFFICULTY difficulty);
}
