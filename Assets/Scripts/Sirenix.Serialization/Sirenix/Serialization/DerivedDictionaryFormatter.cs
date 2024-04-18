using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	internal sealed class DerivedDictionaryFormatter<TDictionary, TKey, TValue> : BaseFormatter<TDictionary> where TDictionary : Dictionary<TKey, TValue>, new()
	{
		private static readonly bool KeyIsValueType;

		private static readonly Serializer<IEqualityComparer<TKey>> EqualityComparerSerializer;

		private static readonly Serializer<TKey> KeyReaderWriter;

		private static readonly Serializer<TValue> ValueReaderWriter;

		private static readonly ConstructorInfo ComparerConstructor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DerivedDictionaryFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DerivedDictionaryFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override TDictionary GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref TDictionary value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref TDictionary value, IDataWriter writer)
		{
			throw null;
		}
	}
}
