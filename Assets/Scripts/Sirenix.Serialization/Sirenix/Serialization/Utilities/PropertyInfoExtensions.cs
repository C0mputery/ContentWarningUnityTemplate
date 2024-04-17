using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization.Utilities
{
	internal static class PropertyInfoExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsAutoProperty(this PropertyInfo propInfo, bool allowVirtual = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsAliasProperty(this PropertyInfo propertyInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PropertyInfo DeAliasProperty(this PropertyInfo propertyInfo, bool throwOnNotAliased = false)
		{
			throw null;
		}
	}
}
