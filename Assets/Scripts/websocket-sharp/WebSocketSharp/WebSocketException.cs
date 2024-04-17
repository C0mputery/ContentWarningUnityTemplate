using System;
using System.Runtime.CompilerServices;

namespace WebSocketSharp
{
	public class WebSocketException : Exception
	{
		private CloseStatusCode _code;

		public CloseStatusCode Code
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketException()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketException(Exception innerException)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketException(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketException(CloseStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketException(string message, Exception innerException)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketException(CloseStatusCode code, Exception innerException)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketException(CloseStatusCode code, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebSocketException(CloseStatusCode code, string message, Exception innerException)
		{
			throw null;
		}
	}
}
