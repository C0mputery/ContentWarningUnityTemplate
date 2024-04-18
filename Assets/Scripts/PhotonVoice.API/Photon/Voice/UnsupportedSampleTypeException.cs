using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	internal class UnsupportedSampleTypeException : Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnsupportedSampleTypeException(Type t)
		{

		}
	}
}
