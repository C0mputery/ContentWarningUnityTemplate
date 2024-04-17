using System;
using System.Runtime.CompilerServices;

namespace Photon.Pun
{
	public class PunRPC : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PunRPC()
		{
			throw null;
		}
	}
}
