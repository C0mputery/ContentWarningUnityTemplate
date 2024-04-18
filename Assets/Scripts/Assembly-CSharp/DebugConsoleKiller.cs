using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugConsoleKiller : MonoBehaviour
{
	public static bool killDebugConsole;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DebugConsoleKiller()
	{

	}
}
