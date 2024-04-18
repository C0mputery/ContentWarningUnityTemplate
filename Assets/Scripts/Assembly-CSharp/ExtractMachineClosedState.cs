using System.Runtime.CompilerServices;

public class ExtractMachineClosedState : VideoExtractMachineState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractMachineClosedState(ExtractVideoMachine machine) : base(machine)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update()
	{
		throw null;
	}
}
