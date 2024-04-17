using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class Int32Serializer : Serializer<int>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, int value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Int32Serializer()
		{
			throw null;
		}
	}
}
