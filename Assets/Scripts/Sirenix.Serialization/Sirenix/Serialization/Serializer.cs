using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class Serializer
	{
		private static readonly Dictionary<Type, Type> PrimitiveReaderWriterTypes;

		private static readonly object LOCK;

		private static readonly Dictionary<Type, Serializer> Weak_ReaderWriterCache;

		private static readonly Dictionary<Type, Serializer> Strong_ReaderWriterCache;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Conditional("UNITY_EDITOR")]
		protected static void FireOnSerializedType(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Serializer GetForValue(object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Serializer<T> Get<T>()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Serializer Get(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Serializer Get(Type type, bool allowWeakFallback)
		{
			throw null;
		}

		public abstract object ReadValueWeak(IDataReader reader);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteValueWeak(object value, IDataWriter writer)
		{
			throw null;
		}

		public abstract void WriteValueWeak(string name, object value, IDataWriter writer);

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Serializer Create(Type type, bool allowWeakfallback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void LogAOTError(Type type, ExecutionEngineException ex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Serializer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Serializer()
		{
			throw null;
		}
	}
	public abstract class Serializer<T> : Serializer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ReadValueWeak(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValueWeak(string name, object value, IDataWriter writer)
		{
			throw null;
		}

		public abstract T ReadValue(IDataReader reader);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteValue(T value, IDataWriter writer)
		{
			throw null;
		}

		public abstract void WriteValue(string name, T value, IDataWriter writer);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Conditional("UNITY_EDITOR")]
		protected static void FireOnSerializedType()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Serializer()
		{
			throw null;
		}
	}
}
