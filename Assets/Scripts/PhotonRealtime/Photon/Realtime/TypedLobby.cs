using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public class TypedLobby
	{
		public string Name;

		public LobbyType Type;

		public static readonly TypedLobby Default;

		public bool IsDefault
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TypedLobby()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypedLobby(string name, LobbyType type)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypedLobby()
		{
			throw null;
		}
	}
}
