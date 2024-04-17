using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	internal sealed class WeakDoubleLookupDictionaryFormatter : WeakBaseFormatter
	{
		private readonly Serializer PrimaryReaderWriter;

		private readonly Serializer InnerReaderWriter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakDoubleLookupDictionaryFormatter(Type serializedType) : base(null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override object GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref object value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref object value, IDataReader reader)
		{
			throw null;
		}
	}
}
