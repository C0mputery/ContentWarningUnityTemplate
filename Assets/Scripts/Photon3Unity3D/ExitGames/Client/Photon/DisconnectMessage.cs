using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class DisconnectMessage
	{
		public short Code;

		public string DebugMessage;

		public Dictionary<byte, object> Parameters;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisconnectMessage()
		{
			throw null;
		}
	}
}
