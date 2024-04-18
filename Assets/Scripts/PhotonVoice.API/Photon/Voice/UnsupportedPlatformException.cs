using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	internal class UnsupportedPlatformException : Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnsupportedPlatformException(string subject, string platform = null)
		{

		}
	}
}
