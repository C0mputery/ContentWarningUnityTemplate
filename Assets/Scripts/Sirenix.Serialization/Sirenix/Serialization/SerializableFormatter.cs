using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Sirenix.Serialization
{
	public sealed class SerializableFormatter<T> : BaseFormatter<T> where T : ISerializable
	{
		private static readonly Func<SerializationInfo, StreamingContext, T> ISerializableConstructor;

		private static readonly ReflectionFormatter<T> ReflectionFormatter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SerializableFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override T GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref T value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref T value, IDataWriter writer)
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializableFormatter()
		{

		}
	}
}
