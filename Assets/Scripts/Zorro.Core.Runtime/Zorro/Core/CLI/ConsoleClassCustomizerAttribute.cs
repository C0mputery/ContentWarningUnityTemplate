using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core.CLI
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ConsoleClassCustomizerAttribute : Attribute
	{
		public string NewDomainName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleClassCustomizerAttribute(string newDomainName)
		{
			throw null;
		}
	}
}
