using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class SerializationAbortException : Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializationAbortException(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializationAbortException(string message, Exception innerException)
		{
			throw null;
		}
	}
}
