using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public abstract class MonsterContentEvent : ContentEvent
{
	public int viewID;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetUniqueID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Serialize(BinarySerializer serializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Deserialize(BinaryDeserializer deserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected MonsterContentEvent()
	{
		throw null;
	}
}
