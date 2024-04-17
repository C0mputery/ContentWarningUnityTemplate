using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core
{
	public static class AnimationCurveExtensions
	{
		[CompilerGenerated]
		private sealed class _003CYieldForCurve_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve animationCurve;

			public bool timeScale;

			public float speed;

			public Action<float> onSampleCurve;

			private float _003Ctimer_003E5__2;

			private float _003Clength_003E5__3;

			object IEnumerator<object>.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			public _003CYieldForCurve_003Ed__3(int _003C_003E1__state)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool MoveNext()
			{
				throw null;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CYieldForCurveFixedUpdate_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve animationCurve;

			public bool timeScale;

			public float speed;

			public Action<float> onSampleCurve;

			private float _003Ctimer_003E5__2;

			private float _003Clength_003E5__3;

			private WaitForFixedUpdate _003Cyield_003E5__4;

			object IEnumerator<object>.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			public _003CYieldForCurveFixedUpdate_003Ed__4(int _003C_003E1__state)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool MoveNext()
			{
				throw null;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float GetStartTime(this AnimationCurve animationCurve)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float GetEndTime(this AnimationCurve animationCurve)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Keyframe First(this AnimationCurve animationCurve)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CYieldForCurve_003Ed__3))]
		public static IEnumerator YieldForCurve(this AnimationCurve animationCurve, Action<float> onSampleCurve, bool timeScale = true, float speed = 1f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CYieldForCurveFixedUpdate_003Ed__4))]
		public static IEnumerator YieldForCurveFixedUpdate(this AnimationCurve animationCurve, Action<float> onSampleCurve, bool timeScale = true, float speed = 1f)
		{
			throw null;
		}
	}
}
