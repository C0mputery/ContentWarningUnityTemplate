using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class WeakKeyValuePairFormatter : WeakBaseFormatter
	{
		private readonly Serializer KeySerializer;

		private readonly Serializer ValueSerializer;

		private readonly PropertyInfo KeyProperty;

		private readonly PropertyInfo ValueProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakKeyValuePairFormatter(Type serializedType) : base(null)
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
