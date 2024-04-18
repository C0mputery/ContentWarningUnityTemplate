using System.Runtime.CompilerServices;
using Zorro.Core;

public class ExtractMachineCheckItemState : VideoExtractMachineState
{
	private Optionable<float> m_timeBeenSearchingForItem;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractMachineCheckItemState(ExtractVideoMachine machine) : base(machine)
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
