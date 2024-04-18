using System.Reflection;
using System.Runtime.CompilerServices;

namespace Zorro.Core.CLI
{
	public class CommandSuggestion : Suggestion
	{
		public string Domain;

		public string Command;

		public ParameterInfo[] ParameterInfos;

		private int selectedParameterIndex;

		public string FullCommand
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CommandSuggestion(string domain, string command, ParameterInfo[] parameterInfos)
		{

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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HighlightParameter(int parameterIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetDisplayTextWithMaxParameter(int maxParameterIndex, bool color)
		{
			throw null;
		}
	}
}
