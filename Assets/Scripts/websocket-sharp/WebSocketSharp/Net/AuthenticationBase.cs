using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net
{
	internal abstract class AuthenticationBase
	{
		private AuthenticationSchemes _scheme;

		internal NameValueCollection Parameters;

		public string Algorithm
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Nonce
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Opaque
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Qop
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
		}

		public AuthenticationSchemes Scheme
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected AuthenticationBase(AuthenticationSchemes scheme, NameValueCollection parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string CreateNonceValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NameValueCollection ParseParameters(string value)
		{
			throw null;
		}

		internal abstract string ToBasicString();

		internal abstract string ToDigestString();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
