using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zorro.Core.CLI.ParsableTypes
{
	[TypeParser(typeof(float))]
	public class FloatCLIParser : CLITypeParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object Parse(string str)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<ParameterAutocomplete> FindAutocomplete(string parameterText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FloatCLIParser()
		{

		}
	}
}
