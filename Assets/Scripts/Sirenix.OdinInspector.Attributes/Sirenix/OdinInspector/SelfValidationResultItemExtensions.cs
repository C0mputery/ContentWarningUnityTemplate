using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	public static class SelfValidationResultItemExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithFix(this ref SelfValidationResult.ResultItem item, string title, Action fix, bool offerInInspector = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithFix<T>(this ref SelfValidationResult.ResultItem item, string title, Action<T> fix, bool offerInInspector = true) where T : new()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithFix(this ref SelfValidationResult.ResultItem item, Action fix, bool offerInInspector = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithFix<T>(this ref SelfValidationResult.ResultItem item, Action<T> fix, bool offerInInspector = true) where T : new()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithFix(this ref SelfValidationResult.ResultItem item, SelfFix fix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithContextClick(this ref SelfValidationResult.ResultItem item, Func<IEnumerable<SelfValidationResult.ContextMenuItem>> onContextClick)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithContextClick(this ref SelfValidationResult.ResultItem item, string path, Action onClick)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithContextClick(this ref SelfValidationResult.ResultItem item, string path, bool on, Action onClick)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithContextClick(this ref SelfValidationResult.ResultItem item, SelfValidationResult.ContextMenuItem onContextClick)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithSceneGUI(this ref SelfValidationResult.ResultItem item, Action onSceneGUI)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem SetSelectionObject(this ref SelfValidationResult.ResultItem item, UnityEngine.Object uObj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem EnableRichText(this ref SelfValidationResult.ResultItem item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithMetaData(this ref SelfValidationResult.ResultItem resultItem, string name, object value, params Attribute[] attributes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithMetaData(this ref SelfValidationResult.ResultItem resultItem, object value, params Attribute[] attributes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ref SelfValidationResult.ResultItem WithButton(this ref SelfValidationResult.ResultItem resultItem, string name, Action onClick)
		{
			throw null;
		}
	}
}
