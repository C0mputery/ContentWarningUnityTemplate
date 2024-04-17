using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public class TypedLobbyInfo : TypedLobby
	{
		public int PlayerCount;

		public int RoomCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypedLobbyInfo()
		{
			throw null;
		}
	}
}
