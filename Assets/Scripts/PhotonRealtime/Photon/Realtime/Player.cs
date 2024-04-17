using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class Player
	{
		private int actorNumber;

		public readonly bool IsLocal;

		private string nickName;

		public object TagObject;

		protected internal Room RoomReference
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

		public int ActorNumber
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool HasRejoined
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public string NickName
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

		public string UserId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public bool IsMasterClient
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsInactive
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

		public Hashtable CustomProperties
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
		protected internal Player(string nickName, int actorNumber, bool isLocal)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal Player(string nickName, int actorNumber, bool isLocal, Hashtable playerProperties)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Player Get(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Player GetNext()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Player GetNextFor(Player currentPlayer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Player GetNextFor(int currentPlayerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal virtual void InternalCacheProperties(Hashtable properties)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToStringFull()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object p)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void ChangeLocalID(int newID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues = null, WebFlags webFlags = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SetPlayerNameProperty()
		{
			throw null;
		}
	}
}
