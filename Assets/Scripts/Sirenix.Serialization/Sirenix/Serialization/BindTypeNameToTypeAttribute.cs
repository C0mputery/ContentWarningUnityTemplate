using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class BindTypeNameToTypeAttribute : Attribute
	{
		internal readonly Type NewType;

		internal readonly string OldTypeName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BindTypeNameToTypeAttribute(string oldFullTypeName, Type newType)
		{

		}
	}
}
