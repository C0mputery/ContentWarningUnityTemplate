using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[DefaultExecutionOrder(-1)]
public class RagdollHandler : Singleton<RagdollHandler>
{
	private List<PlayerRagdoll> ragdolls;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterRagdoll(PlayerRagdoll playerRagdoll)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnregisterRagdoll(PlayerRagdoll playerRagdoll)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RagdollHandler()
	{

	}
}
