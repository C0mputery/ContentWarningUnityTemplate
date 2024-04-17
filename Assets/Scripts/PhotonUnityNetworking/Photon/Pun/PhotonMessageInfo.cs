using System;
using System.Runtime.CompilerServices;
using Photon.Realtime;

namespace Photon.Pun
{
	public struct PhotonMessageInfo
	{
		private readonly int timeInt;

		public readonly Player Sender;

		public readonly PhotonView photonView;

		[Obsolete("Use SentServerTime instead.")]
		public double timestamp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public double SentServerTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int SentServerTimestamp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonMessageInfo(Player player, int timestamp, PhotonView view)
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
