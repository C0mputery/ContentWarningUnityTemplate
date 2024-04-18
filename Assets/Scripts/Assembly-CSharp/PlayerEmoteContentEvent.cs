using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class PlayerEmoteContentEvent : PlayerBaseEvent
{
	public byte emoteItemID;

	public Item item;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerEmoteContentEvent()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerEmoteContentEvent(string playerName, int actorNumber, Item item)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float GetContentValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ushort GetID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Comment GenerateComment()
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
}
