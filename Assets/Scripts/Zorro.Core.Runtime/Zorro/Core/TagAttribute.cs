using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	[AttributeUsage(AttributeTargets.Class)]
	public class TagAttribute : Attribute
	{
		public string Tag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagAttribute(string tag)
		{
			throw null;
		}
	}
}
