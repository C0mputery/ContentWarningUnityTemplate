using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zorro.Core.CLI;

[TypeParser(typeof(Item))]
public class ItemCLIParser : CLITypeParser
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
	public ItemCLIParser()
	{

	}
}
