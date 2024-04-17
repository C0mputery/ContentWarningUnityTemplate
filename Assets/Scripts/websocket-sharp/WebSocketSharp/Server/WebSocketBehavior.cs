using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public abstract class WebSocketBehavior : IWebSocketSession
	{
		private WebSocketContext _context;

		private Func<CookieCollection, CookieCollection, bool> _cookiesValidator;

		private bool _emitOnPing;

		private string _id;

		private bool _ignoreExtensions;

		private Func<string, bool> _originValidator;

		private string _protocol;

		private WebSocketSessionManager _sessions;

		private DateTime _startTime;

		private WebSocket _websocket;

		protected NameValueCollection Headers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected NameValueCollection QueryString
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected WebSocketSessionManager Sessions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public WebSocketState ConnectionState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public WebSocketContext Context
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Func<CookieCollection, CookieCollection, bool> CookiesValidator
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

		public string ID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IgnoreExtensions
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

		public Func<string, bool> OriginValidator
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
			set
			{
				throw null;
			}
		}

		public DateTime StartTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected WebSocketBehavior()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string checkHandshakeRequest(WebSocketContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void onClose(object sender, CloseEventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void onError(object sender, ErrorEventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void onMessage(object sender, MessageEventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void onOpen(object sender, EventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Start(WebSocketContext context, WebSocketSessionManager sessions)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Close(ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Close(CloseStatusCode code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CloseAsync()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CloseAsync(ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CloseAsync(CloseStatusCode code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnClose(CloseEventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnError(ErrorEventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnMessage(MessageEventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool Ping()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool Ping(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Send(byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Send(FileInfo fileInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Send(string data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Send(Stream stream, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SendAsync(byte[] data, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SendAsync(FileInfo fileInfo, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SendAsync(string data, Action<bool> completed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SendAsync(Stream stream, int length, Action<bool> completed)
		{
			throw null;
		}
	}
}
