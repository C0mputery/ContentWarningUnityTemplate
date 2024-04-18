using System.Runtime.CompilerServices;

public class JoiningSpecificRegionState : ConnectionState
{
	public string RoomToJoin;

	public string RegionToJoin;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JoiningSpecificRegionState()
	{

	}
}
