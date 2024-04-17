using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Jobs
{
	public struct SpringJobScale : IJobParallelForTransform
	{
		[Serializable]
		public struct SpringData
		{
			public float damp;

			public float spring;
		}

		[NativeDisableUnsafePtrRestriction]
		private TransformAccess transform;

		[NonSerialized]
		[ReadOnly]
		public NativeArray<Vector3> targets;

		[NonSerialized]
		[ReadOnly]
		public NativeArray<SpringData> springDatas;

		[NonSerialized]
		public NativeArray<Vector3> velocities;

		[NonSerialized]
		public float dt;

		private int index;

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

		public Vector3 Target
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float Damp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float Spring
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(int _index, TransformAccess _transform)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PhysicsStep(float _dt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LagControll(float maxStepSize = 0.004f)
		{
			throw null;
		}
	}
}
