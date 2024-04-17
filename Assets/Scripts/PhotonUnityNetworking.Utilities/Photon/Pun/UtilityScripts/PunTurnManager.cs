using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;

namespace Photon.Pun.UtilityScripts
{
	public class PunTurnManager : MonoBehaviourPunCallbacks, IOnEventCallback
	{
		private Player sender;

		public float TurnDuration;

		public IPunTurnManagerCallbacks TurnManagerListener;

		private readonly HashSet<Player> finishedPlayers;

		public const byte TurnManagerEventOffset = 0;

		public const byte EvMove = 1;

		public const byte EvFinalMove = 2;

		private bool _isOverCallProcessed;

		public int Turn
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

		public float ElapsedTimeInTurn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float RemainingSecondsInTurn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsCompletedByAll
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsFinishedByMe
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsOver
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
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BeginTurn()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendMove(object move, bool finished)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetPlayerFinishedTurn(Player player)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ProcessOnEvent(byte eventCode, object content, int senderId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEvent(EventData photonEvent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PunTurnManager()
		{
			throw null;
		}
	}
}
