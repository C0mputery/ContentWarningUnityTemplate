using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class KeyValuePairFormatter<TKey, TValue> : BaseFormatter<KeyValuePair<TKey, TValue>>
	{
		private static readonly Serializer<TKey> KeySerializer;

		private static readonly Serializer<TValue> ValueSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref KeyValuePair<TKey, TValue> value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref KeyValuePair<TKey, TValue> value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyValuePairFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KeyValuePairFormatter()
		{
			throw null;
		}
	}
}
