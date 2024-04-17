using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	[Serializable]
	public class AppSettings
	{
		public string AppIdRealtime;

		public string AppIdFusion;

		public string AppIdChat;

		public string AppIdVoice;

		public string AppVersion;

		public bool UseNameServer;

		public string FixedRegion;

		[NonSerialized]
		public string BestRegionSummaryFromStorage;

		public string Server;

		public int Port;

		public string ProxyServer;

		public ConnectionProtocol Protocol;

		public bool EnableProtocolFallback;

		public AuthModeOption AuthMode;

		public bool EnableLobbyStatistics;

		public DebugLevel NetworkLogging;

		public bool IsMasterServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsBestRegion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsDefaultNameServer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsDefaultPort
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToStringFull()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsAppId(string val)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string HideAppId(string appId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AppSettings CopyTo(AppSettings d)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AppSettings()
		{
			throw null;
		}
	}
}
