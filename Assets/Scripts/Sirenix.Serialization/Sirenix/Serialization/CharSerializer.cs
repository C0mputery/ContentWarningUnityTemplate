using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class CharSerializer : Serializer<char>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override char ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, char value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharSerializer()
		{
			throw null;
		}
	}
}
