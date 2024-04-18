using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public class StoppableCoroutine
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StoppableCoroutine _003C_003E4__this;

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
			public _003CWait_003Ed__9(int _003C_003E1__state)
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
		private sealed class _003CWrapper_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StoppableCoroutine _003C_003E4__this;

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
			public _003CWrapper_003Ed__8(int _003C_003E1__state)
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

		private readonly MonoBehaviour mb;

		private readonly Coroutine nested;

		private readonly IEnumerator payload;

		private bool terminated;

		public bool wasStopped;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoppableCoroutine(MonoBehaviour mb, IEnumerator aCoroutine)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Coroutine WaitFor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CWrapper_003Ed__8))]
		private IEnumerator Wrapper()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CWait_003Ed__9))]
		private IEnumerator Wait()
		{
			throw null;
		}
	}
}
