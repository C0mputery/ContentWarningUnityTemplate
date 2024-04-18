using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class EnumPagingAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnumPagingAttribute()
		{

		}
	}
}
