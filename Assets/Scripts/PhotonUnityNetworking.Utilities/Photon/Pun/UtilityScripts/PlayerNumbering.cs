using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;

namespace Photon.Pun.UtilityScripts
{
	public class PlayerNumbering : MonoBehaviourPunCallbacks
	{
		public delegate void PlayerNumberingChanged();

		public static PlayerNumbering instance;

		public static Player[] SortedPlayers;

		public const string RoomPlayerIndexedProp = "pNr";

		public bool dontDestroyOnLoad;

		public static event PlayerNumberingChanged OnPlayerNumberingChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnJoinedRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnLeftRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerEnteredRoom(Player newPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerLeftRoom(Player otherPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerNumbering()
		{

		}
	}
}
