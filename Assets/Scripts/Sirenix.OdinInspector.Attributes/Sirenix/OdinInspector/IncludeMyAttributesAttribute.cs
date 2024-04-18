using System;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.Class)]
	public class IncludeMyAttributesAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IncludeMyAttributesAttribute()
		{

		}
	}
}
