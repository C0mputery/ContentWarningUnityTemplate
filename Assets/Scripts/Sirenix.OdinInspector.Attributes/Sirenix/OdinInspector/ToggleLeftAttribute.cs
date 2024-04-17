using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ToggleLeftAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ToggleLeftAttribute()
		{
			throw null;
		}
	}
}
