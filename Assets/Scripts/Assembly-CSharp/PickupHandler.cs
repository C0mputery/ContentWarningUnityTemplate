using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

public class PickupHandler : Singleton<PickupHandler>
{
	private List<Pickup> m_pickup;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Pickup CreatePickup(byte itemID, ItemInstanceData data, Vector3 pos, Quaternion rot, Vector3 vel, Vector3 angVel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Pickup CreatePickup(byte itemID, ItemInstanceData data, Vector3 pos, Quaternion rot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterPickup(Pickup pickup)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnregisterPickup(Pickup pickup)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetRandomPickup(out Pickup pickup)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendPosToEveryone()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PickupHandler()
	{

	}
}
