using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Sirenix.Serialization
{
	public sealed class WeakSerializableFormatter : WeakBaseFormatter
	{
		private readonly Func<SerializationInfo, StreamingContext, ISerializable> ISerializableConstructor;

		private readonly WeakReflectionFormatter ReflectionFormatter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakSerializableFormatter(Type serializedType) : base(serializedType)
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		private SerializationInfo ReadSerializationInfo(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteSerializationInfo(SerializationInfo info, IDataWriter writer)
		{
			throw null;
		}
	}
}
