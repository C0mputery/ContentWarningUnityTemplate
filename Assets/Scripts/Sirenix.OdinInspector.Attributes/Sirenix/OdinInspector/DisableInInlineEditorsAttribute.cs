using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class DisableInInlineEditorsAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisableInInlineEditorsAttribute()
		{
			throw null;
		}
	}
}
