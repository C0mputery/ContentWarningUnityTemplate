using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Zorro.Core
{
	public static class ArrayExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 GetRandomPoint(this Vector3[] array)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 GetRandomPoint(this Transform[] array)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static NativeArray<float3> ToFloat3NativeArray(this Vector3[] array, Allocator allocator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static NativeArray<T> ToNativeArray<T>(this T[] array, Allocator allocator) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetRandom<T>(this T[] array)
		{
			throw null;
		}
	}
}
