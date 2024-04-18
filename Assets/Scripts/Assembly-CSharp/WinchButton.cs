using System.Runtime.CompilerServices;

public class WinchButton : Interactable
{
	public int direction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Interact(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WinchButton()
	{

	}
}
