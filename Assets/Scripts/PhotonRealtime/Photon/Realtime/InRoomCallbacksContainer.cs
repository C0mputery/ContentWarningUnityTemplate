using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	internal class InRoomCallbacksContainer : List<IInRoomCallbacks>, IInRoomCallbacks
	{
		private readonly LoadBalancingClient client;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InRoomCallbacksContainer(LoadBalancingClient client)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPlayerEnteredRoom(Player newPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPlayerLeftRoom(Player otherPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProp)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMasterClientSwitched(Player newMasterClient)
		{
			throw null;
		}
	}
}
