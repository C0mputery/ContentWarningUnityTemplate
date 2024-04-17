using System;
using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public class RaiseEventOptions
	{
		public static readonly RaiseEventOptions Default;

		public EventCaching CachingOption;

		public byte InterestGroup;

		public int[] TargetActors;

		public ReceiverGroup Receivers;

		[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
		public byte SequenceChannel;

		public WebFlags Flags;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RaiseEventOptions()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RaiseEventOptions()
		{
			throw null;
		}
	}
}
