using System.Runtime.CompilerServices;
using Zorro.Core;

public abstract class ConnectionState : StateMachineState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ConnectionState()
	{
		throw null;
	}
}
