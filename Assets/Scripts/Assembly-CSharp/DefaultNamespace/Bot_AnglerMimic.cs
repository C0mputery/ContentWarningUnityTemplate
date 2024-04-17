using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

namespace DefaultNamespace
{
	public class Bot_AnglerMimic : MonoBehaviour
	{
		public bool avoidingPlayer;

		public float avoidPlayerDistance;

		public bool tauntingPlayer;

		public float tauntDistance;

		public float runFromPlayerDistance;

		public float runToPlayerDistance;

		public float customRotationSpeed;

		public float minTimeBeforeWalkSprintSwitch;

		public float minTimeBetweenJumps;

		public float maxTimeBetweenJumps;

		[HideInInspector]
		public Player player;

		private Bot_Angler angler;

		private Bot bot;

		private FakeFlashLight fakeFlashLight_grc;

		private float timeSinceWalkSprintSwitch;

		private float timeToNextJump;

		private PhotonView view;

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

		public bool IsFlashLightOn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool AvoidingPlayer
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

		public bool TauntingPlayer
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

		public bool HasAnglerDaddy
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
		[PunRPC]
		private void RPCA_ToggleFlashLight(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssignAngler(Bot_Angler botAngler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FindAngler()
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
		public Bot_AnglerMimic()
		{
			throw null;
		}
	}
}
