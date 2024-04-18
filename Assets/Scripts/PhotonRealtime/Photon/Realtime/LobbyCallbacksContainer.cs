using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	internal class LobbyCallbacksContainer : List<ILobbyCallbacks>, ILobbyCallbacks
	{
		private readonly LoadBalancingClient client;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LobbyCallbacksContainer(LoadBalancingClient client)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnJoinedLobby()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLeftLobby()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRoomListUpdate(List<RoomInfo> roomList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
		{
			throw null;
		}
	}
}
