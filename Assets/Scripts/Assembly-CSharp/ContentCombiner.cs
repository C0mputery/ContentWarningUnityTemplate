using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class ContentCombiner : ScriptableObject
{
	public abstract void Combine(List<ContentEventFrame> events);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool HasAllEvents(List<ContentEventFrame> events, ushort[] needed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool ReplaceEvents(List<ContentEventFrame> events, ushort[] toReplace, ContentEvent replacementEvent, out ContentEventFrame replacementEventFrame)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ContentCombiner()
	{
		throw null;
	}
}
