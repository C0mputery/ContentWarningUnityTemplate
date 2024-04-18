using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class OptionalAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OptionalAttribute()
		{

		}
	}
}
