using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class SocketTcpAsync : IPhotonSocket, IDisposable
	{
		private class ReceiveContext
		{
			public Socket workSocket;

			public int ReceivedHeaderBytes;

			public byte[] HeaderBuffer;

			public int ExpectedMessageBytes;

			public int ReceivedMessageBytes;

			public byte[] MessageBuffer;

			public bool ReadingHeader
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public bool ReadingMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public byte[] CurrentBuffer
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public int CurrentOffset
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public int CurrentExpected
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReceiveContext(Socket socket, byte[] headerBuffer, byte[] messageBuffer)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
			{
				throw null;
			}
		}

		private Socket sock;

		private readonly object syncer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Preserve]
		public SocketTcpAsync(PeerBase npeer) : base(npeer)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		~SocketTcpAsync()
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
		private void ReceiveAsync(ReceiveContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReceiveAsync(IAsyncResult ar)
		{
			throw null;
		}
	}
}
