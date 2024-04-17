using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public static class ReflectionUtility
	{
		public const BindingFlags FULL_BINDING = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type[] GetClassesThatDeriveFrom(Type baseType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static (Type, T)[] GetClassesWithAttribute<T>() where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static (Type, T)[] GetClassesWithAttribute<T>(IEnumerable<Type> types) where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static FieldInfo[] GetFieldsWithAttribute<T>(Type type) where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static (MethodInfo, Attribute)[] GetMethodsWithAttribute<T>() where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PropertyInfo FindProperty(this Type type, string propertyName, bool throwNotFound = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetInternalProperty(this object obj, string propertyName, object value)
		{
			throw null;
		}
	}
}
