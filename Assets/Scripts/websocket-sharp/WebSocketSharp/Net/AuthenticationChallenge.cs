using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net
{
	internal class AuthenticationChallenge : AuthenticationBase
	{
		public string Domain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Stale
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private AuthenticationChallenge(AuthenticationSchemes scheme, NameValueCollection parameters) : base(scheme, parameters)
		{
			throw null;
		}

		/*[MethodImpl(MethodImplOptions.NoInlining)]
		internal AuthenticationChallenge(AuthenticationSchemes scheme, string realm)
		{
            throw null;
        }*/

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AuthenticationChallenge CreateBasicChallenge(string realm)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AuthenticationChallenge CreateDigestChallenge(string realm)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AuthenticationChallenge Parse(string value)
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
	}
}
