using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DiveBellPlayerDetector : MonoBehaviour
{
	public Transform[] m_detectors;

	private Collider[] results;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICollection<Player> CheckForPlayers()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiveBellPlayerDetector()
	{

	}
}
