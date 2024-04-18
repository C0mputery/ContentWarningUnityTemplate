using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Voice.Unity;
using UnityEngine;
using Zorro.Core.CLI;

public class SurfaceNetworkHandler : MonoBehaviourPunCallbacks
{
	[CompilerGenerated]
	private sealed class _003CFailCoroutine_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SurfaceNetworkHandler _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CFailCoroutine_003Ed__70(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	[SerializeField]
	private PickupSpawner m_VideoCameraSpawner;

	public bool firstDay;

	private const int DAYS_PER_QUOTA = 3;

	private SteamLobbyHandler m_SteamLobby;

	private static bool m_Started;

	private bool m_HeadingToUnderWorld;

	private Action<RoomStatsHolder> m_OnStatsChangedAction;

	private PhotonView m_View;

	private VoiceConnection m_VoiceConnection;

	private static ICollection<Player> PlayersAliveFromUnderWorld;

	private bool m_RequestedSleep;

	private Action m_OnSleepAction;

	private bool m_FailedQuota;

	public static SurfaceNetworkHandler Instance
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

	public static bool HasStarted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public static bool ReturningFromLostWorld
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

	public static bool ReturnedFromLostWorldWithCamera
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

	public static bool ReadyForSleep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public static RoomStatsHolder RoomStats
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

	public ShopHandler ShopHandler
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

	public static int NumberOfPlayersAliveFromUnderWorld
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
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
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSurface()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckForHospitalBill()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendHospitalBill(List<(int, int)> hospitalBill)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_HospitalBill(int actorNumber, int moneyToRemove)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnSurfacePickups()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckSave()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadSave()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPlayersAliveFromUnderworld(ICollection<Player> playersInside)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReturnFromLostWorld()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetReturningFromLostWorld()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetSurface()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnJoinedRoom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckForSleep()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckForMasterClientCommands()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NextDay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnMoneyAdd(int moneyAdded)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnMoneySubtract(int moneySubtracted)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RequestSleep()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_Sleep()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnSlept()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCM_StartGame()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_OpenDoor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PreCheckHeadToUnderWorld()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckIfCameraIsPresent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FailedQuota()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_HelmetText(int messageLocaleKey, int daysLeft)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_QuotaFailed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CFailCoroutine_003Ed__70))]
	private IEnumerator FailCoroutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddOnStatsUpdateCallBack(Action<RoomStatsHolder> onQuotaUpdate)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddOnSleepCallBack(Action onSleep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPC_LoadScene(string level)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void SetCurrentRun(int run)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void SetCurrentDay(int day)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void UnlockExtractor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void AddQuota(int quota)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestStartGame()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SurfaceNetworkHandler()
	{

	}
}
