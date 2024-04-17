using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class Framer<T>
	{
		[CompilerGenerated]
		private sealed class _003CFrame_003Ed__4 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T[] _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Framer<T> _003C_003E4__this;

			private T[] buf;

			public T[] _003C_003E3__buf;

			private int _003CbufPos_003E5__2;

			T[] IEnumerator<T[]>.Current
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
			public _003CFrame_003Ed__4(int _003C_003E1__state)
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

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<T[]> IEnumerable<T[]>.GetEnumerator()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw null;
			}
		}

		protected T[] frame;

		protected int sizeofT;

		protected int framePos;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Framer(int frameSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(Framer<>._003CFrame_003Ed__4))]
		public virtual IEnumerable<T[]> Frame(T[] buf)
		{
			throw null;
		}
	}
}
