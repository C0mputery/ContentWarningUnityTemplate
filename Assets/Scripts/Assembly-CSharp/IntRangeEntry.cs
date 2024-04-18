using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class IntRangeEntry : ItemDataEntry
{
	public int selectedValue;

	public int maxValue;

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
	public IntRangeEntry()
	{

	}
}
