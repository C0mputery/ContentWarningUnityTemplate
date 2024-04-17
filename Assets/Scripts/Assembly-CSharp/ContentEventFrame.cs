using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public struct ContentEventFrame
{
	public ContentEvent contentEvent;

	public float seenAmount;

	public float time;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContentEventFrame(ContentEvent contentEvent, float seenAmount, float time)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContentEventFrame(BinaryDeserializer deserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetScore()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(BinarySerializer serializer)
	{
		throw null;
	}
}
