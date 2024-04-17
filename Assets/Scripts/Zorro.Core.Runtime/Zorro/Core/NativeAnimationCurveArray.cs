using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Zorro.Core
{
	public struct NativeAnimationCurveArray : IDisposable
	{
		private int m_resolution;

		private int curveCount;

		[ReadOnly]
		public NativeArray<float> m_curveData;

		[ReadOnly]
		public NativeArray<float2> m_curveInfo;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NativeAnimationCurveArray(AnimationCurve[] curves, int resolution, Allocator allocator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float EvaluateCurve(int curveIndex, float time)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}
	}
}
