using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zorro.Core;
using Zorro.Core.Serizalization;
using Zorro.PhotonUtility;

public class ItemInstanceHandler : Singleton<ItemInstanceHandler>
{
	public Dictionary<Guid, ItemInstance> m_itemInstances;

	private Dictionary<Guid, Dictionary<ItemRPC, Action<BinaryDeserializer>>> m_rpcActions;

	private ListenerHandle m_listenerHandle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void HandleRPC(ItemInstancePackage package)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterItemInstance(Guid guid, ItemInstance itemInstance)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnregisterItemInstance(Guid guid)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterRPC(Guid itemInstance, ItemRPC rpc, Action<BinaryDeserializer> action)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CallRPC(Guid guid, ItemRPC rpc, BinarySerializer binarySerializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemInstanceHandler()
	{
		throw null;
	}
}
