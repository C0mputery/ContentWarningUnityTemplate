using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core.CLI
{
	[AttributeUsage(AttributeTargets.Method)]
	public class ConsoleCommandAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleCommandAttribute()
		{
			throw null;
		}
	}
}
