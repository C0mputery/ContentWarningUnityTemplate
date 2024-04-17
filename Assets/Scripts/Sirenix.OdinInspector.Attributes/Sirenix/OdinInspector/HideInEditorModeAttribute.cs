using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class HideInEditorModeAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideInEditorModeAttribute()
		{
			throw null;
		}
	}
}
