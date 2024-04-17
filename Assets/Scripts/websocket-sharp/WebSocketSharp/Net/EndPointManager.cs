using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net
{
	internal sealed class EndPointManager
	{
		private static readonly Dictionary<IPEndPoint, EndPointListener> _endpoints;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static EndPointManager()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private EndPointManager()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void addPrefix(string uriPrefix, HttpListener listener)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IPAddress convertToIPAddress(string hostname)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void removePrefix(string uriPrefix, HttpListener listener)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RemoveEndPoint(IPEndPoint endpoint)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddListener(HttpListener listener)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddPrefix(string uriPrefix, HttpListener listener)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveListener(HttpListener listener)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemovePrefix(string uriPrefix, HttpListener listener)
		{
			throw null;
		}
	}
}
