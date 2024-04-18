using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class HashSetFormatter<T> : BaseFormatter<HashSet<T>>
	{
		private static readonly Serializer<T> TSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HashSetFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HashSetFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override HashSet<T> GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref HashSet<T> value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref HashSet<T> value, IDataWriter writer)
		{
			throw null;
		}
	}
}
