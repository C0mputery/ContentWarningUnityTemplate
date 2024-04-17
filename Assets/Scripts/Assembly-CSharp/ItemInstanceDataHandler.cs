using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ItemInstanceDataHandler : RetrievableSingleton<ItemInstanceDataHandler>
{
	private Dictionary<Guid, ItemInstanceData> m_instanceData;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddInstanceData(ItemInstanceData instanceData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveInstanceData(Guid guid)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetInstanceData(Guid guid, out ItemInstanceData o)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemInstanceDataHandler()
	{
		throw null;
	}
}
