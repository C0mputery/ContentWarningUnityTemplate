using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public static class MemberInfoExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsDefined<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsDefined<T>(this ICustomAttributeProvider member) where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetAttribute<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetAttribute<T>(this ICustomAttributeProvider member) where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<T> GetAttributes<T>(this ICustomAttributeProvider member) where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<T> GetAttributes<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Attribute[] GetAttributes(this ICustomAttributeProvider member)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Attribute[] GetAttributes(this ICustomAttributeProvider member, bool inherit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetNiceName(this MemberInfo member)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsStatic(this MemberInfo member)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsAlias(this MemberInfo memberInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MemberInfo DeAlias(this MemberInfo memberInfo, bool throwOnNotAliased = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SignaturesAreEqual(this MemberInfo a, MemberInfo b)
		{
			throw null;
		}
	}
}
