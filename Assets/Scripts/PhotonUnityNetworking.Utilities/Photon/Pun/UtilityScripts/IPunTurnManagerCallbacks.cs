using Photon.Realtime;

namespace Photon.Pun.UtilityScripts
{
	public interface IPunTurnManagerCallbacks
	{
		void OnTurnBegins(int turn);

		void OnTurnCompleted(int turn);

		void OnPlayerMove(Player player, int turn, object move);

		void OnPlayerFinished(Player player, int turn, object move);

		void OnTurnTimeEnds(int turn);
	}
}
