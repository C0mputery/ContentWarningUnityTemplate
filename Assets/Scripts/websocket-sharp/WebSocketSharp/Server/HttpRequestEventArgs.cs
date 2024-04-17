using System;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using WebSocketSharp.Net;

namespace WebSocketSharp.Server
{
	public class HttpRequestEventArgs : EventArgs
	{
		private HttpListenerContext _context;

		private string _docRootPath;

		public HttpListenerRequest Request
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public HttpListenerResponse Response
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IPrincipal User
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HttpRequestEventArgs(HttpListenerContext context, string documentRootPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string createFilePath(string childPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool tryReadFile(string path, out byte[] contents)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] ReadFile(string path)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryReadFile(string path, out byte[] contents)
		{
			throw null;
		}
	}
}
