using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace WebSocketSharp.Net
{
	public sealed class HttpListener : IDisposable
	{
		private AuthenticationSchemes _authSchemes;

		private Func<HttpListenerRequest, AuthenticationSchemes> _authSchemeSelector;

		private string _certFolderPath;

		private Queue<HttpListenerContext> _contextQueue;

		private LinkedList<HttpListenerContext> _contextRegistry;

		private object _contextRegistrySync;

		private static readonly string _defaultRealm;

		private bool _disposed;

		private bool _ignoreWriteExceptions;

		private volatile bool _listening;

		private Logger _log;

		private string _objectName;

		private HttpListenerPrefixCollection _prefixes;

		private string _realm;

		private bool _reuseAddress;

		private ServerSslConfiguration _sslConfig;

		private Func<IIdentity, NetworkCredential> _userCredFinder;

		private Queue<HttpListenerAsyncResult> _waitQueue;

		internal bool ReuseAddress
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

		public AuthenticationSchemes AuthenticationSchemes
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

		public Func<HttpListenerRequest, AuthenticationSchemes> AuthenticationSchemeSelector
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

		public string CertificateFolderPath
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

		public bool IgnoreWriteExceptions
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

		public static bool IsSupported
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
		}

		public HttpListenerPrefixCollection Prefixes
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

		public ServerSslConfiguration SslConfiguration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool UnsafeConnectionNtlmAuthentication
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

		public Func<IIdentity, NetworkCredential> UserCredentialsFinder
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HttpListener()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpListener()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool authenticateContext(HttpListenerContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private HttpListenerAsyncResult beginGetContext(AsyncCallback callback, object state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cleanupContextQueue(bool force)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cleanupContextRegistry()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cleanupWaitQueue(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void close(bool force)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string getRealm()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool registerContext(HttpListenerContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private AuthenticationSchemes selectAuthenticationScheme(HttpListenerRequest request)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void CheckDisposed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool RegisterContext(HttpListenerContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void UnregisterContext(HttpListenerContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Abort()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IAsyncResult BeginGetContext(AsyncCallback callback, object state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpListenerContext EndGetContext(IAsyncResult asyncResult)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpListenerContext GetContext()
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IDisposable.Dispose()
		{
			throw null;
		}
	}
}
