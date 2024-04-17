using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KeybinderHandler : RetrievableSingleton<KeybinderHandler>
{
	private KeybindListenHandle _currentListenHandle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeybindListenHandle StartListening(Action<KeyCode> onKeycodeSet)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopListening(KeybindListenHandle handle)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeybinderHandler()
	{
		throw null;
	}
}
