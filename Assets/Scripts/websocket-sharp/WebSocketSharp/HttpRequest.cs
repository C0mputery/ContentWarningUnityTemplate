using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	internal class HttpRequest : HttpBase
	{
		private CookieCollection _cookies;

		private string _method;

		private string _uri;

		public AuthenticationResponse AuthenticationResponse
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public CookieCollection Cookies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string HttpMethod
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsWebSocketRequest
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string RequestUri
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private HttpRequest(string method, string uri, Version version, NameValueCollection headers) : base(version, headers)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HttpRequest(string method, string uri) : this(method, uri, HttpVersion.Version11, new NameValueCollection())
		{
			throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpRequest CreateConnectRequest(Uri uri)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpRequest CreateWebSocketRequest(Uri uri)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HttpResponse GetResponse(Stream stream, int millisecondsTimeout)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpRequest Parse(string[] headerParts)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpRequest Read(Stream stream, int millisecondsTimeout)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCookies(CookieCollection cookies)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
