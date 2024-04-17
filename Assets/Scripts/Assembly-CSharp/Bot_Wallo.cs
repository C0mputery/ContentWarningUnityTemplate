using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Bot_Wallo : MonoBehaviour
{
	public enum WalloState
	{
		Hiding = 0,
		Reaching = 1,
		Dragging = 2,
		Stealing = 3
	}

	private WallWarpArm[] arms;

	private Bot bot;

	private Vector3 savePoint;

	private Vector3 saveNormal;

	public Animator animator;

	private float sinceSeenPlayer;

	private float hasPlayerFor;

	private PhotonView view;

	private bool intendToTPAway;

	private float intentToTPAwayFor;

	public WalloState walloState;

	private float stealFor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetState(WalloState setState)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoSteal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FinishSteal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStartStealing()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DragPlayerIn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Reaching()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetToIdle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Idle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerStay(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GoToRandomPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CompleteGotoPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EvalPoint(Vector3 point)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EvalPointInDirection(Vector3 point, Vector3 dir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AdditionalEval(Vector3 point, Vector3 dir, float ogDistance)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GoToFailedPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bot_Wallo()
	{
		throw null;
	}
}
