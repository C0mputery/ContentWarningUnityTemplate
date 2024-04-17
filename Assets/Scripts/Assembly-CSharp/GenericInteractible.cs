using System.Runtime.CompilerServices;
using UnityEngine.Events;

public class GenericInteractible : Interactable
{
	public UnityEvent interactEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Interact(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GenericInteractible()
	{
		throw null;
	}
}
