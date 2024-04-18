using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class SByteSerializer : Serializer<sbyte>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override sbyte ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, sbyte value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SByteSerializer()
		{

		}
	}
}
