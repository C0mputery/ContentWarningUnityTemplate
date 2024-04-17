using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class PHealth : MonoBehaviour, PAffectable
	{
		[SerializeField]
		private float health;

		private bool dead;

		public Action OnDied;

		public Action OnDiedLate;

		public Action OnRessurected;

		public Action<float, GameObject> OnTakeDamage;

		public Action<float, GameObject> OnTakeDamageLate;

		public float StartHealth
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

		public bool Paused
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

		public float Health
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void PAffectable.AddForce(Vector3 force)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TakeDamage(float dmg, GameObject damager)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PauseForSeconds(float sec)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PHealth()
		{
			throw null;
		}
	}
}
