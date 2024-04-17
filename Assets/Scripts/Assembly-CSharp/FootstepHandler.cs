using System.Runtime.CompilerServices;
using UnityEngine;

public class FootstepHandler : MonoBehaviour
{
	public float overrideStepNoiseDistance;

	public float noiseSprintMultiplier;

	public float noiseWalkMultiplier;

	public float noiseCrouchMultiplier;

	public bool isPlayerFootSteps;

	public bool careForSurface;

	public int stepInt;

	public Transform main;

	private Player player;

	public bool step;

	public SFXInstanceCollection[] stepSound;

	public SFX_Instance[] extra;

	private bool t;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetInt()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FootstepHandler()
	{
		throw null;
	}
}
