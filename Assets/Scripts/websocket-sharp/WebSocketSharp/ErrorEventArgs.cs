using System;
using System.Runtime.CompilerServices;

namespace WebSocketSharp
{
	public class ErrorEventArgs : EventArgs
	{
		private Exception _exception;

		private string _message;

		public Exception Exception
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Message
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ErrorEventArgs(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ErrorEventArgs(string message, Exception exception)
		{
			throw null;
		}
	}
}
