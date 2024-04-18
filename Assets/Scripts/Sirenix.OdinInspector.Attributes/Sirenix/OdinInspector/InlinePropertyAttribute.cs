using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	public class InlinePropertyAttribute : Attribute
	{
		public int LabelWidth;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InlinePropertyAttribute()
		{

		}
	}
}
