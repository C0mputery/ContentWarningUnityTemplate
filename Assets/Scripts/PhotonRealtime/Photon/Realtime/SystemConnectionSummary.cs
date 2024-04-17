using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public class SystemConnectionSummary
	{
		private class SCSBitPos
		{
			public const int Version = 28;

			public const int UsedProtocol = 25;

			public const int EmptyBit = 24;

			public const int AppQuits = 23;

			public const int AppPause = 22;

			public const int AppPauseRecent = 21;

			public const int AppOutOfFocus = 20;

			public const int AppOutOfFocusRecent = 19;

			public const int NetworkReachable = 18;

			public const int ErrorCodeFits = 17;

			public const int ErrorCodeWinSock = 16;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SCSBitPos()
			{
				throw null;
			}
		}

		public readonly byte Version;

		public byte UsedProtocol;

		public bool AppQuits;

		public bool AppPause;

		public bool AppPauseRecent;

		public bool AppOutOfFocus;

		public bool AppOutOfFocusRecent;

		public bool NetworkReachable;

		public bool ErrorCodeFits;

		public bool ErrorCodeWinSock;

		public int SocketErrorCode;

		private static readonly string[] ProtocolIdToName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SystemConnectionSummary(LoadBalancingClient client)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SystemConnectionSummary(int summary)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int ToInt()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetBit(ref int value, int bitpos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte GetBits(ref int value, int bitpos, byte mask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetBit(ref int value, bool bitval, int bitpos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetBits(ref int value, byte bitvals, int bitpos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SystemConnectionSummary()
		{
			throw null;
		}
	}
}
