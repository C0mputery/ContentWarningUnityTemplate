using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public sealed class AlwaysFormatsSelfAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlwaysFormatsSelfAttribute()
		{
			throw null;
		}
	}
}
