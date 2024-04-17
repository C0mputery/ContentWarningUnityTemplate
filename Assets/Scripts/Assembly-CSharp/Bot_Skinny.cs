using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class Bot_Skinny : MonoBehaviour
{
	public UnityEvent turnBlackEvent;

	public float untilNextSwitch;

	public bool nextWillBeFull;

	private float inDimentionFor;

	public bool isInDimention;

	private float attackingFor;

	private float dieCounter;

	public Light light;

	public Volume post;

	public Volume post_death;

	public Dictionary<Player, ParticleSystem> targetPlayers;

	public Transform eyePos;

	private PhotonView view;

	private Player player;

	private Bot bot;

	private bool attacking;

	public ParticleSystem part;

	public bool fullyInDimention;

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
	private void Patrol()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DimentionSwitching()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void SetSwitchData(bool setNextWillBeSwitch, float setUntilNext)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void DoSwitch(int switches, bool endUpInDimention)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnterDimentionFully()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExitDimentionFully()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_ExitDimentionFully()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetInDimetion(bool setInDimention)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearTargets()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConfigPost()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Combat()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Stare()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_StopAttacking()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void RPCA_StartAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetAttackingLocal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoAttackingLocal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryAttackPlayer(Player p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FailToAttackPlayer(Player p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AttackPlayer(Player p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bot_Skinny()
	{
		throw null;
	}
}
