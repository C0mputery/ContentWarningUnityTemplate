using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Photon.Chat
{
	public class ChatChannel
	{
		public readonly string Name;

		public readonly List<string> Senders;

		public readonly List<object> Messages;

		public int MessageLimit;

		public int ChannelID;

		private Dictionary<object, object> properties;

		public readonly HashSet<string> Subscribers;

		private Dictionary<string, Dictionary<object, object>> usersProperties;

		public bool IsPrivate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected internal set
			{
				throw null;
			}
		}

		public int MessageCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int LastMsgId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public bool PublishSubscribers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public int MaxSubscribers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannel(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(string sender, object message, int msgId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(string[] senders, object[] messages, int lastMsgId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TruncateMessages()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearMessages()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToStringMessages()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ReadChannelProperties(Dictionary<object, object> newProperties)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool AddSubscribers(string[] users)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool AddSubscriber(string userId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool RemoveSubscriber(string userId)
		{
			throw null;
		}
	}
}
