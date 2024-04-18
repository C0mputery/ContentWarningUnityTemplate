using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace WebSocketSharp.Net
{
	[Serializable]
	public class HttpListenerException : Win32Exception
	{
		public override int ErrorCode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpListenerException()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpListenerException(int errorCode)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpListenerException(int errorCode, string message)
		{

		}
	}
}
