using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class ContentProvider : MonoBehaviour
{
	public abstract void GetContent(List<ContentEventFrame> contentEvents, float seenAmount, Camera camera, float time);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ContentProvider()
	{
		throw null;
	}
}
