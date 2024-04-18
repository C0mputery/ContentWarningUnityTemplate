using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DamageOverTimeTrigger : MonoBehaviour
{
	public float initialDamage;

	public List<Player> ignoredPlayers;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTriggerEnter(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DamageOverTimeTrigger()
	{

	}
}
