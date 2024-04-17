using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace pworld.Scripts.Extensions
{
	public static class PExt
	{
		[CompilerGenerated]
		private sealed class _003CDoInSec_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public Action doIt;

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
			public _003CDoInSec_003Ed__20(int _003C_003E1__state)
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
		private sealed class _003CEvalCurve_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public bool reverse;

			public Action<float> readCurve;

			public Action finished;

			private float _003CdeltaTime_003E5__2;

			private float _003Cc_003E5__3;

			private float _003Ct_003E5__4;

			private float _003CcStart_003E5__5;

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
			public _003CEvalCurve_003Ed__21(int _003C_003E1__state)
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
		public static int Flatten(int x, int y, int width)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<T> RemoveRange<T>(this List<T> me, List<T> other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MakeAssetReadable(string path)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SaveObj(UnityEngine.Object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Bounds ToWorld(this Bounds me, Transform transform)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ConfigurableJoint AttachTo(this Rigidbody me, Rigidbody other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3[] GetPositions(this LineRenderer me)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetMouseRaycast(out RaycastHit hit, int groundMask, bool onlyMap = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetMouseRaycastAll(out RaycastHit[] hit, int groundMask, bool onlyMap = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CanSee(Vector3 from, Vector3 to, int layermask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static KEY_STATE GetKeyState(this Input input, KeyCode key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsPlaying(this Animator me, string name, int layerIndex = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string GetVariableName<T>(Expression<Func<T>> expr)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DoIfNotNull(this object me, Action thingToDo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T PGetComp<T>(this T me, GameObject owner) where T : MonoBehaviour
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PCompInit<T>(this T me, ref T alsoMe, GameObject owner) where T : MonoBehaviour
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T PLazyFetch<T>(this T me, ref T alsoMe, GameObject owner) where T : MonoBehaviour
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T PLazyFetchP<T>(this MonoBehaviour me, ref T alsoMe, GameObject owner) where T : MonoBehaviour
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T PLazyFetchC<T>(this MonoBehaviour me, ref T alsoMe, GameObject owner) where T : MonoBehaviour
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DoInSec(this MonoBehaviour me, float time, Action doIt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CDoInSec_003Ed__20))]
		public static IEnumerator DoInSec(float time, Action doIt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CEvalCurve_003Ed__21))]
		public static IEnumerator EvalCurve(AnimationCurve curve, Action<float> readCurve, Action finished, bool reverse = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DoTimes(int times, Action DoIt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetEither<T>(T lhs, T rhs)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StoppableCoroutine StartStoppableCoroutine(this MonoBehaviour mb, IEnumerator coroutine)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsPointOverUIObject(this EventSystem me, Vector3 screenPosition)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetUiUnderPos(this EventSystem me, out List<RaycastResult> hits, Vector3 screenPos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<T> PGetComponentsInChildrenButNotMe<T>(this GameObject me, bool includeInActive = false) where T : Component
		{
			throw null;
		}
	}
}
