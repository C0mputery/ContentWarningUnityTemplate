using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Zorro.Core.SmallShadows
{
	[DefaultExecutionOrder(-1000)]
	public class SmallShadowHandler : Singleton<SmallShadowHandler>
	{
		public ObjectNativeBookkeeper<SmallShadowMesh> m_smallShadowMeshes;

		public NativeListRecord<float3> m_meshPositions;

		public NativeListRecord<bool> m_shadowCastingStates;

		public NativeListRecord<float> m_meshMaxDistances;

		private Optionable<(JobHandle jobHandle, NativeQueue<CheckResult> results)> m_jobHandle;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnCreated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RegisterSmallShadowMesh(SmallShadowMesh mesh)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UnregisterSmallShadowMesh(SmallShadowMesh mesh)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ScheduleShadowDistanceChecks(float3 cameraPos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Process()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmallShadowHandler()
		{

		}
	}
}
