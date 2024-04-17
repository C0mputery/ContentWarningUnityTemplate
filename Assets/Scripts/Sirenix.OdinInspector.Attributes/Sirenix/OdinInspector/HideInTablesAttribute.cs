using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class HideInTablesAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideInTablesAttribute()
		{
			throw null;
		}
	}
}
