using System.Runtime.CompilerServices;

namespace Zorro.Core.CLI
{
	public class ParameterSuggestion : Suggestion
	{
		public string DisplayLine;

		public string TypeLine;

		public string ParameterInput;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParameterSuggestion(string displayLine, string typeLine, string parameterInput)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetInputValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanBeSelected()
		{
			throw null;
		}
	}
}
