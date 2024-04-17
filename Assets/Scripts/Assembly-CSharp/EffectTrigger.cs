using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class EffectTrigger : MonoBehaviour
{
	public float damage;

	public float tase;

	public float fall;

	public UnityEvent eventToCall;

	public float perTargetCooldown;

	internal List<Player> ignoredPlayers;

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
	public EffectTrigger()
	{
		throw null;
	}
}
