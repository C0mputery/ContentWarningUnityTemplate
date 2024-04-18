using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CurvedUI
{
	[ExecuteInEditMode]
	public class CurvedUITMPInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[CompilerGenerated]
		private sealed class _003CCaretBlinker_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CurvedUITMPInputFieldCaret _003C_003E4__this;

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
			public _003CCaretBlinker_003Ed__10(int _003C_003E1__state)
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

		private TMP_InputField myField;

		private RectTransform myCaret;

		private Color origCaretColor;

		private Color origSelectionColor;

		private bool selected;

		private bool selectingText;

		public Color CaretColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Color SelectionColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public float CaretBlinkRate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelect(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeselect(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CCaretBlinker_003Ed__10))]
		private IEnumerator CaretBlinker()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateCaret()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateCaret()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckAndConvertMask()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUITMPInputFieldCaret()
		{

		}
	}
}
