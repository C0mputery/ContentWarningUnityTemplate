using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SpringShakeInstance
{
	public SpringType springType;

	public float spring;

	public float drag;

	public Vector3 vel;

	public Vector3 currentValue;

	public Vector3 currentValue2;

	public float sleepCounter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpringShakeInstance(Vector3 startVel, float spring, float drag, SpringType springType)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Init()
	{
		throw null;
	}
}
