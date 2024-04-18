using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEditor.Localization.Samples
{
	public class LoadingMultipleStringsExample : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadStrings_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadingMultipleStringsExample _003C_003E4__this;

			private AsyncOperationHandle<StringTable> _003CloadingOperation_003E5__2;

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
			public _003CLoadStrings_003Ed__7(int _003C_003E1__state)
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

		public string stringTableCollectionName;

		private string m_TranslatedStringHello;

		private string m_TranslatedStringGoodbye;

		private string m_TranslatedStringThisIsATest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSelectedLocaleChanged(Locale obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CLoadStrings_003Ed__7))]
		private IEnumerator LoadStrings()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetLocalizedString(StringTable table, string entryName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoadingMultipleStringsExample()
		{

		}
	}
}
