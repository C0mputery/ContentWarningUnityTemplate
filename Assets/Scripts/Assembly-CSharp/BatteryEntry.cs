using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class BatteryEntry : ItemDataEntry, IHaveUIData
{
	public float m_charge;

	public float m_maxCharge;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Serialize(BinarySerializer binarySerializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCharge(float chargeToAdd)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Deserialize(BinaryDeserializer binaryDeserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetString()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetPercentage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BatteryEntry()
	{
		throw null;
	}
}
