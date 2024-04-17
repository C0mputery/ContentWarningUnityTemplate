using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Photon.Pun.UtilityScripts
{
	public class OnClickRpc : MonoBehaviourPun, IPointerClickHandler, IEventSystemHandler
	{
		[CompilerGenerated]
		private sealed class _003CClickFlash_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OnClickRpc _003C_003E4__this;

			private bool _003CwasEmissive_003E5__2;

			private float _003Cf_003E5__3;

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
			public _003CClickFlash_003Ed__8(int _003C_003E1__state)
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

		public PointerEventData.InputButton Button;

		public KeyCode ModifierKey;

		public RpcTarget Target;

		private Material originalMaterial;

		private Color originalColor;

		private bool isFlashing;

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PunRPC]
		public void ClickRpc()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CClickFlash_003Ed__8))]
		public IEnumerator ClickFlash()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnClickRpc()
		{
			throw null;
		}
	}
}
