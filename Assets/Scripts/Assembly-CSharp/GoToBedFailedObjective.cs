using System.Runtime.CompilerServices;

public class GoToBedFailedObjective : Objective
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetObjectiveDescription()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GoToBedFailedObjective()
	{

	}
}
