using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;

namespace WebSocketSharp.Net
{
	internal static class HttpUtility
	{
		private static Dictionary<string, char> _entities;

		private static char[] _hexChars;

		private static object _sync;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HttpUtility()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Dictionary<string, char> getEntities()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int getNumber(char c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int getNumber(byte[] bytes, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int getNumber(string s, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string htmlDecode(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string htmlEncode(string s, bool minimal)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void initEntities()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isAlphabet(char c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isNumeric(char c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isUnreserved(char c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isUnreservedInRfc2396(char c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isUnreservedInRfc3986(char c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] urlDecodeToBytes(byte[] bytes, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void urlEncode(byte b, Stream output)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] urlEncodeToBytes(byte[] bytes, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Uri CreateRequestUrl(string requestUri, string host, bool websocketRequest, bool secure)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IPrincipal CreateUser(string response, AuthenticationSchemes scheme, string realm, string method, Func<IIdentity, NetworkCredential> credentialsFinder)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Encoding GetEncoding(string contentType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TryGetEncoding(string contentType, out Encoding result)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string HtmlAttributeEncode(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HtmlAttributeEncode(string s, TextWriter output)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string HtmlDecode(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HtmlDecode(string s, TextWriter output)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string HtmlEncode(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HtmlEncode(string s, TextWriter output)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlDecode(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlDecode(byte[] bytes, Encoding encoding)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlDecode(string s, Encoding encoding)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlDecode(byte[] bytes, int offset, int count, Encoding encoding)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] UrlDecodeToBytes(byte[] bytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] UrlDecodeToBytes(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] UrlDecodeToBytes(byte[] bytes, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlEncode(byte[] bytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlEncode(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlEncode(string s, Encoding encoding)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlEncode(byte[] bytes, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] UrlEncodeToBytes(byte[] bytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] UrlEncodeToBytes(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] UrlEncodeToBytes(string s, Encoding encoding)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count)
		{
			throw null;
		}
	}
}
