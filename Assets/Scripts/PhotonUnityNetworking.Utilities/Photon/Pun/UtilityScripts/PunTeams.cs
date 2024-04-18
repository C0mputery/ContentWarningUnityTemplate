using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;

namespace Photon.Pun.UtilityScripts
{
	[Obsolete("do not use this or add it to the scene. use PhotonTeamsManager instead")]
	public class PunTeams : MonoBehaviourPunCallbacks
	{
		[Obsolete("use custom PhotonTeam instead")]
		public enum Team : byte
		{
			none = 0,
			red = 1,
			blue = 2
		}

		[Obsolete("use PhotonTeamsManager.Instance.TryGetTeamMembers instead")]
		public static Dictionary<Team, List<Player>> PlayersPerTeam;

		[Obsolete("do not use this. PhotonTeamsManager.TeamPlayerProp is used internally instead.")]
		public const string TeamPlayerProp = "team";

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDisable()
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
		public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerLeftRoom(Player otherPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPlayerEnteredRoom(Player newPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("do not call this.")]
		public void UpdateTeams()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PunTeams()
		{

		}
	}
}
