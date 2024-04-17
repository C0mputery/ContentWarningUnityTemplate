using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class LabelWidthAttribute : Attribute
	{
		public float Width;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LabelWidthAttribute(float width)
		{
			throw null;
		}
	}
}
