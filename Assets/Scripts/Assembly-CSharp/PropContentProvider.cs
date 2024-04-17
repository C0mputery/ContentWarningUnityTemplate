using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PropContentProvider : ContentProvider
{
	public PropContent content;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void GetContent(List<ContentEventFrame> contentEvents, float seenAmount, Camera camera, float time)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool ShouldShow()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropContentProvider()
	{
		throw null;
	}
}
