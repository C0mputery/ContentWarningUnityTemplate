using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class SerializationAbortException : Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializationAbortException(string message)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializationAbortException(string message, Exception innerException)
		{

		}
	}
}
