using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class UInt64Serializer : Serializer<ulong>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ulong ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, ulong value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UInt64Serializer()
		{

		}
	}
}
