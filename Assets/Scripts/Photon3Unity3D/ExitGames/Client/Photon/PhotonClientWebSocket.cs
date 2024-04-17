using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExitGames.Client.Photon
{
	public class PhotonClientWebSocket : IPhotonSocket
	{
		private ClientWebSocket clientWebSocket;

		private Task sendTask;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Preserve]
		public PhotonClientWebSocket(PeerBase peerBase) : base(peerBase)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Connect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AsyncConnectAndReceive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Disconnect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PhotonSocketError Send(byte[] data, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PhotonSocketError Receive(out byte[] data)
		{
			throw null;
		}
	}
}
