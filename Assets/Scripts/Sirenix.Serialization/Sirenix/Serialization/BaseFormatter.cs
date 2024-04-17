using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Sirenix.Serialization
{
	public abstract class BaseFormatter<T> : IFormatter<T>, IFormatter
	{
		protected delegate void SerializationCallback(ref T value, StreamingContext context);

		protected static readonly SerializationCallback[] OnSerializingCallbacks;

		protected static readonly SerializationCallback[] OnSerializedCallbacks;

		protected static readonly SerializationCallback[] OnDeserializingCallbacks;

		protected static readonly SerializationCallback[] OnDeserializedCallbacks;

		protected static readonly bool IsValueType;

		protected static readonly bool ImplementsISerializationCallbackReceiver;

		protected static readonly bool ImplementsIDeserializationCallback;

		protected static readonly bool ImplementsIObjectReference;

		public Type SerializedType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BaseFormatter()
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
		void IFormatter.Serialize(object value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		object IFormatter.Deserialize(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Deserialize(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(T value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual T GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RegisterReferenceID(T value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use the InvokeOnDeserializingCallbacks variant that takes a ref T value instead. This is for struct compatibility reasons.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void InvokeOnDeserializingCallbacks(T value, DeserializationContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InvokeOnDeserializingCallbacks(ref T value, DeserializationContext context)
		{
			throw null;
		}

		protected abstract void DeserializeImplementation(ref T value, IDataReader reader);

		protected abstract void SerializeImplementation(ref T value, IDataWriter writer);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected BaseFormatter()
		{
			throw null;
		}
	}
}
