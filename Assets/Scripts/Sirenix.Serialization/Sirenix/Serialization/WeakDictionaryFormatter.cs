using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	internal sealed class WeakDictionaryFormatter : WeakBaseFormatter
	{
		private readonly bool KeyIsValueType;

		private readonly Serializer EqualityComparerSerializer;

		private readonly Serializer KeyReaderWriter;

		private readonly Serializer ValueReaderWriter;

		private readonly ConstructorInfo ComparerConstructor;

		private readonly PropertyInfo ComparerProperty;

		private readonly PropertyInfo CountProperty;

		private readonly Type KeyType;

		private readonly Type ValueType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakDictionaryFormatter(Type serializedType) : base(null)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override object GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref object value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref object value, IDataWriter writer)
		{
			throw null;
		}
	}
}
