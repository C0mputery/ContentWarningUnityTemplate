using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Splines;

public class Antenna : MonoBehaviour
{
	public Transform root;

	[FormerlySerializedAs("defaultTarget")]
	[FormerlySerializedAs("target")]
	public Transform mimicPullTarget;

	private Spline spline;

	private SplineContainer container;

	private LineRenderer lineRenderer;

	public int samples;

	private Bot_Angler angler;

	public float upPosBetweenMeAndMimic;

	public float upPosY;

	public bool IsPullingMimic;

	public float pullForce;

	private PhotonView view_g;

	public Vector3 GetUpPostion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Vector3 GetTargetPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Vector3 GetRootPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Go()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PullMimic()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Antenna()
	{

	}
}
