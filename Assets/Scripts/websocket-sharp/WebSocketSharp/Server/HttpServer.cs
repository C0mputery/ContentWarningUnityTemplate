using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public class HttpServer
	{
		private IPAddress _address;

		private string _docRootPath;

		private string _hostname;

		private WebSocketSharp.Net.HttpListener _listener;

		private Logger _log;

		private int _port;

		private Thread _receiveThread;

		private bool _secure;

		private WebSocketServiceManager _services;

		private volatile ServerState _state;

		private object _sync;

		public IPAddress Address
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
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

		public string DocumentRootPath
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

		public event EventHandler<HttpRequestEventArgs> OnConnect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnDelete
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnGet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnHead
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnOptions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnPost
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnPut
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnTrace
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpServer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpServer(int port)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpServer(string url)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpServer(int port, bool secure)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpServer(IPAddress address, int port)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpServer(IPAddress address, int port, bool secure)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void abort()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool canSet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool checkCertificate(out string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WebSocketSharp.Net.HttpListener createListener(string hostname, int port, bool secure)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void init(string hostname, IPAddress address, int port, bool secure)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void processRequest(WebSocketSharp.Net.HttpListenerContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void processRequest(HttpListenerWebSocketContext context)
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
