using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class TimeEntry : ItemDataEntry
{
	public float currentTime;

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
	public TimeEntry()
	{
		throw null;
	}
}
