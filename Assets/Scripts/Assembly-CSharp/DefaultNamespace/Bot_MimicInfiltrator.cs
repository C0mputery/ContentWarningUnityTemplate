using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
	public class Bot_MimicInfiltrator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFlickerRed_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Bot_MimicInfiltrator _003C_003E4__this;

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
			public _003CFlickerRed_003Ed__69(int _003C_003E1__state)
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

		public float customRotationSpeed;

		public float minTimeBeforeWalkSprintSwitch;

		public float minTimeBetweenJumps;

		public float maxTimeBetweenJumps;

		[HideInInspector]
		public Player player;

		public float distanceToBeConsideredAlone;

		public Player hitTarget;

		public Player mimickingPlayer;

		public float runUntilThisCloseFromTarget;

		public float stopWhenThisCloseToTarget;

		public bool isAngry;

		public float timeBetweenJabs;

		public float jabForce;

		public string angryFaceText;

		public float angryFaceRotation;

		public Color angryFaceColor;

		public float damageOnHit;

		[SerializeField]
		private float fallOnHit;

		[SerializeField]
		private float forceOnHit;

		public List<Player> ignorePlayers;

		public float distanceForHitToBeConsideredAlone;

		public float timeThatFistIsDangerous;

		public float lookAwayChance;

		[FormerlySerializedAs("runAwayChange")]
		public float runAwayChance;

		public float flickerChance;

		public float angryThreshold;

		private readonly Vector3 faceSizeMinMax;

		public float maxTimeAwkward;

		private float angryMeter;

		private bool awkwardLookAway;

		private Vector3 awkwardLookDir;

		private float awkwardTime;

		private Bot bot;

		private FakeFlashLight fakeFlashLight_grc;

		private bool followPlayer;

		private bool goToRandomPoint;

		private Vector3 moveAwayPos;

		private PatrolPoint randomPoint;

		private bool runToPlayer;

		private float timeSinceJab;

		private float timeSinceWalkSprintSwitch;

		private float timeSpentLookingAtMe;

		private float timeSpentNotLookingAtMe;

		private float timeToJab;

		private float timeToNextJump;

		private PhotonView view;

		public float hitDistance;

		private float timeAlive;

		public float nothingChance;

		private bool isMimicing;

		public float DistToTarget
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool Sprint
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

		public float DistanceToHitTarget
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float DistanceToMimickingPlayer
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
		private void FindMimicTarget()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool AnyoneLookingAtMe()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Despawn()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MakeItLessAwkward()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsTargetLookingAtMe()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IamLookingAtTarget()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		public void MakeAngry()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void RPC_AngryVisuals()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CFlickerRed_003Ed__69))]
		private IEnumerator FlickerRed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InternalMimickPlayer(Player playerToMimick, Player hitTarget)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MimickPlayer(Player playerToMimick, Player hitTarget)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void RPC_MimicPlayer(int mimicID, int hitTargetID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void RPC_ImitateVisuals()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Jump()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		private void RPCA_MimicJump()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bot_MimicInfiltrator()
		{
			throw null;
		}
	}
}
