using System;
using System.Runtime.CompilerServices;
using Photon.Realtime;

namespace Photon.Pun.UtilityScripts
{
	public static class TeamExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use player.GetPhotonTeam")]
		public static PunTeams.Team GetTeam(this Player player)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use player.JoinTeam")]
		public static void SetTeam(this Player player, PunTeams.Team team)
		{
			throw null;
		}
	}
}
