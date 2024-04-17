using System.Runtime.CompilerServices;

namespace Photon.Chat
{
	public class ChannelWellKnownProperties
	{
		public const byte MaxSubscribers = byte.MaxValue;

		public const byte PublishSubscribers = 254;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChannelWellKnownProperties()
		{
			throw null;
		}
	}
}
