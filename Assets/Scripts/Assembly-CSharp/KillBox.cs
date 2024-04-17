using System.Runtime.CompilerServices;
using UnityEngine;

public class KillBox : MonoBehaviour
{
	public SFX_Instance killSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTriggerEnter(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KillBox()
	{
		throw null;
	}
}
