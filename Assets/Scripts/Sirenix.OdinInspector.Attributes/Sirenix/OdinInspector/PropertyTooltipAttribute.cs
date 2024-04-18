using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class PropertyTooltipAttribute : Attribute
	{
		public string Tooltip;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertyTooltipAttribute(string tooltip)
		{

		}
	}
}
