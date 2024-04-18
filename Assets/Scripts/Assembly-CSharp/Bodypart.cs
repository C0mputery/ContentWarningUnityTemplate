using System.Runtime.CompilerServices;
using UnityEngine;

public class Bodypart : MonoBehaviour
{
	public BodypartType bodypartType;

	internal Rigidbody rig;

	public BodypartAnimationTarget animationTarget;

	private Quaternion startLocal;

	private Player player;

	private ConfigurableJoint joint;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Config(BodypartType partType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void InitPart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetTarget(BodypartAnimationTarget bodypartAnimationTarget)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void FollowAnimJointDrive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void FollowAnimSimple(Bodypart hip)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void FollowAnimJointVel(Transform physicsRoot, Transform animationRoot, float force, bool addOpposingForce)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddOpposingForce(Vector3 force)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void FollowAnimJointAngularVel(Transform physicsRoot, Transform animationRoot, float torque)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCollisionEnter(Collision collision)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionStay(Collision collision)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Collide(Collision collision)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bodypart()
	{

	}
}
