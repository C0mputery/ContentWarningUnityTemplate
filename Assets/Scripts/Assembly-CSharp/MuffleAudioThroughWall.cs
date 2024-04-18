using System.Runtime.CompilerServices;
using UnityEngine;

public class MuffleAudioThroughWall : MonoBehaviour
{
	public LayerMask worldLayer;

	public float lerp;

	private AudioLowPassFilter lowPass;

	private RaycastHit hit;

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
	public MuffleAudioThroughWall()
	{

	}
}
