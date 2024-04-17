using System.Runtime.CompilerServices;
using UnityEngine;

public static class EmptySprite
{
	private static Sprite instance;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Sprite Get()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsEmptySprite(Sprite s)
	{
		throw null;
	}
}
