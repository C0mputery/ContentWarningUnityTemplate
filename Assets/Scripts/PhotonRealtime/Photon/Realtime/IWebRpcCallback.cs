using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public interface IWebRpcCallback
	{
		void OnWebRpcResponse(OperationResponse response);
	}
}
