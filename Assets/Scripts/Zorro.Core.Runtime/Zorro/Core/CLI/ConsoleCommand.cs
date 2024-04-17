using System.Reflection;
using System.Runtime.CompilerServices;

namespace Zorro.Core.CLI
{
	public struct ConsoleCommand
	{
		public string Command;

		public string DomainName;

		public MethodInfo MethodInfo;

		public ParameterInfo[] ParameterInfo;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleCommand(MethodInfo methodInfo)
		{
			throw null;
		}
	}
}
