using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class PlayerFallingContentEvent : PlayerBaseEvent
{
	public float sinceGrounded;

	public static string[] SMALL_FALL_COMMENTS;

	public static string[] BIG_FALL_COMMENTS;

	private bool IsBigFall
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerFallingContentEvent()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerFallingContentEvent(string playerName, int actorNumber, float sinceGrounded)
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
	static PlayerFallingContentEvent()
	{
		throw null;
	}
}
