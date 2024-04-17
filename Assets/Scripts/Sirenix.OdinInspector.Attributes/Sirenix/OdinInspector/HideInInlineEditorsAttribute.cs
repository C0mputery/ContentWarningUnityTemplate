using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class HideInInlineEditorsAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideInInlineEditorsAttribute()
		{
			throw null;
		}
	}
}
