using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	public class EnumToggleButtonsAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnumToggleButtonsAttribute()
		{
			throw null;
		}
	}
}
