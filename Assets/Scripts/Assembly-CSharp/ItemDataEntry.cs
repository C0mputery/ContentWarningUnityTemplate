using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public abstract class ItemDataEntry
{
	private bool m_dirty;

	public abstract void Serialize(BinarySerializer binarySerializer);

	public abstract void Deserialize(BinaryDeserializer binaryDeserializer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDirty()
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
	protected ItemDataEntry()
	{
		throw null;
	}
}
