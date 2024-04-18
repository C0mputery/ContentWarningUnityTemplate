using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DiveBellPickupDetector : MonoBehaviour
{
	public Transform[] m_detectors;

	private Collider[] results;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICollection<Pickup> CheckForPickups()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiveBellPickupDetector()
	{

	}
}
