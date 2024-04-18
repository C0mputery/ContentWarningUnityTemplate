using System;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	internal class PreserveAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PreserveAttribute()
		{

		}
	}
}
