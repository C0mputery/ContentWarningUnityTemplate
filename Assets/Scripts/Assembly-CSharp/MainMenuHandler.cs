using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using Steamworks;
using Zorro.Core;

public class MainMenuHandler : MonoBehaviourPunCallbacks
{
	[CompilerGenerated]
	private sealed class _003CCheckConnected_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenuHandler _003C_003E4__this;

		private MainMenuLoadingPage _003Cpage_003E5__2;

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
		public _003CCheckConnected_003Ed__13(int _003C_003E1__state)
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

	public MainMenuUIHandler UIHandler;

	private const int MAX_PLAYERS = 4;

	private const string GAME_SCENE = "SurfaceScene";

	private static MainMenuHandler _instance;

	private HAuthTicket hAuthTicket;

	private bool m_Hosting;

	private bool m_Connecting;

	private static bool m_CheckedSteamCMD;

	public static MainMenuHandler Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public static SteamLobbyHandler SteamLobbyHandler
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
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CCheckConnected_003Ed__13))]
	private IEnumerator CheckConnected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetPrettyStateName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConnectToPhoton(BuildVersion version)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPhotonName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnJoinedSteamLobby(string region, string room, bool forceRegion)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadGameScene()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Host(int saveIndex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SilentHost()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void JoinRandom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreatedRoom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreateRoomFailed(short returnCode, string message)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnSteamHosted(ulong obj)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnConnectedToMaster()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckSteamCMD()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCustomAuthenticationFailed(string errorMessage)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSteamAuthTicket(out HAuthTicket ticket)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CancelAuthTicket(HAuthTicket ticket)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainMenuHandler()
	{

	}
}
