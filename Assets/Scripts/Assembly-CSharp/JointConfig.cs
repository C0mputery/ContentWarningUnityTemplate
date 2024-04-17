using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class JointConfig
{
	public bool hasJoint;

	public float springMultiplier;

	public float dragMultiplier;

	[Range(-180f, 180f)]
	public float minX;

	[Range(-180f, 180f)]
	public float maxX;

	public float yAngle;

	public float zAngle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CopyJointSettings(ConfigurableJoint configurableJoint)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ConfigurableJoint SpawnJoint(Rigidbody ownRig, Rigidbody otherRig, float spring, float drag)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JointConfig()
	{
		throw null;
	}
}
