using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class UnknownType
	{
		public byte TypeCode;

		public int Size;

		public byte[] Data;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnknownType()
		{
			throw null;
		}
	}
}
