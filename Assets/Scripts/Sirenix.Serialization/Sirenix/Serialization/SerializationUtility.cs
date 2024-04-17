using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public static class SerializationUtility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IDataWriter CreateWriter(Stream stream, SerializationContext context, DataFormat format)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IDataReader CreateReader(Stream stream, DeserializationContext context, DataFormat format)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IDataWriter GetCachedWriter(out IDisposable cache, DataFormat format, Stream stream, SerializationContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IDataReader GetCachedReader(out IDisposable cache, DataFormat format, Stream stream, DeserializationContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeValueWeak(object value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeValueWeak(object value, IDataWriter writer, out List<UnityEngine.Object> unityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeValue<T>(T value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeValue<T>(T value, IDataWriter writer, out List<UnityEngine.Object> unityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeValueWeak(object value, Stream stream, DataFormat format, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeValueWeak(object value, Stream stream, DataFormat format, out List<UnityEngine.Object> unityObjects, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeValue<T>(T value, Stream stream, DataFormat format, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeValue<T>(T value, Stream stream, DataFormat format, out List<UnityEngine.Object> unityObjects, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] SerializeValueWeak(object value, DataFormat format, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] SerializeValueWeak(object value, DataFormat format, out List<UnityEngine.Object> unityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] SerializeValue<T>(T value, DataFormat format, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] SerializeValue<T>(T value, DataFormat format, out List<UnityEngine.Object> unityObjects, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object DeserializeValueWeak(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object DeserializeValueWeak(IDataReader reader, List<UnityEngine.Object> referencedUnityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T DeserializeValue<T>(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T DeserializeValue<T>(IDataReader reader, List<UnityEngine.Object> referencedUnityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object DeserializeValueWeak(Stream stream, DataFormat format, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object DeserializeValueWeak(Stream stream, DataFormat format, List<UnityEngine.Object> referencedUnityObjects, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T DeserializeValue<T>(Stream stream, DataFormat format, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T DeserializeValue<T>(Stream stream, DataFormat format, List<UnityEngine.Object> referencedUnityObjects, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object DeserializeValueWeak(byte[] bytes, DataFormat format, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object DeserializeValueWeak(byte[] bytes, DataFormat format, List<UnityEngine.Object> referencedUnityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T DeserializeValue<T>(byte[] bytes, DataFormat format, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T DeserializeValue<T>(byte[] bytes, DataFormat format, List<UnityEngine.Object> referencedUnityObjects, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object CreateCopy(object obj)
		{
			throw null;
		}
	}
}
