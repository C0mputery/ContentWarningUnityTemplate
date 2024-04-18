using System.Runtime.CompilerServices;
using UnityEngine;

public class Hazard : MonoBehaviour
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hazard()
	{

	}
}
