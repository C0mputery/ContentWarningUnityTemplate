using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using Photon.Voice.Unity;

namespace Photon.Voice
{
	public abstract class VoiceFollowClient : VoiceConnection
	{
		public bool AutoConnectAndJoin;

		private EnterRoomParams voiceRoomParams;

		private bool manualDisconnect;

		private bool errAuthOrJoin;

		protected abstract bool LeaderInRoom { get; }

		protected abstract bool LeaderOfflineMode { get; }

		protected abstract string GetVoiceRoomName();

		protected abstract bool ConnectVoice();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ConnectAndJoinRoom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disconnect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnOperationResponseReceived(OperationResponse operationResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void LeaderStateChanged(ClientState toState)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnVoiceStateChanged(ClientState fromState, ClientState toState)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConnectOrJoinVoice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool JoinVoiceRoom(string voiceRoomName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FollowLeader(ClientState toState)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FollowLeader()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected VoiceFollowClient()
		{
			throw null;
		}
	}
}
