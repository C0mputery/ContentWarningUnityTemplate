using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	public sealed class DoNotDrawAsReferenceAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DoNotDrawAsReferenceAttribute()
		{

		}
	}
}
