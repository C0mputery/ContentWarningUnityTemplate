using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp
{
	public class WebSocket : IDisposable
	{
		private AuthenticationChallenge _authChallenge;

		private string _base64Key;

		private bool _client;

		private Action _closeContext;

		private CompressionMethod _compression;

		private WebSocketContext _context;

		private CookieCollection _cookies;

		private NetworkCredential _credentials;

		private bool _emitOnPing;

		private bool _enableRedirection;

		private string _extensions;

		private bool _extensionsRequested;

		private object _forMessageEventQueue;

		private object _forPing;

		private object _forSend;

		private object _forState;

		private MemoryStream _fragmentsBuffer;

		private bool _fragmentsCompressed;

		private Opcode _fragmentsOpcode;

		private const string _guid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";

		private Func<WebSocketContext, string> _handshakeRequestChecker;

		private bool _ignoreExtensions;

		private bool _inContinuation;

		private volatile bool _inMessage;

		private volatile Logger _logger;

		private static readonly int _maxRetryCountForConnect;

		private Action<MessageEventArgs> _message;

		private Queue<MessageEventArgs> _messageEventQueue;

		private uint _nonceCount;

		private string _origin;

		private ManualResetEvent _pongReceived;

		private bool _preAuth;

		private string _protocol;

		private string[] _protocols;

		private bool _protocolsRequested;

		private NetworkCredential _proxyCredentials;

		private Uri _proxyUri;

		private volatile WebSocketState _readyState;

		private ManualResetEvent _receivingExited;

		private int _retryCountForConnect;

		private bool _secure;

		private ClientSslConfiguration _sslConfig;

		private Stream _stream;

		private TcpClient _tcpClient;

		private Uri _uri;

		private const string _version = "13";

		private TimeSpan _waitTime;

		internal static readonly byte[] EmptyBytes;

		internal static readonly int FragmentLength;

		internal static readonly RandomNumberGenerator RandomNumber;

		internal CookieCollection CookieCollection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal Func<WebSocketContext, string> CustomHandshakeRequestChecker
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

		internal bool HasMessage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		internal bool IgnoreExtensions
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

		internal bool IsConnected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public CompressionMethod Compression
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

		public IEnumerable<Cookie> Cookies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public NetworkCredential Credentials
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool EmitOnPing
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

		public bool EnableRedirection
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

		public string Extensions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsAlive
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

		public Logger Log
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
				throw null;
			}
		}

		public string Origin
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

		public string Protocol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
				throw null;
			}
		}

		public WebSocketState ReadyState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public ClientSslConfiguration SslConfiguration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Uri Url
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
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

		public event EventHandler<CloseEventArgs> OnClose
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

		public event EventHandler<ErrorEventArgs> OnError
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

		public event EventHandler<MessageEventArgs> OnMessage
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

		public event EventHandler OnOpen
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
		static WebSocket()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocket(HttpListenerWebSocketContext context, string protocol)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocket(TcpListenerWebSocketContext context, string protocol)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebSocket(string url, params string[] protocols)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool accept()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool acceptHandshake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool canSet(out string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool checkHandshakeRequest(WebSocketContext context, out string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool checkHandshakeResponse(HttpResponse response, out string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool checkProtocols(string[] protocols, out string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool checkReceivedFrame(WebSocketFrame frame, out string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void close(ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void close(PayloadData payloadData, bool send, bool receive, bool received)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void closeAsync(ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void closeAsync(PayloadData payloadData, bool send, bool receive, bool received)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool closeHandshake(byte[] frameAsBytes, bool receive, bool received)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool closeHandshake(PayloadData payloadData, bool send, bool receive, bool received)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool connect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string createExtensions()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private HttpResponse createHandshakeFailureResponse(HttpStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private HttpRequest createHandshakeRequest()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private HttpResponse createHandshakeResponse()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool customCheckHandshakeRequest(WebSocketContext context, out string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private MessageEventArgs dequeueFromMessageEventQueue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void doHandshake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void enqueueToMessageEventQueue(MessageEventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void error(string message, Exception exception)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void fatal(string message, Exception exception)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void fatal(string message, ushort code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void fatal(string message, CloseStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ClientSslConfiguration getSslConfiguration()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void message()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void messagec(MessageEventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void messages(MessageEventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ping(byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool processCloseFrame(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void processCookies(CookieCollection cookies)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool processDataFrame(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool processFragmentFrame(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool processPingFrame(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool processPongFrame(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool processReceivedFrame(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void processSecWebSocketExtensionsClientHeader(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void processSecWebSocketExtensionsServerHeader(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void processSecWebSocketProtocolClientHeader(IEnumerable<string> values)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool processUnsupportedFrame(WebSocketFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void refuseHandshake(CloseStatusCode code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void releaseClientResources()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void releaseCommonResources()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void releaseResources()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void releaseServerResources()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool send(Opcode opcode, Stream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool send(Opcode opcode, Stream stream, bool compressed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool send(Fin fin, Opcode opcode, byte[] data, bool compressed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sendAsync(Opcode opcode, Stream stream, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool sendBytes(byte[] bytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private HttpResponse sendHandshakeRequest()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private HttpResponse sendHttpRequest(HttpRequest request, int millisecondsTimeout)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool sendHttpResponse(HttpResponse response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sendProxyConnectRequest()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setClientStream()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void startReceiving()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool validateSecWebSocketAcceptHeader(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool validateSecWebSocketExtensionsServerHeader(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool validateSecWebSocketProtocolServerHeader(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool validateSecWebSocketVersionServerHeader(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Close(HttpResponse response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Close(HttpStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Close(PayloadData payloadData, byte[] frameAsBytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string CreateBase64Key()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string CreateResponseKey(string base64Key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalAccept()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool Ping(byte[] frameAsBytes, TimeSpan timeout)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Send(Opcode opcode, byte[] data, Dictionary<CompressionMethod, byte[]> cache)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Send(Opcode opcode, Stream stream, Dictionary<CompressionMethod, Stream> cache)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Accept()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AcceptAsync()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close(ushort code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close(CloseStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close(ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close(CloseStatusCode code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseAsync()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseAsync(ushort code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseAsync(CloseStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseAsync(ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseAsync(CloseStatusCode code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Connect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConnectAsync()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Ping()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Ping(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Send(byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Send(FileInfo fileInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Send(string data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Send(Stream stream, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendAsync(byte[] data, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendAsync(FileInfo fileInfo, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendAsync(string data, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendAsync(Stream stream, int length, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCookie(Cookie cookie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCredentials(string username, string password, bool preAuth)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProxy(string url, string username, string password)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IDisposable.Dispose()
		{
			throw null;
		}
	}
}
