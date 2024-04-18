using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EPOOutline.Demo
{
	public class Doughnut : MonoBehaviour, ICollectable
	{
		[CompilerGenerated]
		private sealed class _003CAnimateCollection_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Doughnut _003C_003E4__this;

			public GameObject collector;

			private float _003Cduration_003E5__2;

			private float _003CcollectionRadius_003E5__3;

			private float _003CcollectionAngle_003E5__4;

			private float _003CtimeLeft_003E5__5;

			private Vector3 _003CinitialScale_003E5__6;

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
			public _003CAnimateCollection_003Ed__11(int _003C_003E1__state)
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
		private float rotationSpeed;

		[SerializeField]
		private AudioClip eatSound;

		[SerializeField]
		private float moveAmplitude;

		[SerializeField]
		private float moveSpeed;

		private Outlinable outlinable;

		private Vector3 initialPosition;

		private float amplitudeShift;

		private bool isCollected;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Collect(GameObject collector)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CAnimateCollection_003Ed__11))]
		private IEnumerator AnimateCollection(GameObject collector)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Doughnut()
		{

		}
	}
}
