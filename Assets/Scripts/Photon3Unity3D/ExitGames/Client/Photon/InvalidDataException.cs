using System;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class InvalidDataException : Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InvalidDataException(string message)
		{

		}
	}
}
