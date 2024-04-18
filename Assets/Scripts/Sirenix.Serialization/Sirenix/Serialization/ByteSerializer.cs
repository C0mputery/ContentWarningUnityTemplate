using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class ByteSerializer : Serializer<byte>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override byte ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, byte value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ByteSerializer()
		{

		}
	}
}
