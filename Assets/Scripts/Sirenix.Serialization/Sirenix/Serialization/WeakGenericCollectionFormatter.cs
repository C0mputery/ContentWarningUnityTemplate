using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class WeakGenericCollectionFormatter : WeakBaseFormatter
	{
		private readonly Serializer ValueReaderWriter;

		private readonly Type ElementType;

		private readonly PropertyInfo CountProperty;

		private readonly MethodInfo AddMethod;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakGenericCollectionFormatter(Type collectionType, Type elementType) : base(null)
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
