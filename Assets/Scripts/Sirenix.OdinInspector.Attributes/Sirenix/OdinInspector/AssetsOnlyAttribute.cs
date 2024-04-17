using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class AssetsOnlyAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AssetsOnlyAttribute()
		{
			throw null;
		}
	}
}
