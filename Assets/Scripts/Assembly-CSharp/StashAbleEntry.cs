using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class StashAbleEntry : ItemDataEntry
{
	public bool isStashAble;

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
	public StashAbleEntry()
	{

	}
}
