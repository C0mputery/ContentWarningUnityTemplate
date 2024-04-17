using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class SuppressInvalidAttributeErrorAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuppressInvalidAttributeErrorAttribute()
		{
			throw null;
		}
	}
}
