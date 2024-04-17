using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;

namespace Zorro.Core
{
	public static class TransformAccessExtensionMethods
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float3 TransformDirection(this TransformAccess transformAccess, float3 direction)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float3 TransformDirection(this TransformAccess transformAccess, Vector3 direction)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float3 TransformPoint(this TransformAccess transformAccess, float3 direction)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float3 InverseTransformPoint(this TransformAccess transformAccess, float3 pos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float3 InverseTransformPoint(this TransformAccess transformAccess, Vector3 pos)
		{
			throw null;
		}
	}
}
