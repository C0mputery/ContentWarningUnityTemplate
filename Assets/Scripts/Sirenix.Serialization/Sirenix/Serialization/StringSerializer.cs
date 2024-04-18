using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class StringSerializer : Serializer<string>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, string value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StringSerializer()
		{

		}
	}
}
