using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Jobs;

namespace pworld.Scripts.PPhys.Bursted.Jobs
{
	[BurstCompile]
	public struct SpringJobRotation : IJobParallelForTransform
	{
		[Serializable]
		public struct SpringData
		{
			public float damp;

			public float spring;
		}

		public NativeArray<Quaternion> targets;

		[ReadOnly]
		public NativeArray<SpringData> springDatas;

		public NativeArray<Vector3> velocities;

		public float dt;

		[NativeDisableUnsafePtrRestriction]
		private TransformAccess transform;

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

		public Quaternion Target
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Vector3 Up
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Vector3 Forward
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

		public Vector3 TargetUp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Vector3 TargetForward
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
		private void PhysicsStep(float dt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Rotate(Vector3 dRot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LagControll(float maxStepSize = 0.004f)
		{
			throw null;
		}
	}
}
