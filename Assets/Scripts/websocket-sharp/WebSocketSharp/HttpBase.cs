using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;

namespace WebSocketSharp
{
	internal abstract class HttpBase
	{
		private NameValueCollection _headers;

		private const int _headersMaxLength = 8192;

		private Version _version;

		internal byte[] EntityBodyData;

		protected const string CrLf = "\r\n";

		public string EntityBody
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public NameValueCollection Headers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Version ProtocolVersion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected HttpBase(Version version, NameValueCollection headers)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] readEntityBody(Stream stream, string length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string[] readHeaders(Stream stream, int maxLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static T Read<T>(Stream stream, Func<string[], T> parser, int millisecondsTimeout) where T : HttpBase
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] ToByteArray()
		{
			throw null;
		}
	}
}
