using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	public class ShowPropertyResolverAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowPropertyResolverAttribute()
		{
			throw null;
		}
	}
}
