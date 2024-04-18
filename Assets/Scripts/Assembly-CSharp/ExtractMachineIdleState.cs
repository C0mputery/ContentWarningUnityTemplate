using System.Runtime.CompilerServices;

public class ExtractMachineIdleState : VideoExtractMachineState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractMachineIdleState(ExtractVideoMachine machine) : base(machine)
	{

    }

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update()
	{
		throw null;
	}
}
