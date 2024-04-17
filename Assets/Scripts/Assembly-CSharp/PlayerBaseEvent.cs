using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public abstract class PlayerBaseEvent : ContentEvent
{
	public string playerName;

	public int actorNumber;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerBaseEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerBaseEvent(string playerName, int actorNumber)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetUniqueID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string FixPlayerName(string comment)
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
