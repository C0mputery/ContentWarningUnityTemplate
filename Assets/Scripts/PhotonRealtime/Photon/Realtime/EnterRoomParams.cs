using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class EnterRoomParams
	{
		public string RoomName;

		public RoomOptions RoomOptions;

		public TypedLobby Lobby;

		public Hashtable PlayerProperties;

		protected internal bool OnGameServer;

		protected internal JoinMode JoinMode;

		public string[] ExpectedUsers;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnterRoomParams()
		{
			throw null;
		}
	}
}
