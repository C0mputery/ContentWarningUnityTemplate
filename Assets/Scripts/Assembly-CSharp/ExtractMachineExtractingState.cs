using System.Runtime.CompilerServices;

public class ExtractMachineExtractingState : VideoExtractMachineState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractMachineExtractingState(ExtractVideoMachine machine) : base(machine)
	{
        throw null;
    }

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enter()
	{
		throw null;
	}
}
