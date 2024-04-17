using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Sirenix.Serialization
{
	public abstract class WeakBaseFormatter : IFormatter
	{
		protected delegate void SerializationCallback(object value, StreamingContext context);

		protected readonly Type SerializedType;

		protected readonly SerializationCallback[] OnSerializingCallbacks;

		protected readonly SerializationCallback[] OnSerializedCallbacks;

		protected readonly SerializationCallback[] OnDeserializingCallbacks;

		protected readonly SerializationCallback[] OnDeserializedCallbacks;

		protected readonly bool IsValueType;

		protected readonly bool ImplementsISerializationCallbackReceiver;

		protected readonly bool ImplementsIDeserializationCallback;

		protected readonly bool ImplementsIObjectReference;

		Type IFormatter.SerializedType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakBaseFormatter(Type serializedType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static SerializationCallback[] GetCallbacks(MethodInfo[] methods, Type callbackAttribute, ref List<SerializationCallback> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static SerializationCallback CreateCallback(MethodInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(object value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Deserialize(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RegisterReferenceID(object value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InvokeOnDeserializingCallbacks(object value, DeserializationContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual object GetUninitializedObject()
		{
			throw null;
		}

		protected abstract void DeserializeImplementation(ref object value, IDataReader reader);

		protected abstract void SerializeImplementation(ref object value, IDataWriter writer);
	}
}
