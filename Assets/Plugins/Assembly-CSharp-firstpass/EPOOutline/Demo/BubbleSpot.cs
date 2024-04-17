using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EPOOutline.Demo
{
	public class BubbleSpot : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BubbleSpot _003C_003E4__this;

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
			public _003CStart_003Ed__10(int _003C_003E1__state)
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

		[SerializeField]
		private Transform trackPosition;

		[SerializeField]
		private Vector3 trackShift;

		[SerializeField]
		private Camera targetCamera;

		[SerializeField]
		private Transform bubble;

		[SerializeField]
		private bool visibleFromBegining;

		[SerializeField]
		private float showDelay;

		[SerializeField]
		private float showDuration;

		[SerializeField]
		private bool once;

		private bool wasShown;

		private int playersInside;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
		private IEnumerator Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTriggerEnter(Collider other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTriggerExit(Collider other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Hide(float duration)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(float duration)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BubbleSpot()
		{
			throw null;
		}
	}
}
