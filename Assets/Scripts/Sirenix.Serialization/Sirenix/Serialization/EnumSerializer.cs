using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class EnumSerializer<T> : Serializer<T>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EnumSerializer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override T ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, T value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnumSerializer()
		{

		}
	}
}
