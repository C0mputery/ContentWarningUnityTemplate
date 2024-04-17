using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Sirenix.Serialization.Utilities;
using UnityEngine;

namespace Sirenix.Serialization
{
	public static class FormatterUtilities
	{
		private static readonly DoubleLookupDictionary<ISerializationPolicy, Type, MemberInfo[]> MemberArrayCache;

		private static readonly DoubleLookupDictionary<ISerializationPolicy, Type, Dictionary<string, MemberInfo>> MemberMapCache;

		private static readonly object LOCK;

		private static readonly HashSet<Type> PrimitiveArrayTypes;

		private static readonly FieldInfo UnityObjectRuntimeErrorStringField;

		private const string UnityObjectRuntimeErrorString = "The variable nullValue of {0} has not been assigned.\r\nYou probably need to assign the nullValue variable of the {0} script in the inspector.";

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FormatterUtilities()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Dictionary<string, MemberInfo> GetSerializableMembersMap(Type type, ISerializationPolicy policy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MemberInfo[] GetSerializableMembers(Type type, ISerializationPolicy policy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static UnityEngine.Object CreateUnityNull(Type nullType, Type owningType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsPrimitiveType(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsPrimitiveArrayType(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetContainedType(MemberInfo member)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object GetMemberValue(MemberInfo member, object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetMemberValue(MemberInfo member, object obj, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Dictionary<string, MemberInfo> FindSerializableMembersMap(Type type, ISerializationPolicy policy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void FindSerializableMembers(Type type, List<MemberInfo> members, ISerializationPolicy policy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MemberInfo GetPrivateMemberAlias(MemberInfo member, string prefixString = null, string separatorString = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool MemberIsPrivate(MemberInfo member)
		{
			throw null;
		}
	}
}
