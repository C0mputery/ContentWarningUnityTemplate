using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Class)]
	public class EmittedFormatterAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmittedFormatterAttribute()
		{
			throw null;
		}
	}
}
