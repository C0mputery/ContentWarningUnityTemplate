using System.Runtime.CompilerServices;

public class JoiningSpecificRoomState : ConnectionState
{
	public string RoomToJoin;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JoiningSpecificRoomState()
	{

	}
}
