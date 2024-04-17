using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KeybindListenHandle
{
	public Action<KeyCode> OnKeycodeSet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeybindListenHandle(Action<KeyCode> onKeycodeSet)
	{
		throw null;
	}
}
