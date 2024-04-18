using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonoFunctions : MonoBehaviour
{
	public static MonoFunctions instance;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DelayCall(Action actionToDo, float seconds)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void PhotonDestroy(GameObject target, float seconds)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MonoFunctions()
	{

	}
}
