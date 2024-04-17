using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class WeakQueueFormatter : WeakBaseFormatter
	{
		private readonly Serializer ElementSerializer;

		private readonly bool IsPlainQueue;

		private MethodInfo EnqueueMethod;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakQueueFormatter(Type serializedType) : base(serializedType)
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
