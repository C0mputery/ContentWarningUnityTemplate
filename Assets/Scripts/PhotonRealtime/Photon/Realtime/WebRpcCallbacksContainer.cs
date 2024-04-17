using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	internal class WebRpcCallbacksContainer : List<IWebRpcCallback>, IWebRpcCallback
	{
		private LoadBalancingClient client;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebRpcCallbacksContainer(LoadBalancingClient client)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnWebRpcResponse(OperationResponse response)
		{
			throw null;
		}
	}
}
