using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

namespace Photon.Voice.Unity.UtilityScripts
{
	[RequireComponent(typeof(VoiceConnection))]
	public class ConnectAndJoin : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks
	{
		private VoiceConnection voiceConnection;

		public bool RandomRoom;

		[SerializeField]
		private bool autoConnect;

		[SerializeField]
		private bool publishUserId;

		public string RoomName;

		private readonly EnterRoomParams enterRoomParams;

		public bool IsConnected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConnectNow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCreatedRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnJoinedRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLeftRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnConnected()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnConnectedToMaster()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisconnected(DisconnectCause cause)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRegionListReceived(RegionHandler regionHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCustomAuthenticationFailed(string debugMessage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConnectAndJoin()
		{

		}
	}
}
