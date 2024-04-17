using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class WeakStackFormatter : WeakBaseFormatter
	{
		private readonly Serializer ElementSerializer;

		private readonly bool IsPlainStack;

		private readonly MethodInfo PushMethod;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakStackFormatter(Type serializedType) : base(serializedType)
		{
            throw null;
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
