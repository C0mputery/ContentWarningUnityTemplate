using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public abstract class ContentEvent
{
	public abstract float GetContentValue();

	public abstract ushort GetID();

	public abstract string GetName();

	public abstract Comment GenerateComment();

	public abstract void Serialize(BinarySerializer serializer);

	public abstract void Deserialize(BinaryDeserializer deserializer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetUniqueID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ContentEvent()
	{
		throw null;
	}
}
