using System.Runtime.CompilerServices;

public class ConnectionStateHandler : RetrievableSingleton<ConnectionStateHandler>
{
	public ConnectionStateMachine StateMachine;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConnectionState CheckState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disconnect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConnectionStateHandler()
	{

	}
}
