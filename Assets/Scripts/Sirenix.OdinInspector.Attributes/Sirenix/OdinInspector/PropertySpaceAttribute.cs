using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	public class PropertySpaceAttribute : Attribute
	{
		public float SpaceBefore;

		public float SpaceAfter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertySpaceAttribute()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertySpaceAttribute(float spaceBefore)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PropertySpaceAttribute(float spaceBefore, float spaceAfter)
		{

		}
	}
}
