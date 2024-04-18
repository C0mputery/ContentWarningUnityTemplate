using System.Runtime.CompilerServices;
using UnityEngine;

public static class GameBooter
{
	private static bool m_initialized;

	public static bool Initialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeInitializeOnLoadMethod]
	public static void Initialize()
	{
	}
}
