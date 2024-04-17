using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zorro.Core.CLI
{
	public abstract class CLITypeParser
	{
		public abstract object Parse(string str);

		public abstract List<ParameterAutocomplete> FindAutocomplete(string parameterText);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected CLITypeParser()
		{
			throw null;
		}
	}
}
