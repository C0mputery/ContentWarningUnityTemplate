using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ZombieContentProvider : MonsterContentProvider
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void GetContent(List<ContentEventFrame> contentEvents, float seenAmount, Camera camera, float time)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZombieContentProvider()
	{

	}
}
