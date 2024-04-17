using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	public class HideDuplicateReferenceBoxAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideDuplicateReferenceBoxAttribute()
		{
			throw null;
		}
	}
}
