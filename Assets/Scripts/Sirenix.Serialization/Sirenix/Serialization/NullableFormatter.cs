using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class NullableFormatter<T> : BaseFormatter<T?> where T : struct
	{
		private static readonly Serializer<T> TSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static NullableFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NullableFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref T? value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref T? value, IDataWriter writer)
		{
			throw null;
		}
	}
}
