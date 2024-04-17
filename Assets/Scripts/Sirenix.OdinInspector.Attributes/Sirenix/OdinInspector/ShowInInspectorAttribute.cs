using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Sirenix.OdinInspector
{
	[MeansImplicitUse]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	public class ShowInInspectorAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowInInspectorAttribute()
		{
			throw null;
		}
	}
}
