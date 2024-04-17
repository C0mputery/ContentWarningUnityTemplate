using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys;

namespace pworld.Scripts
{
	public class PBooper : MonoBehaviour
	{
		private class Booping
		{
			public PPhysSpringBase booper;

			public GameObject go;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Booping()
			{
				throw null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CRemoveWhenStill_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Booping go;

			private Vector3 _003ClastVel_003E5__2;

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
			public _003CRemoveWhenStill_003Ed__10(int _003C_003E1__state)
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

		public static PBooper me;

		public float spring;

		public float damp;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

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
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ScaleBoopSmall(GameObject go, float force = 5f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PositionBoopSmall(GameObject go, Vector3 force)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PutItOn<T>(GameObject go, Vector3 force, float spring, float damp) where T : PPhysSpringBase
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CRemoveWhenStill_003Ed__10))]
		private IEnumerator RemoveWhenStill(Booping go)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PBooper()
		{
			throw null;
		}
	}
}
