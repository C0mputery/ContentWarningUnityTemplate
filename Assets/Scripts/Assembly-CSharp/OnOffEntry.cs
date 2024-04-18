using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class OnOffEntry : ItemDataEntry
{
	public bool on;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Serialize(BinarySerializer binarySerializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Deserialize(BinaryDeserializer binaryDeserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OnOffEntry()
	{

	}
}
