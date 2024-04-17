using System.Runtime.CompilerServices;

public class DisconnectingState : ConnectionState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DisconnectingState()
	{
		throw null;
	}
}
