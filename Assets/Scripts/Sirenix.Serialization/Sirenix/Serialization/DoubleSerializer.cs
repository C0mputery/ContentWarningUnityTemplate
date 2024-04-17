using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class DoubleSerializer : Serializer<double>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override double ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, double value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DoubleSerializer()
		{
			throw null;
		}
	}
}
