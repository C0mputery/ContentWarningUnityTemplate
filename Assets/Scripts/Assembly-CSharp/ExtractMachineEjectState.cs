using System.Runtime.CompilerServices;

public class ExtractMachineEjectState : VideoExtractMachineState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractMachineEjectState(ExtractVideoMachine machine) : base(machine)
	{

    }

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void FixedUpdate()
	{
		throw null;
	}
}
