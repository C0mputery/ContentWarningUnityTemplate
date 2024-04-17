using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class DecimalSerializer : Serializer<decimal>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override decimal ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, decimal value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecimalSerializer()
		{
			throw null;
		}
	}
}
