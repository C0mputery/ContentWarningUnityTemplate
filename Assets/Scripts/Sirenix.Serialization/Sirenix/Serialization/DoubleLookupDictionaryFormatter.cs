using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	internal sealed class DoubleLookupDictionaryFormatter<TPrimary, TSecondary, TValue> : BaseFormatter<DoubleLookupDictionary<TPrimary, TSecondary, TValue>>
	{
		private static readonly Serializer<TPrimary> PrimaryReaderWriter;

		private static readonly Serializer<Dictionary<TSecondary, TValue>> InnerReaderWriter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DoubleLookupDictionaryFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DoubleLookupDictionaryFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override DoubleLookupDictionary<TPrimary, TSecondary, TValue> GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref DoubleLookupDictionary<TPrimary, TSecondary, TValue> value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref DoubleLookupDictionary<TPrimary, TSecondary, TValue> value, IDataReader reader)
		{
			throw null;
		}
	}
}
