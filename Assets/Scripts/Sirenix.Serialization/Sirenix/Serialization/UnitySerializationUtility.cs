using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Sirenix.Serialization.Utilities;
using UnityEngine;

namespace Sirenix.Serialization
{
	public static class UnitySerializationUtility
	{
		private struct CachedSerializationBackendResult
		{
			public bool HasCalculatedSerializeUnityFieldsTrueResult;

			public bool HasCalculatedSerializeUnityFieldsFalseResult;

			public bool SerializeUnityFieldsTrueResult;

			public bool SerializeUnityFieldsFalseResult;
		}

		public static readonly Type SerializeReferenceAttributeType;

		private static readonly Assembly String_Assembly;

		private static readonly Assembly HashSet_Assembly;

		private static readonly Assembly LinkedList_Assembly;

		private static readonly Dictionary<MemberInfo, WeakValueGetter> UnityMemberGetters;

		private static readonly Dictionary<MemberInfo, WeakValueSetter> UnityMemberSetters;

		private static readonly Dictionary<MemberInfo, bool> UnityWillSerializeMembersCache;

		private static readonly Dictionary<Type, bool> UnityWillSerializeTypesCache;

		private static readonly HashSet<Type> UnityNeverSerializesTypes;

		private static readonly HashSet<string> UnityNeverSerializesTypeNames;

		private static readonly ISerializationPolicy UnityPolicy;

		private static readonly ISerializationPolicy EverythingPolicy;

		private static readonly ISerializationPolicy StrictPolicy;

		private static readonly Dictionary<MemberInfo, CachedSerializationBackendResult> OdinWillSerializeCache_UnityPolicy;

		private static readonly Dictionary<MemberInfo, CachedSerializationBackendResult> OdinWillSerializeCache_EverythingPolicy;

		private static readonly Dictionary<MemberInfo, CachedSerializationBackendResult> OdinWillSerializeCache_StrictPolicy;

		private static readonly Dictionary<ISerializationPolicy, Dictionary<MemberInfo, CachedSerializationBackendResult>> OdinWillSerializeCache_CustomPolicies;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool OdinWillSerialize(MemberInfo member, bool serializeUnityFields, ISerializationPolicy policy = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool CalculateOdinWillSerialize(MemberInfo member, bool serializeUnityFields, ISerializationPolicy policy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GuessIfUnityWillSerialize(MemberInfo member)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool GuessIfUnityWillSerializePrivate(MemberInfo member)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GuessIfUnityWillSerialize(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool GuessIfUnityWillSerializePrivate(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeUnityObject(UnityEngine.Object unityObject, ref SerializationData data, bool serializeUnityFields = false, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeUnityObject(UnityEngine.Object unityObject, ref string base64Bytes, ref List<UnityEngine.Object> referencedUnityObjects, DataFormat format, bool serializeUnityFields = false, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeUnityObject(UnityEngine.Object unityObject, ref byte[] bytes, ref List<UnityEngine.Object> referencedUnityObjects, DataFormat format, bool serializeUnityFields = false, SerializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SerializeUnityObject(UnityEngine.Object unityObject, IDataWriter writer, bool serializeUnityFields = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DeserializeUnityObject(UnityEngine.Object unityObject, ref SerializationData data, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void DeserializeUnityObject(UnityEngine.Object unityObject, ref SerializationData data, DeserializationContext context, bool isPrefabData, List<UnityEngine.Object> prefabInstanceUnityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DeserializeUnityObject(UnityEngine.Object unityObject, ref string base64Bytes, ref List<UnityEngine.Object> referencedUnityObjects, DataFormat format, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DeserializeUnityObject(UnityEngine.Object unityObject, ref byte[] bytes, ref List<UnityEngine.Object> referencedUnityObjects, DataFormat format, DeserializationContext context = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DeserializeUnityObject(UnityEngine.Object unityObject, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<string> SerializePrefabModifications(List<PrefabModification> modifications, ref List<UnityEngine.Object> referencedUnityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string GetStringFromStreamAndReset(Stream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<PrefabModification> DeserializePrefabModifications(List<string> modifications, List<UnityEngine.Object> referencedUnityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object CreateDefaultUnityInitializedObject(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object CreateDefaultUnityInitializedObject(Type type, int depth)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ApplyPrefabModifications(UnityEngine.Object unityObject, List<string> modificationData, List<UnityEngine.Object> referencedUnityObjects)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WeakValueGetter GetCachedUnityMemberGetter(MemberInfo member)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WeakValueSetter GetCachedUnityMemberSetter(MemberInfo member)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ICache GetCachedUnityWriter(DataFormat format, Stream stream, SerializationContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ICache GetCachedUnityReader(DataFormat format, Stream stream, DeserializationContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static UnitySerializationUtility()
		{
			throw null;
		}
	}
}
