using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class FramerResampler<T> : Framer<T>
	{
		[CompilerGenerated]
		private sealed class _003CFrame_003Ed__14 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T[] _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private T[] bufT;

			public T[] _003C_003E3__bufT;

			public FramerResampler<T> _003C_003E4__this;

			private int _003CbufPos_003E5__2;

			private int _003CbufLen_003E5__3;

			private float[] _003Cbuf_003E5__4;

			private float[] _003Cframe_003E5__5;

			private float _003CdeltaK_003E5__6;

			private short[] _003Cbuf_003E5__7;

			private short[] _003Cframe_003E5__8;

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
			public _003CFrame_003Ed__14(int _003C_003E1__state)
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

		protected bool TisFloat;

		protected bool interpolate;

		protected int channels;

		protected int resampleNum;

		protected int resampleDen;

		protected float resampleRatioInv;

		protected int delta;

		private T inSampleCh1;

		private T inSampleCh2;

		private float inSampleCh1Interp;

		private float inSampleCh2Interp;

		private float inSampleCh1InterpChange;

		private float inSampleCh2InterpChange;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FramerResampler(int frameSize, int channels, int resampleNum, int resampleDen, bool interpolate) : base(frameSize)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(FramerResampler<>._003CFrame_003Ed__14))]
		public override IEnumerable<T[]> Frame(T[] bufT)
		{
			throw null;
		}
	}
}
