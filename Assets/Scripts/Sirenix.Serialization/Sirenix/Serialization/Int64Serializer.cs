using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class Int64Serializer : Serializer<long>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, long value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Int64Serializer()
		{

		}
	}
}
