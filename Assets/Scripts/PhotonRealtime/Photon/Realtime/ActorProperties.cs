using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public class ActorProperties
	{
		public const byte PlayerName = byte.MaxValue;

		public const byte IsInactive = 254;

		public const byte UserId = 253;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActorProperties()
		{
			throw null;
		}
	}
}
