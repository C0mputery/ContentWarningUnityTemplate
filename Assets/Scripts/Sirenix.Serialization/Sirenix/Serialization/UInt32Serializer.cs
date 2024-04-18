using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class UInt32Serializer : Serializer<uint>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override uint ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, uint value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UInt32Serializer()
		{

		}
	}
}
