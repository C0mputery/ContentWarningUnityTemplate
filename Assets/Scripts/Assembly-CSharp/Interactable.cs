using System.Runtime.CompilerServices;
using EPOOutline;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
	protected Outlinable m_outline;

	public string hoverText;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsValid(Player player)
	{
		throw null;
	}

	public abstract void Interact(Player player);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEndHover(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartHover(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Interactable()
	{
		throw null;
	}
}
