using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	[HideInTables]
	public sealed class OnStateUpdateAttribute : Attribute
	{
		public string Action;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnStateUpdateAttribute(string action)
		{

		}
	}
}
