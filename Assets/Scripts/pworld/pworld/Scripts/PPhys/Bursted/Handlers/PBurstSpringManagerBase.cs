using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Handlers
{
	public abstract class PBurstSpringManagerBase<TJob, TSpringData, TTarget> : MonoBehaviour where TJob : struct, IJobParallelForTransform where TSpringData : struct where TTarget : struct
	{
		[NonSerialized]
		public NativeArray<TSpringData> datas;

		[NonSerialized]
		public NativeArray<TTarget> targets;

		[NonSerialized]
		public TransformAccessArray transforms;

		[NonSerialized]
		public NativeArray<Vector3> velocities;

		public readonly List<IPBurstSpringWorker<TTarget, TSpringData>> workers;

		public static PBurstSpringManagerBase<TJob, TSpringData, TTarget> Me
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

		protected abstract TJob GetNewJob();

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddWorker(IPBurstSpringWorker<TTarget, TSpringData> _worker)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AllocateDatas(bool _added)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RunJobs()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveWorker(IPBurstSpringWorker<TTarget, TSpringData> _worker)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PBurstSpringManagerBase()
		{
			throw null;
		}
	}
}
