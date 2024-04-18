using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("Use a RegisterFormatterAttribute applied to the containing assembly instead.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CustomGenericFormatterAttribute : CustomFormatterAttribute
	{
		public readonly Type SerializedGenericTypeDefinition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomGenericFormatterAttribute(Type serializedGenericTypeDefinition, int priority = 0)
		{

		}
	}
}
