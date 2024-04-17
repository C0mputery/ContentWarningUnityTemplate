using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class LifeTimeEntry : ItemDataEntry, IHaveUIData
{
	public float m_lifeTimeLeft;

	public float m_maxLifeTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Serialize(BinarySerializer binarySerializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddLifeTime(float lifeTimeToAdd)
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
	public LifeTimeEntry()
	{
		throw null;
	}
}
