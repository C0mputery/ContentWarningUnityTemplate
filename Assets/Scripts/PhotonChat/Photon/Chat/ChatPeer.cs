using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Chat
{
	public class ChatPeer : PhotonPeer
	{
		public string NameServerHost;

		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		public ushort NameServerPortOverride;

		public string NameServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal virtual bool IsProtocolSecure
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatPeer(IPhotonPeerListener listener, ConnectionProtocol protocol) : base(listener, protocol)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Conditional("SUPPORTED_UNITY")]
		private void ConfigUnitySockets()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetNameServerAddress()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AuthenticateOnNameServer(string appId, string appVersion, string region, AuthenticationValues authValues)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChatPeer()
		{
			throw null;
		}
	}
}
