using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;
using UnityEngine.UI;

namespace Photon.Chat.Demo
{
	public class ChatGui : MonoBehaviour, IChatClientListener
	{
		public string[] ChannelsToJoinOnConnect;

		public string[] FriendsList;

		public int HistoryLengthToFetch;

		private string selectedChannelName;

		public ChatClient chatClient;

		protected internal ChatAppSettings chatAppSettings;

		public GameObject missingAppIdErrorPanel;

		public GameObject ConnectingLabel;

		public RectTransform ChatPanel;

		public GameObject UserIdFormPanel;

		public InputField InputFieldChat;

		public Text CurrentChannelText;

		public Toggle ChannelToggleToInstantiate;

		public GameObject FriendListUiItemtoInstantiate;

		private readonly Dictionary<string, Toggle> channelToggles;

		private readonly Dictionary<string, FriendItem> friendListItemLUT;

		public bool ShowState;

		public GameObject Title;

		public Text StateText;

		public Text UserIdText;

		private static string HelpText;

		public int TestLength;

		private byte[] testBytes;

		public string UserName
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Connect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnApplicationQuit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterSend()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSend()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendChatMessage(string inputLine)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PostHelpToCurrentChannel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DebugReturn(DebugLevel level, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnConnected()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisconnected()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChatStateChange(ChatState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubscribed(string[] channels, bool[] results)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubscribed(string channel, string[] users, Dictionary<object, object> properties)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InstantiateChannelButton(string channelName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InstantiateFriendButton(string friendId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUnsubscribed(string[] channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnGetMessages(string channelName, string[] senders, object[] messages)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPrivateMessage(string sender, object message, string channelName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUserSubscribed(string channel, string user)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUserUnsubscribed(string channel, string user)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChannelPropertiesChanged(string channel, string userId, Dictionary<object, object> properties)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUserPropertiesChanged(string channel, string targetUserId, string senderUserId, Dictionary<object, object> properties)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnErrorInfo(string channel, string error, object data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddMessageToSelectedChannel(string msg)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowChannel(string channelName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenDashboard()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatGui()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChatGui()
		{
			throw null;
		}
	}
}
