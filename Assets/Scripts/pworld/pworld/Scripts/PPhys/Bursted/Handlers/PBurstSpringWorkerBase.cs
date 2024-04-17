using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Handlers
{
	public abstract class PBurstSpringWorkerBase<TTarget, TSpringData, TJob, TManager> : MonoBehaviour, IPBurstSpringWorker<TTarget, TSpringData> where TTarget : struct where TSpringData : struct where TJob : struct, IJobParallelForTransform where TManager : PBurstSpringManagerBase<TJob, TSpringData, TTarget>
	{
		[SerializeField]
		protected TSpringData data;

		protected bool IsHired
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

		protected int WorkerIndex
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

		public abstract TManager Manager { get; }

		public abstract TTarget Target { get; }

		TSpringData IPBurstSpringWorker<TTarget, TSpringData>.Data
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

		Transform IPBurstSpringWorker<TTarget, TSpringData>.Transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public virtual Vector3 Velocity
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
		private void JobDataChanged()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateTarget()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Hire(int _index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Fire()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Push(Vector3 dir, float f = 100f)
		{
			throw null;
		}

		protected abstract TSpringData GetDefaultData();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DefaultSpringData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PBurstSpringWorkerBase()
		{
			throw null;
		}
	}
}
