using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	internal static class PhotonCodes
	{
		internal static byte ClientKey;

		internal static byte ModeKey;

		internal static byte ServerKey;

		internal static byte InitEncryption;

		internal static byte Ping;

		public const byte Ok = 0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PhotonCodes()
		{
			throw null;
		}
	}
}
