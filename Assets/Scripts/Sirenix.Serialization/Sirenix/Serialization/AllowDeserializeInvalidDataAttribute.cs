using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public class AllowDeserializeInvalidDataAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllowDeserializeInvalidDataAttribute()
		{
			throw null;
		}
	}
}
