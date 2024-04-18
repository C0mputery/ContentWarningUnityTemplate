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
	public class OnInspectorInitAttribute : ShowInInspectorAttribute
	{
		public string Action;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnInspectorInitAttribute()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnInspectorInitAttribute(string action)
		{

		}
	}
}
