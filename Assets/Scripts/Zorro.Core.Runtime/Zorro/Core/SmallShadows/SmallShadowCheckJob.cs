using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Zorro.Core.SmallShadows
{
	[BurstCompile]
	public struct SmallShadowCheckJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float3> MeshPositions;

		public NativeArray<bool> MeshShadowCastingStates;

		[ReadOnly]
		public NativeArray<float> MeshMaxDistances;

		public float3 CameraPos;

		[WriteOnly]
		internal NativeQueue<CheckResult>.ParallelWriter CheckResults;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(int index)
		{
			throw null;
		}
	}
}
