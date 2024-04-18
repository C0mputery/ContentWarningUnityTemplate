using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShockStickTrigger : MonoBehaviour
{
	public List<Player> ignoredPlayers;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerStay(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShockStickTrigger()
	{

	}
}
