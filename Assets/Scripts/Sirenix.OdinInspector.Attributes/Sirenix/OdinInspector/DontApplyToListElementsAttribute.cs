using System;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DontApplyToListElementsAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DontApplyToListElementsAttribute()
		{

		}
	}
}
