using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class TransformFollowerPair
{
	public BodypartType targetType;

	public Transform main;

	public Transform target;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TransformFollowerPair()
	{

	}
}
