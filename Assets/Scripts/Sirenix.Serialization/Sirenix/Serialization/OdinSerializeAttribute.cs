using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Sirenix.Serialization
{
	[MeansImplicitUse]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class OdinSerializeAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OdinSerializeAttribute()
		{

		}
	}
}
