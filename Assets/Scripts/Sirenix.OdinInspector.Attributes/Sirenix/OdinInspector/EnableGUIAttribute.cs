using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class EnableGUIAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnableGUIAttribute()
		{
			throw null;
		}
	}
}
