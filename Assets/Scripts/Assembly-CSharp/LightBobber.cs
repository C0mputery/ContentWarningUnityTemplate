using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class LightBobber : MonoBehaviour
{
	[FormerlySerializedAs("animationCurve")]
	public AnimationCurve rotationCurve;

	public float forwardOffset;

	public AnimationCurve upDownCurve;

	[FormerlySerializedAs("animationSpeed")]
	public float rotationSpeed;

	public float upDownSpeed;

	public float upDownMul;

	public GameObject origPos;

	private float elapsedTimeRotation;

	private float elapsedTimeUpDown;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightBobber()
	{

	}
}
