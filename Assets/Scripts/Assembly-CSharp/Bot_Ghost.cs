using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Bot_Ghost : MonoBehaviour
{
	public Material defaultMat;

	public Material frenzyMat;

	private SkinnedMeshRenderer skinnedMeshRenderer;

	public Player frenzyTarget;

	public Hazard targetHazard;

	private MonsterAnimationHandler monsterAnimationHandler;

	private PhotonView view;

	private Player player;

	private Bot bot;

	private float sinceDrop;

	private float exhaustion;

	private float sinceConnect;

	private float sinceFrenzyStart;

	private float hoverScale;

	private float sideMove;

	private float blindedValue;

	private bool hurt;

	private bool fleeing;

	private float sinceStartFlee;

	private bool displayFrensy;

	private Joint rJoint;

	private Joint lJoint;

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
	private void HandleBlinding()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HauntPlayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartFlee()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallOutFrenzy(Player targetPlayer, Hazard setHazard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartFrenzy(Player targetPlayer, Hazard setHazard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FrenzyAI()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetVariables()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateVariables()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_DisplayBlinded(bool setTrue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_DisplayFrenzy(bool setTrue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Pull(Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_Drop()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryToGrabPlayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryConnectRight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryConnectLeft()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_ConnectJoint(int targetID, bool rightHand)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetIK()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoReachIK()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bot_Ghost()
	{
		throw null;
	}
}
