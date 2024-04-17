using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class BooleanSerializer : Serializer<bool>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, bool value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BooleanSerializer()
		{
			throw null;
		}
	}
}
