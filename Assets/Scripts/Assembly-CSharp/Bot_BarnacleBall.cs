using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class Bot_BarnacleBall : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIIgnorePlayer_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Bot_BarnacleBall _003C_003E4__this;

		public Player p;

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
		public _003CIIgnorePlayer_003Ed__22(int _003C_003E1__state)
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

	private Player player;

	private Bot bot;

	private PhotonView view;

	private float attackCounter;

	private float suckAttackFor;

	private float suckAttackCooldown;

	private SuckTrigger trigger;

	private ParticleSystem part;

	private List<Player> ignoredPlayers;

	private bool punch;

	public SFX_Instance punchSFX;

	public ParticleSystem barnacleGas;

	private bool releaseGas;

	private float gasSyncCD;

	public float releaseGasFor;

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
	private void TrySyncGas(bool val)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_SyncGas(bool val)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryToAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_DoTentacleAttack(int targetID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Collide(Collision col, Bodypart part)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_TentacleHit(int viewID, int bodyPartID, Vector3 force)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CIIgnorePlayer_003Ed__22))]
	private IEnumerator IIgnorePlayer(Player p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_DoSuckAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChaseTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Investigate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DefaultState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bot_BarnacleBall()
	{

	}
}
