using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public static class FieldInfoExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsAliasField(this FieldInfo fieldInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static FieldInfo DeAliasField(this FieldInfo fieldInfo, bool throwOnNotAliased = false)
		{
			throw null;
		}
	}
}
