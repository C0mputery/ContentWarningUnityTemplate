using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class ArrayFormatter<T> : BaseFormatter<T[]>
	{
		private static Serializer<T> valueReaderWriter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override T[] GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref T[] value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref T[] value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArrayFormatter()
		{
			throw null;
		}
	}
}
