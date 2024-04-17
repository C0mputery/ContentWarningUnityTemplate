using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class ShowDrawerChainAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowDrawerChainAttribute()
		{
			throw null;
		}
	}
}
