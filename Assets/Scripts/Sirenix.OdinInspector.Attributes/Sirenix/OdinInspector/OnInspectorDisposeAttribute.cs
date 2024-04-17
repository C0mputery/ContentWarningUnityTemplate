using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	[IncludeMyAttributes]
	[HideInTables]
	public class OnInspectorDisposeAttribute : ShowInInspectorAttribute
	{
		public string Action;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnInspectorDisposeAttribute()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnInspectorDisposeAttribute(string action)
		{
			throw null;
		}
	}
}
