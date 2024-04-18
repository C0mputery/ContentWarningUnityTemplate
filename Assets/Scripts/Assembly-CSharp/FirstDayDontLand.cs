using System.Runtime.CompilerServices;
using UnityEngine;

public class FirstDayDontLand : MonoBehaviour
{
	public GameObject evening;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FirstDayDontLand()
	{

	}
}
