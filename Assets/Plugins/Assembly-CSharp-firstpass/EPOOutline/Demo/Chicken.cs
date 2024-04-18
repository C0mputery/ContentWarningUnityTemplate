using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace EPOOutline.Demo
{
	public class Chicken : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateChicken_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Chicken _003C_003E4__this;

			private NavMeshPath _003Cpath_003E5__2;

			private float _003CtimeToWait_003E5__3;

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
			public _003CUpdateChicken_003Ed__11(int _003C_003E1__state)
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
		private bool alwaysActive;

		[SerializeField]
		private bool updateChicken;

		[SerializeField]
		private float searchRadius;

		private Outlinable outlinable;

		private NavMeshAgent agent;

		private Animator animator;

		private int enteredCount;

		private static int priority;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
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
		[IteratorStateMachine(typeof(_003CUpdateChicken_003Ed__11))]
		private IEnumerator UpdateChicken()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Chicken()
		{

		}
	}
}
