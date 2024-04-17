using System.Runtime.CompilerServices;

namespace Photon.SocketServer.Security
{
	internal static class OakleyGroups
	{
		public static readonly int Generator;

		public static readonly byte[] OakleyPrime768;

		public static readonly byte[] OakleyPrime1024;

		public static readonly byte[] OakleyPrime1536;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static OakleyGroups()
		{
			throw null;
		}
	}
}
