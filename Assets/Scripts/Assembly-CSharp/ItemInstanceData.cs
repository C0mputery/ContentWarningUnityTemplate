using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Zorro.Core.Serizalization;

public class ItemInstanceData
{
	public Guid m_guid;

	public HashSet<ItemDataEntry> m_dataEntries;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemInstanceData(Guid guid)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetEntry<T>(out T t) where T : ItemDataEntry
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryGetElseAdd<T>(ref T startValue) where T : ItemDataEntry
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetEntry(Type type, out ItemDataEntry t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDataEntry(ItemDataEntry entry)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveDataEntry(ItemDataEntry entry)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(BinarySerializer binarySerializer, bool createNewGuid)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Serialize(bool createNewGuid = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NativeArray<byte> SerializeAsNative()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(BinaryDeserializer binaryDeserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(byte[] bytes)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte GetEntryIdentifier(Type type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemDataEntry GetEntryType(byte identifier)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemDataSyncer CreateDataSyncer(bool roomOwned)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDirty()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearDirty()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemInstanceData Copy()
	{
		throw null;
	}
}
