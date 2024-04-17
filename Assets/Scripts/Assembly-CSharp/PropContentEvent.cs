using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class PropContentEvent : ContentEvent
{
	public PropContent content;

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
	public override int GetUniqueID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropContentEvent()
	{
		throw null;
	}
}
