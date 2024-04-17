using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PPhys
{
	public abstract class PPhysSpringBase : MonoBehaviour
	{
		[SerializeField]
		protected Vector3 _target;

		[SerializeField]
		protected Vector3 velocity;

		public float damp;

		public float spring;

		public float ropeLength;

		public float maxStepSize;

		public float sleepTime;

		public bool SetTargetOnAwake;

		private float dt;

		private bool lastIdle;

		private Vector3 lastTarget;

		private Vector3 lastVelocity;

		public Action OnExitIdle;

		public Action OnIdle;

		private bool sleeping;

		private float timeSinceVelZero;

		public bool useSleeping;

		[SerializeReference]
		public ITimeSource timeSource;

		public Vector3 Velocity
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

		public virtual Vector3 Target
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

		public abstract Vector3 Current { get; set; }

		public Vector3 Acceleration
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

		public bool Idle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool Sleeping
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixTime()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckSleeping()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LagControll(Action<float> physStep, float dt, float maxStepSize = 0.016f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void GoTo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void PhysicsStep(float dt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Push(Vector3 force)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void GoToTarget()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Load(PPhysSetting settings)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateDeltaVel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PPhysSpringBase()
		{
			throw null;
		}
	}
}
