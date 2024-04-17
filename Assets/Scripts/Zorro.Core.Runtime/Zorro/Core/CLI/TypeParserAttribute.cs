using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core.CLI
{
	[AttributeUsage(AttributeTargets.Class)]
	public class TypeParserAttribute : Attribute
	{
		public Type ParseType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeParserAttribute(Type parseType)
		{
			throw null;
		}
	}
}
