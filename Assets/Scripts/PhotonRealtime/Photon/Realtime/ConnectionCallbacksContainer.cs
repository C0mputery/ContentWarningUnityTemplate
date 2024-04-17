using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public class ConnectionCallbacksContainer : List<IConnectionCallbacks>, IConnectionCallbacks
	{
		private readonly LoadBalancingClient client;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConnectionCallbacksContainer(LoadBalancingClient client)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnConnected()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnConnectedToMaster()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRegionListReceived(RegionHandler regionHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisconnected(DisconnectCause cause)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCustomAuthenticationFailed(string debugMessage)
		{
			throw null;
		}
	}
}
