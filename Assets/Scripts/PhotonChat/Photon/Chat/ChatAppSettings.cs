using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Chat
{
	[Serializable]
	public class ChatAppSettings
	{
		public string AppIdChat;

		public string AppVersion;

		public string FixedRegion;

		public string Server;

		public ushort Port;

		public string ProxyServer;

		public ConnectionProtocol Protocol;

		public bool EnableProtocolFallback;

		public DebugLevel NetworkLogging;

		public bool IsDefaultNameServer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatAppSettings()
		{
			throw null;
		}
	}
}
