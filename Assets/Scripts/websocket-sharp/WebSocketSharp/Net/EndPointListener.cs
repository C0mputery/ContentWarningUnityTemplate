using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace WebSocketSharp.Net
{
	internal sealed class EndPointListener
	{
		private List<HttpListenerPrefix> _all;

		private Dictionary<HttpConnection, HttpConnection> _connections;

		private object _connectionsSync;

		private static readonly string _defaultCertFolderPath;

		private IPEndPoint _endpoint;

		private List<HttpListenerPrefix> _prefixes;

		private bool _secure;

		private Socket _socket;

		private ServerSslConfiguration _sslConfig;

		private List<HttpListenerPrefix> _unhandled;

		public IPAddress Address
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

		public int Port
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		static EndPointListener()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EndPointListener(IPEndPoint endpoint, bool secure, string certificateFolderPath, ServerSslConfiguration sslConfig, bool reuseAddress)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void addSpecial(List<HttpListenerPrefix> prefixes, HttpListenerPrefix prefix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void clearConnections()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static RSACryptoServiceProvider createRSAFromFile(string path)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static X509Certificate2 getCertificate(int port, string folderPath, X509Certificate2 defaultCertificate)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void leaveIfNoPrefix()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void onAccept(IAsyncResult asyncResult)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void processAccepted(Socket socket, EndPointListener listener)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool removeSpecial(List<HttpListenerPrefix> prefixes, HttpListenerPrefix prefix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static HttpListener searchHttpListenerFromSpecial(string path, List<HttpListenerPrefix> prefixes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CertificateExists(int port, string folderPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RemoveConnection(HttpConnection connection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool TrySearchHttpListener(Uri uri, out HttpListener listener)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPrefix(HttpListenerPrefix prefix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePrefix(HttpListenerPrefix prefix)
		{
			throw null;
		}
	}
}
