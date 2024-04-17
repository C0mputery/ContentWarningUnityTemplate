using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class UInt16Serializer : Serializer<ushort>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ushort ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, ushort value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UInt16Serializer()
		{
			throw null;
		}
	}
}
