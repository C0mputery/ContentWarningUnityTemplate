using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class DisallowModificationsInAttribute : Attribute
	{
		public PrefabKind PrefabKind;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisallowModificationsInAttribute(PrefabKind kind)
		{
			throw null;
		}
	}
}
