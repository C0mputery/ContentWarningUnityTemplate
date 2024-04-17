using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	internal class UnsupportedCodecException : Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnsupportedCodecException(string info, Codec codec)
		{
			throw null;
		}
	}
}
