using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class ListFormatter<T> : BaseFormatter<List<T>>
	{
		private static readonly Serializer<T> TSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ListFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ListFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override List<T> GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref List<T> value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref List<T> value, IDataWriter writer)
		{
			throw null;
		}
	}
}
