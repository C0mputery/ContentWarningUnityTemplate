using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class DictionaryFormatter<TKey, TValue> : BaseFormatter<Dictionary<TKey, TValue>>
	{
		private static readonly bool KeyIsValueType;

		private static readonly Serializer<IEqualityComparer<TKey>> EqualityComparerSerializer;

		private static readonly Serializer<TKey> KeyReaderWriter;

		private static readonly Serializer<TValue> ValueReaderWriter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DictionaryFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DictionaryFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Dictionary<TKey, TValue> GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref Dictionary<TKey, TValue> value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref Dictionary<TKey, TValue> value, IDataWriter writer)
		{
			throw null;
		}
	}
}
