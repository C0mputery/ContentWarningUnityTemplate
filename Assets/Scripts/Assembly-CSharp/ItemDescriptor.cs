using System.Runtime.CompilerServices;

public struct ItemDescriptor
{
	public Item item;

	public ItemInstanceData data;

	public static ItemDescriptor Empty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemDescriptor(Item item, ItemInstanceData data)
	{
		throw null;
	}
}
