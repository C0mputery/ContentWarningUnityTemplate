using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class PreviouslySerializedAsAttribute : Attribute
	{
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PreviouslySerializedAsAttribute(string name)
		{

		}
	}
}
