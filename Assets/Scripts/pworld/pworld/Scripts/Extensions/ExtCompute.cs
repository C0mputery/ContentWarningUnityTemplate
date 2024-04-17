using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public static class ExtCompute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ComputeBuffer CreateComputeBuffer<T>(this T[] me, ComputeBufferType type = ComputeBufferType.Structured) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ComputeBuffer SetAndCreateComputeBuffer<T>(this T[] me, ComputeShader cs, int kId, string name, ComputeBufferType type = ComputeBufferType.Structured)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ComputeBuffer SetAndCreateComputeBuffer<T>(this NativeArray<T> me, ComputeShader cs, int kId, string name, ComputeBufferType type = ComputeBufferType.Structured) where T : unmanaged
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ComputeBuffer CreateComputeBuffer<T>(this List<T> me, ComputeBufferType type = ComputeBufferType.Structured) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PDispatch(this ComputeShader me, int kid, string threadGroupName, float x = 1f, float y = 1f, float z = 1f)
		{
			throw null;
		}
	}
}
