using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;

namespace Photon.Voice
{
	public class LoadBalancingTransport : LoadBalancingClient, IVoiceTransport, ILogger, IDisposable
	{
		internal const int REMOTE_VOICE_CHANNEL = 0;

		protected VoiceClient voiceClient;

		private PhotonTransportProtocol protocol;

		protected readonly bool cppCompatibilityMode;

		public VoiceClient VoiceClient
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected virtual byte FrameCode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int GetPayloadFragmentSize(SendFrameParams par)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogError(string fmt, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogWarning(string fmt, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogInfo(string fmt, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogDebug(string fmt, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsChannelJoined(int channelId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoadBalancingTransport(ILogger logger = null, ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp, bool cppCompatibilityMode = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void Service()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use LoadBalancingPeer::OpChangeGroups().")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private RaiseEventOptions buildEvOptFromTargets(bool targetMe, int[] targetPlayers)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendVoiceInfo(LocalVoice voice, int channelId, bool targetMe, int[] targetPlayers)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendVoiceRemove(LocalVoice voice, int channelId, bool targetMe, int[] targetPlayers)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual object buildFrameMessage(byte voiceId, byte evNumber, byte frNumber, ArraySegment<byte> data, FrameFlags flags)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendFrame(ArraySegment<byte> data, FrameFlags flags, byte evNumber, byte frNumber, byte voiceId, int channelId, SendFrameParams par)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ChannelIdStr(int channelId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string PlayerIdStr(int playerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void onEventActionVoiceClient(EventData ev)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void onStateChangeVoiceClient(ClientState fromState, ClientState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}
	}
}
