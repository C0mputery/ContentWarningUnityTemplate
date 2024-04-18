using System.Runtime.CompilerServices;
using DefaultNamespace;
using Photon.Pun;
using UnityEngine;

public class Bot_Weeping : MonoBehaviour
{
	public float deAgrroDistance;

	public float turnSpeed;

	public float captureDistance;

	public float timeUntilKillBecauseCaptchaNotStarted;

	public float superCloseAggroRange;

	public Transform rayPoint;

	public Player capturedPlayer;

	public CaptchaGame captchaGame;

	public Player playerInCaptchaGame;

	public Bot bot;

	public CapturedCaptchaCanvas capturedCanvas;

	public float timeSinceCapture;

	public bool captchaGameFinished;

	[HideInInspector]
	public bool debugCapturePlayerOverride;

	public GameObject frontBlocker;

	public bool captchaGameFailed;

	private bool captchaStarted;

	private float timeWaitedToStartCaptcha;

	private PhotonView view;

	private bool readyToBeRemoved;

	private float timeSpentBeingReadyToBeRemoved;

	public bool HasCapturedPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool HasPlayerInCaptchaGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private Vector3 CapturePoint
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
	public WeepingContentProvider.WEEPING_CONTENT_STATE GetContentState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_RelasePlayerAndRestartCaptchaThings()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayerInteracted(PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCM_PlayerJoinsCaptchaGame(int playerViewId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CaptchaUpdateForEveryone()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_InputCharToCaptcha(string input)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryCapturePlayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_CapturePlayer(int playerId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DebugCapturePlayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnToDirectionWithSpace()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunCaptchaGame()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_CaptchaGameFailed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_CaptchaGameSuccess()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_JoinCaptchaGame(int playerID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_LeaveCaptchaGame()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AnyoneLookingAtMe(out Player firstPlayerLookingAtMe)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TargetSomeoneIfTheyAreReallyCloseToMe()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bot_Weeping()
	{

	}
}
