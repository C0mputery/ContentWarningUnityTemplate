using System.Runtime.CompilerServices;
using UnityEngine;

public class SuckTrigger : MonoBehaviour
{
	public Transform suckTowards;

	public float suckForce;

	public bool requireLineOfSight;

	public float maxSuckTimeScale;

	internal float suckTime;

	public float extraDrag;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerStay(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SuckTrigger()
	{

	}
}
