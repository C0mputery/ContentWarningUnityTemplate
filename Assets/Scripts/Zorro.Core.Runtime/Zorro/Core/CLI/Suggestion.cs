using System.Runtime.CompilerServices;

namespace Zorro.Core.CLI
{
	public abstract class Suggestion
	{
		public abstract string GetInputValue();

		public abstract bool CanBeSelected();

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Suggestion()
		{
			throw null;
		}
	}
}
