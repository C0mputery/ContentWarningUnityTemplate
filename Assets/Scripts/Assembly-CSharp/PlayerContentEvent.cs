using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class PlayerContentEvent : PlayerBaseEvent
{
	public float facingFactor;

	public float microphoneFactor;

	public static string[] NORMAL_COMMENTS;

	public static string[] SPEAKING_COMMENTS;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerContentEvent()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerContentEvent(string playerName, int actorNumber, float facingFactor, float microphoneFactor)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PlayerContentEvent()
	{
		throw null;
	}
}
