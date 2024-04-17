using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class RoomInfo
	{
		public bool RemovedFromList;

		private Hashtable customProperties;

		protected int maxPlayers;

		protected int emptyRoomTtl;

		protected int playerTtl;

		protected string[] expectedUsers;

		protected bool isOpen;

		protected bool isVisible;

		protected bool autoCleanUp;

		protected string name;

		public int masterClientId;

		protected string[] propertiesListedInLobby;

		public Hashtable CustomProperties
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int PlayerCount
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

		public int MaxPlayers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsOpen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsVisible
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
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
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
			throw null;
		}
	}
}
