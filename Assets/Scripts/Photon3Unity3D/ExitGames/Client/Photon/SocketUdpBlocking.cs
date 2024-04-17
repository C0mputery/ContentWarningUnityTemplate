using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class SocketUdpBlocking : IPhotonSocket, IDisposable
	{
		private Socket sock;

		private readonly object syncer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Preserve]
		public SocketUdpBlocking(PeerBase npeer) : base(npeer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		~SocketUdpBlocking()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Connect()
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void DnsAndConnect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveLoop()
		{
			throw null;
		}
	}
}