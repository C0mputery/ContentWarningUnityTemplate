using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class Int16Serializer : Serializer<short>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override short ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, short value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Int16Serializer()
		{
			throw null;
		}
	}
}
