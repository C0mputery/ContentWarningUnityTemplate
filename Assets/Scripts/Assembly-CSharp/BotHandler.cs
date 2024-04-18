using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BotHandler : MonoBehaviour
{
	public static BotHandler instance;

	public List<Bot> bots;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Bot GetFurthestFromAnyPlayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Bot GetNextMonster(ref int botID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotHandler()
	{

	}
}
