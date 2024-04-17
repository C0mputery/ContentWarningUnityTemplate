using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace Zorro.Core
{
	public struct NativeAnimationCurve : IDisposable
	{
		private int m_resolution;

		private float m_startTime;

		private float m_endTime;

		[ReadOnly]
		public NativeArray<float> m_curveData;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NativeAnimationCurve(AnimationCurve curve, int resolution, Allocator allocator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float EvaluateCurve(float time)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float Length()
		{
			throw null;
		}
	}
}
