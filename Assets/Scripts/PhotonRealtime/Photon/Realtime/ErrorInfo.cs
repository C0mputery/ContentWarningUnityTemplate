using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class ErrorInfo
	{
		public readonly string Info;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ErrorInfo(EventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
