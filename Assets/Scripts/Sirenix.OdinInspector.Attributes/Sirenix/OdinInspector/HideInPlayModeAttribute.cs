using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All)]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	public class HideInPlayModeAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HideInPlayModeAttribute()
		{

		}
	}
}
