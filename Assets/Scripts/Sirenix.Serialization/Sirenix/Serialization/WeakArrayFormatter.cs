using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class WeakArrayFormatter : WeakBaseFormatter
	{
		private readonly Serializer ValueReaderWriter;

		private readonly Type ElementType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakArrayFormatter(Type arrayType, Type elementType) : base(null)
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
