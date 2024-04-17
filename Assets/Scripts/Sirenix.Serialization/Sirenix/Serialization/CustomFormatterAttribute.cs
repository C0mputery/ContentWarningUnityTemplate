using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("Use a RegisterFormatterAttribute applied to the containing assembly instead.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CustomFormatterAttribute : Attribute
	{
		public readonly int Priority;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomFormatterAttribute()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomFormatterAttribute(int priority = 0)
		{
			throw null;
		}
	}
}
