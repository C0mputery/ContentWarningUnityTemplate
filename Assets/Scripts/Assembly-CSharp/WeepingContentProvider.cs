using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeepingContentProvider : MonsterContentProvider
{
	public enum WEEPING_CONTENT_STATE : byte
	{
		idle = 0,
		success = 1,
		fail = 2,
		captured = 3
	}

	private Bot_Weeping weeping;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void GetContent(List<ContentEventFrame> contentEvents, float seenAmount, Camera camera, float time)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WeepingContentProvider()
	{

	}
}
