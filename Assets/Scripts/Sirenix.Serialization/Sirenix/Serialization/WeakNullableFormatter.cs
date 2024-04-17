using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class WeakNullableFormatter : WeakBaseFormatter
	{
		private readonly Serializer ValueSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakNullableFormatter(Type nullableType) : base(null)
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override object GetUninitializedObject()
		{
			throw null;
		}
	}
}
