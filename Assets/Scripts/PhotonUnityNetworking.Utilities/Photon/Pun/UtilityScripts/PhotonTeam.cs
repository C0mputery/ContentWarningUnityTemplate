using System;
using System.Runtime.CompilerServices;

namespace Photon.Pun.UtilityScripts
{
	[Serializable]
	public class PhotonTeam
	{
		public string Name;

		public byte Code;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTeam()
		{
			throw null;
		}
	}
}
