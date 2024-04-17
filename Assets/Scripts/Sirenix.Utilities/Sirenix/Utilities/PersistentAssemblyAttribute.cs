using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public class PersistentAssemblyAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PersistentAssemblyAttribute()
		{
			throw null;
		}
	}
}
