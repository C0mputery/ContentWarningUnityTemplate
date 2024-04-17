using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UnityEngine;

namespace Photon.Pun.UtilityScripts
{
	[DisallowMultipleComponent]
	public class PhotonTeamsManager : MonoBehaviour, IMatchmakingCallbacks, IInRoomCallbacks
	{
		[SerializeField]
		private List<PhotonTeam> teamsList;

		private Dictionary<byte, PhotonTeam> teamsByCode;

		private Dictionary<string, PhotonTeam> teamsByName;

		private Dictionary<byte, HashSet<Player>> playersPerTeam;

		public const string TeamPlayerProp = "_pt";

		private static PhotonTeamsManager instance;

		public static PhotonTeamsManager Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static event Action<Player, PhotonTeam> PlayerJoinedTeam
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

		public static event Action<Player, PhotonTeam> PlayerLeftTeam
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
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IMatchmakingCallbacks.OnJoinedRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IMatchmakingCallbacks.OnLeftRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IInRoomCallbacks.OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IInRoomCallbacks.OnPlayerLeftRoom(Player otherPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IInRoomCallbacks.OnPlayerEnteredRoom(Player newPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateTeams()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearTeams()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetTeamByCode(byte code, out PhotonTeam team)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetTeamByName(string teamName, out PhotonTeam team)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTeam[] GetAvailableTeams()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetTeamMembers(byte code, out Player[] members)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetTeamMembers(string teamName, out Player[] members)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetTeamMembers(PhotonTeam team, out Player[] members)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetTeamMatesOfPlayer(Player player, out Player[] teamMates)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetTeamMembersCount(byte code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetTeamMembersCount(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetTeamMembersCount(PhotonTeam team)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IMatchmakingCallbacks.OnFriendListUpdate(List<FriendInfo> friendList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IMatchmakingCallbacks.OnCreatedRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IMatchmakingCallbacks.OnCreateRoomFailed(short returnCode, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IMatchmakingCallbacks.OnJoinRoomFailed(short returnCode, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IMatchmakingCallbacks.OnJoinRandomFailed(short returnCode, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IInRoomCallbacks.OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IInRoomCallbacks.OnMasterClientSwitched(Player newMasterClient)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTeamsManager()
		{
			throw null;
		}
	}
}
