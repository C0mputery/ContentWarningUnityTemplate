using System;
using System.Runtime.CompilerServices;

[Serializable]
public class SavedInventoryItem
{
	public string persistentID;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Guid GetPersistentID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SavedInventoryItem(Item item)
	{

	}
}
