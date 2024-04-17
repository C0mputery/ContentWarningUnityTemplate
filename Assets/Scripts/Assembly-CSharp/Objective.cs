using System.Runtime.CompilerServices;

public abstract class Objective
{
	protected string TextToShow;

	public abstract string GetObjectiveDescription();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldShow()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Objective()
	{
		throw null;
	}
}
