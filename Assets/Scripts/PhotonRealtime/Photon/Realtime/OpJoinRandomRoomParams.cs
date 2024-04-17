using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class OpJoinRandomRoomParams
	{
		public Hashtable ExpectedCustomRoomProperties;

		public byte ExpectedMaxPlayers;

		public MatchmakingMode MatchingType;

		public TypedLobby TypedLobby;

		public string SqlLobbyFilter;

		public string[] ExpectedUsers;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpJoinRandomRoomParams()
		{
			throw null;
		}
	}
}
