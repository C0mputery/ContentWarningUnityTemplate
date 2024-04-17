using System.Runtime.CompilerServices;
using UnityEngine;

public class Rebake : MonoBehaviour
{
	public Transform target;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Test()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rebake()
	{
		throw null;
	}
}
