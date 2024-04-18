using System;
using System.Runtime.CompilerServices;
using POpusCodec.Enums;

namespace POpusCodec
{
	public class OpusException : Exception
	{
		private OpusStatusCode _statusCode;

		public OpusStatusCode StatusCode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpusException(OpusStatusCode statusCode, string message)
		{

		}
	}
}
