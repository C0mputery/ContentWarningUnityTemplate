using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public struct SendOptions
	{
		public static readonly SendOptions SendReliable;

		public static readonly SendOptions SendUnreliable;

		public DeliveryMode DeliveryMode;

		public bool Encrypt;

		public byte Channel;

		public bool Reliability
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SendOptions()
		{
			throw null;
		}
	}
}
