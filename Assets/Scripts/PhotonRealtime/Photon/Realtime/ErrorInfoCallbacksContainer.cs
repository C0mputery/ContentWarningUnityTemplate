using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	internal class ErrorInfoCallbacksContainer : List<IErrorInfoCallback>, IErrorInfoCallback
	{
		private LoadBalancingClient client;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ErrorInfoCallbacksContainer(LoadBalancingClient client)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnErrorInfo(ErrorInfo errorInfo)
		{
			throw null;
		}
	}
}
