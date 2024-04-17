using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace WebSocketSharp.Net
{
	internal class AuthenticationResponse : AuthenticationBase
	{
		private uint _nonceCount;

        public AuthenticationResponse(AuthenticationSchemes scheme, NameValueCollection parameters) : base(scheme, parameters)
        {
			throw null;
        }

        internal uint NonceCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Cnonce
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Nc
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Password
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Response
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Uri
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string UserName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		/*[MethodImpl(MethodImplOptions.NoInlining)]
		private AuthenticationResponse(AuthenticationSchemes scheme, NameValueCollection parameters) 
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal AuthenticationResponse(NetworkCredential credentials)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal AuthenticationResponse(AuthenticationChallenge challenge, NetworkCredential credentials, uint nonceCount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal AuthenticationResponse(AuthenticationSchemes scheme, NameValueCollection parameters, NetworkCredential credentials, uint nonceCount)
		{
			throw null;
		}*/

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string createA1(string username, string password, string realm)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string createA1(string username, string password, string realm, string nonce, string cnonce)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string createA2(string method, string uri)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string createA2(string method, string uri, string entity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string hash(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void initAsDigest()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string CreateRequestDigest(NameValueCollection parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AuthenticationResponse Parse(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NameValueCollection ParseBasicCredentials(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override string ToBasicString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override string ToDigestString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IIdentity ToIdentity()
		{
			throw null;
		}
	}
}
