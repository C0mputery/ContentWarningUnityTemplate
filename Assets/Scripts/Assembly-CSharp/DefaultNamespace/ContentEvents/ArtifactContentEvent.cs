using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

namespace DefaultNamespace.ContentEvents
{
	public class ArtifactContentEvent : PropContentEvent
	{
		public Item artifact;

		public bool isHeld;

		public bool isActive;

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
		public ArtifactContentEvent()
		{

		}
	}
}
