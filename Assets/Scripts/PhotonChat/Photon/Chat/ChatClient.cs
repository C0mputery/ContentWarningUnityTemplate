using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Chat
{
	public class ChatClient : IPhotonPeerListener
	{
		private const int FriendRequestListMax = 1024;

		public const int DefaultMaxSubscribers = 100;

		private const byte HttpForwardWebFlag = 1;

		private string chatRegion;

		public string ProxyServerAddress;

		public int MessageLimit;

		public int PrivateChatHistoryLength;

		public readonly Dictionary<string, ChatChannel> PublicChannels;

		public readonly Dictionary<string, ChatChannel> PrivateChannels;

		private readonly HashSet<string> PublicChannelsUnsubscribing;

		private readonly IChatClientListener listener;

		public ChatPeer chatPeer;

		private const string ChatAppName = "chat";

		private bool didAuthenticate;

		private int? statusToSetWhenConnected;

		private object messageToSetWhenConnected;

		private int msDeltaForServiceCalls;

		private int msTimestampOfLastServiceCall;

		public bool EnableProtocolFallback
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string NameServerAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public string FrontendAddress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public string ChatRegion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public ChatState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public ChatDisconnectCause DisconnectedCause
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public bool CanChat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private bool HasPeer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string AppVersion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public string AppId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public AuthenticationValues AuthValues
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string UserId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		public bool UseBackgroundWorkerForSending
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public ConnectionProtocol TransportProtocol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public DebugLevel DebugOut
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanChatInChannel(string channelName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatClient(IChatClientListener listener, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ConnectUsingSettings(ChatAppSettings appSettings)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Connect(string appId, string appVersion, AuthenticationValues authValues)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ConnectAndSetStatus(string appId, string appVersion, AuthenticationValues authValues, int status = 2, object message = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Service()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SendOutgoingInBackground()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Better use UseBackgroundWorkerForSending and Service().")]
		public void SendAcksOnly()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disconnect(ChatDisconnectCause cause = ChatDisconnectCause.DisconnectByClientLogic)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopThread()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Subscribe(string[] channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Subscribe(string[] channels, int[] lastMsgIds)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Subscribe(string[] channels, int messagesFromHistory)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Unsubscribe(string[] channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PublishMessage(string channelName, object message, bool forwardAsWebhook = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool PublishMessageUnreliable(string channelName, object message, bool forwardAsWebhook = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool publishMessage(string channelName, object message, bool reliable, bool forwardAsWebhook = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SendPrivateMessage(string target, object message, bool forwardAsWebhook = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SendPrivateMessage(string target, object message, bool encrypt, bool forwardAsWebhook)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool SendPrivateMessageUnreliable(string target, object message, bool encrypt, bool forwardAsWebhook = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool sendPrivateMessage(string target, object message, bool encrypt, bool reliable, bool forwardAsWebhook = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SetOnlineStatus(int status, object message, bool skipMessage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetOnlineStatus(int status)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetOnlineStatus(int status, object message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AddFriends(string[] friends)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RemoveFriends(string[] friends)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetPrivateChannelNameByUser(string userName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetChannel(string channelName, bool isPrivate, out ChatChannel channel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetChannel(string channelName, out ChatChannel channel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetPrivateChannelByUser(string userId, out ChatChannel channel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPhotonPeerListener.DebugReturn(DebugLevel level, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPhotonPeerListener.OnEvent(EventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPhotonPeerListener.OnOperationResponse(OperationResponse operationResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPhotonPeerListener.OnStatusChanged(StatusCode statusCode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TryAuthenticateOnNameServer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SendChannelOperation(string[] channels, byte operation, int historyLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandlePrivateMessageEvent(EventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleChatMessagesEvent(EventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleSubscribeEvent(EventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleUnsubscribeEvent(EventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleAuthResponse(OperationResponse operationResponse)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleStatusUpdate(EventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ConnectToFrontEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool AuthenticateOnFrontEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleUserUnsubscribedEvent(EventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleUserSubscribedEvent(EventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Subscribe(string channel, int lastMsgId = 0, int messagesFromHistory = -1, ChannelCreationOptions creationOptions = null)
		{
			throw null;
		}
	}
}
