using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public class WebSocketServer
	{
		private IPAddress _address;

		private bool _allowForwardedRequest;

		private WebSocketSharp.Net.AuthenticationSchemes _authSchemes;

		private static readonly string _defaultRealm;

		private bool _dnsStyle;

		private string _hostname;

		private TcpListener _listener;

		private Logger _log;

		private int _port;

		private string _realm;

		private string _realmInUse;

		private Thread _receiveThread;

		private bool _reuseAddress;

		private bool _secure;

		private WebSocketServiceManager _services;

		private ServerSslConfiguration _sslConfig;

		private ServerSslConfiguration _sslConfigInUse;

		private volatile ServerState _state;

		private object _sync;

		private Func<IIdentity, WebSocketSharp.Net.NetworkCredential> _userCredFinder;

		public IPAddress Address
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool AllowForwardedRequest
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public WebSocketSharp.Net.AuthenticationSchemes AuthenticationSchemes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool IsListening
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsSecure
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool KeepClean
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Logger Log
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Port
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Realm
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool ReuseAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public ServerSslConfiguration SslConfiguration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Func<IIdentity, WebSocketSharp.Net.NetworkCredential> UserCredentialsFinder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public TimeSpan WaitTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public WebSocketServiceManager WebSocketServices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WebSocketServer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebSocketServer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebSocketServer(int port)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebSocketServer(string url)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebSocketServer(int port, bool secure)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebSocketServer(IPAddress address, int port)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebSocketServer(IPAddress address, int port, bool secure)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void abort()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool authenticateClient(TcpListenerWebSocketContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool canSet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool checkHostNameForRequest(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string getRealm()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ServerSslConfiguration getSslConfiguration()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void init(string hostname, IPAddress address, int port, bool secure)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void processRequest(TcpListenerWebSocketContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void receiveRequest()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void startReceiving()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void stop(ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void stopReceiving(int millisecondsTimeout)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool tryCreateUri(string uriString, out Uri result, out string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddWebSocketService<TBehavior>(string path) where TBehavior : WebSocketBehavior, new()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddWebSocketService<TBehavior>(string path, Action<TBehavior> initializer) where TBehavior : WebSocketBehavior, new()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RemoveWebSocketService(string path)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}
	}
}
