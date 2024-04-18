using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Trigger_Wisp : MonoBehaviour
{
	public float cooldownPerPlayer;

	public float damage;

	public float force;

	private List<Player> hitPlayers;

	private Bot_ToolkitBoy tool;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerStay(Collider col)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Trigger_Wisp()
	{

	}
}
