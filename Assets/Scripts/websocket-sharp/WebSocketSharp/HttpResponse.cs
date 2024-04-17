using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	internal class HttpResponse : HttpBase
	{
		private string _code;

		private string _reason;

		public CookieCollection Cookies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool HasConnectionClose
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsProxyAuthenticationRequired
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsRedirect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsUnauthorized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsWebSocketResponse
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string StatusCode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private HttpResponse(string code, string reason, Version version, NameValueCollection headers) : base(version, headers)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HttpResponse(HttpStatusCode code) : this(code, code.GetDescription())
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HttpResponse(HttpStatusCode code, string reason) : this(((int)code).ToString(), reason, HttpVersion.Version11, new NameValueCollection())
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpResponse CreateCloseResponse(HttpStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpResponse CreateUnauthorizedResponse(string challenge)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpResponse CreateWebSocketResponse()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpResponse Parse(string[] headerParts)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpResponse Read(Stream stream, int millisecondsTimeout)
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
