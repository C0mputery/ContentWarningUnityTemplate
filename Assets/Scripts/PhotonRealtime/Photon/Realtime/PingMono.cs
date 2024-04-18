using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public class PingMono : PhotonPing
	{
		private Socket sock;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool StartPing(string ip)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Done()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PingMono()
		{

		}
	}
}
