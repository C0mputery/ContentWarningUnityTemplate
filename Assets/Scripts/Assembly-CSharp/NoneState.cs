using System.Runtime.CompilerServices;

public class NoneState : ConnectionState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Exit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NoneState()
	{

	}
}
