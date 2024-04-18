using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class DelayedPropertyAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedPropertyAttribute()
		{

		}
	}
}
